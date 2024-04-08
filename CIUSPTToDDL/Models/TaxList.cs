using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents a tax list.
    /// </summary>
    public class TaxList
    {
        [JsonProperty("TaxSequenceID")]
        public int? TaxSequenceID;

        [JsonProperty("TaxRate")]
        public int? TaxRate;

        [JsonProperty("Printable")]
        public bool? Printable;

        [JsonProperty("CalculusType")]
        public int? CalculusType;

        [JsonProperty("CalculateIncidence")]
        public bool? CalculateIncidence;

        [JsonProperty("TaxOverOtherTaxes")]
        public bool? TaxOverOtherTaxes;

        [JsonProperty("TaxSequenceNumber")]
        public int? TaxSequenceNumber;

        [JsonProperty("TaxRoundingDigits")]
        public int? TaxRoundingDigits;

        [JsonProperty("TaxCalcFormula")]
        public string TaxCalcFormula;

        [JsonProperty("IncidenceCalcFormula")]
        public object IncidenceCalcFormula;

        [JsonProperty("TaxInverseCalcFormula")]
        public string TaxInverseCalcFormula;

        [JsonProperty("IncidenceInverseCalcFormula")]
        public object IncidenceInverseCalcFormula;

        [JsonProperty("TaxOnShipping")]
        public bool? TaxOnShipping;

        [JsonProperty("SecondHandTaxRegimen")]
        public bool? SecondHandTaxRegimen;

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

        [JsonProperty("TaxValuePartyList")]
        public System.Collections.Generic.List<object> TaxValuePartyList;
    }


}
