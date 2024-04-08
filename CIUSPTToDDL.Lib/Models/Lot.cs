using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a lot.
    /// </summary>
    public class Lot
    {
        [JsonProperty("ItemID")]
        public object ItemID;

        [JsonProperty("EditionID")]
        public int? EditionID;

        [JsonProperty("EffectiveDate")]
        public System.DateTime? EffectiveDate;

        [JsonProperty("ExpirationDate")]
        public System.DateTime? ExpirationDate;

        [JsonProperty("SalePrice")]
        public SalePrice SalePrice;

        [JsonProperty("SaveSalePrice")]
        public bool? SaveSalePrice;

        [JsonProperty("ReturnWeek")]
        public int? ReturnWeek;

        [JsonProperty("ReturnYear")]
        public int? ReturnYear;

        [JsonProperty("ItemLotDescription")]
        public object ItemLotDescription;

        [JsonProperty("SupplierItemID")]
        public object SupplierItemID;

        [JsonProperty("BarCode")]
        public object BarCode;

        [JsonProperty("StoreID")]
        public int? StoreID;

        [JsonProperty("LotID")]
        public object LotID;
    }


}
