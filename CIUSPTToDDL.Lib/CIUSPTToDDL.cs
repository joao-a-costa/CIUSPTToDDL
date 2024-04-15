using AutoMapper;
using CIUSPTToDDL.Lib.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UblSharp;
using UblSharp.CommonAggregateComponents;

namespace CIUSPTToDDL.Lib
{
    /// <summary>
    /// Class responsible for parsing CIUSPT invoices and mapping them to ItemTransaction objects.
    /// </summary>
    public class CIUSPTToDDL
    {
        #region "Properties"

        /// <summary>
        /// The parsed InvoiceType object.
        /// </summary>
        public InvoiceType ItemTransactionUBL { get; set; }
        /// <summary>
        /// The parsed ItemTransaction object.
        /// </summary>
        public ItemTransaction ItemTransaction { get; set; }

        #endregion

        #region "Public"


        /// <summary>
        /// Parses a file containing a CIUSPT invoice and maps it to an ItemTransaction object.
        /// </summary>
        /// <param name="fileToParse">The XML file content to parse.</param>
        /// <returns>An ItemTransaction object representing the parsed invoice.</returns>
        public ItemTransaction ParseFromFile(string file)
        {
            return Parse(File.ReadAllText(file));
        }

        /// <summary>
        /// Parses a string containing a CIUSPT invoice and maps it to an ItemTransaction object.
        /// </summary>
        /// <param name="fileToParse">The XML file content to parse.</param>
        /// <returns>An ItemTransaction object representing the parsed invoice.</returns>
        public ItemTransaction ParseFromString(string fileContent)
        {
            return Parse(fileContent);
        }

        #endregion

        #region "Private"

        /// <summary>
        /// Internal parser.
        /// </summary>
        /// <param name="fileToParse">The XML file content to parse.</param>
        /// <returns>An ItemTransaction object representing the parsed invoice.</returns>
        private ItemTransaction Parse(string fileContent)
        {
            InvoiceType invoice = null;

            // Convert string to TextReader
            using (TextReader reader = new StringReader(fileContent))
            {
                invoice = UblDocument.Load<InvoiceType>(reader);

                reader.Close();
            }

            // Configure AutoMapper mappings
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InvoiceType, ItemTransaction>()
                    .ForMember(destination => destination.CreateDate, opt => opt.MapFrom(src => src.IssueDate.Value.DateTime))
                    .ForMember(destination => destination.DeferredPaymentDate, opt => opt.MapFrom(src => src.DueDate.Value.DateTime))
                    .ForMember(destination => destination.ContractReferenceNumber, opt => opt.MapFrom(src => src.BuyerReference.Value))
                    .ForMember(destination => destination.TotalAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.TaxExclusiveAmount.Value))
                    .ForMember(destination => destination.TotalTransactionAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.TaxInclusiveAmount.Value))
                    .ForMember(destination => destination.PartyAddressLine1, opt => opt.MapFrom(src => src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address.StreetName.Value))
                    .ForMember(destination => destination.PartyAddressLine2, opt => opt.MapFrom(src => src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address.AdditionalStreetName.Value))
                    .ForMember(destination => destination.PartyPostalCode, opt => opt.MapFrom(src => $"{src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address.PostalZone.Value} {src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address.CountrySubentity.Value}"))
                    .ForPath(destination => destination.Party, opt => opt.MapFrom(src => MapParty(src.AccountingCustomerParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.UnloadPlaceAddress, opt => opt.MapFrom(src => MapUnloadPlaceAddress(src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address)))
                    .ForPath(destination => destination.Details, opt => opt.MapFrom(src => MapDetails(src.InvoiceLine)))
                    .ForAllOtherMembers(opt => opt.Ignore()); // Ignore all other members, including methods
            });

            // Create the mapper
            var mapper = config.CreateMapper();

            // Map the InvoiceType object to an ItemTransaction object
            var itemTransaction = mapper.Map<ItemTransaction>(invoice);

            ItemTransactionUBL = invoice;
            ItemTransaction = itemTransaction;

            return itemTransaction;
        }

        /// <summary>
        /// Maps a PartyType object to a Party object.
        /// </summary>
        /// <param name="partyType"></param>
        /// <returns></returns>
        private Party MapParty(PartyType partyType, LocationType locationType)
        {
            // TODO: verify if CountryID is ISO 3166-1 alpha-2 code
            return new Party
            {
                // Map properties from PartyType to Party here
                FederalTaxID = partyType.PartyIdentification?.FirstOrDefault()?.ID.Value,
                OrganizationName = partyType.PartyName?.FirstOrDefault()?.Name.Value,
                AddressLine1 = partyType.PostalAddress?.StreetName?.Value,
                AddressLine2 = partyType.PostalAddress?.AdditionalStreetName?.Value,
                PostalCode = partyType.PostalAddress?.PostalZone?.Value,
                CountryID = partyType.PostalAddress?.Country?.IdentificationCode?.Value,
                GLN = locationType.ID?.Value
            };
        }

        /// <summary>
        /// Maps an AddressType object to an UnloadPlaceAddress object.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private UnloadPlaceAddress MapUnloadPlaceAddress(AddressType address)
        {
            return new UnloadPlaceAddress
            {
                AddressLine1 = address?.StreetName?.Value,
                AddressLine2 = address?.AdditionalStreetName?.Value,
                PostalCode = $"{address?.PostalZone?.Value} {address?.CountrySubentity?.Value}",
                CountryID = address?.Country?.IdentificationCode?.Value,
            };
        }

        /// <summary>
        /// Maps a collection of InvoiceLineType objects to a collection of Detail objects.
        /// </summary>
        /// <param name="invoiceLines"></param>
        /// <returns></returns>
        private List<Detail> MapDetails(IEnumerable<InvoiceLineType> invoiceLines)
        {
            var details = new List<Detail>();

            foreach (var invoiceLine in invoiceLines)
            {
                var detail = new Detail
                {
                    // Map properties from InvoiceLineType to Detail here
                    Quantity = (int?)invoiceLine?.Price?.BaseQuantity?.Value,
                    UnitPrice = (double)invoiceLine?.Price?.PriceAmount?.Value,
                    ItemID = invoiceLine?.Item.SellersItemIdentification?.ID?.Value
                };
                details.Add(detail);
            }

            return details;
        }

        #endregion
    }
}