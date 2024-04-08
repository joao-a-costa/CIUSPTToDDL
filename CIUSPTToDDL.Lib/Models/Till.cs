using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a till.
    /// </summary>
    public class Till
    {
        [JsonProperty("TillID")]
        public string TillID;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("StatusCode")]
        public int? StatusCode;

        [JsonProperty("MinimumWarningAmount")]
        public int? MinimumWarningAmount;

        [JsonProperty("DefaultCashBalanceAmount")]
        public int? DefaultCashBalanceAmount;

        [JsonProperty("MaximumWarningAmount")]
        public int? MaximumWarningAmount;

        [JsonProperty("MaximumLockoutAmount")]
        public int? MaximumLockoutAmount;

        [JsonProperty("StoreId")]
        public int? StoreId;

        [JsonProperty("MainTill")]
        public bool? MainTill;

        [JsonProperty("OfflineTill")]
        public bool? OfflineTill;

        [JsonProperty("Comments")]
        public string Comments;

        [JsonProperty("TillOpenMode")]
        public int? TillOpenMode;

        [JsonProperty("OnTouchUseRoute")]
        public bool? OnTouchUseRoute;

        [JsonProperty("MaximumSessionsPerDay")]
        public int? MaximumSessionsPerDay;

        [JsonProperty("CanHaveOpenTill")]
        public bool? CanHaveOpenTill;

        [JsonProperty("TillLockToSalesman")]
        public bool? TillLockToSalesman;

        [JsonProperty("FixSalesmanForSession")]
        public bool? FixSalesmanForSession;

        [JsonProperty("ExclusiveToOwnerSalesman")]
        public bool? ExclusiveToOwnerSalesman;

        [JsonProperty("CanChangeTranOnSignOffTill")]
        public bool? CanChangeTranOnSignOffTill;

        [JsonProperty("CheckForTempTransactionOnSignOff")]
        public bool? CheckForTempTransactionOnSignOff;

        [JsonProperty("OperatorTenderStatement")]
        public bool? OperatorTenderStatement;

        [JsonProperty("TenderStatementTentatives")]
        public int? TenderStatementTentatives;

        [JsonProperty("OnStatementCanHaveDiscrepancy")]
        public bool? OnStatementCanHaveDiscrepancy;

        [JsonProperty("StatementDiscrepancyAmount")]
        public int? StatementDiscrepancyAmount;

        [JsonProperty("DiscrepancyTillID")]
        public string DiscrepancyTillID;

        [JsonProperty("DiscrepancyAccountTypeID")]
        public string DiscrepancyAccountTypeID;

        [JsonProperty("BuiltIn")]
        public bool? BuiltIn;

        [JsonProperty("TillBankAccount")]
        public System.Collections.Generic.List<object> TillBankAccount;
    }


}
