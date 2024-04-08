using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a load place address.
    /// </summary>
    public class LoadPlaceAddress
    {
        [JsonProperty("AddressID")]
        public int? AddressID;

        [JsonProperty("AddressKey")]
        public object AddressKey;

        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("AddressLine1")]
        public string AddressLine1;

        [JsonProperty("AddressLine2")]
        public string AddressLine2;

        [JsonProperty("PostalCode")]
        public string PostalCode;

        [JsonProperty("CountryID")]
        public string CountryID;

        [JsonProperty("CountryName")]
        public object CountryName;

        [JsonProperty("ProvinceID")]
        public object ProvinceID;

        [JsonProperty("ProvinceName")]
        public object ProvinceName;

        [JsonProperty("LocalityID")]
        public int? LocalityID;

        [JsonProperty("LocalityName")]
        public object LocalityName;

        [JsonProperty("AddressType")]
        public int? AddressType;

        [JsonProperty("SendMail")]
        public bool? SendMail;

        [JsonProperty("GLN")]
        public object GLN;

        [JsonProperty("Delivery")]
        public object Delivery;
    }


}
