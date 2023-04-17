using System.IO;
using System.Windows;
using EnKdevsOcarinaOfTimeTracker.Internal;
using EnKdevsOcarinaOfTimeTracker.Models;
using Newtonsoft.Json;

namespace EnKdevsOcarinaOfTimeTracker.Data;

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