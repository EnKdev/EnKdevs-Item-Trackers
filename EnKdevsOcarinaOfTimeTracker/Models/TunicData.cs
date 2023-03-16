using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Models;

public class TunicData
{
    [JsonProperty("goronTunic")]
    public bool GotGoronTunic { get; set; }

    [JsonProperty("zoraTunic")]
    public bool GotZoraTunic { get; set; }
}