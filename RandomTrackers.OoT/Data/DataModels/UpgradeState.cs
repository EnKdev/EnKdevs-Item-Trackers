using Newtonsoft.Json;

namespace RandomTrackers.OoT.Data.DataModels;

public class UpgradeState
{
    /// <summary>
    /// Gets or sets the unique identifier for the upgrade state.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the current state of the upgrade.
    /// </summary>
    [JsonProperty("state")]
    public int State { get; set; }

    /// <summary>
    /// Gets or sets the file path to the sprite image associated with the upgrade state.
    /// </summary>
    [JsonProperty("spritePath")]
    public string? SpritePath { get; set; }
}