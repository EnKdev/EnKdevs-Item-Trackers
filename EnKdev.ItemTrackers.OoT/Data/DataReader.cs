using System;
using System.IO;
using System.Windows;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;
using log4net;
using log4net.Config;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data;

public static class DataReader
{
    public static TrackerData? ReadData()
    {
        var parsedData = new TrackerData();

        try
        {
            var contents = File.ReadAllBytes($"./trackerState");
            var data = PrivateCryptoKey.DecryptData(contents);
            parsedData = JsonConvert.DeserializeObject<TrackerData>(data);

            if (parsedData == null)
            {
                MessageBox.Show("Something went wrong with reading the saved data!");
                parsedData = null;
            }

        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }

        return parsedData;
    }
}