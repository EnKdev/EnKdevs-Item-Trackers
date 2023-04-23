using System.Collections.Generic;
using Semver;

namespace EnKdev.ItemTrackers.OoT;

public static class Constants
{
    public static string AppTitle = $"EnKdevs Ocarina of Time Item Tracker V{SemVersion.ParsedFrom(1, 0, 0, "beta.3", "ocarina")}";

    public const string ItemSongBg = "pack://application:,,,/Images/OoTTrackerItems+Songs.png";
    public const string GearBg = "pack://application:,,,/Images/OoTTrackerGear.png";

    public static List<string> DungeonLocations = new()
    {
        "???",
        "FREE",
        "DEKU",
        "DC",
        "JABU",
        "FRST",
        "FIRE",
        "WTR",
        "SHDW",
        "SPRT"
    };

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
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bomb_Bag_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_30_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Fairy_Ocarina_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Goron_Bracelet_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Quiver_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Silver_Scale_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon_Disabled.png"
    };

    public static List<string> EnabledUpgrade = new()
    {
        "pack://application:,,,/Icons/Upgrade/OoT3D_Adult's_Wallet_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Giant's_Wallet_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bomb_Bag_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Big_Bomb_Bag_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Biggest_Bomb_Bag_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_30_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_40_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_50_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Fairy_Ocarina_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Ocarina_of_Time_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Goron_Bracelet_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Silver_Gauntlets_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Golden_Gauntlets_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Quiver_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Big_Quiver_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Biggest_Quiver_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Silver_Scale_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Golden_Scale_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Longshot_Icon.png"
    };

    public static string GsIcon = "pack://application:,,,/Icons/Other/OoT3D_Token_Icon.png";

    public static List<string> DisabledOther = new()
    {
        "pack://application:,,,/Icons/Other/OoT3D_Gerudo_Token_Icon_Disabled.png",
        "pack://application:,,,/Icons/Other/OoT3D_Shard_of_Agony_Icon_Disabled.png"
    };

    public static List<string> EnabledOther = new()
    {
        "pack://application:,,,/Icons/Other/OoT3D_Gerudo_Token_Icon.png",
        "pack://application:,,,/Icons/Other/OoT3D_Shard_of_Agony_Icon.png"
    };

    public static List<string> DisabledSongs = new()
    {
        "pack://application:,,,/Icons/Songs/OoT3D_Zelda's_Lullaby_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Epona's_Song_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Saria's_Song_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Storms_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Sun's_Song_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Time_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Minuet_of_Forest_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Bolero_of_Fire_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Serenade_of_Water_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Requiem_of_Spirit_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Nocturne_of_Shadow_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Prelude_of_Light_Icon_Disabled.png"
    };

    public static List<string> EnabledSongs = new()
    {
        "pack://application:,,,/Icons/Songs/OoT3D_Zelda's_Lullaby_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Epona's_Song_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Saria's_Song_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Storms_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Sun's_Song_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Time_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Minuet_of_Forest_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Bolero_of_Fire_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Serenade_of_Water_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Requiem_of_Spirit_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Nocturne_of_Shadow_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Prelude_of_Light_Icon.png"
    };

    public static List<string> DisabledItems = new()
    {
       /* 0 */ "pack://application:,,,/Icons/Item/OoT3D_Bomb_Icon_Disabled.png",
       /* 1 */ "pack://application:,,,/Icons/Item/OoT3D_Bombchu_Icon_Disabled.png",
       /* 2 */ "pack://application:,,,/Icons/Item/OoT3D_Boomerang_Icon_Disabled.png",
       /* 3 */ "pack://application:,,,/Icons/Item/OoT3D_Bottle_Icon_Disabled.png",
       /* 4 */ "pack://application:,,,/Icons/Item/OoT3D_Deku_Nut_Icon_Disabled.png",
       /* 5 */ "pack://application:,,,/Icons/Item/OoT3D_Deku_Stick_Icon_Disabled.png",
       /* 6 */ "pack://application:,,,/Icons/Item/OoT3D_Din's_Fire_Icon_Disabled.png",
       /* 7 */ "pack://application:,,,/Icons/Item/OoT3D_Fairy_Bow_Icon_Disabled.png",
       /* 8 */ "pack://application:,,,/Icons/Item/OoT3D_Fairy_Slingshot_Icon_Disabled.png",
       /* 9 */ "pack://application:,,,/Icons/Item/OoT3D_Farore's_Wind_Icon_Disabled.png",
       /* 10 */ "pack://application:,,,/Icons/Item/OoT3D_Fire_Arrow_Icon_Disabled.png",
       /* 11 */ "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon_Disabled.png",
       /* 12 */ "pack://application:,,,/Icons/Item/OoT3D_Ice_Arrow_Icon_Disabled.png",
       /* 13 */ "pack://application:,,,/Icons/Item/OoT3D_Lens_of_Truth_Icon_Disabled.png",
       /* 14 */ "pack://application:,,,/Icons/Item/OoT3D_Light_Arrow_Icon_Disabled.png",
       /* 15 */ "pack://application:,,,/Icons/Item/OoT3D_Megaton_Hammer_Icon_Disabled.png",
       /* 16 */ "pack://application:,,,/Icons/Item/OoT3D_Nayru's_Love_Icon_Disabled.png",
       /* 17 */ "pack://application:,,,/Icons/Item/OoT3D_Magic_Bean_Icon_Disabled.png"
    };

    public static List<string> EnabledItems = new()
    {
        /* 0 */ "pack://application:,,,/Icons/Item/OoT3D_Bomb_Icon.png",
        /* 1 */ "pack://application:,,,/Icons/Item/OoT3D_Bombchu_Icon.png",
        /* 2 */ "pack://application:,,,/Icons/Item/OoT3D_Boomerang_Icon.png",
        /* 3 */ "pack://application:,,,/Icons/Item/OoT3D_Bottle_Icon.png",
        /* 4 */ "pack://application:,,,/Icons/Item/OoT3D_Deku_Nut_Icon.png",
        /* 5 */ "pack://application:,,,/Icons/Item/OoT3D_Deku_Stick_Icon.png",
        /* 6 */ "pack://application:,,,/Icons/Item/OoT3D_Din's_Fire_Icon.png",
        /* 7 */ "pack://application:,,,/Icons/Item/OoT3D_Fairy_Bow_Icon.png",
        /* 8 */ "pack://application:,,,/Icons/Item/OoT3D_Fairy_Slingshot_Icon.png",
        /* 9 */ "pack://application:,,,/Icons/Item/OoT3D_Farore's_Wind_Icon.png",
        /* 10 */ "pack://application:,,,/Icons/Item/OoT3D_Fire_Arrow_Icon.png",
        /* 11 */ "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon.png",
        /* 12 */ "pack://application:,,,/Icons/Item/OoT3D_Ice_Arrow_Icon.png",
        /* 13 */ "pack://application:,,,/Icons/Item/OoT3D_Lens_of_Truth_Icon.png",
        /* 14 */ "pack://application:,,,/Icons/Item/OoT3D_Longshot_Icon.png",
        /* 15 */ "pack://application:,,,/Icons/Item/OoT3D_Light_Arrow_Icon.png",
        /* 16 */ "pack://application:,,,/Icons/Item/OoT3D_Megaton_Hammer_Icon.png",
        /* 17 */ "pack://application:,,,/Icons/Item/OoT3D_Nayru's_Love_Icon.png",
        /* 18 */ "pack://application:,,,/Icons/Item/OoT3D_Magic_Bean_Icon.png"
    };

    public static List<string> ChildTradingSequence = new()
    {
        /* 0 */ "pack://application:,,,/Icons/ChildTrade/OoT3D_Weird_Egg_Icon_Disabled.png",
        /* 1 */ "pack://application:,,,/Icons/ChildTrade/OoT3D_Weird_Egg_Icon.png",
        /* 2 */ "pack://application:,,,/Icons/ChildTrade/OoT3D_Cucco_Icon.png",
        /* 3 */ "pack://application:,,,/Icons/ChildTrade/OoT3D_Zeldas_Letter_Icon.png",
        /* 4 */ "pack://application:,,,/Icons/ChildTrade/OoT3D_Skull_Mask_Icon.png",
        /* 5 */ "pack://application:,,,/Icons/ChildTrade/OoT3D_Mask_of_Truth_Icon.png"
    };

    public static List<string> AdultTradingSequence = new()
    {
        /* 0 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Egg_Icon_Disabled.png",
        /* 1 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Egg_Icon.png",
        /* 2 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Cucco_Icon.png",
        /* 3 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Cojiro_Icon.png",
        /* 4 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Odd_Mushroom_Icon.png",
        /* 5 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Odd_Poultice_Icon.png",
        /* 6 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Poachers_Saw_Icon.png",
        /* 7 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Giants_Knife_Icon.png",
        /* 8 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Broken_Gorons_Sword_Icon.png",
        /* 9 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Prescription_Icon.png",
        /* 10 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Eyeball_Frog_Icon.png",
        /* 11 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Eye_Drops_Icon.png",
        /* 12 */ "pack://application:,,,/Icons/AdultTrade/OoT3D_Claim_Check_Icon.png"
    };
}