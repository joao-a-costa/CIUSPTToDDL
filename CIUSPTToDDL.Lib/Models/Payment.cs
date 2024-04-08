using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a payment.
    /// </summary>
    public class Payment
    {
        [JsonProperty("PaymentID")]
        public int? PaymentID;

        [JsonProperty("PaymentKey")]
        public string PaymentKey;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("PaymentDays")]
        public int? PaymentDays;

        [JsonProperty("PaymentDaysAfter")]
        public int? PaymentDaysAfter;

        [JsonProperty("IssueReceipt")]
        public bool? IssueReceipt;

        [JsonProperty("InternalUse")]
        public bool? InternalUse;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("InstallmentList")]
        public System.Collections.Generic.List<object> InstallmentList;

        [JsonProperty("PaymentDateType")]
        public int? PaymentDateType;

        [JsonProperty("Installments")]
        public int? Installments;

        [JsonProperty("InstallmentsType")]
        public int? InstallmentsType;

        [JsonProperty("TenderID")]
        public int? TenderID;
    }


}
