using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class AdultTradeData
{
	[JsonProperty("pocketEgg")]
	public string PocketEggString { get; set; }

	[JsonProperty("pocketCucco")]
	public string PocketCuccoString { get; set; }

	[JsonProperty("cojiro")]
	public string CojiroString { get; set; }

	[JsonProperty("oddMushroom")]
	public string OddMushroomString { get; set; }

	[JsonProperty("oddPoultice")]
	public string OddPoulticeString { get; set; }

	[JsonProperty("poachersSaw")]
	public string PoachersSawString { get; set; }

	[JsonProperty("giantsKnife")]
	public string GiantsKnifeString { get; set; }

	[JsonProperty("brokenGoronSword")]
	public string BrokenGoronsSwordString { get; set; }

	[JsonProperty("prescription")]
	public string PrescriptionString { get; set; }

	[JsonProperty("eyeballFrog")]
	public string EyeballFrogString { get; set; }

	[JsonProperty("eyeDrops")]
	public string EyeDropsString { get; set; }

	[JsonProperty("claimCheck")]
	public string ClaimCheckString { get; set; }
}