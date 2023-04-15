using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnKdevsOcarinaOfTimeTracker.Data;
using EnKdevsOcarinaOfTimeTracker.Models;
using Semver;

namespace EnKdevsOcarinaOfTimeTracker;

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
    private bool _gotEmerald;
    private bool _gotRuby;
    private bool _gotSapphire;

    private bool _gotLightMed;
    private bool _gotForestMed;
    private bool _gotFireMed;
    private bool _gotWaterMed;
    private bool _gotShadowMed;
    private bool _gotSpiritMed;

    private bool _gotKokiriSword;
    private bool _gotMasterSword;
    private bool _gotBiggoronSword;

    private bool _gotDekuShield;
    private bool _gotHylianShield;
    private bool _gotMirrorShield;

    private bool _gotGoronTunic;
    private bool _gotZoraTunic;

    private bool _gotIronBoots;
    private bool _gotHoverBoots;

    private int _ocarinaState;
    private int _scaleState;
    private int _strengthState;
    private int _bombState;
    private int _quiverState;
    private int _bulletState;

    private bool _gotGerudoToken;
    private bool _gotShard;

    private bool _gotLullaby;
    private bool _gotEpona;
    private bool _gotSaria;
    private bool _gotStorms;
    private bool _gotSuns;
    private bool _gotTime;
    private bool _gotMinuet;
    private bool _gotBolero;
    private bool _gotSerenade;
    private bool _gotRequiem;
    private bool _gotNocturne;
    private bool _gotPrelude;

    private List<string> _acquiredItems;

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

    private TrackerData _trackerData;

    public MainWindowViewModel()
    {
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

        _acquiredItems = new List<string>();

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
    public void ActivateKokiriEmerald()
    {
        KokiriEmeraldImage = Constants.EnabledStones[0];
        _gotEmerald = true;
    }

    [RelayCommand]
    public void DeactivateKokiriEmerald()
    {
        KokiriEmeraldImage = Constants.DisabledStones[0];
        _gotEmerald = false;
    }

    [RelayCommand]
    public void SetEmeraldLocation()
    {
        if (_location1Idx > 9)
        {
            // Reset back to 0
            _location1Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location1 = _location1Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location1Idx++;
        });
    }

    [RelayCommand]
    public void ActivateGoronRuby()
    {
        GoronRubyImage = Constants.EnabledStones[1];
        _gotRuby = true;
    }

    [RelayCommand]
    public void DeactivateGoronRuby()
    {
        GoronRubyImage = Constants.DisabledStones[1];
        _gotRuby = false;
    }

    [RelayCommand]
    public void SetRubyLocation()
    {
        if (_location2Idx > 9)
        {
            // Reset back to 0
            _location2Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location2 = _location2Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location2Idx++;
        });
    }

    [RelayCommand]
    public void ActivateZoraSapphire()
    {
        ZoraSapphireImage = Constants.EnabledStones[2];
        _gotSapphire = true;
    }

    [RelayCommand]
    public void DeactivateZoraSapphire()
    {
        ZoraSapphireImage = Constants.DisabledStones[2];
        _gotSapphire = false;
    }

    [RelayCommand]
    public void SetSapphireLocation()
    {
        if (_location3Idx > 9)
        {
            // Reset back to 0
            _location3Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location3 = _location3Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location3Idx++;
        });
    }

    [RelayCommand]
    public void ActivateLightMedallion()
    {
        LightMedallionImage = Constants.EnabledMeds[0];
        _gotLightMed = true;
    }

    [RelayCommand]
    public void DeactivateLightMedallion()
    {
        LightMedallionImage = Constants.DisabledMeds[0];
        _gotLightMed = false;
    }

    [RelayCommand]
    public void SetLightLocation()
    {
        if (_location4Idx > 9)
        {
            // Reset back to 0
            _location4Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location4 = _location4Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location4Idx++;
        });
    }

    [RelayCommand]
    public void ActivateForestMedallion()
    {
        ForestMedallionImage = Constants.EnabledMeds[1];
        _gotForestMed = true;
    }

    [RelayCommand]
    public void DeactivateForestMedallion()
    {
        ForestMedallionImage = Constants.DisabledMeds[1];
        _gotForestMed = false;
    }

    [RelayCommand]
    public void SetForestLocation()
    {
        if (_location5Idx > 9)
        {
            // Reset back to 0
            _location5Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location5 = _location5Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location5Idx++;
        });
    }

    [RelayCommand]
    public void ActivateFireMedallion()
    {
        FireMedallionImage = Constants.EnabledMeds[2];
        _gotFireMed = true;
    }

    [RelayCommand]
    public void DeactivateFireMedallion()
    {
        FireMedallionImage = Constants.DisabledMeds[2];
        _gotFireMed = false;
    }

    [RelayCommand]
    public void SetFireLocation()
    {
        if (_location6Idx > 9)
        {
            // Reset back to 0
            _location6Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location6 = _location6Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location6Idx++;
        });
    }

    [RelayCommand]
    public void ActivateWaterMedallion()
    {
        WaterMedallionImage = Constants.EnabledMeds[3];
        _gotWaterMed = true;
    }

    [RelayCommand]
    public void DeactivateWaterMedallion()
    {
        WaterMedallionImage = Constants.DisabledMeds[3];
        _gotWaterMed = false;
    }

    [RelayCommand]
    public void SetWaterLocation()
    {
        if (_location7Idx > 9)
        {
            // Reset back to 0
            _location7Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location7 = _location7Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location7Idx++;
        });
    }

    [RelayCommand]
    public void ActivateShadowMedallion()
    {
        ShadowMedallionImage = Constants.EnabledMeds[4];
        _gotShadowMed = true;
    }

    [RelayCommand]
    public void DeactivateShadowMedallion()
    {
        ShadowMedallionImage = Constants.DisabledMeds[4];
        _gotShadowMed = false;
    }

    [RelayCommand]
    public void SetShadowLocation()
    {
        if (_location8Idx > 9)
        {
            // Reset back to 0
            _location8Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location8 = _location8Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location8Idx++;
        });
    }

    [RelayCommand]
    public void ActivateSpiritMedallion()
    {
        SpiritMedallionImage = Constants.EnabledMeds[5];
        _gotSpiritMed = true;
    }

    [RelayCommand]
    public void DeactivateSpiritMedallion()
    {
        SpiritMedallionImage = Constants.DisabledMeds[5];
        _gotSpiritMed = false;
    }

    [RelayCommand]
    public void SetSpiritLocation()
    {
        if (_location9Idx > 9)
        {
            // Reset back to 0
            _location9Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            Location9 = _location9Idx switch
            {
                0 => Constants.DungeonLocations[0], // ""
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

            _location9Idx++;
        });
    }

    #endregion
    #region Equip Items (Tunics, Swords, Shields, Boots)
    #region Swords
    [RelayCommand]
    public void ActivateKokiriSword()
    {
        KokiriSwordImage = Constants.EnabledEquip[0];
        _gotKokiriSword = true;
    }

    [RelayCommand]
    public void DeactivateKokiriSword()
    {
        KokiriSwordImage = Constants.DisabledEquip[0];
        _gotKokiriSword = false;
    }

    [RelayCommand]
    public void ActivateMasterSword()
    {
        MasterSwordImage = Constants.EnabledEquip[1];
        _gotMasterSword = true;
    }

    [RelayCommand]
    public void DeactivateMasterSword()
    {
        MasterSwordImage = Constants.DisabledEquip[1];
        _gotMasterSword = false;
    }

    [RelayCommand]
    public void ActivateBiggoronSword()
    {
        BiggoronSwordImage = Constants.EnabledEquip[2];
        _gotBiggoronSword = true;
    }

    [RelayCommand]
    public void DeactivateBiggoronSword()
    {
        BiggoronSwordImage = Constants.DisabledEquip[2];
        _gotBiggoronSword = false;
    }
    #endregion
    #region Shields
    [RelayCommand]
    public void ActivateDekuShield()
    {
        DekuShieldImage = Constants.EnabledEquip[3];
        _gotDekuShield = true;
    }

    [RelayCommand]
    public void DeactivateDekuShield()
    {
        DekuShieldImage = Constants.DisabledEquip[3];
        _gotDekuShield = false;
    }

    [RelayCommand]
    public void ActivateHylianShield()
    {
        HylianShieldImage = Constants.EnabledEquip[4];
        _gotHylianShield = true;
    }

    [RelayCommand]
    public void DeactivateHylianShield()
    {
        HylianShieldImage = Constants.DisabledEquip[4];
        _gotHylianShield = false;
    }

    [RelayCommand]
    public void ActivateMirrorShield()
    {
        MirrorShieldImage = Constants.EnabledEquip[5];
        _gotMirrorShield = true;
    }

    [RelayCommand]
    public void DeactivateMirrorShield()
    {
        MirrorShieldImage = Constants.DisabledEquip[5];
        _gotMirrorShield = false;
    }
    #endregion
    #region Tunics
    [RelayCommand]
    public void ActivateGoronTunic()
    {
        GoronTunicImage = Constants.EnabledEquip[6];
        _gotGoronTunic = true;
    }

    [RelayCommand]
    public void DeactivateGoronTunic()
    {
        GoronTunicImage = Constants.DisabledEquip[6];
        _gotGoronTunic = false;
    }

    [RelayCommand]
    public void ActivateZoraTunic()
    {
        ZoraTunicImage = Constants.EnabledEquip[7];
        _gotZoraTunic = true;
    }

    [RelayCommand]
    public void DeactivateZoraTunic()
    {
        ZoraTunicImage = Constants.DisabledEquip[7];
        _gotZoraTunic = false;
    }
    #endregion
    #region Boots
    [RelayCommand]
    public void ActivateIronBoots()
    {
        IronBootsImage = Constants.EnabledEquip[8];
        _gotIronBoots = true;
    }

    [RelayCommand]
    public void DeactivateIronBoots()
    {
        IronBootsImage = Constants.DisabledEquip[8];
        _gotIronBoots = false;
    }

    [RelayCommand]
    public void ActivateHoverBoots()
    {
        HoverBootsImage = Constants.EnabledEquip[9];
        _gotHoverBoots = true;
    }

    [RelayCommand]
    public void DeactivateHoverBoots()
    {
        HoverBootsImage = Constants.DisabledEquip[9];
        _gotHoverBoots = false;
    }
    #endregion
    #endregion
    #region Upgrades
    [RelayCommand]
    public void UpgradeOcarina()
    {
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
    public void IncreaseGSCount()
    {
        // Cap at 100
        if (GsTokens == 100)
        {
            GsTokens = 100;
        }
        else
        {
            GsTokens++;
        }
    }

    [RelayCommand]
    public void DecreaseGSCount()
    {
        // Cap at 0
        if (GsTokens == 0)
        {
            GsTokens = 0;
        }
        else
        {
            GsTokens--;
        }
    }

    [RelayCommand]
    public void ActivateToken()
    {
        GerudoTokenImage = Constants.EnabledOther[0];
        _gotGerudoToken = true;
    }

    [RelayCommand]
    public void DeactivateToken()
    {
        GerudoTokenImage = Constants.DisabledOther[0];
        _gotGerudoToken = false;
    }

    [RelayCommand]
    public void ActivateShard()
    {
        ShardImage = Constants.EnabledOther[1];
        _gotShard = true;
    }

    [RelayCommand]
    public void DeactivateShard()
    {
        ShardImage = Constants.DisabledOther[1];
        _gotShard = false;
    }
    #endregion
    #region Songs
    [RelayCommand]
    public void ActivateLullaby()
    {
        LullabyImage = Constants.EnabledSongs[0];
        _gotLullaby = true;
    }

    [RelayCommand]
    public void DeactivateLullaby()
    {
        LullabyImage = Constants.DisabledSongs[0];
        _gotLullaby = false;
    }

    [RelayCommand]
    public void ActivateEpona()
    {
        EponaImage = Constants.EnabledSongs[1];
        _gotEpona = true;
    }

    [RelayCommand]
    public void DeactivateEpona()
    {
        EponaImage = Constants.DisabledSongs[1];
        _gotEpona = false;
    }

    [RelayCommand]
    public void ActivateSaria()
    {
        SariaImage = Constants.EnabledSongs[2];
        _gotSaria = true;
    }

    [RelayCommand]
    public void DeactivateSaria()
    {
        SariaImage = Constants.DisabledSongs[2];
        _gotSaria = false;
    }

    [RelayCommand]
    public void ActivateStorms()
    {
        SosImage = Constants.EnabledSongs[3];
        _gotStorms = true;
    }

    [RelayCommand]
    public void DeactivateStorms()
    {
        SosImage = Constants.DisabledSongs[3];
        _gotStorms = false;
    }

    [RelayCommand]
    public void ActivateSun()
    {
        SunsImage = Constants.EnabledSongs[4];
        _gotSuns = true;
    }

    [RelayCommand]
    public void DeactivateSun()
    {
        SunsImage = Constants.DisabledSongs[4];
        _gotSuns = false;
    }

    [RelayCommand]
    public void ActivateTime()
    {
        SotImage = Constants.EnabledSongs[5];
        _gotTime = true;
    }

    [RelayCommand]
    public void DeactivateTime()
    {
        SotImage = Constants.DisabledSongs[5];
        _gotTime = false;
    }

    [RelayCommand]
    public void ActivateMinuet()
    {
        MinuetImage = Constants.EnabledSongs[6];
        _gotMinuet = true;
    }

    [RelayCommand]
    public void DeactivateMinuet()
    {
        MinuetImage = Constants.DisabledSongs[6];
        _gotMinuet = false;
    }

    [RelayCommand]
    public void ActivateBolero()
    {
        BoleroImage = Constants.EnabledSongs[7];
        _gotBolero = true;
    }

    [RelayCommand]
    public void DeactivateBolero()
    {
        BoleroImage = Constants.DisabledSongs[7];
        _gotBolero = false;
    }

    [RelayCommand]
    public void ActivateSerenade()
    {
        SerenadeImage = Constants.EnabledSongs[8];
        _gotSerenade = true;
    }

    [RelayCommand]
    public void DeactivateSerenade()
    {
        SerenadeImage = Constants.DisabledSongs[8];
        _gotSerenade = false;
    }

    [RelayCommand]
    public void ActivateRequiem()
    {
        RequiemImage = Constants.EnabledSongs[9];
        _gotRequiem = true;
    }

    [RelayCommand]
    public void DeactivateRequiem()
    {
        RequiemImage = Constants.DisabledSongs[9];
        _gotRequiem = false;
    }

    [RelayCommand]
    public void ActivateNocturne()
    {
        NocturneImage = Constants.EnabledSongs[10];
        _gotNocturne = true;
    }

    [RelayCommand]
    public void DeactivateNocturne()
    {
        NocturneImage = Constants.DisabledSongs[10];
        _gotNocturne = false;
    }

    [RelayCommand]
    public void ActivatePrelude()
    {
        PreludeImage = Constants.EnabledSongs[11];
        _gotPrelude = true;
    }

    [RelayCommand]
    public void DeactivatePrelude()
    {
        PreludeImage = Constants.DisabledSongs[11];
        _gotPrelude = false;
    }
    #endregion
    #region General Items
    #endregion
    #region Utils
    private void RemoveElementFromAcquiredItemList(string element)
    {
        var targetItem = _acquiredItems.First(x => x == element);

        if (targetItem == string.Empty)
        {
            return;
        }

        _acquiredItems.Remove(targetItem);
    }

    private void PrepareData()
    {
        _trackerData = new TrackerData
        {
            SongData = new SongData
            {
                SongLullaby = _gotLullaby,
                SongEpona = _gotEpona,
                SongSaria = _gotSaria,
                SongStorms = _gotStorms,
                SongSuns = _gotSuns,
                SongTime = _gotTime,
                SongMinuet = _gotMinuet,
                SongBolero = _gotBolero,
                SongSerenade = _gotSerenade,
                SongRequiem = _gotRequiem,
                SongNocturne = _gotNocturne,
                SongPrelude = _gotPrelude
            },
            RewardData = new DungeonRewardData
            {
                GotEmerald = _gotEmerald,
                GotRuby = _gotRuby,
                GotSapphire = _gotSapphire,
                GotLightMedallion = _gotLightMed,
                GotForestMedallion = _gotForestMed,
                GotFireMedallion = _gotFireMed,
                GotWaterMedallion = _gotWaterMed,
                GotSpiritMedallion = _gotSpiritMed,
                GotShadowMedallion = _gotShadowMed
            },
            EquipData = new EquipData
            {
                Boots = new BootsData
                {
                    GotIronBoots = _gotIronBoots,
                    GotHoverBoots = _gotHoverBoots
                },
                Shields = new ShieldData
                {
                    GotDekuShield = _gotDekuShield,
                    GotHylianShield = _gotHylianShield,
                    GotMirrorShield = _gotMirrorShield
                },
                Swords = new SwordData
                {
                    GotKokiriSword = _gotKokiriSword,
                    GotMasterSword = _gotMasterSword,
                    GotBiggoronSword = _gotMasterSword
                },
                Tunics = new TunicData
                {
                    GotGoronTunic = _gotGoronTunic,
                    GotZoraTunic = _gotZoraTunic
                }
            },
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
            AcquiredItems = _acquiredItems
        };
    }

    [RelayCommand]
    public void WriteData()
    {
        PrepareData();
        DataWriter.WriteData(_trackerData);
    }

    [RelayCommand]
    public void ReadData()
    {
        _trackerData = DataReader.ReadData();
        // SetTracker();
    }

    private void SetTracker()
    {
        // Todo...
    }

    [RelayCommand]
    public void DeleteData()
    {
        if (File.Exists($"./trackerState"))
        {
            File.Delete($"./trackerState");
        }
    }
    #endregion
}