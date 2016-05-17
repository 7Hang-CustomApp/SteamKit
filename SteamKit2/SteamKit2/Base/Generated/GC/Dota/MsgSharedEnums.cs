//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: dota_shared_enums.proto
namespace SteamKit2.GC.Dota.Internal
{
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_GameMode", EnumPassthru=true)]
    public enum DOTA_GameMode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_NONE", Value=0)]
      DOTA_GAMEMODE_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_AP", Value=1)]
      DOTA_GAMEMODE_AP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_CM", Value=2)]
      DOTA_GAMEMODE_CM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_RD", Value=3)]
      DOTA_GAMEMODE_RD = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_SD", Value=4)]
      DOTA_GAMEMODE_SD = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_AR", Value=5)]
      DOTA_GAMEMODE_AR = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_INTRO", Value=6)]
      DOTA_GAMEMODE_INTRO = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_HW", Value=7)]
      DOTA_GAMEMODE_HW = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_REVERSE_CM", Value=8)]
      DOTA_GAMEMODE_REVERSE_CM = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_XMAS", Value=9)]
      DOTA_GAMEMODE_XMAS = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_TUTORIAL", Value=10)]
      DOTA_GAMEMODE_TUTORIAL = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_MO", Value=11)]
      DOTA_GAMEMODE_MO = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_LP", Value=12)]
      DOTA_GAMEMODE_LP = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_POOL1", Value=13)]
      DOTA_GAMEMODE_POOL1 = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_FH", Value=14)]
      DOTA_GAMEMODE_FH = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_CUSTOM", Value=15)]
      DOTA_GAMEMODE_CUSTOM = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_CD", Value=16)]
      DOTA_GAMEMODE_CD = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_BD", Value=17)]
      DOTA_GAMEMODE_BD = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_ABILITY_DRAFT", Value=18)]
      DOTA_GAMEMODE_ABILITY_DRAFT = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_EVENT", Value=19)]
      DOTA_GAMEMODE_EVENT = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_ARDM", Value=20)]
      DOTA_GAMEMODE_ARDM = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_1V1MID", Value=21)]
      DOTA_GAMEMODE_1V1MID = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMEMODE_ALL_DRAFT", Value=22)]
      DOTA_GAMEMODE_ALL_DRAFT = 22
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_GameState", EnumPassthru=true)]
    public enum DOTA_GameState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_INIT", Value=0)]
      DOTA_GAMERULES_STATE_INIT = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_WAIT_FOR_PLAYERS_TO_LOAD", Value=1)]
      DOTA_GAMERULES_STATE_WAIT_FOR_PLAYERS_TO_LOAD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_HERO_SELECTION", Value=2)]
      DOTA_GAMERULES_STATE_HERO_SELECTION = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_STRATEGY_TIME", Value=3)]
      DOTA_GAMERULES_STATE_STRATEGY_TIME = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_PRE_GAME", Value=4)]
      DOTA_GAMERULES_STATE_PRE_GAME = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_GAME_IN_PROGRESS", Value=5)]
      DOTA_GAMERULES_STATE_GAME_IN_PROGRESS = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_POST_GAME", Value=6)]
      DOTA_GAMERULES_STATE_POST_GAME = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_DISCONNECT", Value=7)]
      DOTA_GAMERULES_STATE_DISCONNECT = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_TEAM_SHOWCASE", Value=8)]
      DOTA_GAMERULES_STATE_TEAM_SHOWCASE = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_CUSTOM_GAME_SETUP", Value=9)]
      DOTA_GAMERULES_STATE_CUSTOM_GAME_SETUP = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GAMERULES_STATE_LAST", Value=10)]
      DOTA_GAMERULES_STATE_LAST = 10
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTA_GC_TEAM", EnumPassthru=true)]
    public enum DOTA_GC_TEAM
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GC_TEAM_GOOD_GUYS", Value=0)]
      DOTA_GC_TEAM_GOOD_GUYS = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GC_TEAM_BAD_GUYS", Value=1)]
      DOTA_GC_TEAM_BAD_GUYS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GC_TEAM_BROADCASTER", Value=2)]
      DOTA_GC_TEAM_BROADCASTER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GC_TEAM_SPECTATOR", Value=3)]
      DOTA_GC_TEAM_SPECTATOR = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GC_TEAM_PLAYER_POOL", Value=4)]
      DOTA_GC_TEAM_PLAYER_POOL = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_GC_TEAM_NOTEAM", Value=5)]
      DOTA_GC_TEAM_NOTEAM = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EEvent", EnumPassthru=true)]
    public enum EEvent
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_NONE", Value=0)]
      EVENT_ID_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_DIRETIDE", Value=1)]
      EVENT_ID_DIRETIDE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_SPRING_FESTIVAL", Value=2)]
      EVENT_ID_SPRING_FESTIVAL = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_FROSTIVUS_2013", Value=3)]
      EVENT_ID_FROSTIVUS_2013 = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_COMPENDIUM_2014", Value=4)]
      EVENT_ID_COMPENDIUM_2014 = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_NEXON_PC_BANG", Value=5)]
      EVENT_ID_NEXON_PC_BANG = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_PWRD_DAC_2015", Value=6)]
      EVENT_ID_PWRD_DAC_2015 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_NEW_BLOOM_2015", Value=7)]
      EVENT_ID_NEW_BLOOM_2015 = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_INTERNATIONAL_2015", Value=8)]
      EVENT_ID_INTERNATIONAL_2015 = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_FALL_MAJOR_2015", Value=9)]
      EVENT_ID_FALL_MAJOR_2015 = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_ORACLE_PA", Value=10)]
      EVENT_ID_ORACLE_PA = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_NEW_BLOOM_2015_PREBEAST", Value=11)]
      EVENT_ID_NEW_BLOOM_2015_PREBEAST = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_FROSTIVUS", Value=12)]
      EVENT_ID_FROSTIVUS = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_WINTER_MAJOR_2016", Value=13)]
      EVENT_ID_WINTER_MAJOR_2016 = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EVENT_ID_INTERNATIONAL_2016", Value=14)]
      EVENT_ID_INTERNATIONAL_2016 = 14
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTALeaverStatus_t", EnumPassthru=true)]
    public enum DOTALeaverStatus_t
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_NONE", Value=0)]
      DOTA_LEAVER_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_DISCONNECTED", Value=1)]
      DOTA_LEAVER_DISCONNECTED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_DISCONNECTED_TOO_LONG", Value=2)]
      DOTA_LEAVER_DISCONNECTED_TOO_LONG = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_ABANDONED", Value=3)]
      DOTA_LEAVER_ABANDONED = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_AFK", Value=4)]
      DOTA_LEAVER_AFK = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_NEVER_CONNECTED", Value=5)]
      DOTA_LEAVER_NEVER_CONNECTED = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_NEVER_CONNECTED_TOO_LONG", Value=6)]
      DOTA_LEAVER_NEVER_CONNECTED_TOO_LONG = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_FAILED_TO_READY_UP", Value=7)]
      DOTA_LEAVER_FAILED_TO_READY_UP = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_LEAVER_DECLINED", Value=8)]
      DOTA_LEAVER_DECLINED = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTAConnectionState_t", EnumPassthru=true)]
    public enum DOTAConnectionState_t
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_UNKNOWN", Value=0)]
      DOTA_CONNECTION_STATE_UNKNOWN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_NOT_YET_CONNECTED", Value=1)]
      DOTA_CONNECTION_STATE_NOT_YET_CONNECTED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_CONNECTED", Value=2)]
      DOTA_CONNECTION_STATE_CONNECTED = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_DISCONNECTED", Value=3)]
      DOTA_CONNECTION_STATE_DISCONNECTED = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_ABANDONED", Value=4)]
      DOTA_CONNECTION_STATE_ABANDONED = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_LOADING", Value=5)]
      DOTA_CONNECTION_STATE_LOADING = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTA_CONNECTION_STATE_FAILED", Value=6)]
      DOTA_CONNECTION_STATE_FAILED = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Fantasy_Roles", EnumPassthru=true)]
    public enum Fantasy_Roles
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_ROLE_UNDEFINED", Value=0)]
      FANTASY_ROLE_UNDEFINED = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_ROLE_CORE", Value=1)]
      FANTASY_ROLE_CORE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_ROLE_SUPPORT", Value=2)]
      FANTASY_ROLE_SUPPORT = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Fantasy_Team_Slots", EnumPassthru=true)]
    public enum Fantasy_Team_Slots
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SLOT_NONE", Value=0)]
      FANTASY_SLOT_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SLOT_CORE", Value=1)]
      FANTASY_SLOT_CORE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SLOT_SUPPORT", Value=2)]
      FANTASY_SLOT_SUPPORT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SLOT_ANY", Value=3)]
      FANTASY_SLOT_ANY = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SLOT_BENCH", Value=4)]
      FANTASY_SLOT_BENCH = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Fantasy_Selection_Mode", EnumPassthru=true)]
    public enum Fantasy_Selection_Mode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_INVALID", Value=0)]
      FANTASY_SELECTION_INVALID = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_LOCKED", Value=1)]
      FANTASY_SELECTION_LOCKED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_SHUFFLE", Value=2)]
      FANTASY_SELECTION_SHUFFLE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_FREE_PICK", Value=3)]
      FANTASY_SELECTION_FREE_PICK = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_ENDED", Value=4)]
      FANTASY_SELECTION_ENDED = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_PRE_SEASON", Value=5)]
      FANTASY_SELECTION_PRE_SEASON = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_PRE_DRAFT", Value=6)]
      FANTASY_SELECTION_PRE_DRAFT = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_DRAFTING", Value=7)]
      FANTASY_SELECTION_DRAFTING = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FANTASY_SELECTION_REGULAR_SEASON", Value=8)]
      FANTASY_SELECTION_REGULAR_SEASON = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTAChatChannelType_t", EnumPassthru=true)]
    public enum DOTAChatChannelType_t
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Regional", Value=0)]
      DOTAChannelType_Regional = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Custom", Value=1)]
      DOTAChannelType_Custom = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Party", Value=2)]
      DOTAChannelType_Party = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Lobby", Value=3)]
      DOTAChannelType_Lobby = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Team", Value=4)]
      DOTAChannelType_Team = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Guild", Value=5)]
      DOTAChannelType_Guild = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Fantasy", Value=6)]
      DOTAChannelType_Fantasy = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Whisper", Value=7)]
      DOTAChannelType_Whisper = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Console", Value=8)]
      DOTAChannelType_Console = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Tab", Value=9)]
      DOTAChannelType_Tab = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Invalid", Value=10)]
      DOTAChannelType_Invalid = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_GameAll", Value=11)]
      DOTAChannelType_GameAll = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_GameAllies", Value=12)]
      DOTAChannelType_GameAllies = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_GameSpectator", Value=13)]
      DOTAChannelType_GameSpectator = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_GameCoaching", Value=14)]
      DOTAChannelType_GameCoaching = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Cafe", Value=15)]
      DOTAChannelType_Cafe = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_CustomGame", Value=16)]
      DOTAChannelType_CustomGame = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_Private", Value=17)]
      DOTAChannelType_Private = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DOTAChannelType_PostGame", Value=18)]
      DOTAChannelType_PostGame = 18
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EProfileCardSlotType", EnumPassthru=true)]
    public enum EProfileCardSlotType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProfileCardSlotType_Empty", Value=0)]
      k_EProfileCardSlotType_Empty = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProfileCardSlotType_Stat", Value=1)]
      k_EProfileCardSlotType_Stat = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProfileCardSlotType_Trophy", Value=2)]
      k_EProfileCardSlotType_Trophy = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProfileCardSlotType_Item", Value=3)]
      k_EProfileCardSlotType_Item = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProfileCardSlotType_Hero", Value=4)]
      k_EProfileCardSlotType_Hero = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProfileCardSlotType_Emoticon", Value=5)]
      k_EProfileCardSlotType_Emoticon = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EMatchGroupServerStatus", EnumPassthru=true)]
    public enum EMatchGroupServerStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMatchGroupServerStatus_OK", Value=0)]
      k_EMatchGroupServerStatus_OK = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMatchGroupServerStatus_LimitedAvailability", Value=1)]
      k_EMatchGroupServerStatus_LimitedAvailability = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMatchGroupServerStatus_Offline", Value=2)]
      k_EMatchGroupServerStatus_Offline = 2
    }
  
}
#pragma warning restore 1591
