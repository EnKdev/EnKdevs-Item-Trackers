using Newtonsoft.Json;
using RandomTrackers.Core.Internal;
using RandomTrackers.Core.Logging;

namespace RandomTrackers.Core.Data;

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
    /// <param name="fileName">The name of the file to write.</param>
    public static void WriteState<T>(T obj, string fileName)
    {
        try
        {
            using (var file = File.Create($"./Saves/{fileName}"))
            {
            }
            
            var fileText = JsonConvert.SerializeObject(obj);
            var encryptedData = CryptoHelper.EncryptAndEncode(fileText);
            File.WriteAllText($"./Saves/{fileName}", encryptedData);
        }
        catch (Exception e)
        {
            Logger.LogException(e);
        }
    }
}