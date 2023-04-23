using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class LocationData
{
    [JsonProperty("location1")]
    public int Location1 { get; set; }
    
    [JsonProperty("location2")]
    public int Location2 { get; set; }
    
    [JsonProperty("location3")]
    public int Location3 { get; set; }
    
    [JsonProperty("location4")]
    public int Location4 { get; set; }
    
    [JsonProperty("location5")]
    public int Location5 { get; set; }
    
    [JsonProperty("location6")]
    public int Location6 { get; set; }
    
    [JsonProperty("location7")]
    public int Location7 { get; set; }
    
    [JsonProperty("location8")]
    public int Location8 { get; set; }
    
    [JsonProperty("location9")]
    public int Location9 { get; set; }
}