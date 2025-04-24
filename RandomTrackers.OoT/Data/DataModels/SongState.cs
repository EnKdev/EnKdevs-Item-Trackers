using Newtonsoft.Json;

namespace RandomTrackers.OoT.Data.DataModels;

public class SongState
{
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("spritePath")]
    public string? SpritePath { get; set; }
}