using System;
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


    // Backgrounds
    [ObservableProperty]
    private string _itemSongBackground;

    [ObservableProperty] 
    private string _gearBackground;

    public MainWindowViewModel()
    {
        Title = Constants.AppTitle;

        ItemSongBackground = "pack://application:,,,/Images/OoTTrackerItems+Songs.png";
        GearBackground = "pack://application:,,,/Images/OoTTrackerGear.png";

        KokiriEmeraldImage = "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon_Disabled.png";
        GoronRubyImage = "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon_Disabled.png";
        ZoraSapphireImage = "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon_Disabled.png";
        
        LightMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon_Disabled.png";
        ForestMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon_Disabled.png";
        FireMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon_Disabled.png";
        WaterMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon_Disabled.png";
        ShadowMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon_Disabled.png";
        SpiritMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon_Disabled.png";

        KokiriSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon_Disabled.png";
        MasterSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon_Disabled.png";
        BiggoronSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon_Disabled.png";
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon_Disabled.png";
        HylianShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon_Disabled.png";
        MirrorShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon_Disabled.png";
        KokiriTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Tunic_Icon.png";
        GoronTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon_Disabled.png";
        ZoraTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon_Disabled.png";
        KokiriBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Boots_Icon.png";
        IronBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon_Disabled.png";
        HoverBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon_Disabled.png";
    }

    #region Quest Items (Dungeon Rewards)
    
    [RelayCommand]
    public void ActivateKokiriEmerald()
    {
        KokiriEmeraldImage = "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon.png";
    }

    [RelayCommand]
    public void DeactivateKokiriEmerald()
    {
        KokiriEmeraldImage = "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateGoronRuby()
    {
        GoronRubyImage = "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon.png";
    }

    [RelayCommand]
    public void DeactivateGoronRuby()
    {
        GoronRubyImage = "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateZoraSapphire()
    {
        ZoraSapphireImage = "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon.png";
    }

    [RelayCommand]
    public void DeactivateZoraSapphire()
    {
        ZoraSapphireImage = "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateLightMedallion()
    {
        LightMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon.png";
    }

    [RelayCommand]
    public void DeactivateLightMedallion()
    {
        LightMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateForestMedallion()
    {
        ForestMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon.png";
    }

    [RelayCommand]
    public void DeactivateForestMedallion()
    {
        ForestMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateFireMedallion()
    {
        FireMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon.png";
    }

    [RelayCommand]
    public void DeactivateFireMedallion()
    {
        FireMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateWaterMedallion()
    {
        WaterMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon.png";
    }

    [RelayCommand]
    public void DeactivateWaterMedallion()
    {
        WaterMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateShadowMedallion()
    {
        ShadowMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon.png";
    }

    [RelayCommand]
    public void DeactivateShadowMedallion()
    {
        ShadowMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateSpiritMedallion()
    {
        SpiritMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon.png";
    }

    [RelayCommand]
    public void DeactivateSpiritMedallion()
    {
        SpiritMedallionImage = "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon_Disabled.png";
    }

    #endregion
    #region Equip Items (Tunics, Swords, Shields, Boots)
    #region Swords
    [RelayCommand]
    public void ActivateKokiriSword()
    {
        KokiriSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon.png";
    }

    [RelayCommand]
    public void DeactivateKokiriSword()
    {
        KokiriSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateMasterSword()
    {
        MasterSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon.png";
    }

    [RelayCommand]
    public void DeactivateMasterSword()
    {
        MasterSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateBiggoronSword()
    {
        BiggoronSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon.png";
    }

    [RelayCommand]
    public void DeactivateBiggoronSword()
    {
        BiggoronSwordImage = "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon_Disabled.png";
    }
    #endregion
    #region Shields
    [RelayCommand]
    public void ActivateDekuShield()
    {
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon.png";
    }

    [RelayCommand]
    public void DeactivateDekuShield()
    {
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateHylianShield()
    {
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon.png";
    }

    [RelayCommand]
    public void DeactivateHylianShield()
    {
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateMirrorShield()
    {
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon.png";
    }

    [RelayCommand]
    public void DeactivateMirrorShield()
    {
        DekuShieldImage = "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon_Disabled.png";
    }
    #endregion
    #region Tunics
    [RelayCommand]
    public void ActivateGoronTunic()
    {
        GoronTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon.png";
    }

    [RelayCommand]
    public void DeactivateGoronTunic()
    {
        GoronTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateZoraTunic()
    {
        ZoraTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon.png";
    }

    [RelayCommand]
    public void DeactivateZoraTunic()
    {
        ZoraTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon_Disabled.png";
    }
    #endregion
    #region Boots
    [RelayCommand]
    public void ActivateIronBoots()
    {
        IronBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon.png";
    }

    [RelayCommand]
    public void DeactivateIronBoots()
    {
        IronBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon_Disabled.png";
    }

    [RelayCommand]
    public void ActivateHoverBoots()
    {
        IronBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon.png";
    }

    [RelayCommand]
    public void DeactivateHoverBoots()
    {
        IronBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon_Disabled.png";
    }
    #endregion
    #endregion
}