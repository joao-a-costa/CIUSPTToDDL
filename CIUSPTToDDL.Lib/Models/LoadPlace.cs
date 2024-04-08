using Newtonsoft.Json;

namespace CIUSPTToDDL.Lib.Models
{
    /// <summary>
    /// Represents a load place.
    /// </summary>
    public class LoadPlace
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
