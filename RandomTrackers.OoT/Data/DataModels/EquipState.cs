using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data.DataModels;

public class EquipState
{
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("spritePath")]
    public string? SpritePath { get; set; }
}