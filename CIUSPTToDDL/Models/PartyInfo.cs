using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents a party info.
    /// </summary>
    public class PartyInfo
    {
        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("PartyType")]
        public int? PartyType;

        [JsonProperty("ContactList")]
        public System.Collections.Generic.List<object> ContactList;

        [JsonProperty("AddressList")]
        public System.Collections.Generic.List<object> AddressList;

        [JsonProperty("AccountList")]
        public System.Collections.Generic.List<object> AccountList;

        [JsonProperty("CommentList")]
        public System.Collections.Generic.List<object> CommentList;

        [JsonProperty("ExtraFields")]
        public System.Collections.Generic.List<object> ExtraFields;

        [JsonProperty("MessageList")]
        public System.Collections.Generic.List<object> MessageList;
    }


}
