using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a color.
    /// </summary>
    public class Color
    {
        [JsonProperty("ColorID")]
        public int? ColorID;

        [JsonProperty("ColorKey")]
        public object ColorKey;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("ColorCode")]
        public int? ColorCode;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;

        [JsonProperty("PantoneCode")]
        public string PantoneCode;
    }
}
