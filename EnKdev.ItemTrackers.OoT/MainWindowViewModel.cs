﻿using System;
using System.IO;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnKdev.ItemTrackers.OoT.Data;
using EnKdev.ItemTrackers.OoT.Models;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindowViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string _title;

    // Reward Locations
    [ObservableProperty]
    private string _location1;

    [ObservableProperty]
    private string _location2;

    [ObservableProperty]
    private string _location3;

    [ObservableProperty]
    private string _location4;

    [ObservableProperty]
    private string _location5;

    [ObservableProperty]
    private string _location6;

    [ObservableProperty]
    private string _location7;

    [ObservableProperty]
    private string _location8;

    [ObservableProperty]
    private string _location9;

    // Quest Items (Dungeon Rewards)
    [ObservableProperty]
    private string _kokiriEmeraldImage;

    [ObservableProperty]
    private string _goronRubyImage;

    [ObservableProperty]
    private string _zoraSapphireImage;

    [ObservableProperty] 
    private string _lightMedallionImage;

    [ObservableProperty]
    private string _forestMedallionImage;

    [ObservableProperty]
    private string _fireMedallionImage;

    [ObservableProperty]
    private string _waterMedallionImage;

    [ObservableProperty]
    private string _shadowMedallionImage;

    [ObservableProperty]
    private string _spiritMedallionImage;

    // Equips (Boots, Shields, Swords, Tunics)
    [ObservableProperty]
    private string _kokiriSwordImage;

    [ObservableProperty]
    private string _masterSwordImage;

    [ObservableProperty]
    private string _biggoronSwordImage;

    [ObservableProperty]
    private string _dekuShieldImage;

    [ObservableProperty]
    private string _hylianShieldImage;

    [ObservableProperty]
    private string _mirrorShieldImage;

    [ObservableProperty]
    private string _kokiriTunicImage;

    [ObservableProperty]
    private string _goronTunicImage;

    [ObservableProperty]
    private string _zoraTunicImage;

    [ObservableProperty]
    private string _kokiriBootsImage;

    [ObservableProperty]
    private string _ironBootsImage;

    [ObservableProperty]
    private string _hoverBootsImage;

    // Upgrades
    [ObservableProperty]
    private string _ocarinaImage;

    [ObservableProperty]
    private string _scaleImage;

    [ObservableProperty]
    private string _strengthImage;

    [ObservableProperty]
    private string _bombImage;

    [ObservableProperty]
    private string _quiverImage;

    [ObservableProperty]
    private string _bulletImage;
    
    // Other
    [ObservableProperty]
    private string _gsImage;

    [ObservableProperty] 
    private int _gsTokens;

    [ObservableProperty] 
    private string _gerudoTokenImage;

    [ObservableProperty] 
    private string _shardImage;

    // Songs
    [ObservableProperty]
    private string _lullabyImage;

    [ObservableProperty]
    private string _eponaImage;

    [ObservableProperty]
    private string _sariaImage;

    [ObservableProperty]
    private string _sosImage;

    [ObservableProperty]
    private string _sunsImage;

    [ObservableProperty]
    private string _sotImage;

    [ObservableProperty]
    private string _minuetImage;

    [ObservableProperty]
    private string _boleroImage;

    [ObservableProperty]
    private string _serenadeImage;

    [ObservableProperty]
    private string _requiemImage;

    [ObservableProperty]
    private string _nocturneImage;

    [ObservableProperty]
    private string _preludeImage;

    // General items
    [ObservableProperty] 
    private string _stickImage;

    [ObservableProperty] 
    private string _nutImage;

    [ObservableProperty]
    private string _slingshotImage;

    [ObservableProperty]
    private string _dinsFireImage;

    [ObservableProperty]
    private string _bombItemImage;

    [ObservableProperty]
    private string _bombchuImage;

    [ObservableProperty]
    private string _childTradeItemImage;

    [ObservableProperty]
    private string _faroresWindImage;

    [ObservableProperty]
    private string _boomerangImage;

    [ObservableProperty]
    private string _hookshotImage;

    [ObservableProperty]
    private string _adultTradeItemImage;

    [ObservableProperty]
    private string _nayrusLoveImage;

    [ObservableProperty]
    private string _lensImage;

    [ObservableProperty]
    private string _megatonHammerImage;

    [ObservableProperty]
    private string _bowImage;

    [ObservableProperty]
    private string _magicBeansImage;

    [ObservableProperty]
    private string _bottle1Image;

    [ObservableProperty]
    private string _bottle2Image;

    [ObservableProperty]
    private string _bottle3Image;

    [ObservableProperty]
    private string _bottle4Image;

    [ObservableProperty]
    private string _fireArrowImage;

    [ObservableProperty]
    private string _iceArrowImage;

    [ObservableProperty]
    private string _lightArrowImage;
    
    // Backgrounds
    [ObservableProperty]
    private string _itemSongBackground;

    [ObservableProperty] 
    private string _gearBackground;

    // Data
    private int _ocarinaState;
    private int _scaleState;
    private int _strengthState;
    private int _bombState;
    private int _quiverState;
    private int _bulletState;

    private int _location1Idx;
    private int _location2Idx;
    private int _location3Idx;
    private int _location4Idx;
    private int _location5Idx;
    private int _location6Idx;
    private int _location7Idx;
    private int _location8Idx;
    private int _location9Idx;

    private int _childTradeStage;
    private int _adultTradeStage;

    private int _hookState;

    private TrackerData? _trackerData;

    public MainWindowViewModel()
    {
        Logger.SetupLogger();

        Title = Constants.AppTitle;

        Location1 = Constants.DungeonLocations[0];
        Location2 = Constants.DungeonLocations[0];
        Location3 = Constants.DungeonLocations[0];
        Location4 = Constants.DungeonLocations[0];
        Location5 = Constants.DungeonLocations[0];
        Location6 = Constants.DungeonLocations[0];
        Location7 = Constants.DungeonLocations[0];
        Location8 = Constants.DungeonLocations[0];
        Location9 = Constants.DungeonLocations[0];

        ItemSongBackground = Constants.ItemSongBg;
        GearBackground = Constants.GearBg;

        KokiriEmeraldImage = Constants.DisabledStones[0];
        GoronRubyImage = Constants.DisabledStones[1];
        ZoraSapphireImage = Constants.DisabledStones[2];

        LightMedallionImage = Constants.DisabledMeds[0];
        ForestMedallionImage = Constants.DisabledMeds[1];
        FireMedallionImage = Constants.DisabledMeds[2];
        WaterMedallionImage = Constants.DisabledMeds[3];
        ShadowMedallionImage = Constants.DisabledMeds[4];
        SpiritMedallionImage = Constants.DisabledMeds[5];

        KokiriSwordImage = Constants.DisabledEquip[0];
        MasterSwordImage = Constants.DisabledEquip[1];
        BiggoronSwordImage = Constants.DisabledEquip[2];
        DekuShieldImage = Constants.DisabledEquip[3];
        HylianShieldImage = Constants.DisabledEquip[4];
        MirrorShieldImage = Constants.DisabledEquip[5];
        KokiriTunicImage = Constants.KokiriTunicSprite;
        GoronTunicImage = Constants.DisabledEquip[6];
        ZoraTunicImage = Constants.DisabledEquip[7];
        KokiriBootsImage = Constants.KokiriBootsSprite;
        IronBootsImage = Constants.DisabledEquip[8];
        HoverBootsImage = Constants.DisabledEquip[9];

        OcarinaImage = Constants.DisabledUpgrade[3];
        ScaleImage = Constants.DisabledUpgrade[6];
        StrengthImage = Constants.DisabledUpgrade[4];
        QuiverImage = Constants.DisabledUpgrade[5];
        BombImage = Constants.DisabledUpgrade[1];
        BulletImage = Constants.DisabledUpgrade[2];

        GsImage = Constants.GsIcon;

        GerudoTokenImage = Constants.DisabledOther[0];
        ShardImage = Constants.DisabledOther[1];

        LullabyImage = Constants.DisabledSongs[0];
        EponaImage = Constants.DisabledSongs[1];
        SariaImage = Constants.DisabledSongs[2];
        SosImage = Constants.DisabledSongs[3];
        SunsImage = Constants.DisabledSongs[4];
        SotImage = Constants.DisabledSongs[5];
        MinuetImage = Constants.DisabledSongs[6];
        BoleroImage = Constants.DisabledSongs[7];
        SerenadeImage = Constants.DisabledSongs[8];
        RequiemImage = Constants.DisabledSongs[9];
        NocturneImage = Constants.DisabledSongs[10];
        PreludeImage = Constants.DisabledSongs[11];

        BombItemImage = Constants.DisabledItems[0];
        BombchuImage = Constants.DisabledItems[1];
        BoomerangImage = Constants.DisabledItems[2];
        Bottle1Image = Constants.DisabledItems[3];
        Bottle2Image = Constants.DisabledItems[3];
        Bottle3Image = Constants.DisabledItems[3];
        Bottle4Image = Constants.DisabledItems[3];
        NutImage = Constants.DisabledItems[4];
        StickImage = Constants.DisabledItems[5];
        DinsFireImage = Constants.DisabledItems[6];
        BowImage = Constants.DisabledItems[7];
        SlingshotImage = Constants.DisabledItems[8];
        FaroresWindImage = Constants.DisabledItems[9];
        FireArrowImage = Constants.DisabledItems[10];
        HookshotImage = Constants.DisabledItems[11];
        IceArrowImage = Constants.DisabledItems[12];
        LensImage = Constants.DisabledItems[13];
        LightArrowImage = Constants.DisabledItems[14];
        MegatonHammerImage = Constants.DisabledItems[15];
        NayrusLoveImage = Constants.DisabledItems[16];
        MagicBeansImage = Constants.DisabledItems[17];

        ChildTradeItemImage = Constants.ChildTradingSequence[0];
        AdultTradeItemImage = Constants.AdultTradingSequence[0];
    }

    #region Quest Items (Dungeon Rewards)

    [RelayCommand]
    public void ToggleEmerald()
    {
        Logger.LogCommand(nameof(ToggleEmeraldCommand));
        
        KokiriEmeraldImage = GetState(KokiriEmeraldImage) ? 
            Constants.DisabledStones[0] : 
            Constants.EnabledStones[0];
        
        Logger.LogInteraction(nameof(KokiriEmeraldImage));
    }

    [RelayCommand]
    public void SetEmeraldLocation()
    {
        Logger.LogCommand(nameof(SetEmeraldLocationCommand));
        
        if (_location1Idx >= 9)
        {
            // Reset back to 0
            _location1Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location1Idx++;
            
            Location1 = _location1Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location1
            };
        });
        
        Logger.LogInteraction(nameof(Location1));
    }

    [RelayCommand]
    public void ToggleGoronRuby()
    {
        Logger.LogCommand(nameof(ToggleGoronRubyCommand));
        
        GoronRubyImage = GetState(GoronRubyImage)
            ? Constants.DisabledStones[1]
            : Constants.EnabledStones[1];
        
        Logger.LogInteraction(nameof(GoronRubyImage));
    }

    [RelayCommand]
    public void SetRubyLocation()
    {
        Logger.LogCommand(nameof(SetRubyLocationCommand));
        
        if (_location2Idx >= 9)
        {
            // Reset back to 0
            _location2Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location2Idx++;
            
            Location2 = _location2Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location2
            };
        });
        
        Logger.LogInteraction(nameof(SetRubyLocationCommand));
    }

    [RelayCommand]
    public void ToggleZorasSapphire()
    {
        Logger.LogCommand(nameof(ToggleZorasSapphireCommand));
        
        ZoraSapphireImage = GetState(ZoraSapphireImage)
            ? Constants.DisabledStones[2]
            : Constants.EnabledStones[2];
        
        Logger.LogInteraction(nameof(ZoraSapphireImage));
    }

    [RelayCommand]
    public void SetSapphireLocation()
    {
        Logger.LogCommand(nameof(SetSapphireLocationCommand));
        
        if (_location3Idx >= 9)
        {
            // Reset back to 0
            _location3Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location3Idx++;
            
            Location3 = _location3Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location3
            };
        });
        
        Logger.LogInteraction(nameof(Location3));
    }

    [RelayCommand]
    public void ToggleLightMedallion()
    {
        Logger.LogCommand(nameof(ToggleLightMedallionCommand));
        
        LightMedallionImage = GetState(LightMedallionImage)
            ? Constants.DisabledMeds[0]
            : Constants.EnabledMeds[0];
        
        Logger.LogInteraction(nameof(LightMedallionImage));
    }

    [RelayCommand]
    public void SetLightLocation()
    {
        Logger.LogCommand(nameof(SetLightLocationCommand));
        
        if (_location4Idx >= 9)
        {
            // Reset back to 0
            _location4Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location4Idx++;
            
            Location4 = _location4Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location4
            };
        });
        
        Logger.LogInteraction(nameof(Location4));
    }

    [RelayCommand]
    public void ToggleForestMedallion()
    {
        Logger.LogCommand(nameof(ToggleForestMedallionCommand));
        
        ForestMedallionImage = GetState(ForestMedallionImage)
            ? Constants.DisabledMeds[1]
            : Constants.EnabledMeds[1];
        
        Logger.LogInteraction(nameof(ForestMedallionImage));
    }

    [RelayCommand]
    public void SetForestLocation()
    {
        Logger.LogCommand(nameof(SetForestLocationCommand));
        
        if (_location5Idx >= 9)
        {
            // Reset back to 0
            _location5Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location5Idx++;
            
            Location5 = _location5Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location5
            };
        });
        
        Logger.LogInteraction(nameof(Location5));
    }

    [RelayCommand]
    public void ToggleFireMedallion()
    {
        Logger.LogCommand(nameof(ToggleFireMedallionCommand));
        
        FireMedallionImage = GetState(FireMedallionImage)
            ? Constants.DisabledMeds[2]
            : Constants.EnabledMeds[2];
        
        Logger.LogInteraction(nameof(FireMedallionImage));
    }

    [RelayCommand]
    public void SetFireLocation()
    {
        Logger.LogCommand(nameof(SetFireLocationCommand));
        
        if (_location6Idx >= 9)
        {
            // Reset back to 0
            _location6Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location6Idx++;
            
            Location6 = _location6Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location6
            };
        });
        
        Logger.LogInteraction(nameof(Location6));
    }

    [RelayCommand]
    public void ToggleWaterMedallion()
    {
        Logger.LogCommand(nameof(ToggleWaterMedallionCommand));
        
        WaterMedallionImage = GetState(WaterMedallionImage)
            ? Constants.DisabledMeds[3]
            : Constants.EnabledMeds[3];
        
        Logger.LogInteraction(nameof(WaterMedallionImage));
    }

    [RelayCommand]
    public void SetWaterLocation()
    {
        Logger.LogCommand(nameof(SetWaterLocationCommand));
        
        if (_location7Idx >= 9)
        {
            // Reset back to 0
            _location7Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location7Idx++;
            
            Location7 = _location7Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location7
            };
        });
        
        Logger.LogInteraction(nameof(Location7));
    }

    [RelayCommand]
    public void ToggleShadowMedallion()
    {
        Logger.LogCommand(nameof(ToggleShadowMedallionCommand));
        
        ShadowMedallionImage = GetState(ShadowMedallionImage)
            ? Constants.DisabledMeds[4]
            : Constants.EnabledMeds[4];
        
        Logger.LogInteraction(nameof(ShadowMedallionImage));
    }

    [RelayCommand]
    public void SetShadowLocation()
    {
        Logger.LogCommand(nameof(SetShadowLocationCommand));
        
        if (_location8Idx >= 9)
        {
            // Reset back to 0
            _location8Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location8Idx++;
            
            Location8 = _location8Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location8
            };
        });
        
        Logger.LogInteraction(nameof(Location8));
    }

    [RelayCommand]
    public void ToggleSpiritMedallion()
    {
        Logger.LogCommand(nameof(ToggleSpiritMedallionCommand));
        
        SpiritMedallionImage = GetState(SpiritMedallionImage)
            ? Constants.DisabledMeds[5]
            : Constants.EnabledMeds[5];
        
        Logger.LogInteraction(nameof(SpiritMedallionImage));
    }

    [RelayCommand]
    public void SetSpiritLocation()
    {
        Logger.LogCommand(nameof(SetSpiritLocationCommand));
        
        if (_location9Idx >= 9)
        {
            // Reset back to 0
            _location9Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location9Idx++;
        
            Location9 = _location9Idx switch
            {
                0 => Constants.DungeonLocations[0], // "??"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location9
            };
        });
        
        Logger.LogInteraction(nameof(Location9));
    }

    #endregion
    #region Equip Items (Tunics, Swords, Shields, Boots)
    #region Swords
    [RelayCommand]
    public void ToggleKokiriSword()
    {
        Logger.LogCommand(nameof(ToggleKokiriSwordCommand));
        
        KokiriSwordImage = GetState(KokiriSwordImage)
            ? Constants.DisabledEquip[0]
            : Constants.EnabledEquip[0];
        
        Logger.LogInteraction(nameof(KokiriSwordImage));
    }

    [RelayCommand]
    public void ToggleMasterSword()
    {
        Logger.LogCommand(nameof(ToggleMasterSwordCommand));
        
        MasterSwordImage = GetState(MasterSwordImage)
            ? Constants.DisabledEquip[1]
            : Constants.EnabledEquip[1];
        
        Logger.LogInteraction(nameof(MasterSwordImage));
    }

    [RelayCommand]
    public void ToggleBiggoronSword()
    {
        Logger.LogCommand(nameof(ToggleBiggoronSwordCommand));
        
        BiggoronSwordImage = GetState(BiggoronSwordImage)
            ? Constants.DisabledEquip[2]
            : Constants.EnabledEquip[2];
        
        Logger.LogInteraction(nameof(BiggoronSwordImage));
    }
    #endregion
    #region Shields
    [RelayCommand]
    public void ToggleDekuShield()
    {
        Logger.LogCommand(nameof(ToggleDekuShieldCommand));
        
        DekuShieldImage = GetState(DekuShieldImage)
            ? Constants.DisabledEquip[3]
            : Constants.EnabledEquip[3];
        
        Logger.LogInteraction(nameof(DekuShieldImage));
    }

    [RelayCommand]
    public void ToggleHylianShield()
    {
        Logger.LogCommand(nameof(ToggleHylianShieldCommand));
        
        HylianShieldImage = GetState(HylianShieldImage)
            ? Constants.DisabledEquip[4]
            : Constants.EnabledEquip[4];
        
        Logger.LogInteraction(nameof(HylianShieldImage));
    }

    [RelayCommand]
    public void ToggleMirrorShield()
    {
        Logger.LogCommand(nameof(ToggleMirrorShieldCommand));
        
        MirrorShieldImage = GetState(MirrorShieldImage)
            ? Constants.DisabledEquip[5]
            : Constants.EnabledEquip[5];
        
        Logger.LogInteraction(nameof(MirrorShieldImage));
    }
    #endregion
    #region Tunics
    [RelayCommand]
    public void ToggleGoronTunic()
    {
        Logger.LogCommand(nameof(ToggleGoronTunic));
        
        GoronTunicImage = GetState(GoronTunicImage)
            ? Constants.DisabledEquip[6]
            : Constants.EnabledEquip[6];
        
        Logger.LogInteraction(nameof(GoronTunicImage));
    }

    [RelayCommand]
    public void ToggleZoraTunic()
    {
        Logger.LogCommand(nameof(ToggleZoraTunicCommand));
        
        ZoraTunicImage = GetState(ZoraTunicImage)
            ? Constants.DisabledEquip[7]
            : Constants.EnabledEquip[7];
        
        Logger.LogInteraction(nameof(ZoraTunicImage));
    }
    #endregion
    #region Boots
    [RelayCommand]
    public void ToggleIronBoots()
    {
        Logger.LogCommand(nameof(ToggleIronBootsCommand));
        
        IronBootsImage = GetState(IronBootsImage)
            ? Constants.DisabledEquip[8]
            : Constants.EnabledEquip[8];
        
        Logger.LogInteraction(nameof(IronBootsImage));
    }

    [RelayCommand]
    public void ToggleHoverBoots()
    {
        Logger.LogCommand(nameof(HoverBootsImage));
        
        HoverBootsImage = GetState(HoverBootsImage)
            ? Constants.DisabledEquip[9]
            : Constants.EnabledEquip[9];
        
        Logger.LogInteraction(nameof(HoverBootsImage));
    }
    #endregion
    #endregion
    #region Upgrades
    [RelayCommand]
    public void UpgradeOcarina()
    {
        Logger.LogCommand(nameof(UpgradeOcarinaCommand));
        
        switch (_ocarinaState)
        {
            case 0:
                OcarinaImage = Constants.EnabledUpgrade[8];
                _ocarinaState = 1;
                break;
            case 1:
                OcarinaImage = Constants.EnabledUpgrade[9];
                _ocarinaState = 2;
                break;
            default:
                break;
        }
    }

    [RelayCommand]
    public void DowngradeOcarina()
    {
        Logger.LogCommand(nameof(DowngradeOcarinaCommand));
        
        switch (_ocarinaState)
        {
            case 2:
                OcarinaImage = Constants.EnabledUpgrade[8];
                _ocarinaState = 1;
                break;
            case 1:
                OcarinaImage = Constants.DisabledUpgrade[3];
                _ocarinaState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeScale()
    {
        Logger.LogCommand(nameof(UpgradeScaleCommand));
        
        switch (_scaleState)
        {
            case 0:
                ScaleImage = Constants.EnabledUpgrade[16];
                _scaleState = 1;
                break;
            case 1:
                ScaleImage = Constants.EnabledUpgrade[17];
                _scaleState = 2;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeScale()
    {
        Logger.LogCommand(nameof(DowngradeScaleCommand));
        
        switch (_scaleState)
        {
            case 2:
                ScaleImage = Constants.EnabledUpgrade[16];
                _scaleState = 1;
                break;
            case 1:
                ScaleImage = Constants.DisabledUpgrade[6];
                _scaleState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeStrength()
    {
        Logger.LogCommand(nameof(UpgradeStrengthCommand));
        
        switch (_strengthState)
        {
            case 0:
                StrengthImage = Constants.EnabledUpgrade[10];
                _strengthState = 1;
                break;
            case 1:
                StrengthImage = Constants.EnabledUpgrade[11];
                _strengthState = 2;
                break;
            case 2:
                StrengthImage = Constants.EnabledUpgrade[12];
                _strengthState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeStrength()
    {
        Logger.LogCommand(nameof(DowngradeStrengthCommand));
        
        switch (_strengthState)
        {
            case 3:
                StrengthImage = Constants.EnabledUpgrade[11];
                _strengthState = 2;
                break;
            case 2:
                StrengthImage = Constants.EnabledUpgrade[10];
                _strengthState = 1;
                break;
            case 1:
                StrengthImage = Constants.DisabledUpgrade[4];
                _strengthState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeBomb()
    {
        Logger.LogCommand(nameof(UpgradeBombCommand));
        
        switch (_bombState)
        {
            case 0:
                BombImage = Constants.EnabledUpgrade[2];
                _bombState = 1;
                break;
            case 1:
                BombImage = Constants.EnabledUpgrade[3];
                _bombState = 2;
                break;
            case 2:
                BombImage = Constants.EnabledUpgrade[4];
                _bombState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeBomb()
    {
        Logger.LogCommand(nameof(DowngradeBombCommand));
        
        switch (_bombState)
        {
            case 3:
                BombImage = Constants.EnabledUpgrade[3];
                _bombState = 2;
                break;
            case 2:
                BombImage = Constants.EnabledUpgrade[2];
                _bombState = 1;
                break;
            case 1:
                BombImage = Constants.DisabledUpgrade[1];
                _bombState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeQuiver()
    {
        Logger.LogCommand(nameof(UpgradeQuiverCommand));
        
        switch (_quiverState)
        {
            case 0:
                QuiverImage = Constants.EnabledUpgrade[13];
                _quiverState = 1;
                break;
            case 1:
                QuiverImage = Constants.EnabledUpgrade[14];
                _quiverState = 2;
                break;
            case 2:
                QuiverImage = Constants.EnabledUpgrade[15];
                _quiverState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeQuiver()
    {
        Logger.LogCommand(nameof(DowngradeQuiverCommand));
        
        switch (_quiverState)
        {
            case 3:
                QuiverImage = Constants.EnabledUpgrade[14];
                _quiverState = 2;
                break;
            case 2:
                QuiverImage = Constants.EnabledUpgrade[13];
                _quiverState = 1;
                break;
            case 1:
                QuiverImage = Constants.DisabledUpgrade[5];
                _quiverState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeBullet()
    {
        Logger.LogCommand(nameof(UpgradeBulletCommand));
        
        switch (_bulletState)
        {
            case 0:
                BulletImage = Constants.EnabledUpgrade[5];
                _bulletState = 1;
                break;
            case 1:
                BulletImage = Constants.EnabledUpgrade[6];
                _bulletState = 2;
                break;
            case 2:
                BulletImage = Constants.EnabledUpgrade[7];
                _bulletState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeBullet()
    {
        Logger.LogCommand(nameof(DowngradeBulletCommand));
        
        switch (_bulletState)
        {
            case 3:
                BulletImage = Constants.EnabledUpgrade[6];
                _bulletState = 2;
                break;
            case 2:
                BulletImage = Constants.EnabledUpgrade[5];
                _bulletState = 1;
                break;
            case 1:
                BulletImage = Constants.DisabledUpgrade[2];
                _bulletState = 0;
                break;
        }
    }
    #endregion
    #region Other
    [RelayCommand]
    public void IncreaseGsCount()
    {
        Logger.LogCommand(nameof(IncreaseGsCountCommand));
        
        // Cap at 100
        if (GsTokens == 100)
        {
            GsTokens = 100;
        }
        else
        {
            GsTokens++;
        }
        
        Logger.LogInteraction(nameof(GsTokens));
    }

    [RelayCommand]
    public void DecreaseGsCount()
    {
        Logger.LogCommand(nameof(DecreaseGsCountCommand));
        
        // Cap at 0
        if (GsTokens == 0)
        {
            GsTokens = 0;
        }
        else
        {
            GsTokens--;
        }
        
        Logger.LogInteraction(nameof(GsTokens));
    }

    [RelayCommand]
    public void ToggleGerudoToken()
    {
        Logger.LogCommand(nameof(ToggleGerudoTokenCommand));
        
        GerudoTokenImage = GetState(GerudoTokenImage)
            ? Constants.DisabledOther[0]
            : Constants.EnabledOther[0];
        
        Logger.LogInteraction(nameof(GerudoTokenImage));
    }

    [RelayCommand]
    public void ToggleShard()
    {
        Logger.LogCommand(nameof(ToggleShardCommand));
        
        ShardImage = GetState(ShardImage)
            ? Constants.DisabledOther[1]
            : Constants.EnabledOther[1];
        
        Logger.LogInteraction(nameof(ShardImage));
    }
    #endregion
    #region Songs
    [RelayCommand]
    public void ToggleZeldasLullaby()
    {
        Logger.LogCommand(nameof(ToggleZeldasLullabyCommand));
        
        LullabyImage = GetState(LullabyImage)
            ? Constants.DisabledSongs[0]
            : Constants.EnabledSongs[0];
        
        Logger.LogInteraction(nameof(LullabyImage));
    }

    [RelayCommand]
    public void ToggleEponasSong()
    {
        Logger.LogCommand(nameof(ToggleEponasSongCommand));
        
        EponaImage = GetState(EponaImage)
            ? Constants.DisabledSongs[1]
            : Constants.EnabledSongs[1];
        
        Logger.LogInteraction(nameof(EponaImage));
    }

    [RelayCommand]
    public void ToggleSariasSong()
    {
        Logger.LogCommand(nameof(ToggleSariasSongCommand));
        
        SariaImage = GetState(SariaImage)
            ? Constants.DisabledSongs[2]
            : Constants.EnabledSongs[2];
        
        Logger.LogInteraction(nameof(SariaImage));
    }

    [RelayCommand]
    public void ToggleSongOfStorms()
    {
        Logger.LogCommand(nameof(ToggleSongOfStormsCommand));
        
        SosImage = GetState(SosImage)
            ? Constants.DisabledSongs[3]
            : Constants.EnabledSongs[3];
        
        Logger.LogInteraction(nameof(SosImage));
    }

    [RelayCommand]
    public void ToggleSunsSong()
    {
        Logger.LogCommand(nameof(ToggleSunsSongCommand));
        
        SunsImage = GetState(SunsImage)
            ? Constants.DisabledSongs[4]
            : Constants.EnabledSongs[4];
        
        Logger.LogInteraction(nameof(SunsImage));
    }

    [RelayCommand]
    public void ToggleSongOfTime()
    {
        Logger.LogCommand(nameof(ToggleSongOfTimeCommand));
        
        SotImage = GetState(SotImage)
            ? Constants.DisabledSongs[5]
            : Constants.EnabledSongs[5];
        
        Logger.LogInteraction(nameof(SotImage));
    }

    [RelayCommand]
    public void ToggleMinuet()
    {
        Logger.LogCommand(nameof(ToggleMinuetCommand));
        
        MinuetImage = GetState(MinuetImage)
            ? Constants.DisabledSongs[6]
            : Constants.EnabledSongs[6];
        
        Logger.LogInteraction(nameof(MinuetImage));
    }

    [RelayCommand]
    public void ToggleBolero()
    {
        Logger.LogCommand(nameof(ToggleBoleroCommand));
        
        BoleroImage = GetState(BoleroImage)
            ? Constants.DisabledSongs[7]
            : Constants.EnabledSongs[7];
        
        Logger.LogInteraction(nameof(BoleroImage));
    }

    [RelayCommand]
    public void ToggleSerenade()
    {
        Logger.LogCommand(nameof(ToggleSerenadeCommand));
        
        SerenadeImage = GetState(SerenadeImage)
            ? Constants.DisabledSongs[8]
            : Constants.EnabledSongs[8];
        
        Logger.LogInteraction(nameof(SerenadeImage));
    }

    [RelayCommand]
    public void ToggleRequiem()
    {
        Logger.LogCommand(nameof(ToggleRequiemCommand));
        
        RequiemImage = GetState(RequiemImage)
            ? Constants.DisabledSongs[9]
            : Constants.EnabledSongs[9];
        
        Logger.LogInteraction(nameof(RequiemImage));
    }

    [RelayCommand]
    public void ToggleNocturne()
    {
        Logger.LogCommand(nameof(ToggleNocturneCommand));
        
        NocturneImage = GetState(NocturneImage)
            ? Constants.DisabledSongs[10]
            : Constants.EnabledSongs[10];
        
        Logger.LogInteraction(nameof(NocturneImage));
    }

    [RelayCommand]
    public void TogglePrelude()
    {
        Logger.LogCommand(nameof(TogglePreludeCommand));
        
        PreludeImage = GetState(PreludeImage)
            ? Constants.DisabledSongs[11]
            : Constants.EnabledSongs[11];
        
        Logger.LogInteraction(nameof(PreludeImage));
    }
    #endregion
    #region General Items
    [RelayCommand]
    public void ToggleStick()
    {
        Logger.LogCommand(nameof(ToggleStickCommand));
        
        StickImage = GetState(StickImage)
            ? Constants.DisabledItems[5]
            : Constants.EnabledItems[5];
        
        Logger.LogInteraction(nameof(StickImage));
    }

    [RelayCommand]
    public void ToggleNut()
    {
        Logger.LogCommand(nameof(ToggleNutCommand));
        
        NutImage = GetState(NutImage)
            ? Constants.DisabledItems[4]
            : Constants.EnabledItems[4];
        
        Logger.LogInteraction(nameof(NutImage));
    }

    [RelayCommand]
    public void ToggleSlingshot()
    {
        Logger.LogCommand(nameof(ToggleSlingshotCommand));
        
        SlingshotImage = GetState(SlingshotImage)
            ? Constants.DisabledItems[8]
            : Constants.EnabledItems[8];

        Logger.LogInteraction(nameof(SlingshotImage));
    }

    [RelayCommand]
    public void ToggleDins()
    {
        Logger.LogCommand(nameof(ToggleDinsCommand));
        
        DinsFireImage = GetState(DinsFireImage)
            ? Constants.DisabledItems[6]
            : Constants.EnabledItems[6];
        
        Logger.LogInteraction(nameof(DinsFireImage));
    }

    [RelayCommand]
    public void ToggleBomb()
    {
        Logger.LogCommand(nameof(ToggleBombCommand));
        
        BombItemImage = GetState(BombItemImage)
            ? Constants.DisabledItems[0]
            : Constants.EnabledItems[0];
        
        Logger.LogInteraction(nameof(BombItemImage));
    }

    [RelayCommand]
    public void ToggleBombchu()
    {
        Logger.LogCommand(nameof(ToggleBombchuCommand));
        
        BombchuImage = GetState(BombchuImage)
            ? Constants.DisabledItems[1]
            : Constants.EnabledItems[1];
        
        Logger.LogInteraction(nameof(BombchuImage));
    }

    [RelayCommand]
    public void IncreaseChildTrade()
    {
        Logger.LogCommand(nameof(IncreaseChildTradeCommand));
        
        if (_childTradeStage > 5)
        {
            _childTradeStage = 5;
        }

        ChildTradeItemImage = _childTradeStage switch
        {
            0 => Constants.ChildTradingSequence[1],
            1 => Constants.ChildTradingSequence[2],
            2 => Constants.ChildTradingSequence[3],
            3 => Constants.ChildTradingSequence[4],
            4 => Constants.ChildTradingSequence[5],
            _ => ChildTradeItemImage
        };

        if (_childTradeStage >= 5)
        {
            _childTradeStage = 5;
        }
        else
        {
            _childTradeStage++;
        }
        
        Logger.LogInteraction(nameof(ChildTradeItemImage));
    }

    [RelayCommand]
    public void DecreaseChildTrade()
    {
        Logger.LogCommand(nameof(DecreaseChildTradeCommand));
        
        if (_childTradeStage < 0)
        {
            _childTradeStage = 0;
        }

        ChildTradeItemImage = _childTradeStage switch
        {
            5 => Constants.ChildTradingSequence[4],
            4 => Constants.ChildTradingSequence[3],
            3 => Constants.ChildTradingSequence[2],
            2 => Constants.ChildTradingSequence[1],
            1 => Constants.ChildTradingSequence[0],
            _ => ChildTradeItemImage
        };

        if (_childTradeStage <= 0)
        {
            _childTradeStage = 0;
        }
        else
        {
            _childTradeStage--;
        }
        
        Logger.LogInteraction(nameof(ChildTradeItemImage));
    }

    [RelayCommand]
    public void ToggleFarore()
    {
        Logger.LogCommand(nameof(ToggleFaroreCommand));
        
        FaroresWindImage = GetState(FaroresWindImage)
            ? Constants.DisabledItems[9]
            : Constants.EnabledItems[9];
        
        Logger.LogInteraction(nameof(FaroresWindImage));
    }

    [RelayCommand]
    public void ToggleBoomerang()
    {
        Logger.LogCommand(nameof(ToggleBoomerangCommand));
        
        BoomerangImage = GetState(BoomerangImage)
            ? Constants.DisabledItems[2]
            : Constants.EnabledItems[2];
        
        Logger.LogInteraction(nameof(BoomerangImage));
    }

    [RelayCommand]
    public void IncreaseHookshot()
    {
        Logger.LogCommand(nameof(IncreaseHookshotCommand));
        
        if (_hookState > 2)
        {
            _hookState = 2;
        }

        HookshotImage = _hookState switch
        {
            0 => Constants.EnabledItems[11],
            1 => Constants.EnabledItems[14],
            _ => HookshotImage
        };

        if (_hookState >= 2)
        {
            _hookState = 2;
        }
        else
        {
            _hookState++;   
        }
        
        Logger.LogInteraction(nameof(HookshotImage));
    }

    [RelayCommand]
    public void DecreaseHookshot()
    {
        Logger.LogCommand(nameof(DecreaseHookshotCommand));
        
        if (_hookState < 0)
        {
            _hookState = 0;
        }

        HookshotImage = _hookState switch
        {
            2 => Constants.EnabledItems[11],
            1 => Constants.DisabledItems[11],
            _ => HookshotImage
        };

        if (_hookState <= 0)
        {
            _hookState = 0;
        }
        else
        {
            _hookState--;
        }
        
        Logger.LogInteraction(nameof(HookshotImage));
    }

    [RelayCommand]
    public void IncreaseAdultTrade()
    {
        Logger.LogCommand(nameof(IncreaseAdultTradeCommand));
        
        if (_adultTradeStage > 12)
        {
            _adultTradeStage = 12;
        }

        AdultTradeItemImage = _adultTradeStage switch
        {
            0 => Constants.AdultTradingSequence[1],
            1 => Constants.AdultTradingSequence[2],
            2 => Constants.AdultTradingSequence[3],
            3 => Constants.AdultTradingSequence[4],
            4 => Constants.AdultTradingSequence[5],
            5 => Constants.AdultTradingSequence[6],
            6 => Constants.AdultTradingSequence[7],
            7 => Constants.AdultTradingSequence[8],
            8 => Constants.AdultTradingSequence[9],
            9 => Constants.AdultTradingSequence[10],
            10 => Constants.AdultTradingSequence[11],
            11 => Constants.AdultTradingSequence[12],
            _ => AdultTradeItemImage
        };

        if (_adultTradeStage >= 12)
        {
            _adultTradeStage = 12;
        }
        else
        {
            _adultTradeStage++;   
        }
        
        Logger.LogInteraction(nameof(AdultTradeItemImage));
    }

    [RelayCommand]
    public void DecreaseAdultTrade()
    {
        Logger.LogCommand(nameof(DecreaseAdultTradeCommand));
        
        if (_adultTradeStage < 0)
        {
            _adultTradeStage = 0;
        }

        AdultTradeItemImage = _adultTradeStage switch
        {
            12 => Constants.AdultTradingSequence[11],
            11 => Constants.AdultTradingSequence[10],
            10 => Constants.AdultTradingSequence[9],
            9 => Constants.AdultTradingSequence[8],
            8 => Constants.AdultTradingSequence[7],
            7 => Constants.AdultTradingSequence[6],
            6 => Constants.AdultTradingSequence[5],
            5 => Constants.AdultTradingSequence[4],
            4 => Constants.AdultTradingSequence[3],
            3 => Constants.AdultTradingSequence[2],
            2 => Constants.AdultTradingSequence[1],
            1 => Constants.AdultTradingSequence[0],
            _ => AdultTradeItemImage
        };

        if (_adultTradeStage <= 0)
        {
            _adultTradeStage = 0;
        }
        else
        {
            _adultTradeStage--;   
        }
        
        Logger.LogInteraction(nameof(AdultTradeItemImage));
    }

    [RelayCommand]
    public void ToggleNayru()
    {
        Logger.LogCommand(nameof(ToggleNayruCommand));
        
        NayrusLoveImage = GetState(NayrusLoveImage)
            ? Constants.DisabledItems[16]
            : Constants.EnabledItems[17];
        
        Logger.LogInteraction(nameof(NayrusLoveImage));
    }

    [RelayCommand]
    public void ToggleLens()
    {
        Logger.LogCommand(nameof(ToggleLensCommand));
        
        LensImage = GetState(LensImage)
            ? Constants.DisabledItems[13]
            : Constants.EnabledItems[13];
        
        Logger.LogInteraction(nameof(LensImage));
    }

    [RelayCommand]
    public void ToggleHammer()
    {
        Logger.LogCommand(nameof(ToggleHammerCommand));
        
        MegatonHammerImage = GetState(MegatonHammerImage)
            ? Constants.DisabledItems[15]
            : Constants.EnabledItems[16];
        
        Logger.LogInteraction(nameof(MegatonHammerImage));
    }

    [RelayCommand]
    public void ToggleBow()
    {
        Logger.LogCommand(nameof(ToggleBowCommand));
        
        BowImage = GetState(BowImage)
            ? Constants.DisabledItems[7]
            : Constants.EnabledItems[7];
        
        Logger.LogInteraction(nameof(BowImage));
    }

    [RelayCommand]
    public void ToggleBeans()
    {
        Logger.LogCommand(nameof(ToggleBeansCommand));
        
        MagicBeansImage = GetState(MagicBeansImage)
            ? Constants.DisabledItems[17]
            : Constants.EnabledItems[18];
        
        Logger.LogInteraction(nameof(MagicBeansImage));
    }

    [RelayCommand]
    public void ToggleFireArrow()
    {
        Logger.LogCommand(nameof(ToggleFireArrowCommand));
        
        FireArrowImage = GetState(FireArrowImage)
            ? Constants.DisabledItems[10]
            : Constants.EnabledItems[10];
        
        Logger.LogInteraction(nameof(FireArrowImage));
    }

    [RelayCommand]
    public void ToggleIceArrow()
    {
        Logger.LogCommand(nameof(ToggleIceArrowCommand));
        
        IceArrowImage = GetState(IceArrowImage)
            ? Constants.DisabledItems[12]
            : Constants.EnabledItems[12];
        
        Logger.LogInteraction(nameof(IceArrowImage));
    }

    [RelayCommand]
    public void ToggleLightArrow()
    {
        Logger.LogCommand(nameof(ToggleLightArrowCommand));
        
        LightArrowImage = GetState(LightArrowImage)
            ? Constants.DisabledItems[14]
            : Constants.EnabledItems[15];
        
        Logger.LogInteraction(nameof(LightArrowImage));
    }

    [RelayCommand]
    public void ToggleBottle(string bottleNumber)
    {
        Logger.LogCommand(nameof(ToggleBottleCommand));
        
        var bottleNum = int.Parse(bottleNumber);
        
        switch (bottleNum)
        {
            case 1:
                Bottle1Image = GetState(Bottle1Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                
                Logger.LogInteraction(nameof(Bottle1Image));
                break;
            case 2:
                Bottle2Image = GetState(Bottle2Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                
                Logger.LogInteraction(nameof(Bottle2Image));
                break;
            case 3:
                Bottle3Image = GetState(Bottle3Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                
                Logger.LogInteraction(nameof(Bottle3Image));
                break;
            case 4:
                Bottle4Image = GetState(Bottle4Image)
                    ? Constants.DisabledItems[3] 
                    : Constants.EnabledItems[3];
                
                Logger.LogInteraction(nameof(Bottle4Image));
                break;
        }
    }
    #endregion
    #region Utils
    private void PrepareData()
    {
        _trackerData = new TrackerData
        {
            TradeData = new TradeData
            {
                TradeStageChild = _childTradeStage,
                TradeStageAdult = _adultTradeStage
            },
            UpgradeData = new UpgradeData
            {
                BombState = _bombState,
                BulletState = _bulletState,
                HookState = _hookState,
                OcarinaState = _ocarinaState,
                QuiverState = _quiverState,
                ScaleState = _scaleState,
                StrengthState = _strengthState
            },
            LocationData = new LocationData
            {
                Location1 = _location1Idx,
                Location2 = _location2Idx,
                Location3 = _location3Idx,
                Location4 = _location4Idx,
                Location5 = _location5Idx,
                Location6 = _location6Idx,
                Location7 = _location7Idx,
                Location8 = _location8Idx,
                Location9 = _location9Idx
            },
            UiData = new UiRelevantData
            {
                Location1String = Location1,
                Location2String = Location2,
                Location3String = Location3,
                Location4String = Location4,
                Location5String = Location5,
                Location6String = Location6,
                Location7String = Location7,
                Location8String = Location8,
                Location9String = Location9,
                
                EmeraldString = KokiriEmeraldImage,
                RubyString = GoronRubyImage,
                SapphireString = ZoraSapphireImage,
                LightMedallionString = LightMedallionImage,
                ForestMedallionString = ForestMedallionImage,
                FireMedallionString = FireMedallionImage,
                WaterMedallionString = WaterMedallionImage,
                SpiritMedallionString = SpiritMedallionImage,
                ShadowMedallionString = ShadowMedallionImage,
                
                KokiriSwordString = KokiriSwordImage,
                MasterSwordString = MasterSwordImage,
                BiggoronSwordString = BiggoronSwordImage,
                DekuShieldString = DekuShieldImage,
                HylianShieldString = HylianShieldImage,
                MirrorShieldString = MirrorShieldImage,
                GoronTunicString = GoronTunicImage,
                ZoraTunicString = ZoraTunicImage,
                IronBootsString = IronBootsImage,
                HoverBootsString = HoverBootsImage,
                
                OcarinaString = OcarinaImage,
                ScaleString = ScaleImage,
                StrengthString = StrengthImage,
                BombString = BombImage,
                QuiverString = QuiverImage,
                BulletString = BulletImage,
                
                GsTokenCount = GsTokens,
                GerudoTokenString = GerudoTokenImage,
                ShardString = ShardImage,
                
                LullabyString = LullabyImage,
                EponaString = EponaImage,
                SariaString = SariaImage,
                StormsString = SosImage,
                SunsString = SunsImage,
                TimeString = SotImage,
                MinuetString = MinuetImage,
                BoleroString = BoleroImage,
                SerenadeString = SerenadeImage,
                RequiemString = RequiemImage,
                NocturneString = NocturneImage,
                PreludeString = PreludeImage,
                
                StickString = StickImage,
                NutString = NutImage,
                SlingshotString = SlingshotImage,
                DinsString = DinsFireImage,
                BombItemString = BombItemImage,
                BombchuString = BombchuImage,
                ChildTradeString = ChildTradeItemImage,
                AdultTradeString = AdultTradeItemImage,
                FaroresString = FaroresWindImage,
                BoomerangString = BoomerangImage,
                HookshotString = HookshotImage,
                NayrusString = NayrusLoveImage,
                LensString = LensImage,
                HammerString = MegatonHammerImage,
                BowString = BowImage,
                BeanString = MagicBeansImage,
                FireArrowString = FireArrowImage,
                IceArrowString = IceArrowImage,
                LightArrowString = LightArrowImage,
                Bottle1String = Bottle1Image,
                Bottle2String = Bottle2Image,
                Bottle3String = Bottle3Image,
                Bottle4String = Bottle4Image
            }
        };
    }

    [RelayCommand]
    public void WriteData()
    {
        Logger.LogCommand(nameof(WriteDataCommand));

        PrepareData();
        DataWriter.WriteData(_trackerData);
    }

    [RelayCommand]
    public void ReadData()
    {
        Logger.LogCommand(nameof(ReadDataCommand));
        
        try
        {
            _trackerData = DataReader.ReadData();
            SetTrackerUi();
            SetTrackerCtrl();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Can't read trackerState! Check if a trackerState file exists.");
            Logger.LogException(ex);
        }
    }

    private void SetTrackerUi()
    {
        Location1 = _trackerData.UiData.Location1String;
        Location2 = _trackerData.UiData.Location2String;
        Location3 = _trackerData.UiData.Location3String;
        Location4 = _trackerData.UiData.Location4String;
        Location5 = _trackerData.UiData.Location5String;
        Location6 = _trackerData.UiData.Location6String;
        Location7 = _trackerData.UiData.Location7String;
        Location8 = _trackerData.UiData.Location8String;
        Location9 = _trackerData.UiData.Location9String;

        KokiriEmeraldImage = _trackerData.UiData.EmeraldString;
        GoronRubyImage = _trackerData.UiData.RubyString;
        ZoraSapphireImage = _trackerData.UiData.SapphireString;
        LightMedallionImage = _trackerData.UiData.LightMedallionString;
        ForestMedallionImage = _trackerData.UiData.ForestMedallionString;
        FireMedallionImage = _trackerData.UiData.FireMedallionString;
        WaterMedallionImage = _trackerData.UiData.WaterMedallionString;
        SpiritMedallionImage = _trackerData.UiData.SpiritMedallionString;
        ShadowMedallionImage = _trackerData.UiData.ShadowMedallionString;

        KokiriSwordImage = _trackerData.UiData.KokiriSwordString;
        MasterSwordImage = _trackerData.UiData.MasterSwordString;
        BiggoronSwordImage = _trackerData.UiData.BiggoronSwordString;
        DekuShieldImage = _trackerData.UiData.DekuShieldString;
        HylianShieldImage = _trackerData.UiData.HylianShieldString;
        MirrorShieldImage = _trackerData.UiData.MirrorShieldString;
        IronBootsImage = _trackerData.UiData.IronBootsString;
        HoverBootsImage = _trackerData.UiData.HoverBootsString;
        GoronTunicImage = _trackerData.UiData.GoronTunicString;
        ZoraTunicImage = _trackerData.UiData.ZoraTunicString;

        OcarinaImage = _trackerData.UiData.OcarinaString;
        ScaleImage = _trackerData.UiData.ScaleString;
        StrengthImage = _trackerData.UiData.StrengthString;
        BombImage = _trackerData.UiData.BombString;
        QuiverImage = _trackerData.UiData.QuiverString;
        BulletImage = _trackerData.UiData.BulletString;

        GsTokens = _trackerData.UiData.GsTokenCount;
        GerudoTokenImage = _trackerData.UiData.GerudoTokenString;
        ShardImage = _trackerData.UiData.ShardString;
        
        LullabyImage = _trackerData.UiData.LullabyString;
        EponaImage = _trackerData.UiData.EponaString;
        SariaImage = _trackerData.UiData.SariaString;
        SosImage = _trackerData.UiData.StormsString;
        SunsImage = _trackerData.UiData.SunsString;
        SotImage = _trackerData.UiData.TimeString;
        MinuetImage = _trackerData.UiData.MinuetString;
        BoleroImage = _trackerData.UiData.BoleroString;
        SerenadeImage = _trackerData.UiData.SerenadeString;
        RequiemImage = _trackerData.UiData.RequiemString;
        NocturneImage = _trackerData.UiData.NocturneString;
        PreludeImage = _trackerData.UiData.PreludeString;
        
        StickImage = _trackerData.UiData.StickString;
        NutImage = _trackerData.UiData.NutString;
        SlingshotImage = _trackerData.UiData.SlingshotString;
        DinsFireImage = _trackerData.UiData.DinsString;
        BombItemImage = _trackerData.UiData.BombItemString;
        BombchuImage = _trackerData.UiData.BombchuString;
        ChildTradeItemImage = _trackerData.UiData.ChildTradeString;
        AdultTradeItemImage = _trackerData.UiData.AdultTradeString;
        FaroresWindImage = _trackerData.UiData.FaroresString;
        BoomerangImage = _trackerData.UiData.BoomerangString;
        HookshotImage = _trackerData.UiData.HookshotString;
        NayrusLoveImage = _trackerData.UiData.NayrusString;
        LensImage = _trackerData.UiData.LensString;
        MegatonHammerImage = _trackerData.UiData.HammerString;
        BowImage = _trackerData.UiData.BowString;
        MagicBeansImage = _trackerData.UiData.BeanString;
        FireArrowImage = _trackerData.UiData.FireArrowString;
        IceArrowImage = _trackerData.UiData.IceArrowString;
        LightArrowImage = _trackerData.UiData.LightArrowString;
        Bottle1Image = _trackerData.UiData.Bottle1String;
        Bottle2Image = _trackerData.UiData.Bottle2String;
        Bottle3Image = _trackerData.UiData.Bottle3String;
        Bottle4Image = _trackerData.UiData.Bottle4String;
    }

    private void SetTrackerCtrl()
    {
        _ocarinaState = _trackerData.UpgradeData.OcarinaState;
        _scaleState = _trackerData.UpgradeData.ScaleState;
        _strengthState = _trackerData.UpgradeData.StrengthState;
        _bombState = _trackerData.UpgradeData.BombState;
        _quiverState = _trackerData.UpgradeData.QuiverState;
        _bulletState = _trackerData.UpgradeData.BulletState;
        _hookState = _trackerData.UpgradeData.HookState;

        _location1Idx = _trackerData.LocationData.Location1;
        _location2Idx = _trackerData.LocationData.Location2;
        _location3Idx = _trackerData.LocationData.Location3;
        _location4Idx = _trackerData.LocationData.Location4;
        _location5Idx = _trackerData.LocationData.Location5;
        _location6Idx = _trackerData.LocationData.Location6;
        _location7Idx = _trackerData.LocationData.Location7;
        _location8Idx = _trackerData.LocationData.Location8;
        _location9Idx = _trackerData.LocationData.Location9;

        _childTradeStage = _trackerData.TradeData.TradeStageChild;
        _adultTradeStage = _trackerData.TradeData.TradeStageAdult;
    }

    [RelayCommand]
    public void DeleteData()
    {
        Logger.LogCommand(nameof(DeleteDataCommand));
        
        if (File.Exists($"./trackerState"))
        {
            File.Delete($"./trackerState");
        }
    }

    private static bool GetState(string spriteName)
    {
        // Returns true if the sprite is active
        // Or false is inactive
        return !spriteName.Contains("_Disabled");
    }
    #endregion
}