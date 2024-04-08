using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents a salesman.
    /// </summary>
    public class Salesman
    {
        [JsonProperty("SalesmanID")]
        public int? SalesmanID;

        [JsonProperty("SalesmanKey")]
        public string SalesmanKey;

        [JsonProperty("Name")]
        public string Name;

        [JsonProperty("AddressLine1")]
        public string AddressLine1;

        [JsonProperty("AddressLine2")]
        public string AddressLine2;

        [JsonProperty("PostalCode")]
        public string PostalCode;

        [JsonProperty("CountryID")]
        public string CountryID;

        [JsonProperty("ProvinceID")]
        public string ProvinceID;

        [JsonProperty("LocalityID")]
        public int? LocalityID;

        [JsonProperty("Telephone1")]
        public string Telephone1;

        [JsonProperty("Telephone2")]
        public string Telephone2;

        [JsonProperty("CellPhone1")]
        public string CellPhone1;

        [JsonProperty("CellPhone2")]
        public string CellPhone2;

        [JsonProperty("Email")]
        public string Email;

        [JsonProperty("WebSite")]
        public string WebSite;

        [JsonProperty("AdmissionDate")]
        public System.DateTime? AdmissionDate;

        [JsonProperty("BirthDate")]
        public System.DateTime? BirthDate;

        [JsonProperty("SpokenLanguageID")]
        public string SpokenLanguageID;

        [JsonProperty("IdentityCard")]
        public string IdentityCard;

        [JsonProperty("FederalTaxID")]
        public string FederalTaxID;

        [JsonProperty("SalesmanLevel")]
        public int? SalesmanLevel;

        [JsonProperty("ComissionTaxOnSale")]
        public int? ComissionTaxOnSale;

        [JsonProperty("ComissionIncidenceType")]
        public int? ComissionIncidenceType;

        [JsonProperty("ComissionTaxOnPay")]
        public int? ComissionTaxOnPay;

        [JsonProperty("ComissionAccountTypeID")]
        public string ComissionAccountTypeID;

        [JsonProperty("AplyRetentionTax")]
        public bool? AplyRetentionTax;

        [JsonProperty("RetentionTax")]
        public int? RetentionTax;

        [JsonProperty("SalesGroupID")]
        public int? SalesGroupID;

        [JsonProperty("MaximumDiscount")]
        public int? MaximumDiscount;

        [JsonProperty("Picture")]
        public string Picture;

        [JsonProperty("Password")]
        public string Password;

        [JsonProperty("Comments")]
        public string Comments;

        [JsonProperty("RouteList")]
        public System.Collections.Generic.List<object> RouteList;

        [JsonProperty("Admin")]
        public bool? Admin;

        [JsonProperty("LastSalesmanID")]
        public int? LastSalesmanID;

        [JsonProperty("Permissions")]
        public System.Collections.Generic.List<object> Permissions;

        [JsonProperty("Groups")]
        public System.Collections.Generic.List<object> Groups;

        [JsonProperty("ComissionBySalesmanList")]
        public System.Collections.Generic.List<object> ComissionBySalesmanList;

        [JsonProperty("PartyInfo")]
        public object PartyInfo;

        [JsonProperty("DepartmentID")]
        public string DepartmentID;

        [JsonProperty("LedgerAccountBalance")]
        public int? LedgerAccountBalance;

        [JsonProperty("CurrencyID")]
        public string CurrencyID;

        [JsonProperty("CardID")]
        public string CardID;

        [JsonProperty("DefaultMainTillID")]
        public string DefaultMainTillID;

        [JsonProperty("DefaultTillID")]
        public string DefaultTillID;

        [JsonProperty("DefaultOfflineTillID")]
        public string DefaultOfflineTillID;

        [JsonProperty("Inactive")]
        public bool? Inactive;

        [JsonProperty("AlwaysAvailable")]
        public bool? AlwaysAvailable;

        [JsonProperty("StoreList")]
        public string StoreList;

        [JsonProperty("PasswordStrength")]
        public int? PasswordStrength;

        [JsonProperty("GDPRConsent")]
        public bool? GDPRConsent;

        [JsonProperty("GDPRConsentDate")]
        public System.DateTime? GDPRConsentDate;

        [JsonProperty("GDPRSystemUserGUID")]
        public string GDPRSystemUserGUID;

        [JsonProperty("GDPRForgetDate")]
        public System.DateTime? GDPRForgetDate;

        [JsonProperty("GDPRForgetUserGUID")]
        public string GDPRForgetUserGUID;

        [JsonProperty("GDPRRequestDate")]
        public System.DateTime? GDPRRequestDate;

        [JsonProperty("GDPRRequestEmail")]
        public string GDPRRequestEmail;

        [JsonProperty("GDPRRequestUserGUID")]
        public string GDPRRequestUserGUID;

        [JsonProperty("GDPRStateDate")]
        public System.DateTime? GDPRStateDate;

        [JsonProperty("GDPRStateUserGUID")]
        public string GDPRStateUserGUID;

        [JsonProperty("GDPRState")]
        public int? GDPRState;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("Properties")]
        public System.Collections.Generic.List<object> Properties;

        [JsonProperty("WithholdingTaxType")]
        public string WithholdingTaxType;

        [JsonProperty("WhatsappConsent")]
        public bool? WhatsappConsent;

        [JsonProperty("OrganizationName")]
        public string OrganizationName;

        [JsonProperty("FiscalStatusID")]
        public int? FiscalStatusID;

        [JsonProperty("PartyType")]
        public int? PartyType;

        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("Fax")]
        public object Fax;

        [JsonProperty("Telephone")]
        public string Telephone;

        [JsonProperty("AccountBalance")]
        public int? AccountBalance;

        [JsonProperty("AccountCurrencyID")]
        public string AccountCurrencyID;

        [JsonProperty("Locked")]
        public bool? Locked;

        [JsonProperty("TaxablePersonType")]
        public int? TaxablePersonType;
    }


}
