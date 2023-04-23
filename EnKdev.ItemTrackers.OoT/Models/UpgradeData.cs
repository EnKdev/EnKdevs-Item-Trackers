using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class UpgradeData
{
    [JsonProperty("ocarinaState")]
    public int OcarinaState { get; set; }

    [JsonProperty("bombState")]
    public int BombState { get; set; }

    [JsonProperty("bulletState")]
    public int BulletState { get; set; }

    [JsonProperty("strengthState")]
    public int StrengthState { get; set; }

    [JsonProperty("quiverState")]
    public int QuiverState { get; set; }

    [JsonProperty("scaleState")]
    public int ScaleState { get; set; }

    [JsonProperty("hookState")]
    public int HookState { get; set; }
}