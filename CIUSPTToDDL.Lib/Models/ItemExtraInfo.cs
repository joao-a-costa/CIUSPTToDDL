using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents extra information about an item.
    /// </summary>
    public class ItemExtraInfo
    {
        //[JsonProperty("FishDetails")]
        //public FishDetails FishDetails;

        [JsonProperty("ReadQuantityFromScale")]
        public bool? ReadQuantityFromScale;

        [JsonProperty("CanotChangeSalePrice")]
        public bool? CanotChangeSalePrice;

        [JsonProperty("TagAlongItem")]
        public object TagAlongItem;

        [JsonProperty("TagAlongQuantity")]
        public int? TagAlongQuantity;

        [JsonProperty("InformationMessage")]
        public string InformationMessage;

        [JsonProperty("StockManagement")]
        public bool? StockManagement;

        [JsonProperty("ItemAverageUnitPrice")]
        public double? ItemAverageUnitPrice;

        [JsonProperty("ItemAverageTaxIncludedPrice")]
        public double? ItemAverageTaxIncludedPrice;

        [JsonProperty("ItemLastCostUnitPrice")]
        public double? ItemLastCostUnitPrice;

        [JsonProperty("ItemLastCostTaxIncludedPrice")]
        public double? ItemLastCostTaxIncludedPrice;

        [JsonProperty("ItemQuantityCalcFormula")]
        public object ItemQuantityCalcFormula;

        [JsonProperty("DefaultQntMeasure1")]
        public int? DefaultQntMeasure1;

        [JsonProperty("DefaultQntMeasure2")]
        public int? DefaultQntMeasure2;

        [JsonProperty("DefaultQntMeasure3")]
        public int? DefaultQntMeasure3;

        [JsonProperty("NeededComponents")]
        public int? NeededComponents;

        [JsonProperty("UseComponentPrices")]
        public bool? UseComponentPrices;

        [JsonProperty("UseComponentPriceLineID")]
        public int? UseComponentPriceLineID;

        [JsonProperty("ItemVariables")]
        public object ItemVariables;

        [JsonProperty("PrintStub")]
        public bool? PrintStub;

        [JsonProperty("DoNotGroup")]
        public bool? DoNotGroup;

        [JsonProperty("PictureName")]
        public string PictureName;

        [JsonProperty("OriginalTaxableGroupID")]
        public int? OriginalTaxableGroupID;
    }


}
