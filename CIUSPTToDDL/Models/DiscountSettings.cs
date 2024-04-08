using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    public class DiscountSettings
    {
        [JsonProperty("DiscountID")]
        public int? DiscountID;

        [JsonProperty("CanBeEvaluated")]
        public bool? CanBeEvaluated;

        [JsonProperty("UseTaxIncludedValues")]
        public bool? UseTaxIncludedValues;

        [JsonProperty("OfferSetting")]
        public object OfferSetting;

        [JsonProperty("PriceSetting")]
        public object PriceSetting;

        [JsonProperty("OfferBaseQuantity")]
        public int? OfferBaseQuantity;
    }
}
