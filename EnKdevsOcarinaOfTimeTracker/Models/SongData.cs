using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class SongData
{
    [JsonProperty("lullaby")]
    public bool SongLullaby { get; set; }

    [JsonProperty("epona")]
    public bool SongEpona { get; set; }

    [JsonProperty("saria")]
    public bool SongSaria { get; set; }

    [JsonProperty("storms")]
    public bool SongStorms { get; set; }

    [JsonProperty("suns")]
    public bool SongSuns { get; set; }

    [JsonProperty("time")]
    public bool SongTime { get; set; }

    [JsonProperty("minuet")]
    public bool SongMinuet { get; set; }

    [JsonProperty("bolero")]
    public bool SongBolero { get; set; }

    [JsonProperty("serenade")]
    public bool SongSerenade { get; set; }

    [JsonProperty("requiem")]
    public bool SongRequiem { get; set; }

    [JsonProperty("nocturne")]
    public bool SongNocturne { get; set; }

    [JsonProperty("prelude")]
    public bool SongPrelude { get; set; }
}