using System.IO;
using System.Windows;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data;

public static class DataReader
{
    public static TrackerData ReadData()
    {
        var contents = File.ReadAllBytes($"./trackerState");
        var data = PrivateCryptoKey.DecryptData(contents);
        var parsedData = JsonConvert.DeserializeObject<TrackerData>(data);

        if (parsedData == null)
        {
            MessageBox.Show("Something went wrong with reading the saved data!");
            return null!;
        }
        
        return parsedData;
    }
}