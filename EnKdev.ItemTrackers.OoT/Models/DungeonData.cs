using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class DungeonData
{
	[JsonProperty("dekuCompass")]
	public string DekuCompassString { get; set; }

	[JsonProperty("dekuMap")]
	public string DekuMapString { get; set; }
	
	[JsonProperty("isDekuMq")]
	public bool IsDekuMq { get; set; }

	[JsonProperty("dcMap")]
	public string DcMapString { get; set; }

	[JsonProperty("dcCompass")]
	public string DcCompassString { get; set; }
	
	[JsonProperty("isDcMq")]
	public bool IsDcMq { get; set; }

	[JsonProperty("jabuCompass")]
	public string JabuCompassString { get; set; }

	[JsonProperty("jabuMap")]
	public string JabuMapString { get; set; }
	
	[JsonProperty("isJabuMq")]
	public bool IsJabuMq { get; set; }

	[JsonProperty("forestCompass")]
	public string ForestCompassString { get; set; }

	[JsonProperty("forestMap")]
	public string ForestMapString { get; set; }
	
	[JsonProperty("forestKey")]
	public string ForestKeyString { get; set; }

	[JsonProperty("forestKeyCount")]
	public int ForestKeyCount { get; set; }

	[JsonProperty("forestBk")]
	public string ForestBkString { get; set; }
	
	[JsonProperty("isForestMq")]
	public bool IsForestMq { get; set; }

	[JsonProperty("fireCompass")]
	public string FireCompassString { get; set; }

	[JsonProperty("fireMap")]
	public string FireMapString { get; set; }
	
	[JsonProperty("fireKey")]
	public string FireKeyString { get; set; }

	[JsonProperty("fireKeyCount")]
	public int FireKeyCount { get; set; }

	[JsonProperty("fireBk")]
	public string FireBkString { get; set; }
	
	[JsonProperty("isFireMq")]
	public bool IsFireMq { get; set; }

	[JsonProperty("waterCompass")]
	public string WaterCompassString { get; set; }

	[JsonProperty("waterMap")]
	public string WaterMapString { get; set;}
	
	[JsonProperty("waterKey")]
	public string WaterKeyString { get; set; }

	[JsonProperty("waterKeyCount")]
	public int WaterKeyCount { get; set; }

	[JsonProperty("waterBk")]
	public string WaterBkString { get; set; }
	
	[JsonProperty("isWaterMq")]
	public bool IsWaterMq { get; set; }

	[JsonProperty("spiritCompass")]
	public string SpiritCompassString { get; set; }

	[JsonProperty("spiritMap")]
	public string SpiritMapString { get; set; }
	
	[JsonProperty("spiritKey")]
	public string SpiritKeyString { get; set; }

	[JsonProperty("spiritKeyCount")]
	public int SpiritKeyCount { get; set; }

	[JsonProperty("spiritBk")]
	public string SpiritBkString { get; set; }
	
	[JsonProperty("isSpiritMq")]
	public bool IsSpiritMq { get; set; }

	[JsonProperty("shadowCompass")]
	public string ShadowCompassString { get; set; }

	[JsonProperty("shadowMap")]
	public string ShadowMapString { get; set; }
	
	[JsonProperty("shadowKey")]
	public string ShadowKeyString { get; set; }

	[JsonProperty("shadowKeyCount")]
	public int ShadowKeyCount { get; set; }

	[JsonProperty("shadowBk")]
	public string ShadowBkString { get; set; }
	
	[JsonProperty("isShadowMq")]
	public bool IsShadowMq { get; set; }

	[JsonProperty("bottomCompass")]
	public string BottomCompassString { get; set; }

	[JsonProperty("bottomMap")]
	public string BottomMapString { get; set; }
	
	[JsonProperty("bottomKey")]
	public string BottomKeyString { get; set; }

	[JsonProperty("bottomKeyCount")]
	public int BottomKeyCount { get; set; }
	
	[JsonProperty("isBottomMq")]
	public bool IsBottomMq { get; set; }

	[JsonProperty("cavernCompass")]
	public string CavernCompassString { get; set; }

	[JsonProperty("cavernMap")]
	public string CavernMapString { get; set; }
	
	[JsonProperty("isCavernMq")]
	public bool IsCavernMq { get; set; }
	
	[JsonProperty("ganonKey")]
	public string GanonKeyString { get; set; }

	[JsonProperty("ganonKeyCount")]
	public int GanonKeyCount { get; set; }

	[JsonProperty("ganonBk")]
	public string GanonBkString { get; set; }
	
	[JsonProperty("isGanonMq")]
	public bool IsGanonMq { get; set; }
	
	[JsonProperty("gtgKey")]
	public string GtgKeyString { get; set; }

	[JsonProperty("gtgKeyCount")]
	public int GtgKeyCount { get; set; }
	
	[JsonProperty("isGtgMq")]
	public bool IsGtgMq { get; set; }
}