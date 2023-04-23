using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class TradeData
{
    [JsonProperty("childTradeStage")]
    public int TradeStageChild { get; set; }
    
    [JsonProperty("adultTradeStage")]
    public int TradeStageAdult { get; set; }
}