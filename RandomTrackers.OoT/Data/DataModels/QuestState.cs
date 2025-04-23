using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data.DataModels;

public class QuestState
{
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("spritePath")]
    public string? SpritePath { get; set; }
    
    [JsonProperty("locationIndex")]
    public int LocationIndex { get; set; }
    
    [JsonProperty("locationName")]
    public string? Location { get; set; }
}