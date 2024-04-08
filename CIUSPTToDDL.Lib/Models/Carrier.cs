using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a carrier.
    /// </summary>
    public class Carrier
    {
        [JsonProperty("CarrierID")]
        public int? CarrierID;

        [JsonProperty("CarrierKey")]
        public string CarrierKey;

        [JsonProperty("Name")]
        public string Name;

        [JsonProperty("DefaultSaleFreightCharge")]
        public int? DefaultSaleFreightCharge;

        [JsonProperty("SaleFreightChargeLimit")]
        public int? SaleFreightChargeLimit;

        [JsonProperty("CurrencyID")]
        public string CurrencyID;

        [JsonProperty("CurrencyExchange")]
        public int? CurrencyExchange;

        [JsonProperty("CurrencyFactor")]
        public int? CurrencyFactor;

        [JsonProperty("TaxableGroupID")]
        public int? TaxableGroupID;

        [JsonProperty("ModeOfTransportID")]
        public string ModeOfTransportID;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;
    }


}
