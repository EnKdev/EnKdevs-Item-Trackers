using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class EquipData
{
    [JsonProperty("tunics")]
    public TunicData Tunics { get; set; }

    [JsonProperty("swords")]
    public SwordData Swords { get; set; }

    [JsonProperty("boots")]
    public BootsData Boots { get; set; }

    [JsonProperty("shields")]
    public ShieldData Shields { get; set; }
}