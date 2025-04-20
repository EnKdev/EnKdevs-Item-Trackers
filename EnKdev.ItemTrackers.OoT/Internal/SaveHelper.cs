using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using EnKdev.ItemTrackers.Core.Data;
using EnKdev.ItemTrackers.OoT.Data.DataModels;

namespace EnKdev.ItemTrackers.OoT.Internal;

public static class SaveHelper
{
    public static void SaveArrowState(TrackerProperties properties)
    {
        PrepareDirectory();
        
        var arrowState = new List<ArrowState?>
        {
            new()
            {
                Id = "Arrow_Fire",
                SpritePath = properties.FireArrowImage
            },
            new()
            {
                Id = "Arrow_Ice",
                SpritePath = properties.IceArrowImage
            },
            new()
            {
                Id = "Arrow_Light",
                SpritePath = properties.LightArrowImage
            }
        };

        StateWriter.WriteState(arrowState, "OoT.TrackerState.Arrows.dat");
    }

    public static void SaveItemState(TrackerProperties properties)
    {
        PrepareDirectory();

        var itemState = new ItemState
        {
            AdultTradeIndex = properties.AdultTradeState,
            AdultTradePath = properties.AdultTradeItemImage,
            ChildTradeIndex = properties.ChildTradeState,
            ChildTradePath = properties.ChildTradeItemImage,
            Bottles =
            [
                new BottleState
                {
                    Id = "Bottle1",
                    SpritePath = properties.Bottle1Image
                },
                new BottleState
                {
                    Id = "Bottle2",
                    SpritePath = properties.Bottle2Image
                },
                new BottleState
                {
                    Id = "Bottle3",
                    SpritePath = properties.Bottle3Image
                },
                new BottleState
                {
                    Id = "Bottle4",
                    SpritePath = properties.Bottle4Image
                }
            ],
            Items =
            [
                new ItemStateInternal
                {
                    Id = "Item_DekuStick",
                    SpritePath = properties.StickImage
                },
                new ItemStateInternal
                {
                    Id = "Item_DekuNuts",
                    SpritePath = properties.NutImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Bomb",
                    SpritePath = properties.BombItemImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Bow",
                    SpritePath = properties.BowImage
                },
                new ItemStateInternal
                {
                    Id = "Item_DinsFire",
                    SpritePath = properties.DinsFireImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Slingshot",
                    SpritePath = properties.SlingshotImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Bombchu",
                    SpritePath = properties.BombchuImage
                },
                new ItemStateInternal
                {
                    Id = "Item_FaroresWind",
                    SpritePath = properties.FaroresWindImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Boomerang",
                    SpritePath = properties.BoomerangImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Lens",
                    SpritePath = properties.LensImage
                },
                new ItemStateInternal
                {
                    Id = "Item_MagicBeans",
                    SpritePath = properties.MagicBeansImage
                },
                new ItemStateInternal
                {
                    Id = "Item_Hammer",
                    SpritePath = properties.MegatonHammerImage
                },
                new ItemStateInternal
                {
                    Id = "Item_NayrusLove",
                    SpritePath = properties.NayrusLoveImage
                }
            ]
        };
        
        StateWriter.WriteState(itemState, "OoT.TrackerState.Items.dat");
    }

    public static void SaveUpgradeState(TrackerProperties properties)
    {
        var upgradeState = new List<UpgradeState?>
        {
            new()
            {
                Id = "Upgrade_BulletBag",
                State = properties.BulletState,
                SpritePath = properties.BulletImage
            },
            new()
            {
                Id = "Upgrade_BombBag",
                State = properties.BombState,
                SpritePath = properties.BombImage
            },
            new()
            {
                Id = "Upgrade_Quiver",
                State = properties.QuiverState,
                SpritePath = properties.QuiverImage
            },
            new()
            {
                Id = "Upgrade_Strength",
                State = properties.StrengthState,
                SpritePath = properties.StrengthImage
            },
            new()
            {
                Id = "Upgrade_Scale",
                State = properties.ScaleState,
                SpritePath = properties.ScaleImage
            },
            new()
            {
                Id = "Upgrade_Ocarina",
                State = properties.OcarinaState,
                SpritePath = properties.OcarinaImage
            },
            new()
            {
                Id = "Upgrade_Hookshot",
                State = properties.HookState,
                SpritePath = properties.HookshotImage
            }
        };
        
        StateWriter.WriteState(upgradeState, "OoT.TrackerState.Upgrades.dat");
    }

    public static void SaveEquipState(TrackerProperties properties)
    {
        PrepareDirectory();

        var equipState = new List<EquipState?>
        {
            new()
            {
                Id = "Equip_DekuShield",
                SpritePath = properties.DekuShieldImage
            },
            new()
            {
                Id = "Equip_HylianShield",
                SpritePath = properties.HylianShieldImage
            },
            new()
            {
                Id = "Equip_MirrorShield",
                SpritePath = properties.MirrorShieldImage
            },
            new()
            {
                Id = "Equip_KokiriSword",
                SpritePath = properties.KokiriSwordImage
            },
            new()
            {
                Id = "Equip_MasterSword",
                SpritePath = properties.MasterSwordImage
            },
            new()
            {
                Id = "Equip_BiggoronSword",
                SpritePath = properties.BiggoronSwordImage
            },
            new()
            {
                Id = "Equip_GoronTunic",
                SpritePath = properties.GoronTunicImage
            },
            new()
            {
                Id = "Equip_ZoraTunic",
                SpritePath = properties.ZoraTunicImage
            },
            new()
            {
                Id = "Equip_HoverBoots",
                SpritePath = properties.HoverBootsImage
            },
            new()
            {
                Id = "Equip_IronBoots",
                SpritePath = properties.IronBootsImage
            }
        };
        
        StateWriter.WriteState(equipState, "OoT.TrackerState.Equips.dat");
    }

    private static void PrepareDirectory()
    {
        if (!Directory.Exists("./Saves/"))
        {
            Directory.CreateDirectory("./Saves/");
        }
    }

    public static void ReadArrowState(TrackerProperties properties)
    {
        var arrowState = StateReader.ReadState<List<ArrowState?>>("OoT.TrackerState.Arrows.dat");

        if (arrowState == null)
        {
            return;
        }
        
        properties.FireArrowImage = arrowState[0]?.SpritePath;
        properties.IceArrowImage = arrowState[1]?.SpritePath;
        properties.LightArrowImage = arrowState[2]?.SpritePath;
    }

    public static void ReadItemState(TrackerProperties properties)
    {
        var itemState = StateReader.ReadState<ItemState>("OoT.TrackerState.Items.dat");

        if (itemState == null)
        {
            return;
        }

        properties.AdultTradeState = itemState.AdultTradeIndex;
        properties.AdultTradeItemImage = itemState.AdultTradePath;
        properties.ChildTradeState = itemState.ChildTradeIndex;
        properties.ChildTradeItemImage = itemState.ChildTradePath;
        
        properties.Bottle1Image = itemState.Bottles[0]?.SpritePath;
        properties.Bottle2Image = itemState.Bottles[1]?.SpritePath;
        properties.Bottle3Image = itemState.Bottles[2]?.SpritePath;
        properties.Bottle4Image = itemState.Bottles[3]?.SpritePath;
        
        properties.StickImage = itemState.Items[0]?.SpritePath;
        properties.NutImage = itemState.Items[1]?.SpritePath;
        properties.BombItemImage = itemState.Items[2]?.SpritePath;
        properties.BowImage = itemState.Items[3]?.SpritePath;
        properties.DinsFireImage = itemState.Items[4]?.SpritePath;
        properties.SlingshotImage = itemState.Items[5]?.SpritePath;
        properties.BombchuImage = itemState.Items[6]?.SpritePath;
        properties.FaroresWindImage = itemState.Items[7]?.SpritePath;
        properties.BoomerangImage = itemState.Items[8]?.SpritePath;
        properties.LensImage = itemState.Items[9]?.SpritePath;
        properties.MagicBeansImage = itemState.Items[10]?.SpritePath;
        properties.MegatonHammerImage = itemState.Items[11]?.SpritePath;
        properties.NayrusLoveImage = itemState.Items[12]?.SpritePath;
    }
    
    public static void ReadUpgradeState(TrackerProperties properties)
    {
        var upgradeState = StateReader.ReadState<List<UpgradeState?>>("OoT.TrackerState.Upgrades.dat");

        if (upgradeState == null)
        {
            return;
        }
        
        properties.BulletState = (int)upgradeState[0]?.State!;
        properties.BulletImage = upgradeState[0]?.SpritePath;

        properties.BombState = (int)upgradeState[1]?.State!;
        properties.BombImage = upgradeState[1]?.SpritePath;
        
        properties.QuiverState = (int)upgradeState[2]?.State!;
        properties.QuiverImage = upgradeState[2]?.SpritePath;
        
        properties.StrengthState = (int)upgradeState[3]?.State!;
        properties.StrengthImage = upgradeState[3]?.SpritePath;
        
        properties.ScaleState = (int)upgradeState[4]?.State!;
        properties.ScaleImage = upgradeState[4]?.SpritePath;
        
        properties.OcarinaState = (int)upgradeState[5]?.State!;
        properties.OcarinaImage = upgradeState[5]?.SpritePath;
        
        properties.HookState = (int)upgradeState[6]?.State!;
        properties.HookshotImage = upgradeState[6]?.SpritePath;
    }
    
    public static void ReadEquipState(TrackerProperties properties)
    {
        var equipState = StateReader.ReadState<List<EquipState?>>("OoT.TrackerState.Equips.dat");

        if (equipState == null)
        {
            return;
        }
        
        properties.DekuShieldImage = equipState[0]?.SpritePath;
        properties.HylianShieldImage = equipState[1]?.SpritePath;
        properties.MirrorShieldImage = equipState[2]?.SpritePath;
        
        properties.KokiriSwordImage = equipState[3]?.SpritePath;
        properties.MasterSwordImage = equipState[4]?.SpritePath;
        properties.BiggoronSwordImage = equipState[5]?.SpritePath;
        
        properties.GoronTunicImage = equipState[6]?.SpritePath;
        properties.ZoraTunicImage = equipState[7]?.SpritePath;
        
        properties.HoverBootsImage = equipState[8]?.SpritePath;
        properties.IronBootsImage = equipState[9]?.SpritePath;
    }
}