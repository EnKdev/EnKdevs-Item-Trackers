using System.Collections.Generic;
using System.Windows.Documents;
using Semver;

namespace EnKdevsOcarinaOfTimeTracker;

public static class Constants
{
    public static string AppTitle = $"EnKdevs Ocarina of Time Item Tracker V{SemVersion.ParsedFrom(1, 0, 2, "dev")}";

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

    public const string KokiriTunicSprite = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Tunic_Icon.png";
    public const string KokiriBootsSprite = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Boots_Icon.png";

    public static List<string> DisabledEquip = new()
    {
        "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon_Disabled.png"
    };

    public static List<string> EnabledEquip = new()
    {
        "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon.png"
    };

    public static List<string> DisabledUpgrade = new()
    {
        "pack://application:,,,/Icons/Upgrade/OoT3D_Adult's_Wallet_Icon_Disabled.png",
        // Todo: Add rest of disabled upgrade icons.
    }
}