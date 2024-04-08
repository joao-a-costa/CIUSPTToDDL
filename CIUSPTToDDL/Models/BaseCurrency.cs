using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents a base currency.
    /// </summary>
    public class BaseCurrency
    {
        [JsonProperty("CurrencyID")]
        public string CurrencyID;

        [JsonProperty("CurrencyKey")]
        public string CurrencyKey;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("SaleExchange")]
        public int SaleExchange;

        [JsonProperty("BuyExchange")]
        public int BuyExchange;

        [JsonProperty("ExchangeDate")]
        public System.DateTime? ExchangeDate;

        [JsonProperty("ItsEuroCurrency")]
        public bool ItsEuroCurrency;

        [JsonProperty("EuroConversionRate")]
        public int EuroConversionRate;

        [JsonProperty("RelatedCurrencyID")]
        public string RelatedCurrencyID;

        [JsonProperty("Symbol")]
        public string Symbol;

        [JsonProperty("SymbolPosition")]
        public string SymbolPosition;

        [JsonProperty("NegativeFormat")]
        public string NegativeFormat;

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces;

        [JsonProperty("PriceItemDecimalPlaces")]
        public int PriceItemDecimalPlaces;

        [JsonProperty("FormatMask")]
        public string FormatMask;

        [JsonProperty("ISOCode")]
        public string ISOCode;

        [JsonProperty("Inactive")]
        public bool Inactive;
    }


}
