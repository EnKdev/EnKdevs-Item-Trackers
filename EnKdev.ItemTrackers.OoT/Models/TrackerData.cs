using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class TrackerData
{
    [JsonProperty("dungeonData")]
    public DungeonData DungeonData { get; set; }

    [JsonProperty("dungeonTypeData")]
    public DungeonTypeData DungeonTypeData { get; set; }

    [JsonProperty("tradeData")]
    public TradeData TradeData { get; set; }

    [JsonProperty("upgradeData")]
    public UpgradeData UpgradeData { get; set; }
    
    [JsonProperty("locationData")]
    public LocationData LocationData { get; set; }
    
    [JsonProperty("uiData")]
    public UiRelevantData UiData { get; set; }
}

