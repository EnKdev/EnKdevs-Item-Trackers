using System;
using System.IO;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data;

public static class DataWriter
{
    // TrackerData has been assembled in MainWindowViewModel
    public static void WriteData(TrackerData? data)
    {
        try
        {
            using (var file = File.Create($"./trackerState"))
            {
            }

            var fileText = JsonConvert.SerializeObject(data, Formatting.Indented);
            var encryptedData = CryptoHelper.EncryptAndEncode(fileText);
            File.WriteAllText($"./trackerState", encryptedData);
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }
    }
}