using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class DungeonRewardData
{
    [JsonProperty("emeraldState")]
    public bool GotEmerald { get; set; }

    [JsonProperty("rubyState")]
    public bool GotRuby { get; set; }

    [JsonProperty("sapphireState")]
    public bool GotSapphire { get; set; }

    [JsonProperty("lightMedallionState")]
    public bool GotLightMedallion { get; set; }

    [JsonProperty("forestMedallionState")]
    public bool GotForestMedallion { get; set; }

    [JsonProperty("fireMedallionState")]
    public bool GotFireMedallion { get; set; }

    [JsonProperty("waterMedallionState")]
    public bool GotWaterMedallion { get; set; }

    [JsonProperty("shadowMedallionState")]
    public bool GotShadowMedallion { get; set; }

    [JsonProperty("spiritMedallionState")]
    public bool GotSpiritMedallion { get; set; }
}