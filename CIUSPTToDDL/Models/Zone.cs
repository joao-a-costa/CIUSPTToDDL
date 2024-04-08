using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents a zone.
    /// </summary>
    public class Zone
    {
        [JsonProperty("ZoneID")]
        public int? ZoneID;

        [JsonProperty("Zonekey")]
        public string Zonekey;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("ZoneType")]
        public int? ZoneType;

        [JsonProperty("CurrencyID")]
        public string CurrencyID;

        [JsonProperty("CountryID")]
        public string CountryID;

        [JsonProperty("TaxRegionID")]
        public string TaxRegionID;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("TaxExemptionReasonCode")]
        public string TaxExemptionReasonCode;

        [JsonProperty("TaxExemptionReasonCodeService")]
        public string TaxExemptionReasonCodeService;
    }
}
