using Newtonsoft.Json;
using RandomTrackers.Core.Internal;
using RandomTrackers.Core.Logging;

namespace RandomTrackers.Core.Data;

/// <summary>
/// Provides methods to read the state of an item tracker.
/// </summary>
public static class StateReader
{
    /// <summary>
    /// Reads the state of an item tracker.
    /// </summary>
    /// <typeparam name="T">The type of the state to be read.</typeparam>
    /// <param name="fileName">The file name of the state to read.</param>
    /// <returns>The parsed state object of type T.</returns>
    /// <exception cref="Exception">Thrown if something goes wrong with reading the tracker state.</exception>
    public static T? ReadState<T>(string fileName) where T : new()
    {
        T? parsedData = new();

        try
        {
            var contents = File.ReadAllText($"./Saves/{fileName}");
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