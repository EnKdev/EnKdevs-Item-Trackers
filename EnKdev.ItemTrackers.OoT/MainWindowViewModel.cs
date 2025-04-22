using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnKdev.ItemTrackers.Core;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.OoT.Commands;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindowViewModel : ObservableRecipient
{
    [ObservableProperty]
    private TrackerProperties _trackerProperties = new();

    private const int MaxHeartContainers = 8;
    private const int MaxHeartPieces = 36;
    private const int MaxGsTokens = 100;

    private readonly List<string> _stateFiles =
    [
        "OoT.TrackerState.Arrows.dat",
        "OoT.TrackerState.Items.dat",
        "OoT.TrackerState.Upgrades.dat",
        "OoT.TrackerState.Equip.dat",
        "OoT.TrackerState.Dungeons.dat",
        "OoT.TrackerState.Quest.dat",
        "OoT.TrackerState.Other.dat",
        "OoT.TrackerState.Data.dat",
        "OoT.TrackerState.Songs.dat"
    ];

    private static bool _arrowStateExists;
    private static bool _itemStateExists;
    private static bool _upgradeStateExists;
    private static bool _equipStateExists;
    private static bool _dungeonStateExists;
    private static bool _questStateExists;
    private static bool _otherStateExists;
    private static bool _dataStateExists;
    private static bool _songStateExists;
    
    // Observable properties
    [ObservableProperty]
    private string _title;

    public MainWindowViewModel()
    {
        _title = AppConstants.AppTitle;

        Resolver.ResolveDefaultLocations(TrackerProperties);
        Resolver.ResolveDefaultDungeonTypes(TrackerProperties);
        Resolver.ResolveDefaultKeyColors(TrackerProperties);
        Resolver.ResolveBackgrounds(TrackerProperties);
        Resolver.ResolveDefaultIcons(TrackerProperties);
        Resolver.ResolveKeyIcons(TrackerProperties);
        Resolver.ResolveDungeonIcons(TrackerProperties);
        Resolver.ResolveSongIcons(TrackerProperties);
        Resolver.ResolveEquipIcons(TrackerProperties);
        Resolver.ResolveGearIcons(TrackerProperties);
        Resolver.ResolveItemIcons(TrackerProperties);

        InitVariables();

        foreach (var stateFile in _stateFiles.Where(stateFile => File.Exists($"./Saves/{stateFile}")))
        {
            switch (stateFile)
            {
                case "OoT.TrackerState.Arrows.dat":
                    _arrowStateExists = true;
                    break;
                case "OoT.TrackerState.Items.dat":
                    _itemStateExists = true;
                    break;
                case "OoT.TrackerState.Upgrades.dat":
                    _upgradeStateExists = true;
                    break;
                case "OoT.TrackerState.Equip.dat":
                    _equipStateExists = true;
                    break;
                case "OoT.TrackerState.Dungeons.dat":
                    _dungeonStateExists = true;
                    break;
                case "OoT.TrackerState.Quest.dat":
                    _questStateExists = true;
                    break;
                case "OoT.TrackerState.Other.dat":
                    _otherStateExists = true;
                    break;
                case "OoT.TrackerState.Data.dat":
                    _dataStateExists = true;
                    break;
                case "OoT.TrackerState.Songs.dat":
                    _songStateExists = true;
                    break;
            }
        }
        
        LoadStates(TrackerProperties);
    }

    private void InitVariables()
    {
        TrackerProperties.OcarinaState = -1;
        TrackerProperties.ScaleState = -1;
        TrackerProperties.StrengthState = -1;
        TrackerProperties.QuiverState = -1;
        TrackerProperties.BulletState = -1;
        TrackerProperties.BombState = -1;
        TrackerProperties.HookState = -1;

        TrackerProperties.ChildTradeState = -1;
        TrackerProperties.AdultTradeState = -1;

        TrackerProperties.Location1Idx = 0;
        TrackerProperties.Location2Idx = 0;
        TrackerProperties.Location3Idx = 0;
        TrackerProperties.Location4Idx = 0;
        TrackerProperties.Location5Idx = 0;
        TrackerProperties.Location6Idx = 0;
        TrackerProperties.Location7Idx = 0;
        TrackerProperties.Location8Idx = 0;
        TrackerProperties.Location9Idx = 0;
        
        TrackerProperties.Dungeon1Idx = 0;
        TrackerProperties.Dungeon2Idx = 0;
        TrackerProperties.Dungeon3Idx = 0;
        TrackerProperties.Dungeon4Idx = 0;
        TrackerProperties.Dungeon5Idx = 0;
        TrackerProperties.Dungeon6Idx = 0;
        TrackerProperties.Dungeon7Idx = 0;
        TrackerProperties.Dungeon8Idx = 0;
        TrackerProperties.Dungeon9Idx = 0;
        TrackerProperties.Dungeon10Idx = 0;
        TrackerProperties.Dungeon11Idx = 0;
        TrackerProperties.Dungeon12Idx = 0;

        TrackerProperties.HpProg = 0;
        
        TrackerProperties.IsDekuMq = false;
        TrackerProperties.IsDcMq = false;
        TrackerProperties.IsJabuMq = false;
        TrackerProperties.IsForestMq = false;
        TrackerProperties.IsFireMq = false;
        TrackerProperties.IsWaterMq = false;
        TrackerProperties.IsShadowMq = false;
        TrackerProperties.IsSpiritMq = false;
        TrackerProperties.IsBottomMq = false;
        TrackerProperties.IsCavernMq = false;
    }
    
    // ==================
    // = OTHER COMMANDS =
    // ==================
    
    [RelayCommand]
    private void ToggleOther(string otherId)
    {
        Logger.LogCommand(nameof(ToggleOtherCommand));
        CommandHandler.ToggleOther(otherId, TrackerProperties);
        
        SaveHelper.SaveOtherState(TrackerProperties);
    }

    [RelayCommand]
    private void HandleGsCount(string action)
    {
        Logger.LogCommand(nameof(HandleGsCountCommand));

        switch (action)
        {
            case "inc":
                CommandHandler.IncreaseGoldSkulltulaCount(TrackerProperties, MaxGsTokens);
                break;
            case "dec":
                CommandHandler.DecreaseGoldSkulltulaCount(TrackerProperties);
                break;
        }
        
        SaveHelper.SaveDataState(TrackerProperties);
    }

    [RelayCommand]
    private void HandleHearts(string action)
    {
        Logger.LogCommand(nameof(HandleHeartsCommand));

        switch (action)
        {
            case "hc":
                CommandHandler.IncreaseHeartContainerCount(TrackerProperties, MaxHeartContainers);
                break;
            case "hp":
                CommandHandler.ProgressHeartPiece(TrackerProperties, MaxHeartPieces);
                ProcessHeartPieceProgression(TrackerProperties);
                break;
        }
        
        SaveHelper.SaveDataState(TrackerProperties);
    }
    
    // ==============================
    // = QUEST PROGRESSION COMMANDS =
    // ==============================
    
    [RelayCommand]
    private void ToggleQuest(string progressionId)
    {
        Logger.LogCommand(nameof(ToggleQuestCommand));
        CommandHandler.ToggleQuest(progressionId, TrackerProperties);
        
        SaveHelper.SaveQuestState(TrackerProperties);
    }

    [RelayCommand]
    private void SetLocation(string progressionId)
    {
        Logger.LogCommand(nameof(SetLocationCommand));
        CommandHandler.UpdateLocation(progressionId, TrackerProperties);
        
        SaveHelper.SaveQuestState(TrackerProperties);
    }
    
    // =================
    // = SONG COMMANDS =
    // =================

    [RelayCommand]
    private void ToggleSong(string songId)
    {
        Logger.LogCommand(nameof(ToggleSongCommand));
        CommandHandler.ToggleSong(songId, TrackerProperties);
        
        SaveHelper.SaveSongState(TrackerProperties);
    }
    
    // ==================
    // = EQUIP COMMANDS =
    // ==================

    [RelayCommand]
    private void ToggleEquip(string equipId)
    {
        Logger.LogCommand(nameof(ToggleEquipCommand));
        CommandHandler.ToggleEquip(equipId, TrackerProperties);
        
        SaveHelper.SaveEquipState(TrackerProperties);
    }
    
    // ====================
    // = UPGRADE COMMANDS =
    // ====================
    
    [RelayCommand]
    private void ChangeStrength(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeStrengthCommand));
        CommandHandler.ChangeStrength(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }

    [RelayCommand]
    private void ChangeScale(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);

        Logger.LogCommand(nameof(ChangeScaleCommand));
        CommandHandler.ChangeScale(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }
    
    // =================
    // = ITEM COMMANDS =
    // =================
    
    [RelayCommand]
    private void ToggleItem(string itemId)
    {
        Logger.LogCommand(nameof(ToggleItemCommand));
        CommandHandler.ToggleItem(itemId, TrackerProperties);
        
        SaveHelper.SaveItemState(TrackerProperties);
    }

    [RelayCommand]
    private void ChangeOcarina(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);

        Logger.LogCommand(nameof(ChangeOcarinaCommand));
        CommandHandler.ChangeOcarina(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }

    [RelayCommand]
    private void ChangeHookshot(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeHookshotCommand));
        CommandHandler.ChangeHookshot(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }
    
    // ==================
    // = ARROW COMMANDS =
    // ==================
    
    [RelayCommand]
    private void ToggleArrow(string arrowId)
    {
        Logger.LogCommand(nameof(ToggleArrowCommand));
        CommandHandler.ToggleArrow(arrowId, TrackerProperties);
        
        SaveHelper.SaveArrowState(TrackerProperties);
    }
    
    // ===================
    // = BOTTLE COMMANDS =
    // ===================
    
    [RelayCommand]
    private void ToggleBottle(string bottleId)
    {
        Logger.LogCommand(nameof(ToggleBottleCommand));
        CommandHandler.ToggleBottle(bottleId, TrackerProperties);
        
        SaveHelper.SaveItemState(TrackerProperties);
    }
    
    // =================
    // = GEAR COMMANDS =
    // =================

    [RelayCommand]
    private void ChangeQuiver(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeQuiverCommand));
        CommandHandler.ChangeQuiver(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }

    [RelayCommand]
    private void ChangeBombBag(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeBombBagCommand));
        CommandHandler.ChangeBombBag(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }

    [RelayCommand]
    private void ChangeBulletBag(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeBulletBagCommand));
        CommandHandler.ChangeBulletBag(TrackerProperties, isUpgradeBool);
        
        SaveHelper.SaveUpgradeState(TrackerProperties);
    }
    
    // ==================
    // = TRADE COMMANDS =
    // ==================

    [RelayCommand]
    private void ChangeChildTrade(string isAdvancing)
    {
        var isAdvancingBool = bool.Parse(isAdvancing);
        
        Logger.LogCommand(nameof(ChangeChildTradeCommand));
        CommandHandler.ChangeChildTrade(TrackerProperties, isAdvancingBool);
        
        SaveHelper.SaveItemState(TrackerProperties);
    }
    
    [RelayCommand]
    private void ChangeAdultTrade(string isAdvancing)
    {
        var isAdvancingBool = bool.Parse(isAdvancing);
        
        Logger.LogCommand(nameof(ChangeChildTradeCommand));
        CommandHandler.ChangeAdultTrade(TrackerProperties, isAdvancingBool);
        
        SaveHelper.SaveItemState(TrackerProperties);
    }
    
    // ====================
    // = DUNGEON COMMANDS =
    // ====================

    [RelayCommand]
    private void ToggleMap(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleMapCommand));
        CommandHandler.ToggleMap(TrackerProperties, dungeonId);
        
        SaveHelper.SaveDungeonState(TrackerProperties);
    }

    [RelayCommand]
    private void ToggleCompass(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleCompassCommand));
        CommandHandler.ToggleCompass(TrackerProperties, dungeonId);
        
        SaveHelper.SaveDungeonState(TrackerProperties);
    }

    [RelayCommand]
    private void ToggleDungeonState(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleDungeonStateCommand));
        CommandHandler.UpdateDungeonState(TrackerProperties, dungeonId);
        
        SaveHelper.SaveDungeonState(TrackerProperties);
    }

    [RelayCommand]
    private void HandleKeys(string dungeonId)
    {
        Logger.LogCommand(nameof(HandleKeysCommand));
        CommandHandler.HandleKeys(TrackerProperties, dungeonId);
        
        SaveHelper.SaveDungeonState(TrackerProperties);
    }

    [RelayCommand]
    private void ToggleBossKey(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleBossKeyCommand));
        CommandHandler.ToggleBossKey(TrackerProperties, dungeonId);
        
        SaveHelper.SaveDungeonState(TrackerProperties);
    }
    
    // Util methods
    private static void ProcessHeartPieceProgression(TrackerProperties properties)
    {
        if (properties.HeartPieceCount == 0)
        {
            properties.HeartPieceProgression = OoTConstants.HeartPieceProgression[0];
        }
        else
            properties.HeartPieceProgression = (properties.HeartPieceCount % 4) switch
            {
                1 => OoTConstants.HeartPieceProgression[1],
                2 => OoTConstants.HeartPieceProgression[2],
                3 => OoTConstants.HeartPieceProgression[3],
                0 => OoTConstants.HeartPieceProgression[4],
                _ => properties.HeartPieceProgression
            };
        
        Logger.LogInteraction(nameof(properties.HeartPieceProgression));
    }

    [RelayCommand]
    private void ShowInfo()
    {
        Logger.LogCommand(nameof(ShowInfoCommand));
        CommandHandler.ShowInfo();
    }

    [RelayCommand]
    private void NewRun()
    {
        Logger.LogCommand(nameof(NewRunCommand));
        
        // Step 1: Reset the tracker
        Reset();
        
        // Step 2: Pack up the previous made states into an archive and move it
        CommandHandler.NewRun();
    }

    [RelayCommand]
    private void DeleteRun()
    {
        Logger.LogCommand(nameof(DeleteRunCommand));
        
        // Step 1: Reset the tracker
        Reset();
        
        // Step 2: Delete all previously made states.
        CommandHandler.DeleteRun();
    }

    [RelayCommand]
    private void ExitApp()
    {
        Logger.LogCommand(nameof(ExitAppCommand));
        
        // Sayonara.
        CommandHandler.Quit();
    }

    private static void LoadStates(TrackerProperties properties)
    {
        if (_arrowStateExists)
        {
            SaveHelper.ReadArrowState(properties);
        }

        if (_itemStateExists)
        {
            SaveHelper.ReadItemState(properties);
        }

        if (_upgradeStateExists)
        {
            SaveHelper.ReadUpgradeState(properties);
        }
        
        if (_equipStateExists)
        {
            SaveHelper.ReadEquipState(properties);
        }
        
        if (_dungeonStateExists)
        {
            SaveHelper.ReadDungeonState(properties);
        }
        
        if (_questStateExists)
        {
            SaveHelper.ReadQuestState(properties);
        }
        
        if (_otherStateExists)
        {
            SaveHelper.ReadOtherState(properties);
        }
        
        if (_dataStateExists)
        {
            SaveHelper.ReadDataState(properties);
        }

        if (_songStateExists)
        {
            SaveHelper.ReadSongState(properties);
        }
    }

    private void Reset()
    {
        Title = AppConstants.AppTitle;

        Resolver.ResolveDefaultLocations(TrackerProperties);
        Resolver.ResolveDefaultDungeonTypes(TrackerProperties);
        Resolver.ResolveDefaultKeyColors(TrackerProperties);
        Resolver.ResolveBackgrounds(TrackerProperties);
        Resolver.ResolveDefaultIcons(TrackerProperties);
        Resolver.ResolveKeyIcons(TrackerProperties);
        Resolver.ResolveDungeonIcons(TrackerProperties);
        Resolver.ResolveSongIcons(TrackerProperties);
        Resolver.ResolveEquipIcons(TrackerProperties);
        Resolver.ResolveGearIcons(TrackerProperties);
        Resolver.ResolveItemIcons(TrackerProperties);

        InitVariables();
    }
}