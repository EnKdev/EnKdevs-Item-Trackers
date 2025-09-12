using System.Collections.Generic;
using Newtonsoft.Json;

namespace RandomTrackers.OoT.Data.DataModels;

public class ItemState
{
    /// <summary>
    /// Represents the collection of bottle states within the item state.
    /// Each bottle state describes information about an individual bottle's
    /// attributes such as its ID and associated sprite path.
    /// </summary>
    [JsonProperty("bottleStates")]
    public List<BottleState?> Bottles { get; set; }


    /// <summary>
    /// Represents the collection of item states within the item state.
    /// Each item state contains details such as the item's ID and its associated sprite path.
    /// </summary>
    [JsonProperty("itemStates")]
    public List<ItemStateInternal?> Items { get; set; }


    /// <summary>
    /// Represents the file path associated with the child trade item in the current item state.
    /// This property typically defines the location of resources or data linked to the child
    /// trade progression within the system.
    /// </summary>
    [JsonProperty("childTradePath")]
    public string? ChildTradePath { get; set; }

    /// <summary>
    /// Represents the index of the currently tracked child trade progression item.
    /// This property is used to determine the position or state within the child trade sequence.
    /// </summary>
    [JsonProperty("childTradeIndex")]
    public int ChildTradeIndex { get; set; }

    /// <summary>
    /// Represents the string path associated with the adult trade sequence.
    /// This path identifies the series of items or progression in the adult trade process
    /// and is likely used to track or reference the current state in the sequence.
    /// </summary>
    [JsonProperty("adultTradePath")]
    public string? AdultTradePath { get; set; }

    /// <summary>
    /// Indicates the current progress index in the adult trade sequence.
    /// This value corresponds to the step the player has reached in the trade quest,
    /// providing a way to track advancement within the adult trade path.
    /// </summary>
    [JsonProperty("adultTradeIndex")]
    public int AdultTradeIndex { get; set; }
}