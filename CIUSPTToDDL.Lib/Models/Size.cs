using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a size.
    /// </summary>
    public class Size
    {
        [JsonProperty("SizeID")]
        public int? SizeID;

        [JsonProperty("SizeKey")]
        public object SizeKey;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("StandardSizeID")]
        public int? StandardSizeID;

        [JsonProperty("GenderID")]
        public int? GenderID;

        [JsonProperty("ClothingTypeID")]
        public int? ClothingTypeID;
    }


}
