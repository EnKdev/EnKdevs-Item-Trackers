using System;
using System.Reflection.Metadata;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Semver;

namespace EnKdevsOcarinaOfTimeTracker;

public partial class MainWindowViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string _title;

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

    public MainWindowViewModel()
    {
        Title = Constants.AppTitle;

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
}