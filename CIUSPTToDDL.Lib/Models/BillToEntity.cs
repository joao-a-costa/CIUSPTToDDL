using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    public class BillToEntity
    {
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

        [JsonProperty("FiscalStatusID")]
        public int? FiscalStatusID;

        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("PartyType")]
        public int? PartyType;

        [JsonProperty("PartyInfo")]
        public PartyInfo PartyInfo;

        [JsonProperty("DefaultPartyType")]
        public int? DefaultPartyType;

        [JsonProperty("AccountType")]
        public AccountType AccountType;

        [JsonProperty("HasAccountType")]
        public bool? HasAccountType;

        [JsonProperty("AddressID")]
        public int? AddressID;

        [JsonProperty("AddressKey")]
        public int? AddressKey;

        [JsonProperty("Entity")]
        public Entity Entity;

        [JsonProperty("Email")]
        public object Email;

        [JsonProperty("Fax")]
        public object Fax;

        [JsonProperty("EntityObject")]
        public EntityObject EntityObject;

        [JsonProperty("Locked")]
        public bool? Locked;

        [JsonProperty("FederalTaxID")]
        public object FederalTaxID;

        [JsonProperty("Telephone")]
        public object Telephone;

        [JsonProperty("AccountBalance")]
        public int? AccountBalance;

        [JsonProperty("AccountCurrencyID")]
        public string AccountCurrencyID;

        [JsonProperty("TaxablePersonType")]
        public int? TaxablePersonType;
    }
}
