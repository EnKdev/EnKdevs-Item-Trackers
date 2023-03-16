using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class SwordData
{
    [JsonProperty("kokiriSword")]
    public bool GotKokiriSword { get; set; }

    [JsonProperty("masterSword")]
    public bool GotMasterSword { get; set; }

    [JsonProperty("biggoronSword")]
    public bool GotBiggoronSword { get; set; }
}