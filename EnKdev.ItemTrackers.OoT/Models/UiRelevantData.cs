using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Models;

public class UiRelevantData
{
    [JsonProperty("ui_loc1str")]
    public string Location1String { get; set; }
    
    [JsonProperty("ui_loc2str")]
    public string Location2String { get; set; }
    
    [JsonProperty("ui_loc3str")]
    public string Location3String { get; set; }
    
    [JsonProperty("ui_loc4str")]
    public string Location4String { get; set; }
    
    [JsonProperty("ui_loc5str")]
    public string Location5String { get; set; }
    
    [JsonProperty("ui_loc6str")]
    public string Location6String { get; set; }
    
    [JsonProperty("ui_loc7str")]
    public string Location7String { get; set; }
    
    [JsonProperty("ui_loc8str")]
    public string Location8String { get; set; }
    
    [JsonProperty("ui_loc9str")]
    public string Location9String { get; set; }
    
    [JsonProperty("ui_d1type")]
    public string Dungeon1Type { get; set; }
    
    [JsonProperty("ui_d2type")]
    public string Dungeon2Type { get; set; }
    
    [JsonProperty("ui_d3type")]
    public string Dungeon3Type { get; set; }
    
    [JsonProperty("ui_d4type")]
    public string Dungeon4Type { get; set; }
    
    [JsonProperty("ui_d5type")]
    public string Dungeon5Type { get; set; }
    
    [JsonProperty("ui_d6type")]
    public string Dungeon6Type { get; set; }
    
    [JsonProperty("ui_d7type")]
    public string Dungeon7Type { get; set; }
    
    [JsonProperty("ui_d8type")]
    public string Dungeon8Type { get; set; }
    
    [JsonProperty("ui_d9type")]
    public string Dungeon9Type { get; set; }
    
    [JsonProperty("ui_d10type")]
    public string Dungeon10Type { get; set; }
    
    [JsonProperty("ui_d11type")]
    public string Dungeon11Type { get; set; }
    
    [JsonProperty("ui_d12type")]
    public string Dungeon12Type { get; set; }
    
    [JsonProperty("q_kokEmStr")]
    public string EmeraldString { get; set; }
    
    [JsonProperty("q_gorRuStr")]
    public string RubyString { get; set; }
    
    [JsonProperty("q_zorSaStr")]
    public string SapphireString { get; set; }
    
    [JsonProperty("q_liMedStr")]
    public string LightMedallionString { get; set; }
    
    [JsonProperty("q_foMedStr")]
    public string ForestMedallionString { get; set; }
    
    [JsonProperty("q_fiMedStr")]
    public string FireMedallionString { get; set; }
    
    [JsonProperty("q_waMedStr")]
    public string WaterMedallionString { get; set; }
    
    [JsonProperty("q_spMedStr")]
    public string SpiritMedallionString { get; set; }
    
    [JsonProperty("q_shMedStr")]
    public string ShadowMedallionString { get; set; }
    
    [JsonProperty("eq_kokSwordStr")]
    public string KokiriSwordString { get; set; }

    [JsonProperty("eq_masSwordStr")]
    public string MasterSwordString { get; set; }

    [JsonProperty("eq_bigSwordStr")]
    public string BiggoronSwordString { get; set; }

    [JsonProperty("eq_dekShStr")]
    public string DekuShieldString { get; set; }

    [JsonProperty("eq_hylShStr")]
    public string HylianShieldString { get; set; }

    [JsonProperty("eq_mirShStr")]
    public string MirrorShieldString { get; set; }

    [JsonProperty("eq_gorTuStr")]
    public string GoronTunicString { get; set; }

    [JsonProperty("eq_zorTuStr")]
    public string ZoraTunicString { get; set; }

    [JsonProperty("eq_irBooStr")]
    public string IronBootsString { get; set; }

    [JsonProperty("eq_hoBooStr")]
    public string HoverBootsString { get; set; }
    
    [JsonProperty("u_ocStr")]
    public string OcarinaString { get; set; }
    
    [JsonProperty("u_scStr")]
    public string ScaleString { get; set; }
    
    [JsonProperty("u_stStr")]
    public string StrengthString { get; set; }
    
    [JsonProperty("u_boStr")]
    public string BombString { get; set; }
    
    [JsonProperty("u_quStr")]
    public string QuiverString { get; set; }
    
    [JsonProperty("u_buStr")]
    public string BulletString { get; set; }
    
    [JsonProperty("o_gsTokCnt")]
    public int GsTokenCount { get; set; }
    
    [JsonProperty("o_geTokStr")]
    public string GerudoTokenString { get; set; }
    
    [JsonProperty("o_shStr")]
    public string ShardString { get; set; }
    
    [JsonProperty("s_zlStr")]
    public string LullabyString { get; set; }
    
    [JsonProperty("s_esStr")]
    public string EponaString { get; set; }
    
    [JsonProperty("s_sasStr")]
    public string SariaString { get; set; }
    
    [JsonProperty("s_sosStr")]
    public string StormsString { get; set; }
    
    [JsonProperty("s_susStr")]
    public string SunsString { get; set; }
    
    [JsonProperty("s_sotStr")]
    public string TimeString { get; set; }
    
    [JsonProperty("s_mfStr")]
    public string MinuetString { get; set; }
    
    [JsonProperty("s_bfStr")]
    public string BoleroString { get; set; }
    
    [JsonProperty("s_swStr")]
    public string SerenadeString { get; set; }
    
    [JsonProperty("s_rsStr")]
    public string RequiemString { get; set; }
    
    [JsonProperty("s_nsStr")]
    public string NocturneString { get; set; }
    
    [JsonProperty("s_plStr")]
    public string PreludeString { get; set; }
    
    [JsonProperty("i_dsStr")]
    public string StickString { get; set; }
    
    [JsonProperty("i_dnStr")]
    public string NutString { get; set; }
    
    [JsonProperty("i_fsStr")]
    public string SlingshotString { get; set; }
    
    [JsonProperty("i_dfStr")]
    public string DinsString { get; set; }
    
    [JsonProperty("i_boStr")]
    public string BombItemString { get; set; }
    
    [JsonProperty("i_chStr")]
    public string BombchuString { get; set; }
    
    [JsonProperty("i_chTrStr")]
    public string ChildTradeString { get; set; }
    
    [JsonProperty("i_adTrStr")]
    public string AdultTradeString { get; set; }
    
    [JsonProperty("i_fwStr")]
    public string FaroresString { get; set; }
    
    [JsonProperty("i_booStr")]
    public string BoomerangString { get; set; }
    
    [JsonProperty("i_hsStr")]
    public string HookshotString { get; set; }
    
    [JsonProperty("i_nlStr")]
    public string NayrusString { get; set; }
    
    [JsonProperty("i_ltStr")]
    public string LensString { get; set; }
    
    [JsonProperty("i_mhStr")]
    public string HammerString { get; set; }
    
    [JsonProperty("i_fbStr")]
    public string BowString { get; set; }
    
    [JsonProperty("i_mbStr")]
    public string BeanString { get; set; }
    
    [JsonProperty("i_faStr")]
    public string FireArrowString { get; set; }
    
    [JsonProperty("i_iaStr")]
    public string IceArrowString { get; set; }
    
    [JsonProperty("i_laStr")]
    public string LightArrowString { get; set; }
    
    [JsonProperty("i_b1Str")]
    public string Bottle1String { get; set; }
    
    [JsonProperty("i_b2Str")]
    public string Bottle2String { get; set; }
    
    [JsonProperty("i_b3Str")]
    public string Bottle3String { get; set; }
    
    [JsonProperty("i_b4Str")]
    public string Bottle4String { get; set; }
}