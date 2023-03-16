using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class TrackerData
{
    [JsonProperty("questStatus")]
    public DungeonRewardData RewardData { get; set; }

    [JsonProperty("equipData")]
    public EquipData EquipData { get; set; }

    [JsonProperty("upgradeData")]
    public UpgradeData UpgradeData { get; set; }

    [JsonProperty("acquiredItems")]
    public List<string> AcquiredItems { get; set; }
}

