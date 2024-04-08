using Newtonsoft.Json;

namespace CIUSPTToDDL.Models
{
    public class FishDetails
    {
        [JsonProperty("ScientificName")]
        public object ScientificName;

        [JsonProperty("ProductionMethodID")]
        public int? ProductionMethodID;

        [JsonProperty("ProductionMethodName")]
        public object ProductionMethodName;

        [JsonProperty("CaptureAreaID")]
        public int? CaptureAreaID;

        [JsonProperty("CaptureAreaDescription")]
        public object CaptureAreaDescription;

        [JsonProperty("CaptureCountryID")]
        public object CaptureCountryID;

        [JsonProperty("CaptureCountryName")]
        public object CaptureCountryName;

        [JsonProperty("NetDrainedWeight")]
        public int? NetDrainedWeight;

        [JsonProperty("NetDrainedUnitOfMeasure")]
        public object NetDrainedUnitOfMeasure;

        [JsonProperty("SubCaptureAreaID")]
        public int? SubCaptureAreaID;

        [JsonProperty("SubCaptureAreaDescription")]
        public object SubCaptureAreaDescription;

        [JsonProperty("FishingGearID")]
        public object FishingGearID;

        [JsonProperty("FishingGearDescription")]
        public object FishingGearDescription;

        [JsonProperty("FishingGearCategory")]
        public object FishingGearCategory;

        [JsonProperty("ConservationMethod")]
        public int? ConservationMethod;
    }


}
