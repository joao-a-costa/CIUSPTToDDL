using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    public class Taxis
    {
        [JsonProperty("TaxSequenceID")]
        public int? TaxSequenceID;

        [JsonProperty("TaxRate")]
        public int? TaxRate;

        [JsonProperty("TotalNetAmount")]
        public double? TotalNetAmount;

        [JsonProperty("TotalNetChargeableAmount")]
        public double? TotalNetChargeableAmount;

        [JsonProperty("TotalIncidenceAmount")]
        public int? TotalIncidenceAmount;

        [JsonProperty("TotalTaxAmount")]
        public double? TotalTaxAmount;

        [JsonProperty("TotalTaxChargeableAmount")]
        public double? TotalTaxChargeableAmount;

        [JsonProperty("mvarTotalAmount")]
        public int? MvarTotalAmount;

        [JsonProperty("TaxOverOtherTaxes")]
        public bool? TaxOverOtherTaxes;

        [JsonProperty("CalculateIncidence")]
        public bool? CalculateIncidence;

        [JsonProperty("UseIncidence")]
        public bool? UseIncidence;

        [JsonProperty("SecondHandTaxRegimen")]
        public bool? SecondHandTaxRegimen;

        [JsonProperty("ChargeableMotive")]
        public int? ChargeableMotive;

        [JsonProperty("TaxItemType")]
        public int? TaxItemType;

        [JsonProperty("TaxCountryID")]
        public string TaxCountryID;

        [JsonProperty("TaxRegionID")]
        public string TaxRegionID;

        [JsonProperty("TaxGroupID")]
        public string TaxGroupID;

        [JsonProperty("TaxCode")]
        public string TaxCode;

        [JsonProperty("TaxExemptionReasonCode")]
        public string TaxExemptionReasonCode;

        [JsonProperty("TotalAmount")]
        public double? TotalAmount;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("TaxValuePartyList")]
        public System.Collections.Generic.List<object> TaxValuePartyList;

        [JsonProperty("CalculusType")]
        public int? CalculusType;
    }


}
