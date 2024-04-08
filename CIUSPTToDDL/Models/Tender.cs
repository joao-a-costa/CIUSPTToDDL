using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents a tender.
    /// </summary>
    public class Tender
    {
        [JsonProperty("TenderID")]
        public int? TenderID;

        [JsonProperty("TenderKey")]
        public string TenderKey;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("MinimumSaleAmount")]
        public int? MinimumSaleAmount;

        [JsonProperty("MaximumAcceptAmount")]
        public int? MaximumAcceptAmount;

        [JsonProperty("MaxAcceptAmntCurrencyID")]
        public string MaxAcceptAmntCurrencyID;

        [JsonProperty("MaxAcceptAmntCurrencyFactor")]
        public int? MaxAcceptAmntCurrencyFactor;

        [JsonProperty("MaxAcceptAmntCurrencyExchange")]
        public int? MaxAcceptAmntCurrencyExchange;

        [JsonProperty("CanReturnMoneyChange")]
        public bool? CanReturnMoneyChange;

        [JsonProperty("TenderUse")]
        public int? TenderUse;

        [JsonProperty("UseDOCToPay")]
        public bool? UseDOCToPay;

        [JsonProperty("DocIDUsedToPay")]
        public string DocIDUsedToPay;

        [JsonProperty("TenderType")]
        public int? TenderType;

        [JsonProperty("CustomerIdentificationRequired")]
        public bool? CustomerIdentificationRequired;

        [JsonProperty("AccountIdentificationRequired")]
        public bool? AccountIdentificationRequired;

        [JsonProperty("OpenCashDrawerRequired")]
        public bool? OpenCashDrawerRequired;

        [JsonProperty("SeriesBarcodeList")]
        public System.Collections.Generic.List<object> SeriesBarcodeList;

        [JsonProperty("Internal")]
        public bool? Internal;

        [JsonProperty("InternalUse")]
        public bool? InternalUse;

        [JsonProperty("UpdateTillReport")]
        public bool? UpdateTillReport;

        [JsonProperty("DebitedOnAccount")]
        public bool? DebitedOnAccount;

        [JsonProperty("Inactive")]
        public bool? Inactive;

        [JsonProperty("StampDutyBillOfExchange")]
        public string StampDutyBillOfExchange;

        [JsonProperty("SAFTPaymentMechanism")]
        public string SAFTPaymentMechanism;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("DebitedDocuments")]
        public System.Collections.Generic.List<object> DebitedDocuments;

        [JsonProperty("Properties")]
        public System.Collections.Generic.List<object> Properties;

        [JsonProperty("ChargeDaysAfterDueDate")]
        public int? ChargeDaysAfterDueDate;
    }


}
