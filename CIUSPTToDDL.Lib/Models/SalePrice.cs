using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a sale price.
    /// </summary>
    public class SalePrice
    {
        [JsonProperty("LotID")]
        public object LotID;

        [JsonProperty("PriceLineID")]
        public int? PriceLineID;

        [JsonProperty("SizeID")]
        public int? SizeID;

        [JsonProperty("ColorID")]
        public int? ColorID;

        [JsonProperty("UnitOfMeasureID")]
        public object UnitOfMeasureID;

        [JsonProperty("PropertyValue1")]
        public object PropertyValue1;

        [JsonProperty("PropertyValue2")]
        public object PropertyValue2;

        [JsonProperty("PropertyValue3")]
        public object PropertyValue3;

        [JsonProperty("UnitPrice")]
        public int? UnitPrice;

        [JsonProperty("TaxIncludedPrice")]
        public int? TaxIncludedPrice;

        [JsonProperty("CreateDate")]
        public System.DateTime? CreateDate;

        [JsonProperty("CurrencyID")]
        public string CurrencyID;

        [JsonProperty("CurrencyFactor")]
        public int? CurrencyFactor;

        [JsonProperty("CurrencyExchange")]
        public int? CurrencyExchange;

        [JsonProperty("FixedProfitRate")]
        public int? FixedProfitRate;

        [JsonProperty("ExcludesGlobalDiscount")]
        public bool? ExcludesGlobalDiscount;

        [JsonProperty("DiscountPercent")]
        public double? DiscountPercent;

        [JsonProperty("PriceUnitID")]
        public object PriceUnitID;
    }


}
