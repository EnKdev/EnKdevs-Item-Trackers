using Newtonsoft.Json;

namespace RandomTrackers.OoT.Data.DataModels;

public class DungeonState
{
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("name")]
    public string? Name { get; set; }
    
    [JsonProperty("mapSprite")]
    public string? MapSprite { get; set; }
    
    [JsonProperty("compassSprite")]
    public string? CompassSprite { get; set; }
    
    [JsonProperty("keySprite")]
    public string? KeySprite { get; set; }
    
    [JsonProperty("bossKeySprite")]
    public string? BossKeySprite { get; set; }
    
    [JsonProperty("isMasterQuest")]
    public bool IsMasterQuest { get; set; }

    [JsonProperty("collectedKeys")]
    public int CollectedKeys { get; set; }
    
    [JsonProperty("countColor")]
    public string? CountColor { get; set; }
    
    [JsonProperty("dungeonIndex")]
    public int DungeonIndex { get; set; }
    
    [JsonProperty("dungeonType")]
    public string? DungeonType { get; set; }
}