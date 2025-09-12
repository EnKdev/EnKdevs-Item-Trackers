using System.Windows;
using RandomTrackers.Core.Data;
using RandomTrackers.Core.Internal.Json;
using RandomTrackers.Core.Logging;
using RandomTrackers.OoT.Internal;

namespace RandomTrackers.OoT;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        Logger.SetupLogger();
        Logger.LogInformation("[Startup] App started. Reading data file.");
        Globals.InstanceData = JsonReader.ReadDataFile<OoTData>();
        Logger.LogInformation("[Startup] Data file read.");
        Logger.LogInformation("[Startup] Instantiating main window.");
    }
}