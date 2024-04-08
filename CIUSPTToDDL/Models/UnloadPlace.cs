using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    /// <summary>
    /// Represents an unload place.
    /// </summary>
    public class UnloadPlace
    {
        [JsonProperty("LoadUnloadPlaceID")]
        public int? LoadUnloadPlaceID;

        [JsonProperty("Description")]
        public string Description;

        [JsonProperty("AddressType")]
        public int? AddressType;

        [JsonProperty("AddressTypeID")]
        public int? AddressTypeID;

        [JsonProperty("ExtendedProperties")]
        public System.Collections.Generic.List<object> ExtendedProperties;
    }
}
