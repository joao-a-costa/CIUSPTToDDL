﻿using AutoMapper;
using CIUSPTToDDL.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UblSharp;
using UblSharp.CommonAggregateComponents;

namespace CIUSPTToDDL
{
    /// <summary>
    /// Class responsible for parsing CIUSPT invoices and mapping them to ItemTransaction objects.
    /// </summary>
    public class CIUSPTToDDL
    {
        /// <summary>
        /// Parses the given XML file containing a CIUSPT invoice and maps it to an ItemTransaction object.
        /// </summary>
        /// <param name="fileToParse">The XML file content to parse.</param>
        /// <returns>An ItemTransaction object representing the parsed invoice.</returns>
        public static ItemTransaction Parse(string fileToParse)
        {
            InvoiceType invoice = null;

            // Convert string to TextReader
            using (TextReader reader = new StringReader(fileToParse))
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
                    .ForPath(destination => destination.Party, opt => opt.MapFrom(src => MapParty(src.AccountingCustomerParty.Party)))
                    .ForPath(destination => destination.UnloadPlaceAddress, opt => opt.MapFrom(src => MapUnloadPlaceAddress(src.Delivery.Cast<DeliveryType>().FirstOrDefault().DeliveryLocation.Address)))
                    .ForPath(destination => destination.Details, opt => opt.MapFrom(src => MapDetails(src.InvoiceLine)))
                    .ForAllOtherMembers(opt => opt.Ignore()); // Ignore all other members, including methods
            });

            // Create the mapper
            var mapper = config.CreateMapper();

            // Map the InvoiceType object to an ItemTransaction object
            var itemTransaction = mapper.Map<ItemTransaction>(invoice);

            return itemTransaction;
        }

        /// <summary>
        /// Maps a PartyType object to a Party object.
        /// </summary>
        /// <param name="partyType"></param>
        /// <returns></returns>
        private static Party MapParty(PartyType partyType)
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
            };
        }

        /// <summary>
        /// Maps an AddressType object to an UnloadPlaceAddress object.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private static UnloadPlaceAddress MapUnloadPlaceAddress(AddressType address)
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
        private static List<Detail> MapDetails(IEnumerable<InvoiceLineType> invoiceLines)
        {
            var details = new List<Detail>();

            foreach (var invoiceLine in invoiceLines)
            {
                var detail = new Detail
                {
                    // Map properties from InvoiceLineType to Detail here
                    Quantity = (int?)invoiceLine?.InvoicedQuantity?.Value,
                    UnitPrice = (double)invoiceLine?.LineExtensionAmount?.Value,
                    ItemID = invoiceLine?.Item.SellersItemIdentification?.ID?.Value
                };
                details.Add(detail);
            }

            return details;
        }
    }
}