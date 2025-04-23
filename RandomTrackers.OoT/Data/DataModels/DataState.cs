using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data.DataModels;

public class DataState
{
    [JsonProperty("heartPieces")]
    public int HeartPieces { get; set; }
    
    [JsonProperty("heartContainers")]
    public int HeartContainers { get; set; }
    
    [JsonProperty("gsTokens")]
    public int GsTokens { get; set; }
    
    [JsonProperty("hpImage")]
    public string? HpImage { get; set; }
}