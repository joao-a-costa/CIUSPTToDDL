using Newtonsoft.Json;
using System.Collections.Generic;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a detail.
    /// </summary>
    public class Detail
    {
        [JsonProperty("TransSerial")]
        public string TransSerial;

        [JsonProperty("TransDocument")]
        public string TransDocument;

        [JsonProperty("TransDocNumber")]
        public int? TransDocNumber;

        [JsonProperty("Key")]
        public int? Key;

        [JsonProperty("CreateDate")]
        public System.DateTime? CreateDate;

        [JsonProperty("CreateTime")]
        public System.DateTime? CreateTime;

        [JsonProperty("OriginCreateDate")]
        public System.DateTime? OriginCreateDate;

        [JsonProperty("OriginTransSerial")]
        public string OriginTransSerial;

        [JsonProperty("OriginTransDocument")]
        public string OriginTransDocument;

        [JsonProperty("OriginTransDocNumber")]
        public int? OriginTransDocNumber;

        [JsonProperty("OriginLineItemID")]
        public int? OriginLineItemID;

        [JsonProperty("OriginLineItemSubID")]
        public int? OriginLineItemSubID;

        [JsonProperty("OriginQuantity")]
        public int? OriginQuantity;

        [JsonProperty("OriginUnits")]
        public int? OriginUnits;

        [JsonProperty("DestinationTransSerial")]
        public string DestinationTransSerial;

        [JsonProperty("DestinationTransDocument")]
        public string DestinationTransDocument;

        [JsonProperty("DestinationTransDocNumber")]
        public int? DestinationTransDocNumber;

        [JsonProperty("DestinationLineItemID")]
        public int? DestinationLineItemID;

        [JsonProperty("DestinationLineItemSubID")]
        public int? DestinationLineItemSubID;

        [JsonProperty("DestinationQuantity")]
        public int? DestinationQuantity;

        [JsonProperty("DestinationUnits")]
        public int? DestinationUnits;

        [JsonProperty("TransactionConverted")]
        public bool? TransactionConverted;

        [JsonProperty("LineItemID")]
        public int? LineItemID;

        [JsonProperty("LineItemSubID")]
        public int? LineItemSubID;

        [JsonProperty("ItemID")]
        public string ItemID;

        [JsonProperty("POSItemID")]
        public string POSItemID;

        [JsonProperty("BarCode")]
        public string BarCode;

        [JsonProperty("Lot")]
        public Lot Lot;

        [JsonProperty("ItemType")]
        public int? ItemType;

        [JsonProperty("SupplierItemID")]
        public string SupplierItemID;

        [JsonProperty("Color")]
        public Color Color;

        [JsonProperty("Size")]
        public Size Size;

        [JsonProperty("GridSize")]
        public System.Collections.Generic.List<object> GridSize;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("ShortDescription")]
        public string ShortDescription;

        [JsonProperty("TaxableGroupID")]
        public int? TaxableGroupID;

        //[JsonProperty("Taxes")]
        //public List<Taxis>? Taxes;

        [JsonProperty("TaxList")]
        public List<TaxList> TaxList;

        [JsonProperty("UnitOfSaleID")]
        public string UnitOfSaleID;

        [JsonProperty("AlternativeUnitOfStock")]
        public object AlternativeUnitOfStock;

        [JsonProperty("WeightUnitOfMeasure")]
        public string WeightUnitOfMeasure;

        [JsonProperty("WeightMeasure")]
        public int? WeightMeasure;

        [JsonProperty("Graduation")]
        public int? Graduation;

        [JsonProperty("ItemTax")]
        public int? ItemTax;

        [JsonProperty("ItemTax2")]
        public int? ItemTax2;

        [JsonProperty("ItemTax3")]
        public int? ItemTax3;

        [JsonProperty("PhysicalQtyRule")]
        public int? PhysicalQtyRule;

        [JsonProperty("CountedQuantity")]
        public int? CountedQuantity;

        [JsonProperty("ConsignmentQuantity")]
        public int? ConsignmentQuantity;

        [JsonProperty("Quantity1")]
        public int? Quantity1;

        [JsonProperty("Quantity2")]
        public int? Quantity2;

        [JsonProperty("Quantity3")]
        public int? Quantity3;

        [JsonProperty("Quantity4")]
        public int? Quantity4;

        [JsonProperty("ComponentQty")]
        public int? ComponentQty;

        [JsonProperty("UnitCasesCount")]
        public int? UnitCasesCount;

        [JsonProperty("DiscountPercent")]
        public double? DiscountPercent;

        [JsonProperty("DiscountValue")]
        public double? DiscountValue;

        [JsonProperty("UnitDiscountValue")]
        public int? UnitDiscountValue;

        [JsonProperty("OriginalUnitPrice")]
        public double? OriginalUnitPrice;

        [JsonProperty("OriginalTaxIncludedPrice")]
        public double? OriginalTaxIncludedPrice;

        [JsonProperty("OriginalDiscountPercent")]
        public double? OriginalDiscountPercent;

        [JsonProperty("FamilyID")]
        public int? FamilyID;

        [JsonProperty("FamilyName")]
        public string FamilyName;

        [JsonProperty("FamilyMaximumDiscount")]
        public int? FamilyMaximumDiscount;

        [JsonProperty("MandatoryCustomer")]
        public bool? MandatoryCustomer;

        [JsonProperty("WarehouseID")]
        public int? WarehouseID;

        [JsonProperty("WarehouseOutgoing")]
        public int? WarehouseOutgoing;

        [JsonProperty("WarehouseReceipt")]
        public int? WarehouseReceipt;

        [JsonProperty("CumulativeDiscountPercent1")]
        public double? CumulativeDiscountPercent1;

        [JsonProperty("CumulativeDiscountPercent2")]
        public double? CumulativeDiscountPercent2;

        [JsonProperty("CumulativeDiscountPercent3")]
        public double? CumulativeDiscountPercent3;

        [JsonProperty("PaymentDiscountPercent1")]
        public double? PaymentDiscountPercent1;

        [JsonProperty("PaymentDiscountPercent2")]
        public double? PaymentDiscountPercent2;

        [JsonProperty("PaymentDiscountPercent3")]
        public double? PaymentDiscountPercent3;

        [JsonProperty("PartyTypeCode")]
        public int? PartyTypeCode;

        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("CustomerImputeID")]
        public int? CustomerImputeID;

        [JsonProperty("ImputeToCustomerID")]
        public int? ImputeToCustomerID;

        [JsonProperty("BillToPartyID")]
        public int? BillToPartyID;

        [JsonProperty("SalesmanId")]
        public int? SalesmanId;

        [JsonProperty("TotalGrossAmount")]
        public double? TotalGrossAmount;

        [JsonProperty("TotalLineItemDiscountAmount")]
        public int? TotalLineItemDiscountAmount;

        [JsonProperty("TotalGlobalDiscountAmount")]
        public int? TotalGlobalDiscountAmount;

        [JsonProperty("TotalNetAmount")]
        public double? TotalNetAmount;

        [JsonProperty("TotalNetBaseTaxAmount")]
        public double? TotalNetBaseTaxAmount;

        [JsonProperty("TotalNetPrintAmout")]
        public double? TotalNetPrintAmout;

        [JsonProperty("TotalTaxAmount")]
        public double? TotalTaxAmount;

        [JsonProperty("TotalOtherTaxAmount")]
        public int? TotalOtherTaxAmount;

        [JsonProperty("TotalAmount")]
        public double? TotalAmount;

        [JsonProperty("TotalTaxIncludedAmount")]
        public double? TotalTaxIncludedAmount;

        [JsonProperty("ShareFreightAmount")]
        public int? ShareFreightAmount;

        [JsonProperty("BaseCurrency")]
        public BaseCurrency BaseCurrency;

        [JsonProperty("QntyReorderPoint")]
        public int? QntyReorderPoint;

        [JsonProperty("QntyAvailableBalanceCount")]
        public int? QntyAvailableBalanceCount;

        [JsonProperty("QntyPhysicalBalanceCount")]
        public int? QntyPhysicalBalanceCount;

        [JsonProperty("QntyWrPhysicalBalanceCount")]
        public int? QntyWrPhysicalBalanceCount;

        [JsonProperty("QntyWrAvailableBalanceCount")]
        public int? QntyWrAvailableBalanceCount;

        [JsonProperty("QntyPhysicalBalanceDiff")]
        public int? QntyPhysicalBalanceDiff;

        [JsonProperty("UnitsAvailableBalanceCount")]
        public int? UnitsAvailableBalanceCount;

        [JsonProperty("UnitsPhysicalBalanceCount")]
        public int? UnitsPhysicalBalanceCount;

        [JsonProperty("UnitsWrPhysicalBalanceCount")]
        public int? UnitsWrPhysicalBalanceCount;

        [JsonProperty("UnitsWrAvailableBalanceCount")]
        public int? UnitsWrAvailableBalanceCount;

        [JsonProperty("UnitsPhysicalBalanceDiff")]
        public int? UnitsPhysicalBalanceDiff;

        [JsonProperty("AverageCostPrice")]
        public int? AverageCostPrice;

        [JsonProperty("LastCostPrice")]
        public int? LastCostPrice;

        [JsonProperty("AverageCostStockValue")]
        public int? AverageCostStockValue;

        [JsonProperty("LastCostStockValue")]
        public int? LastCostStockValue;

        [JsonProperty("DatePhysicalBalanceCount")]
        public System.DateTime? DatePhysicalBalanceCount;

        [JsonProperty("TimeAdjustmentBalanceCount")]
        public System.DateTime? TimeAdjustmentBalanceCount;

        [JsonProperty("FrequentShopperPoints")]
        public int? FrequentShopperPoints;

        [JsonProperty("VoucherGiftValue")]
        public int? VoucherGiftValue;

        [JsonProperty("TransactionDetailClosed")]
        public bool? TransactionDetailClosed;

        [JsonProperty("TempContractReferenceNumber")]
        public object TempContractReferenceNumber;

        //[JsonProperty("ItemExtraInfo")]
        //public ItemExtraInfo? ItemExtraInfo;

        [JsonProperty("ItemProperties")]
        public ItemProperties ItemProperties;

        [JsonProperty("ItemContractGuid")]
        public string ItemContractGuid;

        [JsonProperty("IsComponent")]
        public bool? IsComponent;

        [JsonProperty("Comments")]
        public string Comments;

        [JsonProperty("SecondHandTaxRegimen")]
        public bool? SecondHandTaxRegimen;

        [JsonProperty("PriceAndDiscountChangeFlags")]
        public int? PriceAndDiscountChangeFlags;

        [JsonProperty("OfferTypeFlags")]
        public int? OfferTypeFlags;

        [JsonProperty("PromotionApplied")]
        public bool? PromotionApplied;

        [JsonProperty("PromotionAppliedQERO")]
        public bool? PromotionAppliedQERO;

        [JsonProperty("ProductCode")]
        public string ProductCode;

        [JsonProperty("PlantProtectionSaleAuthNumber")]
        public string PlantProtectionSaleAuthNumber;

        [JsonProperty("ProductCategory")]
        public int? ProductCategory;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        //[JsonProperty("DiscountSettings")]
        //public DiscountSettings? DiscountSettings;

        [JsonProperty("Guid")]
        public string Guid;

        [JsonProperty("Quantity")]
        public int? Quantity;

        [JsonProperty("Units")]
        public int? Units;

        [JsonProperty("StockUnits")]
        public int? StockUnits;

        [JsonProperty("UnitConversion")]
        public int? UnitConversion;

        [JsonProperty("PackQuantity")]
        public int? PackQuantity;

        [JsonProperty("QuantityFactor")]
        public int? QuantityFactor;

        [JsonProperty("PackUnitPrice")]
        public double? PackUnitPrice;

        [JsonProperty("PackTaxIncludedPrice")]
        public double? PackTaxIncludedPrice;

        [JsonProperty("UnitList")]
        public System.Collections.Generic.List<object> UnitList;

        [JsonProperty("HasComponents")]
        public bool? HasComponents;

        [JsonProperty("HasPropertiesOnComponents")]
        public bool? HasPropertiesOnComponents;

        [JsonProperty("TaxIncludedPrice")]
        public double? TaxIncludedPrice;

        [JsonProperty("UnitPrice")]
        public double? UnitPrice;

        [JsonProperty("ActualDeliveryDate")]
        public System.DateTime? ActualDeliveryDate;

        [JsonProperty("PhysicalQtyDate")]
        public System.DateTime? PhysicalQtyDate;

        [JsonProperty("RequiredDeliveryDateTime")]
        public System.DateTime? RequiredDeliveryDateTime;

        [JsonProperty("ComponentList")]
        public System.Collections.Generic.List<object> ComponentList;

        [JsonProperty("Signature")]
        public string Signature;

        [JsonProperty("ExtraFieldList")]
        public System.Collections.Generic.List<object> ExtraFieldList;

        [JsonProperty("RetentionTax")]
        public int? RetentionTax;

        [JsonProperty("Notes")]
        public List<string> DetailNotes;
    }
}
