using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;

namespace EnKdev.ItemTrackers.OoT.Data;

public static class Logger
{
    private static ILog _logger;

    public static void SetupLogger()
    {
        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        _logger = LogManager.GetLogger(typeof(LoggerManager));
    }
    
    public static void LogInteraction(string interaction)
    {
        _logger.Info($"User made an interaction: {interaction}");
    }

    public static void LogCommand(string command)
    {
        _logger.Info($"User triggered the following command: {command}");
    }

    public static void LogException(Exception ex)
    {
        var exceptionText = $"""
                            An exception occured!!!
                            ------------------------
                            Message: {ex.Message}
                            StackTrace:
                            {ex.StackTrace}
                            """;
        
        _logger.Fatal(exceptionText);
    }
}