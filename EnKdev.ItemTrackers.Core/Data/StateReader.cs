using EnKdev.ItemTrackers.Core.Internal;
using EnKdev.ItemTrackers.Core.Logging;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Data;

/// <summary>
/// Provides methods to read the state of an item tracker.
/// </summary>
public static class StateReader
{
    /// <summary>
    /// Reads the state of an item tracker.
    /// </summary>
    /// <typeparam name="T">The type of the state to be read.</typeparam>
    /// <returns>The parsed state object of type T.</returns>
    /// <exception cref="Exception">Thrown if something goes wrong with reading the tracker state.</exception>
    public static T? ReadState<T>() where T : new()
    {
        T? parsedData = new();

        try
        {
            var contents = File.ReadAllText("./trackerState");
            var data = CryptoHelper.DecodeAndDecrypt(contents);
            parsedData = JsonConvert.DeserializeObject<T>(data);

            if (parsedData == null)
            {
                throw new Exception("Something went wrong with reading the tracker state!");
            }
        }
        catch (Exception e)
        {
            Logger.LogException(e);
        }

        return parsedData;
    }
}