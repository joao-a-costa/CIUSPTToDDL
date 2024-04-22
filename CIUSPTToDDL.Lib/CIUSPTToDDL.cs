using AutoMapper;
using CIUSPTToDDL.Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using UblSharp;
using UblSharp.CommonAggregateComponents;

namespace CIUSPTToDDL.Lib
{
    /// <summary>
    /// Class responsible for parsing CIUSPT invoices and mapping them to ItemTransaction objects.
    /// </summary>
    public class CIUSPTToDDL
    {
        #region "Enums"

        /// <summary>
        /// The type of document being parsed.
        /// </summary>
        public enum DocumentType
        {
            Invoice = 1,
            CreditNote = 2
        }

        #endregion

        #region "Constants"

        //private const string _documentTypeInvoice = "Invoice";
        //private const string _documentTypeCreditNote = "CreditNote";
        private const string _infoUnrecognizedDocumentType = "Unrecognized document type";

        #endregion

        #region "Properties"

        /// <summary>
        /// The parsed InvoiceType object.
        /// </summary>
        public IBaseDocument ItemTransactionUBL { get; set; }
        /// <summary>
        /// The parsed ItemTransaction object.
        /// </summary>
        public ItemTransaction ItemTransaction { get; set; }
        public DocumentType ItemTransactionUBLDocumentType { get; set; } = DocumentType.Invoice;

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
        public ItemTransaction Parse(string fileContent)
        {
            MapperConfiguration config = null;
            XDocument doc = XDocument.Parse(fileContent);
            XElement root = doc.Root;

            // Initialize invoice object
            IBaseDocument invoice = null;

            // Load the XML based on the root element
            if (root.Name.LocalName == DocumentType.CreditNote.ToString())
            {
                invoice = UblDocument.Load<CreditNoteType>(new StringReader(fileContent));
                ItemTransactionUBLDocumentType = DocumentType.CreditNote;
            }
            else if (root.Name.LocalName == DocumentType.Invoice.ToString())
            {
                invoice = UblDocument.Load<InvoiceType>(new StringReader(fileContent));
                ItemTransactionUBLDocumentType = DocumentType.Invoice;
            }
            else
                throw new InvalidOperationException(_infoUnrecognizedDocumentType);

            // Configure AutoMapper mappings
            switch (ItemTransactionUBLDocumentType)
            {
                case DocumentType.Invoice:
                    config = MapInvoice();
                    break;
                case DocumentType.CreditNote:
                    config = MapCreditNote();
                    break;
                default:
                    break;
            }

            // Map the InvoiceType object to an ItemTransaction object
            var itemTransaction = config.CreateMapper().Map<ItemTransaction>(invoice);

            ItemTransactionUBL = invoice;
            ItemTransaction = itemTransaction;

            return itemTransaction;
        }

        #endregion

        #region "Private"

        /// <summary>
        /// Maps an InvoiceType object to an ItemTransaction object.
        /// </summary>
        /// <returns>The mapper configuration</returns>
        private MapperConfiguration MapInvoice()
        {
            // Configure AutoMapper mappings
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InvoiceType, ItemTransaction>()
                    .ForMember(destination => destination.CreateDate, opt => opt.MapFrom(src => src.IssueDate.Value.DateTime))
                    .ForMember(destination => destination.DeferredPaymentDate, opt => opt.MapFrom(src => src.DueDate.Value.DateTime))
                    .ForMember(destination => destination.ContractReferenceNumber, opt => opt.MapFrom(src => src.OrderReference.ID.Value))
                    .ForMember(destination => destination.TotalAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.TaxExclusiveAmount.Value))
                    .ForMember(destination => destination.TotalTransactionAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.TaxInclusiveAmount.Value))
                    .ForMember(destination => destination.TotalGlobalDiscountAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.AllowanceTotalAmount.Value))
                    .ForPath(destination => destination.Party, opt => opt.MapFrom(src => MapParty(src.AccountingCustomerParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.CustomerParty, opt => opt.MapFrom(src => MapParty(src.AccountingCustomerParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.SupplierParty, opt => opt.MapFrom(src => MapParty(src.AccountingSupplierParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.UnloadPlaceAddress, opt => opt.MapFrom(src => MapUnloadPlaceAddress(src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address)))
                    .ForPath(destination => destination.Details, opt => opt.MapFrom(src => MapInvoiceLines(src.InvoiceLine)))
                    .ForAllOtherMembers(opt => opt.Ignore()); // Ignore all other members, including methods
            });
        }

        /// <summary>
        /// Maps a CreditNoteType object to an ItemTransaction object.
        /// </summary>
        /// <returns>The mapper configuration</returns>
        private MapperConfiguration MapCreditNote()
        {
            // Configure AutoMapper mappings
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreditNoteType, ItemTransaction>()
                    .ForMember(destination => destination.CreateDate, opt => opt.MapFrom(src => src.IssueDate.Value.DateTime))
                    //.ForMember(destination => destination.DeferredPaymentDate, opt => opt.MapFrom(src => src.DueDate.Value.DateTime))
                    .ForMember(destination => destination.ContractReferenceNumber, opt => opt.MapFrom(src => src.OrderReference.ID.Value))
                    .ForMember(destination => destination.TotalAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.TaxExclusiveAmount.Value))
                    .ForMember(destination => destination.TotalTransactionAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.TaxInclusiveAmount.Value))
                    .ForMember(destination => destination.TotalGlobalDiscountAmount, opt => opt.MapFrom(src => src.LegalMonetaryTotal.AllowanceTotalAmount.Value))
                    .ForPath(destination => destination.Party, opt => opt.MapFrom(src => MapParty(src.AccountingCustomerParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.CustomerParty, opt => opt.MapFrom(src => MapParty(src.AccountingCustomerParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.SupplierParty, opt => opt.MapFrom(src => MapParty(src.AccountingSupplierParty.Party, src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation)))
                    .ForPath(destination => destination.UnloadPlaceAddress, opt => opt.MapFrom(src => MapUnloadPlaceAddress(src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address)))
                    .ForPath(destination => destination.Details, opt => opt.MapFrom(src => MapCreditNoteLines(src.CreditNoteLine)))
                    .ForAllOtherMembers(opt => opt.Ignore()); // Ignore all other members, including methods
            });
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
        private List<Detail> MapInvoiceLines(IEnumerable<InvoiceLineType> invoiceLines)
        {
            var details = new List<Detail>();

            foreach (var line in invoiceLines)
            {
                var description = line?.Item?.Description?.FirstOrDefault()?.Value ?? line?.Item?.Name?.Value;

                var detail = new Detail
                {
                    // Map properties from InvoiceLineType to Detail here
                    Quantity = (int?)line?.InvoicedQuantity?.Value,
                    UnitPrice = (double)line?.Price?.PriceAmount?.Value,
                    ItemID = line?.Item.SellersItemIdentification?.ID?.Value,
                    Description = description
                };

                if (line?.AllowanceCharge?.FirstOrDefault()?.MultiplierFactorNumeric.Value != null)
                    detail.DiscountPercent = (double)line?.AllowanceCharge?.FirstOrDefault()?.MultiplierFactorNumeric.Value;

                details.Add(detail);
            }

            return details;
        }

        /// <summary>
        /// Maps a collection of CreditNoteLineType objects to a collection of Detail objects.
        /// </summary>
        /// <param name="creditNoteLines"></param>
        /// <returns></returns>
        private List<Detail> MapCreditNoteLines(IEnumerable<CreditNoteLineType> creditNoteLines)
        {
            var details = new List<Detail>();

            foreach (var line in creditNoteLines)
            {
                var detail = new Detail
                {
                    // Map properties from InvoiceLineType to Detail here
                    Quantity = (int?)line?.CreditedQuantity?.Value,
                    UnitPrice = (double)line?.Price?.PriceAmount?.Value,
                    ItemID = line?.Item.SellersItemIdentification?.ID?.Value,
                    Description = line?.Item?.Description?.FirstOrDefault()?.Value
                };

                if (line?.AllowanceCharge?.FirstOrDefault()?.MultiplierFactorNumeric.Value != null)
                    detail.DiscountPercent = (double)line?.AllowanceCharge?.FirstOrDefault()?.MultiplierFactorNumeric.Value;

                details.Add(detail);
            }

            return details;
        }

        #endregion
    }
}