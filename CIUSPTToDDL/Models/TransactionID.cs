using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    public class TransactionID
    {
        [JsonProperty("TransSerial")]
        public string TransSerial;

        [JsonProperty("TransDocument")]
        public string TransDocument;

        [JsonProperty("TransDocNumber")]
        public int? TransDocNumber;

        [JsonProperty("createDate")]
        public System.DateTime? CreateDate;
    }
}
