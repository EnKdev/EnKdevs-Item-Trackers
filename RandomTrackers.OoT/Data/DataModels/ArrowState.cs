using Newtonsoft.Json;

namespace RandomTrackers.OoT.Data.DataModels;

public class ArrowState
{
    /// <summary>
    /// Gets or sets the unique identifier for the arrow state.
    /// This property represents the identification value as a string,
    /// allowing differentiation between various arrow states within the application.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the path to the sprite associated with the arrow state.
    /// This property stores the file path as a string, enabling the application
    /// to locate and use the corresponding image for visual representation.
    /// </summary>
    [JsonProperty("spritePath")]
    public string? SpritePath { get; set; }
}