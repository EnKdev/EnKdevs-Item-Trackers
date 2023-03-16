using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class ShieldData
{
    [JsonProperty("dekuShield")]
    public bool GotDekuShield { get; set; }

    [JsonProperty("hylianShield")]
    public bool GotHylianShield { get; set; }

    [JsonProperty("mirrorShield")]
    public bool GotMirrorShield { get; set; }
}