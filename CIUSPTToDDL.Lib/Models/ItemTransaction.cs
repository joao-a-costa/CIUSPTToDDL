using Newtonsoft.Json;
using System.Collections.Generic;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents an item transaction.
    /// </summary>
    public class ItemTransaction
    {
        [JsonProperty("TransDocType")]
        public int? TransDocType;

        [JsonProperty("TransBehavior")]
        public int? TransBehavior;

        [JsonProperty("TransactionGuid")]
        public string TransactionGuid;

        [JsonProperty("TempTransIndex")]
        public int? TempTransIndex;

        [JsonProperty("CreateDate")]
        public System.DateTime? CreateDate;

        [JsonProperty("CreateTime")]
        public System.DateTime? CreateTime;

        [JsonProperty("DeferredPaymentDate")]
        public System.DateTime? DeferredPaymentDate;

        [JsonProperty("ActualDeliveryDate")]
        public System.DateTime? ActualDeliveryDate;

        [JsonProperty("ContractReferenceNumber")]
        public string ContractReferenceNumber;

        [JsonProperty("DefaultWarehouse")]
        public int? DefaultWarehouse;

        [JsonProperty("PartyAddressID")]
        public int? PartyAddressID;

        [JsonProperty("PartyAddressLine1")]
        public string PartyAddressLine1;

        [JsonProperty("PartyAddressLine2")]
        public string PartyAddressLine2;

        [JsonProperty("PartyPostalCode")]
        public string PartyPostalCode;

        [JsonProperty("PartyGLN")]
        public string PartyGLN;

        [JsonProperty("PartyDelivery")]
        public string PartyDelivery;

        [JsonProperty("BillToPartyAddressID")]
        public int? BillToPartyAddressID;

        [JsonProperty("BillToPartyAddressLine1")]
        public object BillToPartyAddressLine1;

        [JsonProperty("BillToPartyAddressLine2")]
        public object BillToPartyAddressLine2;

        [JsonProperty("BillToPartyPostalCode")]
        public object BillToPartyPostalCode;

        [JsonProperty("Zone")]
        public Zone Zone;

        [JsonProperty("BaseCurrency")]
        public BaseCurrency BaseCurrency;

        //[JsonProperty("AlternCurrency")]
        //public AlternCurrency? AlternCurrency;

        [JsonProperty("Salesman")]
        public Salesman Salesman;

        [JsonProperty("Payment")]
        public Payment Payment;

        [JsonProperty("Tender")]
        public Tender Tender;

        [JsonProperty("Carrier")]
        public Carrier Carrier;

        [JsonProperty("LoadPlace")]
        public LoadPlace LoadPlace;

        [JsonProperty("UnloadPlace")]
        public UnloadPlace UnloadPlace;

        [JsonProperty("LoadPlaceDateTime")]
        public System.DateTime? LoadPlaceDateTime;

        [JsonProperty("UnloadPlaceDateTime")]
        public System.DateTime? UnloadPlaceDateTime;

        [JsonProperty("LoadPlaceAddress")]
        public LoadPlaceAddress LoadPlaceAddress;

        [JsonProperty("UnloadPlaceAddress")]
        public UnloadPlaceAddress UnloadPlaceAddress;

        [JsonProperty("TransactionTaxIncluded")]
        public bool? TransactionTaxIncluded = false;

        [JsonProperty("TransactionCreditSale")]
        public bool? TransactionCreditSale;

        [JsonProperty("TransactionConverted")]
        public bool? TransactionConverted;

        [JsonProperty("Comments")]
        public string Comments;

        [JsonProperty("RectificationMotive")]
        public string RectificationMotive;

        [JsonProperty("RetentionTax")]
        public int? RetentionTax;

        [JsonProperty("GlobalDiscountPercent")]
        public int? GlobalDiscountPercent;

        [JsonProperty("PaymentDiscountPercent")]
        public int? PaymentDiscountPercent;

        [JsonProperty("PaymentCumulativeDiscountPercent1")]
        public int? PaymentCumulativeDiscountPercent1;

        [JsonProperty("PaymentCumulativeDiscountPercent2")]
        public int? PaymentCumulativeDiscountPercent2;

        [JsonProperty("PaymentCumulativeDiscountPercent3")]
        public int? PaymentCumulativeDiscountPercent3;

        [JsonProperty("TotalGrossAmount")]
        public double? TotalGrossAmount;

        [JsonProperty("TotalLineItemDiscountAmount")]
        public int? TotalLineItemDiscountAmount;

        [JsonProperty("TotalPaymentDiscountAmount")]
        public int? TotalPaymentDiscountAmount;

        [JsonProperty("TotalRedeemedVoucherAmount")]
        public int? TotalRedeemedVoucherAmount;

        [JsonProperty("TotalGlobalDiscountAmount")]
        public int? TotalGlobalDiscountAmount;

        [JsonProperty("TotalNetAmount")]
        public double? TotalNetAmount;

        [JsonProperty("TotalTaxAmount")]
        public double? TotalTaxAmount;

        [JsonProperty("TotalOtherTaxesAmount")]
        public int? TotalOtherTaxesAmount;

        [JsonProperty("TotalFreightAmount")]
        public int? TotalFreightAmount;

        [JsonProperty("TotalFreightAmountWithTax")]
        public int? TotalFreightAmountWithTax;

        [JsonProperty("FreightTaxableGroupID")]
        public int? FreightTaxableGroupID;

        [JsonProperty("FreightTaxes")]
        public System.Collections.Generic.List<object> FreightTaxes;

        [JsonProperty("FreightTaxList")]
        public System.Collections.Generic.List<object> FreightTaxList;

        [JsonProperty("TotalAdjustmentAmount")]
        public int? TotalAdjustmentAmount;

        [JsonProperty("TotalAmount")]
        public double? TotalAmount;

        [JsonProperty("TotalRetentionAmount")]
        public int? TotalRetentionAmount;

        [JsonProperty("TotalAdvancementRetentionAmount")]
        public int? TotalAdvancementRetentionAmount;

        [JsonProperty("TotalAllowanceAmount")]
        public int? TotalAllowanceAmount;

        [JsonProperty("TotalChargeAmount")]
        public int? TotalChargeAmount;

        [JsonProperty("TotalTransactionAmount")]
        public double? TotalTransactionAmount;

        [JsonProperty("TotalPayedAmount")]
        public int? TotalPayedAmount;

        [JsonProperty("SecondIssue")]
        public bool? SecondIssue;

        [JsonProperty("TransStatus")]
        public int? TransStatus;

        [JsonProperty("StatusFlags")]
        public int? StatusFlags;

        [JsonProperty("SecondHandTaxRegimen")]
        public bool? SecondHandTaxRegimen;

        //[JsonProperty("Taxes")]
        //public List<Taxis>? Taxes;

        [JsonProperty("Details")]
        public List<Detail> Details;

        [JsonProperty("LedgerAccount")]
        public System.Collections.Generic.List<object> LedgerAccount;

        [JsonProperty("TenderLineItem")]
        public System.Collections.Generic.List<object> TenderLineItem;

        //[JsonProperty("ExtraFieldList")]
        //public List<ExtraFieldList>? ExtraFieldList;

        [JsonProperty("BankReceiptList")]
        public System.Collections.Generic.List<object> BankReceiptList;

        [JsonProperty("AccountTransaction")]
        public object AccountTransaction;

        //[JsonProperty("WorkstationStamp")]
        //public WorkstationStamp? WorkstationStamp;

        [JsonProperty("BalconyScaleTicketProcessed")]
        public System.Collections.Generic.List<object> BalconyScaleTicketProcessed;

        [JsonProperty("AllowancesCharges")]
        public System.Collections.Generic.List<object> AllowancesCharges;

        [JsonProperty("RedeemedVouchers")]
        public System.Collections.Generic.List<object> RedeemedVouchers;

        [JsonProperty("FrequentShopperPoints")]
        public int? FrequentShopperPoints;

        [JsonProperty("DiscountFreqShopperPoints")]
        public int? DiscountFreqShopperPoints;

        [JsonProperty("AccountingExportDate")]
        public System.DateTime? AccountingExportDate;

        [JsonProperty("VoucherSpentValueAmount")]
        public int? VoucherSpentValueAmount;

        [JsonProperty("VoucherDocSpentList")]
        public System.Collections.Generic.List<object> VoucherDocSpentList;

        [JsonProperty("Reconciled")]
        public bool? Reconciled;

        [JsonProperty("DownPaymentInvoice")]
        public bool? DownPaymentInvoice;

        [JsonProperty("VoucherGiftTransSerial")]
        public string VoucherGiftTransSerial;

        [JsonProperty("VoucherGiftTransDocument")]
        public string VoucherGiftTransDocument;

        [JsonProperty("VoucherGiftTransDocNumber")]
        public int? VoucherGiftTransDocNumber;

        [JsonProperty("VoucherGiftValue")]
        public int? VoucherGiftValue;

        [JsonProperty("VoucherGiftFamilyList")]
        public object VoucherGiftFamilyList;

        [JsonProperty("TotalOtherCostAmount")]
        public int? TotalOtherCostAmount;

        [JsonProperty("BuyShareOtherCostList")]
        public System.Collections.Generic.List<object> BuyShareOtherCostList;

        [JsonProperty("CurrentStatusID")]
        public string CurrentStatusID;

        [JsonProperty("AccountingOperation")]
        public string AccountingOperation;

        [JsonProperty("PrintedCopies")]
        public int? PrintedCopies;

        [JsonProperty("OfferVoucherGiftValue")]
        public int? OfferVoucherGiftValue;

        [JsonProperty("Till")]
        public Till Till;

        [JsonProperty("SignatureInvoiceNo")]
        public string SignatureInvoiceNo;

        [JsonProperty("VoidMotive")]
        public object VoidMotive;

        [JsonProperty("SystemEntryUser")]
        public string SystemEntryUser;

        [JsonProperty("TransmissionStatus")]
        public int? TransmissionStatus;

        [JsonProperty("ShipmentDocumentType")]
        public int? ShipmentDocumentType;

        [JsonProperty("RegistrationPlate")]
        public string RegistrationPlate;

        [JsonProperty("CashAccountingSchemeType")]
        public int? CashAccountingSchemeType;

        [JsonProperty("CustomerPaidDeductibleAmount")]
        public int? CustomerPaidDeductibleAmount;

        [JsonProperty("PaymentDiscountAmountChangeFlags")]
        public int? PaymentDiscountAmountChangeFlags;

        [JsonProperty("PlantProtectionActivityAuth")]
        public string PlantProtectionActivityAuth;

        [JsonProperty("PlantProtectionApplicator")]
        public string PlantProtectionApplicator;

        [JsonProperty("EInvoiceStatus")]
        public int? EInvoiceStatus;

        [JsonProperty("EInvoiceStatusDate")]
        public System.DateTime? EInvoiceStatusDate;

        [JsonProperty("EInvoiceSender")]
        public string EInvoiceSender;

        [JsonProperty("EInvoiceReceiver")]
        public string EInvoiceReceiver;

        [JsonProperty("EInvoiceSubmitDate")]
        public System.DateTime? EInvoiceSubmitDate;

        [JsonProperty("LoyaltyId")]
        public string LoyaltyId;

        [JsonProperty("LoyaltyUploadDate")]
        public System.DateTime? LoyaltyUploadDate;

        [JsonProperty("BalanceFreqShopperPoints")]
        public int? BalanceFreqShopperPoints;

        [JsonProperty("OnlineReceiptTagType")]
        public int? OnlineReceiptTagType;

        [JsonProperty("OnlineReceiptTag")]
        public string OnlineReceiptTag;

        [JsonProperty("OnlineReceiptToken")]
        public string OnlineReceiptToken;

        [JsonProperty("OnlineReceiptEmail")]
        public string OnlineReceiptEmail;

        [JsonProperty("PABudgetExpenditureNumber")]
        public string PABudgetExpenditureNumber;

        [JsonProperty("PAContractNumber")]
        public string PAContractNumber;

        [JsonProperty("PACommitmentNumber")]
        public string PACommitmentNumber;

        [JsonProperty("ATCUD")]
        public string ATCUD;

        [JsonProperty("QRCode")]
        public string QRCode;

        [JsonProperty("FrequentShopperProcessingState")]
        public int? FrequentShopperProcessingState;

        [JsonProperty("ATDocCodeId")]
        public string ATDocCodeId;

        //[JsonProperty("Entity")]
        //public Entity? Entity;

        //[JsonProperty("BillToEntity")]
        //public BillToEntity? BillToEntity;

        [JsonProperty("PartyTypeCode")]
        public int? PartyTypeCode;

        [JsonProperty("BillToPartyTypeCode")]
        public int? BillToPartyTypeCode;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("CustomerImpute")]
        public object CustomerImpute;

        [JsonProperty("TotalAdvancementAmount")]
        public int? TotalAdvancementAmount;

        [JsonProperty("TotalAdvancementNetAmount")]
        public int? TotalAdvancementNetAmount;

        [JsonProperty("Party")]
        public Party Party;

        //[JsonProperty("BillToParty")]
        //public BillToParty? BillToParty;

        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("BillToPartyID")]
        public int? BillToPartyID;

        [JsonProperty("PartyOrganizationName")]
        public string PartyOrganizationName;

        [JsonProperty("BillToPartyOrganizationName")]
        public object BillToPartyOrganizationName;

        [JsonProperty("PartyFederalTaxID")]
        public string PartyFederalTaxID;

        [JsonProperty("BillToPartyFederalTaxID")]
        public object BillToPartyFederalTaxID;

        [JsonProperty("PartyFiscalStatus")]
        public int? PartyFiscalStatus;

        [JsonProperty("BillToPartyFiscalStatus")]
        public int? BillToPartyFiscalStatus;

        [JsonProperty("PartyTelephone")]
        public string PartyTelephone;

        [JsonProperty("PartyFax")]
        public string PartyFax;

        [JsonProperty("PartyMobilePhone")]
        public string PartyMobilePhone;

        [JsonProperty("PartyEmail")]
        public string PartyEmail;

        [JsonProperty("PartyAccountBalance")]
        public double? PartyAccountBalance;

        [JsonProperty("BillToPartyAccountBalance")]
        public int? BillToPartyAccountBalance;

        [JsonProperty("PartyAccountCurrencyID")]
        public string PartyAccountCurrencyID;

        [JsonProperty("BillToPartyAccountCurrencyID")]
        public string BillToPartyAccountCurrencyID;

        [JsonProperty("PartyFrequentShopperPoints")]
        public int? PartyFrequentShopperPoints;

        [JsonProperty("PartyCountryID")]
        public string PartyCountryID;

        [JsonProperty("BillToPartyCountryID")]
        public object BillToPartyCountryID;

        [JsonProperty("PartyProvinceID")]
        public string PartyProvinceID;

        [JsonProperty("BillToPartyProvinceID")]
        public object BillToPartyProvinceID;

        [JsonProperty("PartyLocalityID")]
        public int? PartyLocalityID;

        [JsonProperty("BillToPartyLocalityID")]
        public int? BillToPartyLocalityID;

        [JsonProperty("PartyCarrierID")]
        public int? PartyCarrierID;

        [JsonProperty("PartyBankAccountNumber")]
        public object PartyBankAccountNumber;

        [JsonProperty("PartyBankCode")]
        public object PartyBankCode;

        [JsonProperty("PartyBranchCode")]
        public object PartyBranchCode;

        [JsonProperty("PartyAccountCheckDigit")]
        public object PartyAccountCheckDigit;

        [JsonProperty("PartyBankName")]
        public object PartyBankName;

        [JsonProperty("PartyPriceItemDecimalPlaces")]
        public int? PartyPriceItemDecimalPlaces;

        [JsonProperty("PartyFreightOnLedgerAccount")]
        public bool? PartyFreightOnLedgerAccount;

        [JsonProperty("PartyAccountingGeneralLedgerID")]
        public string PartyAccountingGeneralLedgerID;

        [JsonProperty("PartySupplierCustomerID")]
        public object PartySupplierCustomerID;

        [JsonProperty("PartyVehicleID")]
        public int? PartyVehicleID;

        [JsonProperty("PartyVehicleLicensePlate")]
        public object PartyVehicleLicensePlate;

        [JsonProperty("PartyVehicleMake")]
        public object PartyVehicleMake;

        [JsonProperty("PartyVehicleModel")]
        public object PartyVehicleModel;

        [JsonProperty("PartyVehicleYear")]
        public int? PartyVehicleYear;

        [JsonProperty("PartyVehicleMonth")]
        public int? PartyVehicleMonth;

        [JsonProperty("PartyVehicleDateOfFirstRegistration")]
        public System.DateTime? PartyVehicleDateOfFirstRegistration;

        [JsonProperty("PartyVehicleColor")]
        public object PartyVehicleColor;

        [JsonProperty("PartyVehicleFrameNumber")]
        public object PartyVehicleFrameNumber;

        [JsonProperty("PartyVehicleEngineNumber")]
        public object PartyVehicleEngineNumber;

        [JsonProperty("PartyVehicleKilometers")]
        public int? PartyVehicleKilometers;

        [JsonProperty("PartyVehicleOriginalKilometers")]
        public int? PartyVehicleOriginalKilometers;

        [JsonProperty("PartyVehicleComments")]
        public object PartyVehicleComments;

        [JsonProperty("PartyWorkID")]
        public int? PartyWorkID;

        [JsonProperty("PartyWorkComments")]
        public object PartyWorkComments;

        [JsonProperty("PartyWorkDescription")]
        public object PartyWorkDescription;

        [JsonProperty("PartyWorkBudgetValue")]
        public int? PartyWorkBudgetValue;

        [JsonProperty("PartyWorkStartDate")]
        public System.DateTime? PartyWorkStartDate;

        [JsonProperty("PartyWorkEndDate")]
        public System.DateTime? PartyWorkEndDate;

        [JsonProperty("PartyCustomerLevel")]
        public int? PartyCustomerLevel;

        [JsonProperty("PartyPrintCopies")]
        public int? PartyPrintCopies;

        [JsonProperty("OriginatingON")]
        public string OriginatingON;

        [JsonProperty("HandWrittenTransactionNumber")]
        public string HandWrittenTransactionNumber;

        [JsonProperty("IsOnPreparednessState")]
        public bool? IsOnPreparednessState;

        [JsonProperty("HasValidSignature")]
        public bool? HasValidSignature;

        [JsonProperty("Signature")]
        public object Signature;

        [JsonProperty("SignatureMessage")]
        public object SignatureMessage;

        [JsonProperty("SignatureControl")]
        public int? SignatureControl;

        [JsonProperty("SoftwareCertificateNumber")]
        public int? SoftwareCertificateNumber;

        [JsonProperty("SystemEntryDate")]
        public System.DateTime? SystemEntryDate;

        //[JsonProperty("TransactionID")]
        //public TransactionID TransactionID;

        [JsonProperty("TransSerial")]
        public string TransSerial;

        [JsonProperty("TransDocument")]
        public string TransDocument;

        [JsonProperty("TransDocNumber")]
        public int? TransDocNumber;

        [JsonProperty("TotalServiceAmount")]
        public int? TotalServiceAmount;

        [JsonProperty("RetentionPaidAmount")]
        public int? RetentionPaidAmount;

        [JsonProperty("CanBeCalculatedOnTaxIncluded")]
        public bool? CanBeCalculatedOnTaxIncluded;

        [JsonProperty("WithholdingTaxType")]
        public string WithholdingTaxType;

        [JsonProperty("_ISignableTransaction_Signature")]
        public object ISignableTransactionSignature;

        [JsonProperty("_ISignableTransaction_TotalAmount")]
        public double? ISignableTransactionTotalAmount;

        [JsonProperty("_ISignableTransaction_SystemEntryDate")]
        public System.DateTime? ISignableTransactionSystemEntryDate;

        [JsonProperty("_ISignableTransaction_TransactionID")]
        public string ISignableTransactionTransactionID;
    }
}