using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class BootsData
{
    [JsonProperty("ironBoots")]
    public bool GotIronBoots { get; set; }

    [JsonProperty("hoverBoots")]
    public bool GotHoverBoots { get; set; }
}