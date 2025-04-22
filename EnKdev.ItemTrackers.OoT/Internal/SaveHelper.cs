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

    public static void SaveDungeonState(TrackerProperties properties)
    {
        PrepareDirectory();

        var dungeonState = new List<DungeonState?>
        {
            new()
            {
                Id = "Dungeon_Deku",
                Name = "Inside the Deku Tree",
                MapSprite = properties.DekuMapImage,
                CompassSprite = properties.DekuCompassImage,
                IsMasterQuest = properties.IsDekuMq,
                DungeonIndex = properties.Dungeon1Idx
            },
            new()
            {
                Id = "Dungeon_Dodongo",
                Name = "Dodongo's Cavern",
                MapSprite = properties.DcMapImage,
                CompassSprite = properties.DcCompassImage,
                IsMasterQuest = properties.IsDcMq,
                DungeonIndex = properties.Dungeon2Idx
            },
            new()
            {
                Id = "Dungeon_Jabu",
                Name = "Jabu Jabus Belly",
                MapSprite = properties.JabuMapImage,
                CompassSprite = properties.JabuCompassImage,
                IsMasterQuest = properties.IsJabuMq,
                DungeonIndex = properties.Dungeon3Idx
            },
            // ---------
            new()
            {
                Id = "Dungeon_Forest",
                Name = "Forest Temple",
                MapSprite = properties.ForestMapImage,
                CompassSprite = properties.ForestCompassImage,
                KeySprite = properties.ForestKeyImage,
                BossKeySprite = properties.ForestBkImage,
                CollectedKeys = properties.ForestKeyCount,
                IsMasterQuest = properties.IsForestMq,
                DungeonIndex = properties.Dungeon4Idx
            },
            new()
            {
                Id = "Dungeon_Fire",
                Name = "Fire Temple",
                MapSprite = properties.FireMapImage,
                CompassSprite = properties.FireCompassImage,
                KeySprite = properties.FireKeyImage,
                BossKeySprite = properties.FireBkImage,
                CollectedKeys = properties.FireKeyCount,
                IsMasterQuest = properties.IsFireMq,
                DungeonIndex = properties.Dungeon5Idx
            },
            new()
            {
                Id = "Dungeon_Water",
                Name = "Water Temple",
                MapSprite = properties.WaterMapImage,
                CompassSprite = properties.WaterCompassImage,
                KeySprite = properties.WaterKeyImage,
                BossKeySprite = properties.WaterBkImage,
                CollectedKeys = properties.WaterKeyCount,
                IsMasterQuest = properties.IsWaterMq,
                DungeonIndex = properties.Dungeon6Idx
            },
            new()
            {
                Id = "Dungeon_Shadow",
                Name = "Shadow Temple",
                MapSprite = properties.ShadowMapImage,
                CompassSprite = properties.ShadowCompassImage,
                KeySprite = properties.ShadowKeyImage,
                BossKeySprite = properties.ShadowBkImage,
                CollectedKeys = properties.ShadowKeyCount,
                IsMasterQuest = properties.IsShadowMq,
                DungeonIndex = properties.Dungeon7Idx
            },
            new()
            {
                Id = "Dungeon_Spirit",
                Name = "Spirit Temple",
                MapSprite = properties.SpiritMapImage,
                CompassSprite = properties.SpiritCompassImage,
                KeySprite = properties.SpiritKeyImage,
                BossKeySprite = properties.SpiritBkImage,
                CollectedKeys = properties.SpiritKeyCount,
                IsMasterQuest = properties.IsSpiritMq,
                DungeonIndex = properties.Dungeon8Idx
            },
            // ---------
            new()
            {
                Id = "Dungeon_Ice",
                Name = "Ice Cavern",
                MapSprite = properties.CavernMapImage,
                CompassSprite = properties.CavernCompassImage,
                IsMasterQuest = properties.IsCavernMq,
                DungeonIndex = properties.Dungeon9Idx
            },
            new()
            {
                Id = "Dungeon_Bottom",
                Name = "Bottom of the Well",
                MapSprite = properties.BottomMapImage,
                CompassSprite = properties.BottomCompassImage,
                KeySprite = properties.BottomKeyImage,
                CollectedKeys = properties.BottomKeyCount,
                IsMasterQuest = properties.IsBottomMq,
                DungeonIndex = properties.Dungeon10Idx
            },
            new()
            {
                Id = "Dungeon_Gerudo",
                Name = "Gerudo Training Ground",
                KeySprite = properties.GtgKeyImage,
                CollectedKeys = properties.GtgKeyCount,
                IsMasterQuest = properties.IsGtgMq,
                DungeonIndex = properties.Dungeon11Idx
            },
            new()
            {
                Id = "Dungeon_Ganon",
                Name = "Ganon's Castle",
                KeySprite = properties.GanonKeyImage,
                BossKeySprite = properties.GanonBkImage,
                CollectedKeys = properties.GanonKeyCount,
                IsMasterQuest = properties.IsGanonMq,
                DungeonIndex = properties.Dungeon12Idx
            }
        };
        
        StateWriter.WriteState(dungeonState, "OoT.TrackerState.Dungeons.dat");
    }

    public static void SaveQuestState(TrackerProperties properties)
    {
        PrepareDirectory();

        var questState = new List<QuestState?>
        {
            new()
            {
                Id = "Progression_LightMedallion",
                SpritePath = properties.LightMedallionImage,
                LocationIndex = properties.Location1Idx
            },
            new()
            {
                Id = "Progression_ForestMedallion",
                SpritePath = properties.ForestMedallionImage,
                LocationIndex = properties.Location2Idx
            },
            new()
            {
                Id = "Progression_FireMedallion",
                SpritePath = properties.FireMedallionImage,
                LocationIndex = properties.Location3Idx
            },
            new()
            {
                Id = "Progression_WaterMedallion",
                SpritePath = properties.WaterMedallionImage,
                LocationIndex = properties.Location4Idx
            },
            new()
            {
                Id = "Progression_ShadowMedallion",
                SpritePath = properties.ShadowMedallionImage,
                LocationIndex = properties.Location5Idx
            },
            new()
            {
                Id = "Progression_SpiritMedallion",
                SpritePath = properties.SpiritMedallionImage,
                LocationIndex = properties.Location6Idx
            },
            new()
            {
                Id = "Progression_KokiriEmerald",
                SpritePath = properties.KokiriEmeraldImage,
                LocationIndex = properties.Location7Idx
            },
            new()
            {
                Id = "Progression_GoronRuby",
                SpritePath = properties.GoronRubyImage,
                LocationIndex = properties.Location8Idx
            },
            new()
            {
                Id = "Progression_ZoraSapphire",
                SpritePath = properties.ZoraSapphireImage,
                LocationIndex = properties.Location9Idx
            }
        };
        
        StateWriter.WriteState(questState, "OoT.TrackerState.Quests.dat");
    }

    public static void SaveOtherState(TrackerProperties properties)
    {
        PrepareDirectory();

        var otherState = new List<OtherState?>
        {
            new()
            {
                Id = "Other_Token",
                SpritePath = properties.GerudoTokenImage
            },
            new()
            {
                Id = "Other_Shard",
                SpritePath = properties.ShardImage
            }
        };
        
        StateWriter.WriteState(otherState, "OoT.TrackerState.Other.dat");
    }

    public static void SaveDataState(TrackerProperties properties)
    {
        PrepareDirectory();

        var dataState = new DataState()
        {
            HeartPieces = properties.HeartPieceCount,
            HeartContainers = properties.HeartContainerCount,
            GsTokens = properties.GsTokens,
            HpImage = properties.HeartPieceProgression
        };
        
        StateWriter.WriteState(dataState, "OoT.TrackerState.Data.dat");
    }

    public static void SaveSongState(TrackerProperties properties)
    {
        PrepareDirectory();

        var songState = new List<SongState?>
        {
            new()
            {
                Id = "Song_Lullaby",
                SpritePath = properties.LullabyImage
            },
            new()
            {
                Id = "Song_Epona",
                SpritePath = properties.EponaImage
            },
            new()
            {
                Id = "Song_Saria",
                SpritePath = properties.SariaImage
            },
            new()
            {
                Id = "Song_Storms",
                SpritePath = properties.SosImage
            },
            new()
            {
                Id = "Song_Suns",
                SpritePath = properties.SunsImage
            },
            new()
            {
                Id = "Song_Time",
                SpritePath = properties.SotImage
            },
            // ------
            new()
            {
                Id = "Song_Minuet",
                SpritePath = properties.MinuetImage
            },
            new()
            {
                Id = "Song_Bolero",
                SpritePath = properties.BoleroImage
            },
            new()
            {
                Id = "Song_Serenade",
                SpritePath = properties.SerenadeImage
            },
            new()
            {
                Id = "Song_Nocturne",
                SpritePath = properties.NocturneImage
            },
            new()
            {
                Id = "Song_Requiem",
                SpritePath = properties.RequiemImage
            },
            new()
            {
                Id = "Song_Prelude",
                SpritePath = properties.PreludeImage
            }
        };
        
        StateWriter.WriteState(songState, "OoT.TrackerState.Songs.dat");
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

    public static void ReadDungeonState(TrackerProperties properties)
    {
        var dungeonState = StateReader.ReadState<List<DungeonState?>>("OoT.TrackerState.Dungeons.dat");
        
        if (dungeonState == null)
        {
            return;
        }
        
        properties.DekuMapImage = dungeonState[0]?.MapSprite;
        properties.DekuCompassImage = dungeonState[0]?.CompassSprite;
        properties.IsDekuMq = dungeonState[0]?.IsMasterQuest ?? false;
        
        properties.DcMapImage = dungeonState[1]?.MapSprite;
        properties.DcCompassImage = dungeonState[1]?.CompassSprite;
        properties.IsDcMq = dungeonState[1]?.IsMasterQuest ?? false;
        
        properties.JabuMapImage = dungeonState[2]?.MapSprite;
        properties.JabuCompassImage = dungeonState[2]?.CompassSprite;
        properties.IsJabuMq = dungeonState[2]?.IsMasterQuest ?? false;
        
        properties.ForestMapImage = dungeonState[3]?.MapSprite;
        properties.ForestCompassImage = dungeonState[3]?.CompassSprite;
        properties.ForestKeyImage = dungeonState[3]?.KeySprite;
        properties.ForestBkImage = dungeonState[3]?.BossKeySprite;
        properties.ForestKeyCount = dungeonState[3]?.CollectedKeys ?? 0;
        properties.IsForestMq = dungeonState[3]?.IsMasterQuest ?? false;
        
        properties.FireMapImage = dungeonState[4]?.MapSprite;
        properties.FireCompassImage = dungeonState[4]?.CompassSprite;
        properties.FireKeyImage = dungeonState[4]?.KeySprite;
        properties.FireBkImage = dungeonState[4]?.BossKeySprite;
        properties.FireKeyCount = dungeonState[4]?.CollectedKeys ?? 0;
        properties.IsFireMq = dungeonState[4]?.IsMasterQuest ?? false;
        
        properties.WaterMapImage = dungeonState[5]?.MapSprite;
        properties.WaterCompassImage = dungeonState[5]?.CompassSprite;
        properties.WaterKeyImage = dungeonState[5]?.KeySprite;
        properties.WaterBkImage = dungeonState[5]?.BossKeySprite;
        properties.WaterKeyCount = dungeonState[5]?.CollectedKeys ?? 0;
        properties.IsWaterMq = dungeonState[5]?.IsMasterQuest ?? false;
        
        properties.ShadowMapImage = dungeonState[6]?.MapSprite;
        properties.ShadowCompassImage = dungeonState[6]?.CompassSprite;
        properties.ShadowKeyImage = dungeonState[6]?.KeySprite;
        properties.ShadowBkImage = dungeonState[6]?.BossKeySprite;
        properties.ShadowKeyCount = dungeonState[6]?.CollectedKeys ?? 0;
        properties.IsShadowMq = dungeonState[6]?.IsMasterQuest ?? false;
        
        properties.SpiritMapImage = dungeonState[7]?.MapSprite;
        properties.SpiritCompassImage = dungeonState[7]?.CompassSprite;
        properties.SpiritKeyImage = dungeonState[7]?.KeySprite;
        properties.SpiritBkImage = dungeonState[7]?.BossKeySprite;
        properties.SpiritKeyCount = dungeonState[7]?.CollectedKeys ?? 0;
        properties.IsSpiritMq = dungeonState[7]?.IsMasterQuest ?? false;
        
        properties.CavernMapImage = dungeonState[8]?.MapSprite;
        properties.CavernCompassImage = dungeonState[8]?.CompassSprite;
        properties.IsCavernMq = dungeonState[8]?.IsMasterQuest ?? false;
        
        properties.BottomMapImage = dungeonState[9]?.MapSprite;
        properties.BottomCompassImage = dungeonState[9]?.CompassSprite;
        properties.BottomKeyImage = dungeonState[9]?.KeySprite;
        properties.BottomKeyCount = dungeonState[9]?.CollectedKeys ?? 0;
        
        properties.GtgKeyImage = dungeonState[10]?.KeySprite;
        properties.GtgKeyCount = dungeonState[10]?.CollectedKeys ?? 0;
        properties.IsGtgMq = dungeonState[10]?.IsMasterQuest ?? false;
        
        properties.GanonKeyImage = dungeonState[11]?.KeySprite;
        properties.GanonBkImage = dungeonState[11]?.BossKeySprite;
        properties.GanonKeyCount = dungeonState[11]?.CollectedKeys ?? 0;
        properties.IsGanonMq = dungeonState[11]?.IsMasterQuest ?? false;
    }
    
    public static void ReadQuestState(TrackerProperties properties)
    {
        var questState = StateReader.ReadState<List<QuestState?>>("OoT.TrackerState.Quests.dat");
        
        if (questState == null)
        {
            return;
        }
        
        properties.LightMedallionImage = questState[0]?.SpritePath;
        properties.Location1Idx = questState[0]?.LocationIndex ?? 0;
        
        properties.ForestMedallionImage = questState[1]?.SpritePath;
        properties.Location2Idx = questState[1]?.LocationIndex ?? 0;
        
        properties.FireMedallionImage = questState[2]?.SpritePath;
        properties.Location3Idx = questState[2]?.LocationIndex ?? 0;
        
        properties.WaterMedallionImage = questState[3]?.SpritePath;
        properties.Location4Idx = questState[3]?.LocationIndex ?? 0;
        
        properties.ShadowMedallionImage = questState[4]?.SpritePath;
        properties.Location5Idx = questState[4]?.LocationIndex ?? 0;
        
        properties.SpiritMedallionImage = questState[5]?.SpritePath;
        properties.Location6Idx = questState[5]?.LocationIndex ?? 0;
        
        properties.KokiriEmeraldImage = questState[6]?.SpritePath;
        properties.Location7Idx = questState[6]?.LocationIndex ?? 0;
        
        properties.GoronRubyImage = questState[7]?.SpritePath;
        properties.Location8Idx = questState[7]?.LocationIndex ?? 0;
        
        properties.ZoraSapphireImage = questState[8]?.SpritePath;
        properties.Location9Idx = questState[8]?.LocationIndex ?? 0;
    }
    
    public static void ReadOtherState(TrackerProperties properties)
    {
        var otherState = StateReader.ReadState<List<OtherState?>>("OoT.TrackerState.Other.dat");
        
        if (otherState == null)
        {
            return;
        }
        
        properties.GerudoTokenImage = otherState[0]?.SpritePath;
        properties.ShardImage = otherState[1]?.SpritePath;
    }
    
    public static void ReadDataState(TrackerProperties properties)
    {
        var dataState = StateReader.ReadState<DataState>("OoT.TrackerState.Data.dat");
        
        if (dataState == null)
        {
            return;
        }
        
        properties.HeartPieceCount = dataState.HeartPieces;
        properties.HeartContainerCount = dataState.HeartContainers;
        properties.GsTokens = dataState.GsTokens;
        properties.HeartPieceProgression = dataState.HpImage;
    }

    public static void ReadSongState(TrackerProperties properties)
    {
        var songState = StateReader.ReadState<List<SongState?>>("OoT.TrackerState.Songs.dat");

        if (songState == null)
        {
            return;
        }
        
        properties.LullabyImage = songState[0]?.SpritePath;
        properties.EponaImage = songState[1]?.SpritePath;
        properties.SariaImage = songState[2]?.SpritePath;
        properties.SosImage = songState[3]?.SpritePath;
        properties.SunsImage = songState[4]?.SpritePath;
        properties.SotImage = songState[5]?.SpritePath;
        
        properties.MinuetImage = songState[6]?.SpritePath;
        properties.BoleroImage = songState[7]?.SpritePath;
        properties.SerenadeImage = songState[8]?.SpritePath;
        properties.NocturneImage = songState[9]?.SpritePath;
        properties.RequiemImage = songState[10]?.SpritePath;
        properties.PreludeImage = songState[11]?.SpritePath;
    }
}