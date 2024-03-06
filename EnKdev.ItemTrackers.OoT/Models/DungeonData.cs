using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class DungeonData
{
	[JsonProperty("dekuCompass")]
	public bool HasDekuCompass { get; set; }

	[JsonProperty("dekuMap")]
	public bool HasDekuMap { get; set; }

	[JsonProperty("dcCompass")]
	public bool HasDcCompass { get; set; }

	[JsonProperty("dcMap")]
	public bool HasDcMap { get; set; }

	[JsonProperty("jabuCompass")]
	public bool HasJabuCompass { get; set; }

	[JsonProperty("jabuMap")]
	public bool HasJabuMap { get; set; }

	[JsonProperty("forestCompass")]
	public bool HasForestCompass { get; set; }

	[JsonProperty("hasForestMap")]
	public bool HasForestMap { get; set; }

	[JsonProperty("forestKeyCount")]
	public int ForestKeyCount { get; set; }

	[JsonProperty("hasForestBK")]
	public bool HasForestBossKey { get; set; }

	[JsonProperty("hasFireCompass")]
	public bool HasFireCompass { get; set; }

	[JsonProperty("hasFireMap")]
	public bool HasFireMap { get; set; }

	[JsonProperty("fireKeyCount")]
	public int FireKeyCount { get; set; }

	[JsonProperty("hasFireBK")]
	public bool HasFireBossKey { get; set; }

	[JsonProperty("hasWaterCompass")]
	public bool HasWaterCompass { get; set; }

	[JsonProperty("hasWaterMap")]
	public bool HasWaterMap { get; set;}

	[JsonProperty("waterKeyCount")]
	public int WaterKeyCount { get; set; }

	[JsonProperty("hasWaterBK")]
	public bool HasWaterBossKey { get; set; }

	[JsonProperty("hasSpiritCompass")]
	public bool HasSpiritCompass { get; set; }

	[JsonProperty("hasSpiritMap")]
	public bool HasSpiritMap { get; set; }

	[JsonProperty("spiritKeyCount")]
	public int SpiritKeyCount { get; set; }

	[JsonProperty("hasSpiritBK")]
	public bool HasSpiritBossKey { get; set; }

	[JsonProperty("hasShadowCompass")]
	public bool HasShadowCompass { get; set; }

	[JsonProperty("hasShadowMap")]
	public bool HasShadowMap { get; set; }

	[JsonProperty("shadowKeyCount")]
	public int ShadowKeyCount { get; set; }

	[JsonProperty("hasShadowBK")]
	public bool HasShadowBossKey { get; set; }

	[JsonProperty("hasBottomCompass")]
	public bool HasBottomCompass { get; set; }

	[JsonProperty("hasBottomMap")]
	public bool HasBottomMap { get; set; }

	[JsonProperty("bottomKeyCount")]
	public int BottomKeyCount { get; set; }

	[JsonProperty("hasCavernCompass")]
	public bool HasCavernCompass { get; set; }

	[JsonProperty("hasCavernMap")]
	public bool HasCavernMap { get; set; }

	[JsonProperty("ganonKeyCount")]
	public int GanonKeyCount { get; set; }

	[JsonProperty("hasGanonBK")]
	public bool HasGanonBossKey { get; set; }

	[JsonProperty("gtgKeyCount")]
	public int GtgKeyCount { get; set; }
}