using System;
using System.IO;
using System.Text;
using EnKdevsOcarinaOfTimeTracker.Internal;
using EnKdevsOcarinaOfTimeTracker.Models;
using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Data;

public static class DataWriter
{
    // TrackerData has been assembled in MainWindowViewModel
    public static void WriteData(TrackerData data)
    {
        using (var file = File.Create($"./trackerState")) {}
        var fileText = JsonConvert.SerializeObject(data, Formatting.Indented);
        var encryptedData = PrivateCryptoKey.EncryptData(fileText);
        File.WriteAllBytes($"./trackerState", encryptedData);
    }
}