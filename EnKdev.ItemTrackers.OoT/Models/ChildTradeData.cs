using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class ChildTradeData
{
	[JsonProperty("wierdEgg")]
	public string WeirdEggString { get; set; }

	[JsonProperty("cucco")]
	public string CuccoString { get; set; }

	[JsonProperty("letter")]
	public string LetterString { get; set; }

	[JsonProperty("skullMask")]
	public string SkullMaskString { get; set; }

	[JsonProperty("maskOfTruth")]
	public string MaskOfTruthString { get; set; }
}