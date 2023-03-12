using System.Collections.Generic;
using System.Windows.Documents;
using Semver;

namespace EnKdevsOcarinaOfTimeTracker;

public static class Constants
{
    public static string AppTitle = $"EnKdevs Ocarina of Time Item Tracker V{SemVersion.ParsedFrom(1, 0, 1, "dev")}";

    public const string ItemSongBg = "pack://application:,,,/Images/OoTTrackerItems+Songs.png";
    public const string GearBg = "pack://application:,,,/Images/OoTTrackerGear.png";

    public static List<string> DisabledStones = new()
    {
        "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon_Disabled.png"
    };

    public static List<string> EnabledStones = new()
    {
        "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon.png"
    };

    public static List<string> DisabledMeds = new()
    {
        "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon_Disabled.png"
    };

    public static List<string> EnabledMeds = new()
    {
        "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon.png"
    };
}