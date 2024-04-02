using EnKdev.ItemTrackers.Core.Internal;
using EnKdev.ItemTrackers.Core.Logging;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Data;

/// <summary>
/// Provides methods to write the state of an item tracker.
/// </summary>
public static class StateWriter
{
    /// <summary>
    /// Writes the state of an item tracker.
    /// </summary>
    /// <typeparam name="T">The type of the object.</typeparam>
    /// <param name="obj">The object whose state will be written.</param>
    public static void WriteState<T>(T obj)
    {
        try
        {
            using (var file = File.Create("./trackerState"))
            {
            }
            
            var fileText = JsonConvert.SerializeObject(obj);
            var encryptedData = CryptoHelper.EncryptAndEncode(fileText);
            File.WriteAllText("./trackerState", encryptedData);
        }
        catch (Exception e)
        {
            Logger.LogException(e);
        }
    }
}