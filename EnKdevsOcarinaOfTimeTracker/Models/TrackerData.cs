using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class TrackerData
{
    [JsonProperty("songs")]
    public SongData SongData { get; set; }

    [JsonProperty("questStatus")]
    public DungeonRewardData RewardData { get; set; }

    [JsonProperty("equipData")]
    public EquipData EquipData { get; set; }
    
    [JsonProperty("tradeData")]
    public TradeData TradeData { get; set; }

    [JsonProperty("upgradeData")]
    public UpgradeData UpgradeData { get; set; }

    [JsonProperty("acquiredItems")]
    public List<string> AcquiredItems { get; set; }
}

