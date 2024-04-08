using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents an account type.
    /// </summary>
    public class AccountType
    {
        [JsonProperty("AccountTypeID")]
        public object AccountTypeID;

        [JsonProperty("UseOnCustomers")]
        public bool? UseOnCustomers;

        [JsonProperty("UseOnSuppliers")]
        public bool? UseOnSuppliers;

        [JsonProperty("UseOnSalesman")]
        public bool? UseOnSalesman;

        [JsonProperty("UseOnOtherEntities")]
        public bool? UseOnOtherEntities;

        [JsonProperty("Description")]
        public object Description;

        [JsonProperty("AffectsBalanceAmount")]
        public bool? AffectsBalanceAmount;

        [JsonProperty("AffectsPlafondAmount")]
        public bool? AffectsPlafondAmount;
    }


}
