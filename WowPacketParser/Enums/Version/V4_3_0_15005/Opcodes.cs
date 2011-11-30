using System.Collections.Generic;

namespace WowPacketParser.Enums.Version//.V4_3_0_15005
{
    public static partial class Opcodes
    {
        private static Dictionary<Opcode, int> _V4_3_0_opcodes = new Dictionary<Opcode, int>
        {
            {Opcode.CMSG_BUY_BANK_SLOT, 0xC00},
            {Opcode.CMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x884},
            {Opcode.CMSG_MAIL_TAKE_ITEM, 0x7C06},
            {Opcode.CMSG_MAIL_TAKE_MONEY, 0x6426},
            {Opcode.CMSG_AUTH_SESSION, 0x1100},
            {Opcode.CMSG_AUTO_DECLINE_GUILD_INVITES, 0x48A2},
            {Opcode.CMSG_AUCTION_LIST_ITEMS, 0x2C26},
            {Opcode.CMSG_AUCTION_PLACE_BID, 0x1020},
            {Opcode.CMSG_SET_ACTIONBAR_TOGGLES, 0x76A4},
            {Opcode.CMSG_BUY_ITEM, 0x1086},
            {Opcode.CMSG_BUYBACK_ITEM, 0x4AA6},
            {Opcode.CMSG_CANCEL_GROWTH_AURA, 0x6A80},
            {Opcode.CMSG_CAST_SPELL, 0x1C82},            
            {Opcode.CMSG_COMMENTATOR_GET_PLAYER_INFO, 0x1E86},
            {Opcode.CMSG_COMMENTATOR_GET_MAP_INFO, 0x3804},
            {Opcode.CMSG_CONTACT_LIST, 0x44A2},
            {Opcode.CMSG_CLEAR_CHANNEL_WATCH, 0x4406},
            {Opcode.CMSG_CANCEL_CAST, 0x6482},
            {Opcode.CMSG_CANCEL_AUTO_REPEAT_SPELL, 0x4600},
            {Opcode.CMSG_CHAR_CREATE, 0x2A86},
            {Opcode.CMSG_CHAR_DELETE, 0x38A4},
            {Opcode.CMSG_CORPSE_MAP_POSITION_QUERY, 0x2E20},
            {Opcode.CMSG_DEL_FRIEND, 0x6EA0},
            {Opcode.CMSG_GET_MAIL_LIST, 0x5222},
            {Opcode.CMSG_GET_MIRRORIMAGE_DATA, 0x7822},
            {Opcode.CMSG_GOSSIP_HELLO, 0x3622},
            {Opcode.CMSG_GMRESPONSE_CREATE_TICKET, 0x6C82},
            {Opcode.CMSG_GMRESPONSE_RESOLVE, 0x284},
            {Opcode.CMSG_GMSURVEY_SUBMIT, 0x70A6},
            {Opcode.CMSG_GMTICKET_DELETETICKET, 0x200},
            {Opcode.CMSG_GMTICKET_UPDATETEXT, 0x32A0},
            {Opcode.CMSG_GM_REPORT_LAG, 0x6CA6},
            {Opcode.CMSG_GROUP_SET_LEADER, 0x5206},
            {Opcode.CMSG_GROUP_ASSISTANT_LEADER, 0x5282},
            {Opcode.CMSG_GRANT_LEVEL, 0x6084},
            {Opcode.CMSG_GROUP_RAID_CONVERT, 0x2482},
            {Opcode.CMSG_GUILD_BANK_QUERY_TAB, 0x5E00},
            {Opcode.CMSG_HEARTH_AND_RESURRECT, 0x7AA4},
            {Opcode.CMSG_INSTANCE_LOCK_RESPONSE, 0x6224},
            {Opcode.CMSG_INSPECT, 0x4222},
            {Opcode.CMSG_JOIN_CHANNEL, 0x074C},
            {Opcode.CMSG_KEEP_ALIVE, 0x66A0},
            {Opcode.CMSG_LIST_INVENTORY, 0x4026},
            {Opcode.CMSG_LOOT_RELEASE, 0x6802},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x7C20},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x136E},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x034C},
            {Opcode.CMSG_NAME_QUERY, 0x7220},
            {Opcode.CMSG_OPENING_CINEMATIC, 0x3800},
            {Opcode.CMSG_OFFER_PETITION, 0x3682},
            {Opcode.CMSG_PETITION_SIGN, 0x5804},
            {Opcode.CMSG_PING, 0x0100},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0326},
            {Opcode.CMSG_PLAYED_TIME, 0x24A2},
            {Opcode.CMSG_PLAYER_LOGOUT, 0x4826},
            {Opcode.CMSG_QUERY_TIME, 0x5200},
            {Opcode.CMSG_STANDSTATECHANGE, 0x7804},
            {Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST, 0x3202},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0x1000},
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x2A06},
            {Opcode.CMSG_QUESTGIVER_REQUEST_REWARD, 0x66A6},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x7E86},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x1284},
            {Opcode.CMSG_QUESTLOG_REMOVE_QUEST, 0xE20},   
            {Opcode.CMSG_QUERY_QUESTS_COMPLETED, 0x5AA0},
            {Opcode.CMSG_REQUEST_PET_INFO, 0x78A6},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x1E80},
            {Opcode.CMSG_REALM_SPLIT, 0x1680},
            {Opcode.CMSG_REPOP_REQUEST,0x6206},
            {Opcode.CMSG_REQUEST_RAID_INFO, 0x7A82},
            {Opcode.CMSG_REQUEST_VEHICLE_EXIT, 0x26A4},
            {Opcode.CMSG_RESET_INSTANCES, 0x7400},
            {Opcode.CMSG_RECLAIM_CORPSE, 0x4282},
            {Opcode.CMSG_SUMMON_CANCEL, 0x5EA6},
            {Opcode.CMSG_SELL_ITEM, 0x3000},
            {Opcode.CMSG_SET_ALLOW_LOW_LEVEL_RAID1, 0x4A2},
            {Opcode.CMSG_SET_ALLOW_LOW_LEVEL_RAID2, 0x7602},
            {Opcode.CMSG_SET_PRIMARY_TALENT_TREE, 0x70A4},
            {Opcode.CMSG_SET_SAVED_INSTANCE_EXTEND, 0x3280},
            {Opcode.CMSG_SET_TAXI_BENCHMARK_MODE, 0x3A06},
            {Opcode.CMSG_SET_TITLE, 0xE00},
            {Opcode.CMSG_SETSHEATHED, 0x4400},
            {Opcode.CMSG_SPIRIT_HEALER_ACTIVATE, 0x4024},
            {Opcode.CMSG_STABLE_PET, 0x5004},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x6200},
            {Opcode.CMSG_SWAP_ITEM, 0x6404},
            {Opcode.CMSG_TAXINODE_STATUS_QUERY, 0x6E02},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x7293},
            {Opcode.CMSG_TRAINER_BUY_SPELL, 0x7EA0},
            {Opcode.CMSG_TRAINER_LIST, 0x4EA6},
            {Opcode.CMSG_TOGGLE_PVP, 0x48A6},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x02A0},
            {Opcode.CMSG_WRAP_ITEM, 0x1824},

            {Opcode.MSG_RANDOM_ROLL, 0x3424},
            {Opcode.MSG_SET_DUNGEON_DIFFICULTY, 0x7006},
            {Opcode.MSG_PETITION_RENAME, 0x4204},
            {Opcode.MSG_SET_RAID_DIFFICULTY, 0x826},
            {Opcode.MSG_RAID_READY_CHECK_CONFIRM, 0x7C00},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x1723},
            {Opcode.SMSG_CHAR_CREATE, 0x2A82},
            {Opcode.SMSG_CHAR_DELETE, 0x2A02},
            {Opcode.SMSG_MESSAGECHAT, 0x3884},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x5E20},
            {Opcode.SMSG_PARTY_MEMBER_STATS_FULL, 0x5680},
            {Opcode.SMSG_PONG, 0x0302},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x2004},
            {Opcode.SMSG_QUESTGIVER_QUEST_FAILED, 0x60A2},
            {Opcode.SMSG_QUESTGIVER_QUEST_LIST, 0x5024},
            {Opcode.SMSG_QUESTLOG_FULL, 0x2A84},
            {Opcode.SMSG_QUESTUPDATE_COMPLETE, 0x6284},
            {Opcode.SMSG_QUESTUPDATE_FAILED, 0x5684},
            {Opcode.SMSG_TRAINER_BUY_FAILED, 0x34A2},
            {Opcode.SMSG_TRAINER_LIST, 0x4C80},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA_COMPLETE, 0x40A4},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x4CA6},
            {Opcode.SMSG_MONSTER_MOVE, 0x60A0},
            {Opcode.SMSG_MONSTER_MOVE_TRANSPORT, 0xEA4},

            // Tests
            {Opcode.TEST_43_34595, 0x8723},
            {Opcode.CMSG_LOAD_SCREEN, 0x0976},
            {Opcode.SMSG_MULTIPLE_PACKETS, 0x0723},


            // SF, TODO: Rename to "TC" opcode names
            {Opcode.SMSG_GUILD_FLAGGED_FOR_RENAME, 0x41A},
            {Opcode.CMSG_GUILD_CHANGE_NAME_REQUEST, 0x224C},
            {Opcode.SMSG_GUILD_CHANGE_NAME_RESULT, 0x241C},
            {Opcode.SMSG_GUILD_MEMBER_DAILY_RESET, 0x243E},
            {Opcode.CMSG_GUILD_REPLACE_GUILD_MASTER, 0x2A48},
            {Opcode.CMSG_GUILD_INVITE_BY_NAME, 0x4936},
            {Opcode.SMSG_GUILD_BANK_QUERY_RESULTS, 0x4C28}, // ???
            {Opcode.SMSG_GUILD_ROSTER_UPDATE, 0x4E3C}, // ???
            {Opcode.CMSG_LFG_PROPOSAL_RESULT, 0x146},
            {Opcode.CMSG_LFG_JOIN, 0x154},
            {Opcode.CMSG_LFG_SET_ROLES, 0x304},
            {Opcode.CMSG_LFG_TELEPORT, 0x366},
            {Opcode.SMSG_LFG_BOOT_PLAYER, 0x924},
            {Opcode.CMSG_LFG_GET_SYSTEM_INFO, 0x926},
            {Opcode.CMSG_LFG_SET_COMMENT, 0xB06},
            {Opcode.CMSG_LFG_GET_STATUS, 0x4144},
            {Opcode.CMSG_LFG_LEAVE, 0x4306},
            {Opcode.CMSG_LFG_LFR_JOIN, 0x4B36},
            {Opcode.CMSG_LFG_LFR_LEAVE, 0x4B44},
            {Opcode.SMSG_SET_DF_FAST_LAUNCH_RESULT, 0x661C},
            {Opcode.SMSG_LFG_UPDATE_STATUS, 0x40A},
            {Opcode.CMSG_SET_EVERYONE_IS_ASSISTANT, 0x376},
            {Opcode.SMSG_RESET_COMPRESSION_CONTEXT, 0x1722}, // ??? must-implement
            {Opcode.SMSG_CUSTOM_LOAD_SCREEN, 0x2438}, // ???
            {Opcode.SMSG_GAME_EVENT_DEBUG_LOG, 0x2498},
            {Opcode.SMSG_SERVER_PERF, 0x2638}, // ???
            {Opcode.SMSG_FLOOD_DETECTED, 0x323},
            {Opcode.SMSG_AREA_TRIGGER_MOVEMENT_UPDATE, 0x438},
            {Opcode.SMSG_LFG_SLOT_INVALID, 0x263E},
            {Opcode.SMSG_XP_GAIN_ABORTED, 0x2C0C},
            {Opcode.SMSG_CHAT_IGNORED_ACCOUNT_MUTED, 0x2E3C},
            {Opcode.SMSG_MAP_OBJ_EVENTS, 0x2E88},
            {Opcode.SMSG_DUMP_RIDE_TICKETS_RESPONSE, 0x4C9A},
            {Opcode.SMSG_UPDATE_SERVER_PLAYER_POSITION, 0x4E9C},
            {Opcode.CMSG_BATTLEFIELD_LEAVE, 0x6203},
            {Opcode.SMSG_CLEAR_COOLDOWNS, 0x64BC},
            {Opcode.SMSG_LOOT_CONTENTS, 0x660A},
            {Opcode.SMSG_PRINT_NOTIFICATION, 0x669A},
            {Opcode.SMSG_GAME_OBJECT_ACTIVATE_ANIM_KIT, 0x6C0A},
            {Opcode.SMSG_LFG_UPDATE_STATUS_NONE, 0x6C28},
            {Opcode.SMSG_ACCOUNT_INFO_RESPONSE, 0x6C3A},
            {Opcode.CMSG_UNLEARN_SPECIALIZATION, 0x7003},
            {Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x269A},
            {Opcode.SMSG_DONT_AUTO_PUSH_SPELLS_TO_ACTION_BAR, 0x26BE},
            {Opcode.SMSG_UPDATE_DUNGEON_ENCOUNTER_FOR_LOOT, 0x449C},
            {Opcode.SMSG_UPDATE_ACTION_BUTTONS, 0x461C},
            {Opcode.SMSG_MISSILE_CANCEL, 0x46B8},
            {Opcode.SMSG_ITEM_EXPIRE_PURCHASE_REFUND, 0x2C08},
            {Opcode.SMSG_VOID_ITEM_SWAP_RESPONSE, 0xC1C},
            {Opcode.CMSG_VOID_STORAGE_TRANSFER, 0x2011},
            {Opcode.SMSG_VOID_TRANSFER_RESULT, 0x2CA8},
            {Opcode.CMSG_UNLOCK_VOID_STORAGE, 0x2681},
            {Opcode.CMSG_SWAP_VOID_ITEM, 0x3291},
            {Opcode.CMSG_QUERY_VOID_STORAGE, 0x3431},
            {Opcode.SMSG_VOID_STORAGE_FAILED, 0x263C},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x2698},
            {Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x4CAE},
            {Opcode.CMSG_TRANSMOGRIFY_ITEMS, 0x3081},
            {Opcode.CMSG_GUILD_MEMBER_SEND_SOR_REQUEST, 0x88C},
            {Opcode.CMSG_SEND_SOR_REQUEST_VIA_BNET_ACCOUNT_ID, 0X4956},
            {Opcode.CMSG_SEND_SOR_REQUEST_VIA_ADDRESS, 0x4B16},
            {Opcode.SMSG_SOR_START_EXPERIENCE_INCOMPLETE, 0x4C8C},

        };
    }
}
