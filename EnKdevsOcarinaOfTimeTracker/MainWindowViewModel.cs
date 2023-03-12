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
    }

    #region Quest Items (Dungeon Rewards)
    
    [RelayCommand]
    public void ActivateKokiriEmerald()
    {
        KokiriEmeraldImage = Constants.EnabledStones[0];
    }

    [RelayCommand]
    public void DeactivateKokiriEmerald()
    {
        KokiriEmeraldImage = Constants.DisabledStones[0];
    }

    [RelayCommand]
    public void ActivateGoronRuby()
    {
        GoronRubyImage = Constants.EnabledStones[1];
    }

    [RelayCommand]
    public void DeactivateGoronRuby()
    {
        GoronRubyImage = Constants.DisabledStones[1];
    }

    [RelayCommand]
    public void ActivateZoraSapphire()
    {
        ZoraSapphireImage = Constants.EnabledStones[2];
    }

    [RelayCommand]
    public void DeactivateZoraSapphire()
    {
        ZoraSapphireImage = Constants.DisabledStones[2];
    }

    [RelayCommand]
    public void ActivateLightMedallion()
    {
        LightMedallionImage = Constants.EnabledMeds[0];
    }

    [RelayCommand]
    public void DeactivateLightMedallion()
    {
        LightMedallionImage = Constants.DisabledMeds[0];
    }

    [RelayCommand]
    public void ActivateForestMedallion()
    {
        ForestMedallionImage = Constants.EnabledMeds[1];
    }

    [RelayCommand]
    public void DeactivateForestMedallion()
    {
        ForestMedallionImage = Constants.DisabledMeds[1];
    }

    [RelayCommand]
    public void ActivateFireMedallion()
    {
        FireMedallionImage = Constants.EnabledMeds[2];
    }

    [RelayCommand]
    public void DeactivateFireMedallion()
    {
        FireMedallionImage = Constants.DisabledMeds[2];
    }

    [RelayCommand]
    public void ActivateWaterMedallion()
    {
        WaterMedallionImage = Constants.EnabledMeds[3];
    }

    [RelayCommand]
    public void DeactivateWaterMedallion()
    {
        WaterMedallionImage = Constants.DisabledMeds[3];
    }

    [RelayCommand]
    public void ActivateShadowMedallion()
    {
        ShadowMedallionImage = Constants.EnabledMeds[4];
    }

    [RelayCommand]
    public void DeactivateShadowMedallion()
    {
        ShadowMedallionImage = Constants.DisabledMeds[4];
    }

    [RelayCommand]
    public void ActivateSpiritMedallion()
    {
        SpiritMedallionImage = Constants.EnabledMeds[5];
    }

    [RelayCommand]
    public void DeactivateSpiritMedallion()
    {
        SpiritMedallionImage = Constants.DisabledMeds[5];
    }

    #endregion
    #region Equip Items (Tunics, Swords, Shields, Boots)
    #region Swords
    [RelayCommand]
    public void ActivateKokiriSword()
    {
        KokiriSwordImage = Constants.EnabledEquip[0];
    }

    [RelayCommand]
    public void DeactivateKokiriSword()
    {
        KokiriSwordImage = Constants.DisabledEquip[0];
    }

    [RelayCommand]
    public void ActivateMasterSword()
    {
        MasterSwordImage = Constants.EnabledEquip[1];
    }

    [RelayCommand]
    public void DeactivateMasterSword()
    {
        MasterSwordImage = Constants.DisabledEquip[1];
    }

    [RelayCommand]
    public void ActivateBiggoronSword()
    {
        BiggoronSwordImage = Constants.EnabledEquip[2];
    }

    [RelayCommand]
    public void DeactivateBiggoronSword()
    {
        BiggoronSwordImage = Constants.DisabledEquip[2];
    }
    #endregion
    #region Shields
    [RelayCommand]
    public void ActivateDekuShield()
    {
        DekuShieldImage = Constants.EnabledEquip[3];
    }

    [RelayCommand]
    public void DeactivateDekuShield()
    {
        DekuShieldImage = Constants.DisabledEquip[3];
    }

    [RelayCommand]
    public void ActivateHylianShield()
    {
        HylianShieldImage = Constants.EnabledEquip[4];
    }

    [RelayCommand]
    public void DeactivateHylianShield()
    {
        HylianShieldImage = Constants.DisabledEquip[4];
    }

    [RelayCommand]
    public void ActivateMirrorShield()
    {
        MirrorShieldImage = Constants.EnabledEquip[5];
    }

    [RelayCommand]
    public void DeactivateMirrorShield()
    {
        MirrorShieldImage = Constants.DisabledEquip[5];
    }
    #endregion
    #region Tunics
    [RelayCommand]
    public void ActivateGoronTunic()
    {
        GoronTunicImage = Constants.EnabledEquip[6];
    }

    [RelayCommand]
    public void DeactivateGoronTunic()
    {
        GoronTunicImage = Constants.DisabledEquip[6];
    }

    [RelayCommand]
    public void ActivateZoraTunic()
    {
        ZoraTunicImage = Constants.EnabledEquip[7];
    }

    [RelayCommand]
    public void DeactivateZoraTunic()
    {
        ZoraTunicImage = Constants.DisabledEquip[7];
    }
    #endregion
    #region Boots
    [RelayCommand]
    public void ActivateIronBoots()
    {
        IronBootsImage = Constants.EnabledEquip[8];
    }

    [RelayCommand]
    public void DeactivateIronBoots()
    {
        IronBootsImage = Constants.DisabledEquip[8];
    }

    [RelayCommand]
    public void ActivateHoverBoots()
    {
        HoverBootsImage = Constants.EnabledEquip[9];
    }

    [RelayCommand]
    public void DeactivateHoverBoots()
    {
        HoverBootsImage = Constants.DisabledEquip[9];
    }
    #endregion
    #endregion
}