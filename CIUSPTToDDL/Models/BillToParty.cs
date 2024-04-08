using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CIUSPTToDDL.Models
{
    public class BillToParty
    {
        [JsonProperty("CustomerID")]
        public int? CustomerID;

        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("CustomerKey")]
        public object CustomerKey;

        [JsonProperty("OrganizationName")]
        public object OrganizationName;

        [JsonProperty("AddressLine1")]
        public object AddressLine1;

        [JsonProperty("AddressLine2")]
        public object AddressLine2;

        [JsonProperty("PostalCode")]
        public object PostalCode;

        [JsonProperty("CountryID")]
        public object CountryID;

        [JsonProperty("ProvinceID")]
        public object ProvinceID;

        [JsonProperty("LocalityID")]
        public int? LocalityID;

        [JsonProperty("PersonalIdNumber")]
        public object PersonalIdNumber;

        [JsonProperty("BirthDate")]
        public System.DateTime? BirthDate;

        [JsonProperty("WebAddress")]
        public object WebAddress;

        [JsonProperty("Telephone1")]
        public object Telephone1;

        [JsonProperty("Telephone2")]
        public object Telephone2;

        [JsonProperty("Telephone3")]
        public object Telephone3;

        [JsonProperty("Telephone4")]
        public object Telephone4;

        [JsonProperty("MobileTelephone1")]
        public object MobileTelephone1;

        [JsonProperty("MobileTelephone2")]
        public object MobileTelephone2;

        [JsonProperty("Fax")]
        public object Fax;

        [JsonProperty("Email")]
        public object Email;

        [JsonProperty("CustomerPicturePath")]
        public object CustomerPicturePath;

        [JsonProperty("SalesmanId")]
        public int? SalesmanId;

        [JsonProperty("SalesmanName")]
        public object SalesmanName;

        [JsonProperty("CardID")]
        public object CardID;

        [JsonProperty("ZoneID")]
        public int? ZoneID;

        [JsonProperty("ZoneName")]
        public object ZoneName;

        [JsonProperty("CurrencyID")]
        public string CurrencyID;

        [JsonProperty("PaymentID")]
        public int? PaymentID;

        [JsonProperty("PaymentName")]
        public object PaymentName;

        [JsonProperty("CarrierID")]
        public int? CarrierID;

        [JsonProperty("CarrierName")]
        public object CarrierName;

        [JsonProperty("CashDiscountTermID")]
        public object CashDiscountTermID;

        [JsonProperty("CashDiscountTermName")]
        public object CashDiscountTermName;

        [JsonProperty("TenderID")]
        public int? TenderID;

        [JsonProperty("PriceLineID")]
        public int? PriceLineID;

        [JsonProperty("CustomerLevel")]
        public int? CustomerLevel;

        [JsonProperty("CustomerGroupDescription")]
        public object CustomerGroupDescription;

        [JsonProperty("EntityFiscalStatusID")]
        public int? EntityFiscalStatusID;

        [JsonProperty("AplyRetentionTax")]
        public bool? AplyRetentionTax;

        [JsonProperty("RetentionTax")]
        public int? RetentionTax;

        [JsonProperty("Comments")]
        public object Comments;

        [JsonProperty("Locked")]
        public bool? Locked;

        [JsonProperty("ActiveParty")]
        public bool? ActiveParty;

        [JsonProperty("LimitType")]
        public int? LimitType;

        [JsonProperty("LimitPurchaseDays")]
        public int? LimitPurchaseDays;

        [JsonProperty("LimitPurchaseValue")]
        public int? LimitPurchaseValue;

        [JsonProperty("LimitPurchaseCurrencyID")]
        public string LimitPurchaseCurrencyID;

        [JsonProperty("LimitPurchaseExchange")]
        public int? LimitPurchaseExchange;

        [JsonProperty("LimitPurchaseFactor")]
        public int? LimitPurchaseFactor;

        [JsonProperty("DirectDiscount")]
        public int? DirectDiscount;

        [JsonProperty("GlobalDiscount")]
        public int? GlobalDiscount;

        [JsonProperty("TemporaryID")]
        public object TemporaryID;

        [JsonProperty("IntranetUsername")]
        public object IntranetUsername;

        [JsonProperty("IntranetPassword")]
        public object IntranetPassword;

        [JsonProperty("IntranetGroup")]
        public object IntranetGroup;

        [JsonProperty("IntranetActive")]
        public bool? IntranetActive;

        [JsonProperty("IntranetEMailDaily")]
        public bool? IntranetEMailDaily;

        [JsonProperty("IntranetEMailWeekly")]
        public bool? IntranetEMailWeekly;

        [JsonProperty("IntranetLastVisit")]
        public System.DateTime? IntranetLastVisit;

        [JsonProperty("CreateDate")]
        public System.DateTime? CreateDate;

        [JsonProperty("LastUpdated")]
        public System.DateTime? LastUpdated;

        [JsonProperty("LastTransSerial")]
        public object LastTransSerial;

        [JsonProperty("LastTransDocument")]
        public object LastTransDocument;

        [JsonProperty("LastTransDocNumber")]
        public int? LastTransDocNumber;

        [JsonProperty("LedgerAccountBalance")]
        public int? LedgerAccountBalance;

        [JsonProperty("DefaultTransSerial")]
        public object DefaultTransSerial;

        [JsonProperty("DefaultTransDocument")]
        public object DefaultTransDocument;

        [JsonProperty("DefaultTransDocNumber")]
        public int? DefaultTransDocNumber;

        [JsonProperty("FrequentShopperPoints")]
        public int? FrequentShopperPoints;

        [JsonProperty("PartyInfo")]
        public PartyInfo PartyInfo;

        [JsonProperty("ContractList")]
        public System.Collections.Generic.List<object> ContractList;

        [JsonProperty("ImputeList")]
        public System.Collections.Generic.List<object> ImputeList;

        [JsonProperty("BankRemittanceAccount")]
        public object BankRemittanceAccount;

        [JsonProperty("RemittanceBankID")]
        public int? RemittanceBankID;

        [JsonProperty("RemittanceAccountID")]
        public int? RemittanceAccountID;

        [JsonProperty("SendXMLMailAfterSave")]
        public bool? SendXMLMailAfterSave;

        [JsonProperty("UseIntraStat")]
        public bool? UseIntraStat;

        [JsonProperty("IntraStatPortID")]
        public object IntraStatPortID;

        [JsonProperty("AccountingGeneralLedgerID")]
        public object AccountingGeneralLedgerID;

        [JsonProperty("RelationshipID")]
        public int? RelationshipID;

        [JsonProperty("CustomerDefaultTransSerial")]
        public string CustomerDefaultTransSerial;

        [JsonProperty("CustomerPrintCopies")]
        public int? CustomerPrintCopies;

        [JsonProperty("TaxablePersonType")]
        public int? TaxablePersonType;

        [JsonProperty("CashAccountingSchemeSignIn")]
        public System.DateTime? CashAccountingSchemeSignIn;

        [JsonProperty("CashAccountingSchemeSignOut")]
        public System.DateTime? CashAccountingSchemeSignOut;

        [JsonProperty("DefaultBillToCustomerID")]
        public int? DefaultBillToCustomerID;

        [JsonProperty("IssuingOutput")]
        public int? IssuingOutput;

        [JsonProperty("PlantProtectionActivityAuth")]
        public object PlantProtectionActivityAuth;

        [JsonProperty("EinvoicingEmail")]
        public object EinvoicingEmail;

        [JsonProperty("GDPRConsent")]
        public bool? GDPRConsent;

        [JsonProperty("GDPRConsentDate")]
        public System.DateTime? GDPRConsentDate;

        [JsonProperty("GDPRSystemUserGUID")]
        public object GDPRSystemUserGUID;

        [JsonProperty("GDPRForgetDate")]
        public System.DateTime? GDPRForgetDate;

        [JsonProperty("GDPRForgetUserGUID")]
        public object GDPRForgetUserGUID;

        [JsonProperty("GDPRRequestDate")]
        public System.DateTime? GDPRRequestDate;

        [JsonProperty("GDPRRequestEmail")]
        public object GDPRRequestEmail;

        [JsonProperty("GDPRRequestUserGUID")]
        public object GDPRRequestUserGUID;

        [JsonProperty("GDPRStateDate")]
        public System.DateTime? GDPRStateDate;

        [JsonProperty("GDPRStateUserGUID")]
        public object GDPRStateUserGUID;

        [JsonProperty("GDPRState")]
        public int? GDPRState;

        [JsonProperty("IsPublicAdministration")]
        public bool? IsPublicAdministration;

        [JsonProperty("PricingID")]
        public int? PricingID;

        [JsonProperty("CustomerSupplierID")]
        public object CustomerSupplierID;

        [JsonProperty("GLN")]
        public object GLN;

        [JsonProperty("Delivery")]
        public object Delivery;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("Properties")]
        public System.Collections.Generic.List<object> Properties;

        [JsonProperty("ItemContractList")]
        public System.Collections.Generic.List<object> ItemContractList;

        [JsonProperty("EInvoiceChannel")]
        public object EInvoiceChannel;

        [JsonProperty("WithholdingTaxType")]
        public object WithholdingTaxType;

        [JsonProperty("WhatsappConsent")]
        public bool? WhatsappConsent;

        [JsonProperty("PACustomerID")]
        public object PACustomerID;

        [JsonProperty("XCHOnboarded")]
        public bool? XCHOnboarded;

        [JsonProperty("XCHConsent")]
        public bool? XCHConsent;

        [JsonProperty("FederalTaxID")]
        public object FederalTaxID;

        [JsonProperty("FiscalStatusID")]
        public int? FiscalStatusID;

        [JsonProperty("PartyType")]
        public int? PartyType;

        [JsonProperty("Telephone")]
        public object Telephone;

        [JsonProperty("AccountBalance")]
        public int? AccountBalance;

        [JsonProperty("AccountCurrencyID")]
        public string AccountCurrencyID;

        [JsonProperty("$Type")]
        public string Type;
    }


}
