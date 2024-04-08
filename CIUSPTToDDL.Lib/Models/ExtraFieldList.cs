using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents an extra field list.
    /// </summary>
    public class ExtraFieldList
    {
        [JsonProperty("PartyID")]
        public int? PartyID;

        [JsonProperty("ItemID")]
        public object ItemID;

        [JsonProperty("TransSerial")]
        public string TransSerial;

        [JsonProperty("TransDocument")]
        public string TransDocument;

        [JsonProperty("TransDocNumber")]
        public int? TransDocNumber;

        [JsonProperty("ExtraFieldID")]
        public int? ExtraFieldID;

        [JsonProperty("TextAnswer")]
        public string TextAnswer;

        [JsonProperty("NumberAnswer")]
        public int? NumberAnswer;

        [JsonProperty("DateAnswer")]
        public System.DateTime? DateAnswer;

        [JsonProperty("BooleanAnswer")]
        public bool? BooleanAnswer;

        [JsonProperty("MemoAnswer")]
        public string MemoAnswer;

        [JsonProperty("LineItemID")]
        public int? LineItemID;

        [JsonProperty("LineItemSubID")]
        public int? LineItemSubID;
    }


}
