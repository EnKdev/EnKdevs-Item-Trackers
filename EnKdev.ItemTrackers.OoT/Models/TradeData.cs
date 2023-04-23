using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class TradeData
{
    [JsonProperty("childTradeStage")]
    public int TradeStageChild { get; set; }
    
    [JsonProperty("adultTradeStage")]
    public int TradeStageAdult { get; set; }
}