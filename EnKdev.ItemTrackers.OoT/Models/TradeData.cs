using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class TradeData
{
    [JsonProperty("childTradeData")]
    public ChildTradeData ChildTradeData { get; set; }

    [JsonProperty("adultTradeData")]
    public AdultTradeData AdultTradeData { get; set; }
}