namespace Eternar.Core
{
    using System.Collections.Generic;

    using CitizenFX.Core;
    using CitizenFX.Core.Native;

    public static class Natives
    {
        private static readonly Dictionary<string, Hash> NativeHashes = new Dictionary<string, Hash>
        {
            // Weather
            ["_FORCE_LIGHTNING_FLASH_AT_COORDS"] = (Hash)0x67943537D179597C,

            // Ped
            ["APPLY_DAMAGE_TO_PED"] = (Hash)0x697157CED63F18D4,
            ["IS_PED_FALLING"] = (Hash)0xFB92A102F1C4DFA3,
            ["IS_PED_ON_FOOT"] = (Hash)0x01FEE67DB37F59B2,
            ["CLEAR_PED_BLOOD_DAMAGE"] = (Hash)0x8FE22675A5A45817,
            ["CLEAR_PED_WETNESS"] = (Hash)0x9C720776DAA43E7E,
            ["SET_PED_CAN_BE_TARGETTED"] = (Hash)0x63F58F7C80513AAD,
            ["SET_PED_CAN_RAGDOLL"] = (Hash)0xB128377056A54E2A,
            ["SET_PED_COMBAT_ABILITY"] = (Hash)0xC7622C0D36B2FDA8,
            ["CLEAR_PED_ENV_DIRT"] = (Hash)0x6585D955A68452A5,
            ["_GET_PED_HEIGHT"] = (Hash)0x1D491CCF7211FB74,
            ["_SET_PED_SCALE"] = (Hash)0x25ACFC650B65C538,
            ["IS_PED_STILL"] = (Hash)0xAC29253EEF8F0180,
            ["IS_PED_STOPPED"] = (Hash)0x530944F6F4B8A214,
            ["DISABLE_PED_PAIN_AUDIO"] = (Hash)0xA9A41C1E940FB0E8,
            ["SET_PED_INTO_VEHICLE"] = (Hash)0xF75B0D629E1C063D,
            ["GET_VEHICLE_PED_IS_IN"] = (Hash)0x9A9112A0FE9A4713,
            ["GET_VEHICLE_PED_IS_ENTERING"] = (Hash)0xF92691AED837A5FC,
            ["GET_VEHICLE_PED_IS_USING"] = (Hash)0x6094AD011A2EA87D,
            ["GET_PED_IN_VEHICLE_SEAT"] = (Hash)0xBB40DD2270B65366,
            ["SET_BLOCKING_OF_NON_TEMPORARY_EVENTS"] = (Hash)0x9F8AA94D6D97DBF4,
            ["SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE"] = (Hash)0x7A6535691B477C48,
            ["CLEAR_PED_TASKS_IMMEDIATELY"] = (Hash)0xAAA34F8A7CB32098,
            ["IS_PED_MALE"] = (Hash)0x6D9F5FAA7488BA46,
            ["_GET_ATTRIBUTE_CORE_VALUE"] = (Hash)0x36731AC041289BB1,
            ["_SET_ATTRIBUTE_CORE_VALUE"] = (Hash)0xC6258F41D86676E0,
            ["CLEAR_PED_LAST_DAMAGE_BONE"] = (Hash)0x8EF6B7AC68E2F01B,
            ["CLEAR_PED_WETNESS"] = (Hash)0x9C720776DAA43E7E,
            ["CREATE_PED_INSIDE_VEHICLE"] = (Hash)0x7DD959874C1FD534,
            ["CLONE_PED"] = (Hash)0xEF29A16337FACADB,
            ["_FREEZE_PED_CAMERA_ROTATION"] = (Hash)0xFF287323B0E2C69A,
            ["GET_PED_CAUSE_OF_DEATH"] = (Hash)0x16FFE42AB2D2DC59,
            ["GET_PED_IS_BEING_GRAPPLED"] = (Hash)0x3BDFCF25B58B0415,
            ["GET_PED_IS_GRAPPLING"] = (Hash)0x0E99E3BF11BB6367,
            ["GET_PED_MONEY"] = (Hash)0x3F69145BBA87BAE7,
            ["GET_PED_TIME_OF_DEATH"] = (Hash)0x1E98817B311AE98A,
            ["IS_PED_CARRYING_SOMETHING"] = (Hash)0xA911EE21EDF69DAF,
            ["IS_PED_DIVING"] = (Hash)0x5527B8246FEF9B11,
            ["IS_PED_INJURED"] = (Hash)0x84A2DD9AC37C35C1,
            ["IS_PED_SHOOTING"] = (Hash)0x34616828CD07F1A1,
            ["IS_PED_SITTING"] = (Hash)0x84D0BF2B21862059,
            ["SET_PED_MAX_HEALTH"] = (Hash)0xF5F6378C4F3419D3,
            ["SET_PED_MONEY"] = (Hash)0xA9C8960E8684C1B5,
            ["IS_PED_CUFFED"] = (Hash)0x74E559B3BC910685,
            ["IS_PED_IN_WRITHE"] = (Hash)0xDEB6D52126E7D640,
            ["IS_PED_RUNNING"] = (Hash)0xC5286FFC176F28A2,
            ["IS_PED_WALKING"] = (Hash)0xDE4C184B2B9B071A,
            ["REMOVE_ALL_PED_WEAPONS"] = (Hash)0xF25DF915FA38C5F3,
            ["REMOVE_WEAPON_FROM_PED"] = (Hash)0x4899CB088EDF59B8,
            ["SET_PED_AMMO"] = (Hash)0x14E56BC5B5DB6A19,
            ["SET_PED_INFINITE_AMMO"] = (Hash)0x3EDCB0505123623B,
            ["RESURRECT_PED"] = (Hash)0x71BC8E838B9C6035,
            ["GET_PED_SOURCE_OF_DEATH"] = (Hash)0x93C8B64DEB84728C,
            ["SET_PED_IS_DRUNK"] = (Hash)0x95D2D383D5396B8A,

            ["_RESTORE_PED_STAMINA"] = (Hash)0x675680D089BFA21F,
            ["_GET_PED_MAX_STAMINA"] = (Hash)0xCB42AFE2B613EE55,
            ["_CHANGE_PED_STAMINA"] = (Hash)0xC3D4B754C0E86B9E,
            
            ["IS_PED_ENTERING_TRANSPORT"] = (Hash)0x619E63980BFC0096,
            ["IS_PED_EXITING_TRANSPORT"] = (Hash)0x660639BC60157048,

            // Blip
            ["GET_BLIP_FROM_ENTITY"] = (Hash)0x6D2C41A8BD6D6FD0,
            ["GET_BLIP_COORDS"] = (Hash)0x201C319797BDA603,
            ["DOES_BLIP_EXIST"] = (Hash)0xCD82FA174080B3B1,

            // Map
            ["IS_WAYPOINT_ACTIVE"] = (Hash)0x202B1BBFC6AB5EE4,
            ["_GET_WAYPOINT_COORDS"] = (Hash)0x29B30D07C3F7873B,
            ["CLEAR_GPS_PLAYER_WAYPOINT"] = (Hash)0x08FDC6F796E350D1,

            // World
            ["GET_GROUND_Z_FOR_3D_COORD"] = (Hash)0x24FA4267BB8D2431,
            ["GET_GROUND_Z_AND_NORMAL_FOR_3D_COORD"] = (Hash)0x2A29CA9A6319E6AB,
            ["_GET_HEIGHTMAP_BOTTOM_Z_FOR_POSITION"] = (Hash)0x336511A34F2E5185,

            // Entity
            ["PLACE_ENTITY_ON_GROUND_PROPERLY"] = (Hash)0x9587913B9E772D29,
            ["GET_ENTITY_HEIGHT_ABOVE_GROUND"] = (Hash)0x0D3B5BAEA08F63E9,
            ["GET_ENTITY_COORDS"] = (Hash)0xA86D5F069399F44D,
            ["SET_ENTITY_COORDS"] = (Hash)0x06843DA7060A026B,
            ["GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS"] = (Hash)0x1899F328B0E12848,
            ["SET_ENTITY_COORDS_NO_OFFSET"] = (Hash)0x239A3351AC1DA385,
            ["SET_ENTITY_HEADING"] = (Hash)0xCF2B9C0645C4651B,
            ["GET_ENTITY_HEADING"] = (Hash)0xC230DD956E2F5507,
            ["GET_ENTITY_ROTATION"] = (Hash)0xE09CAF86C32CB48F,
            ["SET_ENTITY_ROTATION"] = (Hash)0x9CC8314DFEDE441E,
            ["GET_ENTITY_VELOCITY"] = (Hash)0x4805D2B1D8CF94A9,
            ["SET_ENTITY_VELOCITY"] = (Hash)0x1C99BB7B6E96D16F,
            ["SET_ENTITY_INVINCIBLE"] = (Hash)0xA5C38736C426FCB8,
            ["IS_ENTITY_ON_SCREEN"] = (Hash)0x613C15D5D8DB781F,
            ["HAS_ENTITY_CLEAR_LOS_TO_ENTITY"] = (Hash)0xFCDFF7B72D23A1AC,
            ["DOES_ENTITY_EXIST"] = (Hash)0xD42BD6EB2E0F1677,
            ["SET_ENTITY_AS_MISSION_ENTITY"] = (Hash)0xDC19C288082E586E,
            ["DELETE_ENTITY"] = (Hash)0x4CD38C78BD19A497,
            ["IS_ENTITY_DEAD"] = (Hash)0x7D5B1F88E7504BBA,
            ["GET_ENTITY_TYPE"] = (Hash)0x97F696ACA466B4E0,
            ["GET_ENTITY_HEALTH"] = (Hash)0x82368787EA73C0F7,
            ["SET_ENTITY_HEALTH"] = (Hash)0xAC2767ED8BDFAB15,
            ["_GET_ENTITY_HEALTH_FLOAT"] = (Hash)0x96C638784DB4C815,
            ["GET_ENTITY_MAX_HEALTH"] = (Hash)0x15D757606D170C3C,
            ["SET_ENTITY_MAX_HEALTH"] = (Hash)0x166E7CF68597D8B5,
            ["GET_ENTITY_SPEED"] = (Hash)0xFB6BA510A533DF81,
            ["GET_ENTITY_SPEED_VECTOR"] = (Hash)0xF2DB09816A419DC5,
            ["GET_ENTITY_MODEL"] = (Hash)0xDA76A9F39210D365,
            ["GET_ENTITY_FORWARD_VECTOR"] = (Hash)0x2412D9C05BB09B97,
            ["FREEZE_ENTITY_POSITION"] = (Hash)0x7D9EFB7AD6B19754,

            ["IS_CONTROL_PRESSED"] = (Hash)0xF3A21BCD95725A4A,

            // Player
            ["SET_SUPER_JUMP_THIS_FRAME"] = (Hash)0xB3E9BE963F10C445,
            ["SET_SWIM_MULTIPLIER_FOR_PLAYER"] = (Hash)0xBFCEABDE34DA5085,
            ["PLAYER_ID"] = (Hash)0x217E9DC48139933D,
            ["PLAYER_PED_ID"] = (Hash)0x096275889B8E0EE0,
            ["GET_PLAYER_PED"] = (Hash)0x275F255ED201B937,
            ["BOOST_PLAYER_HORSE_SPEED_FOR_TIME"] = (Hash)0x09C28F828EE674FA,
            ["GET_PLAYER_NAME"] = (Hash)0x7124FD9AC0E01BA0,
            ["_SET_PED_BRAWLING_STYLE"] = (Hash)0x8BA83CC4288CD56D,
            ["DISABLE_PLAYER_FIRING"] = (Hash)0x2970929FD5F9FC89,
            ["GET_ENTITY_PLAYER_IS_FREE_AIMING_AT"] = (Hash)0xA6817C110B830EAD,
            ["_GET_PLAYER_HEALTH"] = (Hash)0x0317C947D062854E,
            ["GET_PLAYER_INVINCIBLE"] = (Hash)0x0CBBCB2CCFA7DC4E,
            ["_GET_PLAYER_STAMINA"] = (Hash)0x0FF421E467373FCF,
            ["IS_PLAYER_CLIMBING"] = (Hash)0xB8A70C22FD48197A,
            ["IS_PLAYER_RIDING_TRAIN"] = (Hash)0x2FB0ACADA6A238DD,
            ["IS_PLAYER_TARGETTING_ENTITY"] = (Hash)0x27F89FDC16688A7A,
            ["SET_PLAYER_MODEL"] = (Hash)0xED40380076A31506,
            ["SET_PLAYER_WEAPON_DAMAGE_MODIFIER"] = (Hash)0x94D529F7B73D7A85,
            ["IS_PLAYER_PLAYING"] = (Hash)0xBFFB35986CAAE58C,
            ["SET_EVERYONE_IGNORE_PLAYER"] = (Hash)0x34630A768925B852,

            ["NETWORK_IS_PLAYER_ACTIVE"] = (Hash)0xB8DFD30D6973E135,

            // Vehicle
            ["CREATE_VEHICLE"] = (Hash)0xAF35D0D2583051B0,
            ["DELETE_VEHICLE"] = (Hash)0xE20A909D8C4A70F8,

            ["_CREATE_MISSION_TRAIN"] = (Hash)0xC239DBD9A57D2A71,
            ["DELETE_ALL_TRAINS"] = (Hash)0xA3120A1385F17FF7,
            ["DELETE_MISSION_TRAIN"] = (Hash)0x0D3630FB07E8B570,
            ["SET_RANDOM_TRAINS"] = (Hash)0x1156C6EE7E82A98A,
            ["_SET_TRAIN_STOPS_FOR_STATIONS"] = (Hash)0x4182C037AA1F0091,

            ["SET_TRAIN_CRUISE_SPEED"] = (Hash)0x01021EB2E96B793C,
            ["_SET_TRAIN_MAX_SPEED"] = (Hash)0x9F29999DFDF2AEB8,
            ["SET_TRAIN_SPEED"] = (Hash)0xDFBA6BBFF7CCAFBB,

            ["SET_VEHICLE_CAN_BE_TARGETTED"] = (Hash)0x05254BA0B44ADC16,
            ["CAN_SHUFFLE_SEAT"] = (Hash)0xF8B2D32A2231FD24,

            // Model
            ["SET_MODEL_AS_NO_LONGER_NEEDED"] = (Hash)0x4AD96EF928BD4F9A,
            ["REQUEST_MODEL"] = (Hash)0xFA28FE3A6246FC30,
            ["HAS_MODEL_LOADED"] = (Hash)0x1283B8B89DD5D1B6,
            ["IS_MODEL_IN_CDIMAGE"] = (Hash)0xD6F3B6D7716CFF8E,
            ["IS_MODEL_A_VEHICLE"] = (Hash)0x354F62672DE7DB0A,
            ["IS_MODEL_VALID"] = (Hash)0x392C8D8E07B70EFC,
            ["_IS_THIS_MODEL_A_HORSE"] = (Hash)0x772A1969F649E902,

            ["GET_HASH_KEY"] = (Hash)0xFD340785ADF8CFB7,

            // Graphics
            ["GET_SCREEN_COORD_FROM_WORLD_COORD"] = (Hash)0xCB50D7AFCC8B0EC6,
            ["GET_SCREEN_RESOLUTION"] = (Hash)0x66773C92835D0909,
            ["SET_SCRIPT_GFX_DRAW_ORDER"] = (Hash)0xCFCC78391C8B3814,

            // Hud
            ["_BG_SET_TEXT_COLOR"] = (Hash)0x16FA5CE47F184F1E,
            ["_BG_SET_TEXT_SCALE"] = (Hash)0xA1253A3C870B6843,
            ["_BG_DISPLAY_TEXT"] = (Hash)0x16794E044C9EFB58,
            ["SET_TEXT_FONT"] = (Hash)0x66E0276CC5F6B9DA,
            ["SET_TEXT_DROPSHADOW"] = (Hash)0x465C84BC39F1C351,
            ["IS_PAUSE_MENU_ACTIVE"] = (Hash)0x535384D6067BA42E,

            // Misc
            ["VAR_STRING"] = (Hash)0xFA925AC00EB830B9,
            ["VDIST"] = (Hash)0x2A488C176D52CCA5,
            ["VDIST2"] = (Hash)0xB7A628320EFF8E47,

            // Event
            ["SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME"] = (Hash)0x84994FAD4E4E4E69,

            // Fire
            ["ADD_EXPLOSION"] = (Hash)0x7D6F58F69DA92530,
            ["ADD_OWNED_EXPLOSION"] = (Hash)0xD84A917A64D4D016,
            ["ADD_EXPLOSION_WITH_USER_VFX"] = (Hash)0x53BA259F3A67A99E,

            // Networking
            ["NET_TO_VEH"] = (Hash)0xBFFEAB45A9A9094A,
            ["NET_TO_ENT"] = (Hash)0x367B936610BA360C,
            ["NET_TO_OBJ"] = (Hash)0xD8515F5FEA14CB3F,
            ["NET_TO_PED"] = (Hash)0xBDCD95FC216A8B3E,

            ["PED_TO_NET"] = (Hash)0x0EDEC3C276198689,
            ["OBJ_TO_NET"] = (Hash)0x99BFDC94A603E541,
            ["VEH_TO_NET"] = (Hash)0xB4C94523F023419C,

            ["NETWORK_IS_HOST"] = (Hash)0x8DB296B814EDDA07,
            ["NETWORK_GET_ENTITY_FROM_NETWORK_ID"] = (Hash)0xCE4E5D9B0A4FF560,

            // Map
            ["BLIP_ADD_FOR_COORDS"] = (Hash)0x554D9D53F696D002,
            ["BLIP_ADD_FOR_ENTITY"] = (Hash)0x23F74C2FDA6E7C61,
            ["BLIP_ADD_FOR_RADIUS"] = (Hash)0x45F13B7E0A15C880,

            ["REMOVE_BLIP"] = (Hash)0xF2C3C9DA47AAA54A,
            ["SET_BLIP_ROTATION"] = (Hash)0x6049966A94FBE706,
            ["SET_BLIP_SCALE"] = (Hash)0xD38744167B2FA257,
            ["SET_BLIP_SPRITE"] = (Hash)0x74F74D3207ED525C,
            ["SET_BLIP_FLASHES"] = (Hash)0x0DF2B55F717DDB10,
            ["IS_BLIP_ON_MINIMAP"] = (Hash)0x46534526B9CD2D17,
            ["_SET_BLIP_NAME_FROM_PLAYER_STRING"] = (Hash)0x9CB1A1623062F402,

            // Cam
            ["IS_SCREEN_FADING_IN"] = (Hash)0x0CECCC63FFA2EF24,
            ["IS_SCREEN_FADING_OUT"] = (Hash)0x02F39BEFE7B88D00,
            ["IS_SCREEN_FADED_OUT"] = (Hash)0xF5472C80DF2FF847,
            ["IS_SCREEN_FADED_IN"] = (Hash)0x37F9A426FBCF4AF2,

            ["DO_SCREEN_FADE_IN"] = (Hash)0x6A053CF596F67DF7,
            ["DO_SCREEN_FADE_OUT"] = (Hash)0x40C719A5E410B9E4,

            // Task
            ["TASK_STAND_STILL"] = (Hash)0x919BE13EED931959,
            ["TASK_JUMP"] = (Hash)0x0AE4086104E067B1,
            ["TASK_WHISTLE_ANIM"] = (Hash)0xD6401A1B2F63BED6,
            ["TASK_PAUSE"] = (Hash)0xE73A266DB0CA9042,
        };

        public static void ForceLightningFlashAtCoords(float x, float y, float z)
            => Function.Call(NativeHashes["_FORCE_LIGHTNING_FLASH_AT_COORDS"], x, y, z);

        public static void ApplyDamageToPed(int ped, int damage, bool armorFirst)
            => Function.Call(NativeHashes["APPLY_DAMAGE_TO_PED"], ped, damage, armorFirst);

        public static int GetBlipFromEntity(int entity)
            => Function.Call<int>(NativeHashes["GET_BLIP_FROM_ENTITY"], entity);

        public static Vector3 GetBlipCoords(int handle)
            => Function.Call<Vector3>(NativeHashes["GET_BLIP_COORDS"], handle);

        public static bool DoesBlipExists(int handle)
            => Function.Call<bool>(NativeHashes["DOES_BLIP_EXIST"], handle);

        public static bool IsWaypointActive()
            => Function.Call<bool>(NativeHashes["IS_WAYPOINT_ACTIVE"]);

        public static Vector3 GetWaypointCoords()
            => Function.Call<Vector3>(NativeHashes["_GET_WAYPOINT_COORDS"]);

        public static bool GetGroundZFor_3dCoord(Vector3 coords, ref float groundz)
        {
            OutputArgument outZ = new OutputArgument();

            bool result = Function.Call<bool>(NativeHashes["GET_GROUND_Z_FOR_3D_COORD"], coords.X, coords.Y, coords.Z, outZ);

            groundz = outZ.GetResult<float>();
            return result;
        }

        public static bool GetGroundZFor_3dCoord(float x, float y, float z, ref float groundz)
        {
            OutputArgument outZ = new OutputArgument();

            bool result = Function.Call<bool>(NativeHashes["GET_GROUND_Z_FOR_3D_COORD"], x, y, z, outZ);

            groundz = outZ.GetResult<float>();
            return result;
        }

        public static bool GetGroundZ_AndNormal_For_3dCoord(Vector3 coords, ref float groundz, ref Vector3 normal)
        {
            OutputArgument outNormal = new OutputArgument();
            OutputArgument outZ = new OutputArgument();

            bool result = Function.Call<bool>(NativeHashes["GET_GROUND_Z_AND_NORMAL_FOR_3D_COORD"], coords.X, coords.Y, coords.Z, outZ, outNormal);

            groundz = outZ.GetResult<float>();
            normal = outNormal.GetResult<Vector3>();
            return result;
        }

        public static bool GetGroundZ_AndNormal_For_3dCoord(float x, float y, float z, ref float groundz, ref Vector3 normal)
        {
            OutputArgument outNormal = new OutputArgument();
            OutputArgument outZ = new OutputArgument();

            bool result = Function.Call<bool>(NativeHashes["GET_GROUND_Z_AND_NORMAL_FOR_3D_COORD"], x, y, z, outZ, outNormal);

            groundz = outZ.GetResult<float>();
            normal = outNormal.GetResult<Vector3>();
            return result;
        }

        public static void PlaceEntityOnGroundProperly(int entity)
            => Function.Call(NativeHashes["PLACE_ENTITY_ON_GROUND_PROPERLY"], entity, false);

        public static float GetEntityHeightAboveGround(int entity)
            => Function.Call<float>(NativeHashes["GET_ENTITY_HEIGHT_ABOVE_GROUND"], entity);

        public static Vector3 GetEntityCoords(int entity, bool alive, bool realCoords)
            => Function.Call<Vector3>(NativeHashes["GET_ENTITY_COORDS"], entity, alive, realCoords);

        public static bool IsPedFalling(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_FALLING"], ped);

        public static bool IsPedOnFoot(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_ON_FOOT"], ped);

        public static Vector3 GetOffsetFromEntityInWorldCoords(int entity, float offsetX, float offsetY, float offsetZ)
            => Function.Call<Vector3>(NativeHashes["GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS"], entity, offsetX, offsetY, offsetZ);

        public static void SetEntityCoordsNoOffset(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis)
            => Function.Call(NativeHashes["SET_ENTITY_COORDS_NO_OFFSET"], entity, xPos, yPos, zPos, xAxis, yAxis, zAxis);

        public static void SetEntityHeading(int entity, float heading)
            => Function.Call(NativeHashes["SET_ENTITY_HEADING"], entity, heading);

        public static float GetEntityHeading(int entity)
            => Function.Call<float>(NativeHashes["GET_ENTITY_HEADING"], entity);

        public static bool IsControlPressed(int padIndex, uint control)
            => Function.Call<bool>(NativeHashes["IS_CONTROL_PRESSED"], padIndex, control);

        public static void ClearPedBloodDamage(int ped)
            => Function.Call(NativeHashes["CLEAR_PED_BLOOD_DAMAGE"], ped);

        public static void ClearPedWetness(int ped)
            => Function.Call(NativeHashes["CLEAR_PED_WETNESS"], ped);

        public static void ClearPedEnvDirt(int ped)
            => Function.Call(NativeHashes["CLEAR_PED_ENV_DIRT"], ped);

        public static void SetEntityInvincible(int ped, bool state)
            => Function.Call(NativeHashes["SET_ENTITY_INVINCIBLE"], ped, state);

        public static void SetPedCanBeTargetted(int ped, bool state)
            => Function.Call(NativeHashes["SET_PED_CAN_BE_TARGETTED"], ped, state);

        public static void SetPedCanRagdoll(int ped, bool state)
            => Function.Call(NativeHashes["SET_PED_CAN_RAGDOLL"], ped, state);

        public static void RestorePedStamina(int ped, float stamina)
            => Function.Call(NativeHashes["_RESTORE_PED_STAMINA"], ped, stamina);

        public static float GetPedMaxStamina(int ped)
            => Function.Call<float>(NativeHashes["_GET_PED_MAX_STAMINA"], ped);

        public static void SetPedCombatAbility(int ped, CombatAbilityLevel abilityLevel)
            => Function.Call(NativeHashes["SET_PED_COMBAT_ABILITY"], ped, abilityLevel);

        public static void SetSuperJumpThisFrame(int player)
            => Function.Call(NativeHashes["SET_SUPER_JUMP_THIS_FRAME"], player);

        public static void SetSwimMultiplierForPlayer(int player, float multiplier)
            => Function.Call(NativeHashes["SET_SWIM_MULTIPLIER_FOR_PLAYER"], player, multiplier);

        public static int PlayerId()
            => Function.Call<int>(NativeHashes["PLAYER_ID"]);

        public static float GetHeightMapBottomZForPosition(float left, float right)
            => Function.Call<float>(NativeHashes["_GET_HEIGHTMAP_BOTTOM_Z_FOR_POSITION"], left, right);

        public static float GetPedHeight(int ped)
            => Function.Call<float>(NativeHashes["_GET_PED_HEIGHT"], ped);

        public static bool ChangePedStamina(int ped, float amount)
            => Function.Call<bool>(NativeHashes["_CHANGE_PED_STAMINA"], ped, amount);

        public static void SetPedScale(int ped, float scale)
            => Function.Call(NativeHashes["_SET_PED_SCALE"], ped, scale);

        public static bool IsPedStill(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_STILL"], ped);

        public static bool IsPedStopped(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_STOPPED"], ped);

        public static Vector3 GetEntityVelocity(int entity, bool p2)
            => Function.Call<Vector3>(NativeHashes["GET_ENTITY_VELOCITY"], entity, p2);

        public static void SetEntityVelocity(int entity, float x, float y, float z)
            => Function.Call(NativeHashes["SET_ENTITY_VELOCITY"], entity, x, y, z);

        public static void SetEntityVelocity(int entity, Vector3 velocity)
            => Function.Call(NativeHashes["SET_ENTITY_VELOCITY"], entity, velocity.X, velocity.Y, velocity.Z);

        public static void DisablePedPainAudio(int ped, bool state)
            => Function.Call(NativeHashes["DISABLE_PED_PAIN_AUDIO"], ped, state);

        public static int CreateVehicle(uint hash, float x, float y, float z, float heading, bool isNetwork, bool bScriptHostVeh = false)
            => Function.Call<int>(NativeHashes["CREATE_VEHICLE"], hash, x, y, z, heading, isNetwork, bScriptHostVeh, false, false);

        public static int CreateVehicle(uint hash, Vector3 coords, float heading, bool isNetwork, bool bScriptHostVeh = false)
            => Function.Call<int>(NativeHashes["CREATE_VEHICLE"], hash, coords.X, coords.Y, coords.Z, heading, isNetwork, bScriptHostVeh, false, false);

        public static void SetModelAsNoLongerNeeded(uint hash)
            => Function.Call(NativeHashes["SET_MODEL_AS_NO_LONGER_NEEDED"], hash);

        public static uint GetHashKey(string str)
            => Function.Call<uint>(NativeHashes["GET_HASH_KEY"], str);

        public static void SetPedIntoVehicle(int ped, int vehicle, VehicleSeat seatIndex)
            => Function.Call(NativeHashes["SET_PED_INTO_VEHICLE"], ped, vehicle, seatIndex);

        public static void RequestModel(uint hash)
            => Function.Call(NativeHashes["REQUEST_MODEL"], hash);

        public static bool HasModelLoaded(uint hash)
            => Function.Call<bool>(NativeHashes["HAS_MODEL_LOADED"], hash);

        public static bool IsModelInCdImage(uint hash)
            => Function.Call<bool>(NativeHashes["IS_MODEL_IN_CDIMAGE"], hash);

        public static bool IsModelAVehicle(uint hash)
            => Function.Call<bool>(NativeHashes["IS_MODEL_A_VEHICLE"], hash);

        public static bool IsModelValid(uint hash)
            => Function.Call<bool>(NativeHashes["IS_MODEL_VALID"], hash);

        public static int GetPlayerPed(int player)
            => Function.Call<int>(NativeHashes["GET_PLAYER_PED"], player);

        public static bool IsModelAHorse(uint hash)
            => Function.Call<bool>(NativeHashes["_IS_THIS_MODEL_A_HORSE"], hash);

        public static void BoostPlayerHorseSpeedForTime(int player, float speedBoost, int duration)
            => Function.Call(NativeHashes["BOOST_PLAYER_HORSE_SPEED_FOR_TIME"], player, speedBoost, duration);

        public static int GetVehiclePedIsIn(int ped, bool lastVehicle)
            => Function.Call<int>(NativeHashes["GET_VEHICLE_PED_IS_IN"], ped, lastVehicle);

        public static int GetVehiclePedIsEntering(int ped)
            => Function.Call<int>(NativeHashes["GET_VEHICLE_PED_IS_ENTERING"], ped);

        public static int GetVehiclePedIsUsing(int ped)
            => Function.Call<int>(NativeHashes["GET_VEHICLE_PED_IS_USING"], ped);

        public static bool IsEntityOnScreen(int entity)
            => Function.Call<bool>(NativeHashes["IS_ENTITY_ON_SCREEN"], entity);

        public static void GetScreenResolution(ref int x, ref int y)
        {
            OutputArgument outX = new OutputArgument();
            OutputArgument outY = new OutputArgument();

            Function.Call(NativeHashes["GET_SCREEN_RESOLUTION"], outX, outY);

            x = outX.GetResult<int>();
            y = outY.GetResult<int>();
        }

        public static bool GetScreenCoordFromWorldCoord(float worldX, float worldY, float worldZ, ref float screenX, ref float screenY)
        {
            OutputArgument outX = new OutputArgument();
            OutputArgument outY = new OutputArgument();

            bool result = Function.Call<bool>(NativeHashes["GET_SCREEN_COORD_FROM_WORLD_COORD"], worldX, worldY, worldZ, outX, outY);

            screenX = outX.GetResult<float>();
            screenY = outY.GetResult<float>();
            return result;
        }

        public static VarString CreateVarString(string text)
            => Function.Call<long>(NativeHashes["VAR_STRING"], VarStringFlag.Text, "LITERAL_STRING", text);

        public static void DisplayText(VarString str, float x, float y)
            => Function.Call(NativeHashes["_BG_DISPLAY_TEXT"], str.Text, x, y);

        public static void SetTextColor(int r, int g, int b, int a)
            => Function.Call(NativeHashes["_BG_SET_TEXT_COLOR"], r, g, b, a);

        public static void SetTextScale(float scaleX, float scaleY)
            => Function.Call(NativeHashes["_BG_SET_TEXT_SCALE"], scaleX, scaleY);

        public static void SetTextCentre(bool align)
            => API.SetTextCentre(align);

        public static void SetTextFont(int fontType)
            => Function.Call(NativeHashes["SET_TEXT_FONT"], fontType);

        public static bool NetworkIsPlayerActive(int player)
            => Function.Call<bool>(NativeHashes["NETWORK_IS_PLAYER_ACTIVE"], player);

        public static string GetPlayerName(int player)
            => Function.Call<string>(NativeHashes["GET_PLAYER_NAME"], player);

        public static bool HasEntityClearLosToEntity(int entity, int targetEntity, int traceType)
            => Function.Call<bool>(NativeHashes["HAS_ENTITY_CLEAR_LOS_TO_ENTITY"], entity, targetEntity, traceType);

        public static bool DoesEntityExists(int entity)
            => Function.Call<bool>(NativeHashes["DOES_ENTITY_EXIST"], entity);

        public static float VDIST(float x1, float y1, float z1, float x2, float y2, float z2)
            => Function.Call<float>(NativeHashes["VDIST"], x1, y1, z1, x2, y2, z2);

        public static float VDIST(Vector3 firstCoord, Vector3 secondCoord)
            => Function.Call<float>(NativeHashes["VDIST"], firstCoord.X, firstCoord.Y, firstCoord.Z, secondCoord.X, secondCoord.Y, secondCoord.Z);

        public static float VDIST2(float x1, float y1, float z1, float x2, float y2, float z2)
            => Function.Call<float>(NativeHashes["VDIST2"], x1, y1, z1, x2, y2, z2);

        public static float VDIST2(Vector3 firstCoord, Vector3 secondCoord)
            => Function.Call<float>(NativeHashes["VDIST2"], firstCoord.X, firstCoord.Y, firstCoord.Z, secondCoord.X, secondCoord.Y, secondCoord.Z);

        public static void SetTextDropShadow(int distance, int r, int g, int b, int a)
            => Function.Call(NativeHashes["SET_TEXT_DROPSHADOW"], distance, r, g, b, a);

        public static void SetScriptGfxDrawOrder(int drawOrder)
            => Function.Call(NativeHashes["SET_SCRIPT_GFX_DRAW_ORDER"], drawOrder);

        public static void ClearGpsPlayerWaypoint()
            => Function.Call(NativeHashes["CLEAR_GPS_PLAYER_WAYPOINT"]);

        public static bool IsPauseMenuActive()
            => Function.Call<bool>(NativeHashes["IS_PAUSE_MENU_ACTIVE"]);

        public static int PlayerPedId()
            => Function.Call<int>(NativeHashes["PLAYER_PED_ID"]);

        public static void SetEntityAsMissionEntity(int entity, bool p1, bool p2)
            => Function.Call(NativeHashes["SET_ENTITY_AS_MISSION_ENTITY"], entity, p1, p2);

        public static void DeleteVehicle(ref int vehicle)
        {
            OutputArgument outVehicle = new OutputArgument();
            Function.Call(NativeHashes["DELETE_VEHICLE"], vehicle);
            vehicle = outVehicle.GetResult<int>();
        }

        public static void SuppressShockingEventsNextFrame()
            => Function.Call(NativeHashes["SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME"]);

        public static void AddExplosion(Vector3 coords, ExplosionTag explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
            => Function.Call(NativeHashes["ADD_EXPLOSION"], coords.X, coords.Y, coords.Z, explosionType, damageScale, isAudible, isInvisible, cameraShake);

        public static void AddExplosion(float x, float y, float z, ExplosionTag explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
            => Function.Call(NativeHashes["ADD_EXPLOSION"], x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake);

        public static void AddOwnedExplosion(Vector3 coords, ExplosionTag explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
            => Function.Call(NativeHashes["ADD_OWNED_EXPLOSION"], coords.X, coords.Y, coords.Z, explosionType, damageScale, isAudible, isInvisible, cameraShake);

        public static void AddOwnedExplosion(float x, float y, float z, ExplosionTag explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
            => Function.Call(NativeHashes["ADD_OWNED_EXPLOSION"], x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake);

        public static void AddExplosionWithUserVfx(Vector3 coords, ExplosionTag explosionType, uint explosionFx, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
            => Function.Call(NativeHashes["ADD_EXPLOSION_WITH_USER_VFX"], coords.X, coords.Y, coords.Z, explosionType, explosionFx, damageScale, isAudible, isInvisible, cameraShake);

        public static void AddExplosionWithUserVfx(float x, float y, float z, ExplosionTag explosionType, uint explosionFx, float damageScale, bool isAudible, bool isInvisible, float cameraShake)
            => Function.Call(NativeHashes["ADD_EXPLOSION_WITH_USER_VFX"], x, y, z, explosionType, explosionFx, damageScale, isAudible, isInvisible, cameraShake);

        public static bool GetClosestFirePos(ref Vector3 outPosition, float x, float y, float z)
        {
            OutputArgument outVector = new OutputArgument();
            bool result = Function.Call<bool>(NativeHashes["GET_CLOSEST_FIRE_POS"], x, y, z);
            outPosition = outVector.GetResult<Vector3>();
            return result;
        }

        public static bool GetClosestFirePos(ref Vector3 outPosition, Vector3 coords)
        {
            OutputArgument outVector = new OutputArgument();
            bool result = Function.Call<bool>(NativeHashes["GET_CLOSEST_FIRE_POS"], coords.X, coords.Y, coords.Z);
            outPosition = outVector.GetResult<Vector3>();
            return result;
        }

        public static int NetToVeh(int netHandle)
            => Function.Call<int>(NativeHashes["NET_TO_VEH"], netHandle);

        public static int NetToEnt(int netHandle)
            => Function.Call<int>(NativeHashes["NET_TO_ENT"], netHandle);

        public static int NetToObj(int netHandle)
            => Function.Call<int>(NativeHashes["NET_TO_OBJ"], netHandle);

        public static int NetToPed(int netHandle)
            => Function.Call<int>(NativeHashes["NET_TO_PED"], netHandle);

        public static int VehToNet(int vehicle)
            => Function.Call<int>(NativeHashes["VEH_TO_NET"], vehicle);

        public static int ObjToNet(int vehicle)
            => Function.Call<int>(NativeHashes["OBJ_TO_NET"], vehicle);

        public static int PedToNet(int vehicle)
            => Function.Call<int>(NativeHashes["PED_TO_NET"], vehicle);

        public static bool NetworkIsHost()
            => Function.Call<bool>(NativeHashes["NETWORK_IS_HOST"]);

        public static int CreateTrain(TrainModels configHash, float x, float y, float z, bool p4, bool passengers, bool p6, bool p7)
            => Function.Call<int>(NativeHashes["_CREATE_MISSION_TRAIN"], configHash, x, y, z, p4, passengers, p6, p7);

        public static int CreateTrain(TrainModels configHash, Vector3 coords, bool p4, bool passengers, bool p6, bool p7)
            => Function.Call<int>(NativeHashes["_CREATE_MISSION_TRAIN"], configHash, coords.X, coords.Y, coords.Z, p4, passengers, p6, p7);

        public static void DeleteAllTrains()
            => Function.Call(NativeHashes["DELETE_ALL_TRAINS"]);

        public static void DeleteMisionTrain(ref int trainHandle)
        {
            OutputArgument outHandle = new OutputArgument();
            Function.Call(NativeHashes["DELETE_MISSION_TRAIN"], outHandle);
            trainHandle = outHandle.GetResult<int>();
        }

        public static void SetRandomTrains(bool toggle)
            => Function.Call(NativeHashes["SET_RANDOM_TRAINS"], toggle);

        public static void SetTrainStopsForStations(int train, bool toggle)
            => Function.Call(NativeHashes["_SET_TRAIN_STOPS_FOR_STATIONS"], train, toggle);

        public static void SetTrainSpeed(int train, float speed)
            => Function.Call(NativeHashes["SET_TRAIN_SPEED"], train, speed);

        public static void SetTrainMaxSpeed(int train, float speed)
            => Function.Call(NativeHashes["_SET_TRAIN_MAX_SPEED"], train, speed);

        public static void SetTrainCruiseSpeed(int train, float speed)
            => Function.Call(NativeHashes["SET_TRAIN_CRUISE_SPEED"], train, speed);

        public static int AddBlipForCoords(uint hash, float x, float y, float z)
            => Function.Call<int>(NativeHashes["BLIP_ADD_FOR_COORDS"], hash, x, y, z);

        public static int AddBlipForCoords(uint hash, Vector3 coords)
            => Function.Call<int>(NativeHashes["BLIP_ADD_FOR_COORDS"], hash, coords.X, coords.Y, coords.Z);

        public static int AddBlipForRadius(uint hash, float x, float y, float z, float radius)
            => Function.Call<int>(NativeHashes["BLIP_ADD_FOR_RADIUS"], hash, x, y, z, radius);

        public static int AddBlipForRadius(uint hash, Vector3 coords, float radius)
            => Function.Call<int>(NativeHashes["BLIP_ADD_FOR_RADIUS"], hash, coords.X, coords.Y, coords.Z, radius);

        public static int AddBlipForEntity(uint hash, int entity)
            => Function.Call<int>(NativeHashes["BLIP_ADD_FOR_ENTITY"], hash, entity);

        public static void RemoveBlip(ref int blip)
        {
            OutputArgument outBlip = new OutputArgument();
            Function.Call(NativeHashes["REMOVE_BLIP"], outBlip);
            blip = outBlip.GetResult<int>();
        }

        public static void RemoveBlip(int blip)
            => Function.Call(NativeHashes["REMOVE_BLIP"], blip);

        public static void SetBlipRotation(int blip, int rotation)
            => Function.Call(NativeHashes["SET_BLIP_ROTATION"], blip, rotation);

        public static void SetBlipScale(int blip, float scale)
            => Function.Call(NativeHashes["SET_BLIP_SCALE"], blip, scale);

        public static void SetBlipSprite(int blip, uint hash)
            => Function.Call(NativeHashes["SET_BLIP_SPRITE"], blip, hash);

        public static void SetBlipName(int blip, VarString name)
            => Function.Call(NativeHashes["_SET_BLIP_NAME_FROM_PLAYER_STRING"], blip, name.Text);

        public static int GetPedInVehicleSeat(int vehicle, VehicleSeat seat)
            => Function.Call<int>(NativeHashes["GET_PED_IN_VEHICLE_SEAT"], vehicle, seat);

        public static void SetBlockingOfNonTemporaryEvents(int ped, bool toggle)
            => Function.Call(NativeHashes["SET_BLOCKING_OF_NON_TEMPORARY_EVENTS"], ped, toggle);

        public static void SetPedCanBeKnockedOffVehicle(int ped, KnockOffVehicle state)
            => Function.Call(NativeHashes["SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE"], ped, state);

        public static void SetVehicleCanBeTargetted(int vehicle, bool state)
            => Function.Call(NativeHashes["SET_VEHICLE_CAN_BE_TARGETTED"], vehicle, state);

        public static void ClearPedTasksImmediately(int ped, bool p1, bool p2)
            => Function.Call(NativeHashes["CLEAR_PED_TASKS_IMMEDIATELY"], ped, p1, p2);

        public static bool SetBlipFlashes(int handle, bool state)
            => Function.Call <bool>(NativeHashes["SET_BLIP_FLASHES"], handle, state, 2);

        public static bool IsBlipOnMinimap(int handle)
            => Function.Call<bool>(NativeHashes["IS_BLIP_ON_MINIMAP"], handle);

        public static bool IsScreenFadingIn()
            => Function.Call<bool>(NativeHashes["IS_SCREEN_FADING_IN"]);
        
        public static bool IsScreenFadingOut()
            => Function.Call<bool>(NativeHashes["IS_SCREEN_FADING_OUT"]);
        
        public static bool IsScreenFadedOut()
            => Function.Call<bool>(NativeHashes["IS_SCREEN_FADED_OUT"]);

        public static bool IsScreenFadedIn()
            => Function.Call<bool>(NativeHashes["IS_SCREEN_FADED_IN"]);

        public static void DoScreenFadeIn(int duration)
            => Function.Call(NativeHashes["DO_SCREEN_FADE_IN"], duration);

        public static void DoScreenFadeOut(int duration)
            => Function.Call(NativeHashes["DO_SCREEN_FADE_OUT"], duration);

        public static void SetEntityCoords(int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)
            => Function.Call(NativeHashes["SET_ENTITY_COORDS"], entity, xPos, yPos, zPos, xAxis, yAxis, zAxis, clearArea);

        public static void SetEntityCoords(int entity, Vector3 pos, bool xAxis, bool yAxis, bool zAxis, bool clearArea)
            => Function.Call(NativeHashes["SET_ENTITY_COORDS"], entity, pos.X, pos.Y, pos.Z, xAxis, yAxis, zAxis, clearArea);

        public static Vector3 GetEntityRotation(int entity, int rotationOrder)
            => Function.Call<Vector3>(NativeHashes["GET_ENTITY_ROTATION"], entity, rotationOrder);

        public static void SetEntityRotation(int entity, float pitch, float roll, float yaw, int rotationOrder, bool p5)
            => Function.Call(NativeHashes["SET_ENTITY_ROTATION"], entity, pitch, roll, yaw, rotationOrder, p5);

        public static void DeleteEntity(ref int entity)
        {
            OutputArgument outEnt = new OutputArgument();
            Function.Call(NativeHashes["DELETE_ENTITY"], outEnt);
            entity = outEnt.GetResult<int>();
        }

        public static void DeleteEntity(int entity)
            => Function.Call(NativeHashes["DELETE_ENTITY"], entity);

        public static bool IsEntityDead(int entity)
            => Function.Call<bool>(NativeHashes["IS_ENTITY_DEAD"], entity);

        public static EntityType GetEntityType(int entity)
            => Function.Call<EntityType>(NativeHashes["GET_ENTITY_TYPE"], entity);

        public static int NetworkGetEntityFromNetworkId(int netId)
            => Function.Call<int>(NativeHashes["NETWORK_GET_ENTITY_FROM_NETWORK_ID"], netId);

        public static bool IsPedMale(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_MALE"], ped);

        public static int GetEntityHealth(int entity)
            => Function.Call<int>(NativeHashes["GET_ENTITY_HEALTH"], entity);
        
        public static float GetEntityHealthFloat(int entity)
            => Function.Call<float>(NativeHashes["_GET_ENTITY_HEALTH_FLOAT"], entity);

        public static int GetEntityMaxHealth(int entity)
            => Function.Call<int>(NativeHashes["GET_ENTITY_MAX_HEALTH"], entity);
        
        public static void SetEntityMaxHealth(int entity, int value)
            => Function.Call(NativeHashes["SET_ENTITY_MAX_HEALTH"], entity, value);
        
        public static void SetEntityHealth(int entity, int value)
            => Function.Call(NativeHashes["SET_ENTITY_HEALTH"], entity, value);

        public static float GetEntitySpeed(int entity)
            => Function.Call<float>(NativeHashes["GET_ENTITY_SPEED"], entity);
        
        public static Vector3 GetEntitySpeedVector(int entity)
            => Function.Call<Vector3>(NativeHashes["GET_ENTITY_SPEED_VECTOR"], entity);

        public static uint GetEntityModel(int entity)
            => Function.Call<uint>(NativeHashes["GET_ENTITY_MODEL"], entity);

        public static Vector3 GetEntityForwardVector(int entity)
            => Function.Call<Vector3>(NativeHashes["GET_ENTITY_FORWARD_VECTOR"], entity);

        public static void TaskStandStill(int ped, int time)
            => Function.Call(NativeHashes["TASK_STAND_STILL"], ped, time);

        public static void TaskJump(int ped)
            => Function.Call(NativeHashes["TASK_JUMP"], ped, false);

        public static void TaskWhistle(int ped, int p1, int p2)
            => Function.Call(NativeHashes["TASK_WHISTLE_ANIM"], ped, p1, p2);

        public static int GetAttributeCoreValue(int ped, PedAttribute attribute)
            => Function.Call<int>(NativeHashes["_GET_ATTRIBUTE_CORE_VALUE"], ped, attribute);

        public static void SetAttributeCoreValue(int ped, PedAttribute attribute, int value)
            => Function.Call(NativeHashes["_SET_ATTRIBUTE_CORE_VALUE"], ped, attribute, value);

        public static bool IsPedEnteringTransport(int ped, int transportEntity, bool p2)
            => Function.Call<bool>(NativeHashes["IS_PED_ENTERING_TRANSPORT"], ped, transportEntity, p2);

        public static bool IsPedExitingTransport(int ped, int transportEntity)
            => Function.Call<bool>(NativeHashes["IS_PED_EXITING_TRANSPORT"], ped, transportEntity);

        public static void FreezeEntityPosition(int entity, bool toggle)
            => Function.Call(NativeHashes["FREEZE_ENTITY_POSITION"], entity, toggle);

        public static void SetPedBrawlingStyle(int ped, BrawlingStyle brawlingStyle)
            => Function.Call(NativeHashes["_SET_PED_BRAWLING_STYLE"], ped, brawlingStyle);

        public static void DisablePlayerFiring(int player, bool toggle)
            => Function.Call(NativeHashes["DISABLE_PLAYER_FIRING"], player, toggle);

        public static bool GetEntityPlayerIsFreeAimingAt(int player, ref int entity)
        {
            OutputArgument outEntity = new OutputArgument();

            bool result = Function.Call<bool>(NativeHashes["GET_ENTITY_PLAYER_IS_FREE_AIMING_AT"], player, outEntity);

            entity = outEntity.GetResult<int>();
            return result;
        }

        public static float GetPlayerHealth(int player)
            => Function.Call<float>(NativeHashes["_GET_PLAYER_HEALTH"], player);

        public static bool GetPlayerInvicible(int player)
            => Function.Call<bool>(NativeHashes["GET_PLAYER_INVINCIBLE"], player);

        public static float GetPlayerStamina(int player)
            => Function.Call<float>(NativeHashes["_GET_PLAYER_STAMINA"], player);

        public static bool IsPlayerClimbing(int player)
            => Function.Call<bool>(NativeHashes["IS_PLAYER_CLIMBING"], player);

        public static bool IsPlayerRidingTrain(int player)
            => Function.Call<bool>(NativeHashes["IS_PLAYER_RIDING_TRAIN"], player);

        public static bool IsPlayerTargettingEntity(int player, int entity, bool p2)
            => Function.Call<bool>(NativeHashes["IS_PLAYER_TARGETTING_ENTITY"],player, entity, p2);

        public static void SetPlayerModel(int player, PedHash modelHash, bool p2)
            => Function.Call(NativeHashes["SET_PLAYER_MODEL"], player, modelHash, p2);

        public static void SetPlayerWeaponDamageModifier(int player, float modifier)
            => Function.Call(NativeHashes["SET_PLAYER_WEAPON_DAMAGE_MODIFIER"], player, modifier);

        public static bool IsPlayerPlaying(int player)
            => Function.Call<bool>(NativeHashes["IS_PLAYER_PLAYING"], player);

        public static void SetEveryoneIgnorePlayer(int player, bool toggle)
            => Function.Call(NativeHashes["SET_EVERYONE_IGNORE_PLAYER"], player, toggle);

        public static void ClearPedLastDamageBone(int player)
            => Function.Call(NativeHashes["CLEAR_PED_LAST_DAMAGE_BONE"], player);

        public static void ClearPlayerWetness(int ped)
            => Function.Call(NativeHashes["CLEAR_PED_WETNESS"], ped);

        public static int ClonePed(int ped, bool isNetwork, bool bScriptHostPed, bool copyHeadBlendFlag)
            => Function.Call<int>(NativeHashes["CLONE_PED"], ped, isNetwork, bScriptHostPed, copyHeadBlendFlag);

        public static int CreatePedInsideVehicle(int vehicle, uint modelHah, int seatIndex, bool p3, bool p4, bool p5)
            => Function.Call<int>(NativeHashes["CREATE_PED_INSIDE_VEHICLE"], vehicle, modelHah, seatIndex, p3, p4, p5); 
            
        public static void FreezePedCameraRotation(int ped)
            => Function.Call(NativeHashes["_FREEZE_PED_CAMERA_ROTATION"], ped);

        public static uint GetPedCauseOfDeath(int ped)
            => Function.Call<uint>(NativeHashes["GET_PED_CAUSE_OF_DEATH"], ped);

        public static bool GetPedIsBeingGrappled(int ped)
            => Function.Call<bool>(NativeHashes["GET_PED_IS_BEING_GRAPPLED"], ped);

        public static bool GetPedIsGrappling(int ped)
            => Function.Call<bool>(NativeHashes["GET_PED_IS_GRAPPLING"], ped);

        public static int GetPedMoney(int ped)
            => Function.Call<int>(NativeHashes["GET_PED_MONEY"], ped);

        public static int GetPedTimeOfDeath(int ped)
            => Function.Call<int>(NativeHashes["GET_PED_TIME_OF_DEATH"], ped);

        public static bool IsPedCarryingSomething(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_CARRYING_SOMETHING"], ped);

        public static bool IsPedDiving(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_DIVING"], ped);

        public static bool IsPedInjured(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_INJURED"], ped);

        public static bool IsPedShooting(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_SHOOTING"], ped);

        public static bool IsPedSitting(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_SITTING"], ped);

        public static void SetPedMaxHealth(int ped, int value)
            => Function.Call(NativeHashes["SET_PED_MAX_HEALTH"], ped, value);

        public static void SetPedMoney(int ped, int amount)
            => Function.Call(NativeHashes["SET_PED_MAX_HEALTH"], ped, amount);

        public static bool IsPedCuffed(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_CUFFED"], ped);

        public static bool IsPedInWrithe(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_IN_WRITHE"], ped);

        public static bool IsPedRunning(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_RUNNING"], ped);

        public static bool IsPedWalking(int ped)
            => Function.Call<bool>(NativeHashes["IS_PED_WALKING"], ped);

        public static void TaskPause(int ped, int ms)
            => Function.Call(NativeHashes["IS_PED_WALKING"], ped, ms);

        public static bool CanShuffleSeat(int ped, VehicleSeat seatIndex)
            => Function.Call<bool>(NativeHashes["CAN_SHUFFLE_SEAT"], ped, seatIndex);

        public static void RemoveAllPedWeapons(int ped, bool p1, bool p2)
            => Function.Call(NativeHashes["REMOVE_ALL_PED_WEAPONS"], ped, p1, p2);

        public static void RemoveWeaponFromPed(int ped, uint weaponHash, bool p2, RemoveItemReason removeReason)
            => Function.Call(NativeHashes["REMOVE_WEAPON_FROM_PED"], ped, weaponHash, p2, removeReason);

        public static void SetPedAmmo(int ped, uint weaponhash, int ammo)
            => Function.Call(NativeHashes["SET_PED_AMMO"], ped, weaponhash, ammo);

        public static void SetPedInfiniteAmmo(int ped, bool toggle, uint weaponhash)
            => Function.Call(NativeHashes["SET_PED_INFINITE_AMMO"], ped, toggle, weaponhash);

        public static void ResurrectPed(int ped)
            => Function.Call(NativeHashes["RESURRECT_PED"], ped);

        public static int GetPedSourceOfDeath(int ped)
            => Function.Call<int>(NativeHashes["GET_PED_SOURCE_OF_DEATH"], ped);

        public static void SetPedIsDrunk(int ped, bool toggle)
            => Function.Call(NativeHashes["SET_PED_IS_DRUNK"], ped, toggle);
    }
}