using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents item properties.
    /// </summary>
    public class ItemProperties
    {
        [JsonProperty("PropertyID1")]
        public object PropertyID1;

        [JsonProperty("PropertyID2")]
        public object PropertyID2;

        [JsonProperty("PropertyID3")]
        public object PropertyID3;

        [JsonProperty("PropertyValue1")]
        public object PropertyValue1;

        [JsonProperty("PropertyValue1_Key2")]
        public object PropertyValue1Key2;

        [JsonProperty("PropertyValue1_Key3")]
        public object PropertyValue1Key3;

        [JsonProperty("PropertyValue2")]
        public object PropertyValue2;

        [JsonProperty("PropertyValue2_Key2")]
        public object PropertyValue2Key2;

        [JsonProperty("PropertyValue2_Key3")]
        public object PropertyValue2Key3;

        [JsonProperty("PropertyValue3")]
        public object PropertyValue3;

        [JsonProperty("PropertyValue3_Key2")]
        public object PropertyValue3Key2;

        [JsonProperty("PropertyValue3_Key3")]
        public object PropertyValue3Key3;

        [JsonProperty("SupplierID")]
        public int? SupplierID;

        [JsonProperty("ProductionDate")]
        public System.DateTime? ProductionDate;

        [JsonProperty("ExpirationDate")]
        public System.DateTime? ExpirationDate;

        [JsonProperty("PhysicalQty")]
        public int? PhysicalQty;

        [JsonProperty("PhysicalUnits")]
        public int? PhysicalUnits;

        [JsonProperty("LastCostPrice")]
        public int? LastCostPrice;

        [JsonProperty("AverageCostStockValue")]
        public int? AverageCostStockValue;

        [JsonProperty("ControlType")]
        public int? ControlType;

        [JsonProperty("ControlMode")]
        public int? ControlMode;

        [JsonProperty("UseExpirationDate")]
        public bool? UseExpirationDate;

        [JsonProperty("UseProductionDate")]
        public bool? UseProductionDate;

        [JsonProperty("ExpirationDateControl")]
        public int? ExpirationDateControl;

        [JsonProperty("MaximumQuantity")]
        public int? MaximumQuantity;

        [JsonProperty("UsePriceOnProp1")]
        public bool? UsePriceOnProp1;

        [JsonProperty("UsePriceOnProp2")]
        public bool? UsePriceOnProp2;

        [JsonProperty("UsePriceOnProp3")]
        public bool? UsePriceOnProp3;

        [JsonProperty("DirectEntry")]
        public bool? DirectEntry;

        [JsonProperty("HasPropertyValues")]
        public bool? HasPropertyValues;

        [JsonProperty("HasPropertyIDs")]
        public bool? HasPropertyIDs;
    }


}
