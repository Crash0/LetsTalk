#region Header
// <copyright file="Class2.cs" company="GoDialog AS">
// File Created:  08/12-2016
// Last Modified: 08/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Telephony
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;



    public class CiscoSPA525GConfigGenerator : ICiscoSPAConfigGenerator
    {
        public readonly string provisonIp;

        public ConnectionType IpType = ConnectionType.DHCP;

        private readonly string MAC;

        private string _Accept_Media_Loopback_Request = "automatic";

        private string _ACD_Ext = "1";

        private string _ACD_Login_Serv = "No";

        private string _Admin_Password = string.Empty;

        private string _Alert_Tone = "600@-19;.2(.05/0.05/1)";

        private string _Alert_Tone_Off = "No";

        private string _Application_LED;

        private string _Attendant_Console_Call_Pickup_Code = "*98";

        private string _Attn_Transfer_Serv = "Yes";

        private string _Auth_Type = "None";

        private string _Auto_Answer_Page = "Yes";

        private string _AVT_Codec_Name = "telephone-event";

        private string _AVT_Dynamic_Payload = "101";

        private string _Back_Light_Enable = "No";

        private string _Back_Light_Timer__sec_ = "30";

        private string _Background_Picture_Type = "default";

        private string _BLF_Busy_LED;

        private string _BLF_DNS_Enable = "No";

        private string _BLF_Held_LED;

        private string _BLF_Idle_LED;

        private string _BLF_List_URI;

        private string _BLF_Ringing_LED;

        private string _Blind_Transfer_Serv = "Yes";

        private string _Block_ANC_Serv = "Yes";

        private string _Block_ANC_Setting = "No";

        private string _Block_CID_Serv = "Yes";

        private string _Block_CID_Setting = "No";

        private string _Bluetooth_Dial_Tone = "350@-19,440@-19;1(0/*/0);10(*/0/1+2)";

        private string _Bluetooth_Input_Gain = "0";

        private string _Bluetooth_Mode = "Handsfree";

        private string _Bluetooth_Volume = "9";

        private string _BMP_Picture_Download_URL = string.Empty;

        private string _Busy_Tone = "480@-19,620@-19;10(.5/.5/1+2)";

        private string _Cadence_1 = "60(2/4)";

        private string _Cadence_2 = "60(.3/.2,1/.2,.3/4)";

        private string _Cadence_3 = "60(.8/.4,.8/4)";

        private string _Cadence_4 = "60(.4/.2,.3/.2,.8/4)";

        private string _Cadence_5 = "60(.2/.2,.2/.2,.2/.2,1/4)";

        private string _Cadence_6 = "60(.2/.4,.2/.4,.2/4)";

        private string _Cadence_7 = "60(4.5/4)";

        private string _Cadence_8 = "60(0.25/9.75)";

        private string _Cadence_9 = "60(.4/.2,.4/2)";

        private string _Call_Back_Active_LED;

        private string _Call_Back_Delay = ".5";

        private string _Call_Back_Expires = "1800";

        private string _Call_Back_Retry_Intvl = "30";

        private string _Call_Back_Serv = "Yes";

        private string _Call_Feature_Sync_Ext = "Disabled";

        private string _Call_Park_Serv = "Yes";

        private string _Call_Pick_Up_Serv = "Yes";

        private string _Call_Waiting_Tone = "440@-10;30(.3/9.7/1)";

        private string _Caller_ID_Header = "PAID-RPID-FROM";

        private string _Cfwd_All_Dest;

        private string _Cfwd_All_Serv = "Yes";

        private string _Cfwd_Busy_Dest;

        private string _Cfwd_Busy_Serv = "Yes";

        private string _Cfwd_Dial_Tone = "350@-19,440@-19;2(.2/.2/1+2);10(*/0/1+2)";

        private string _Cfwd_No_Ans_Delay = "20";

        private string _Cfwd_No_Ans_Dest;

        private string _Cfwd_No_Ans_Serv = "Yes";

        private string _Cfwd_Setting = "Yes";

        private string _Client_DN;

        private string _Conference_Package = "No";

        private string _Conference_Serv = "Yes";

        private string _Conference_Tone = "350@-19;20(.1/.1/1,.1/9.7/1)";

        private string _Conferencing_Key_List = "hold|1;endcall|2;join|4;";

        private string _Confirm_Tone = "600@-16;1(.25/.25/1)";

        private string _Connect_on_Bootup = "No";

        private string _Connected_Key_List = "hold|1;endcall|2;conf|3;xfer|4;bxfer;confLx;xferLx;park;phold;flash;";

        private string _Corp_Dir_Name;

        private string _CTI_Enable = "No";

        private string _CW_Setting = "Yes";

        private string _Date_Format = "day/month";

        private string _Daylight_Saving_Time_Enable = "Yes";

        private string _Daylight_Saving_Time_Rule = "start=3/-1/7/2;end=10/-1/7/2;save=1";

        private string _debugLevel = "3";

        private string _debugServer = string.Empty;

        private string _DHCP_Option_To_Use = "66,160,159,150";

        private string _Dial_Assistance = "No";

        private string _Dial_Tone = "350@-19,440@-19;10(*/0/1+2)";

        private string _Dialing_Input_Key_List = "option|1;dial|2;delchr|3;cancel|4;";

        private string _Dictionary_Server_Script;

        private string _Directory_Enable = "No";

        private string _Directory_Name;

        private string _Directory_Password;

        private string _Directory_Type = "Enterprise";

        private string _Directory_UserID;

        private string _Disabled_LED;

        private string _Display_Attr;

        private string _Display_Text_Message_on_Recv = "Yes";

        private string _DND_Serv = "Yes";

        private string _DND_Setting = "No";

        private string _DNS_serverorder = "Manual,DHCP";

        private string _domain = string.Empty;

        private string _Downgrade_Rev_Limit = string.Empty;

        private string _DTMF_Playback_Length = ".1";

        private string _DTMF_Playback_Level = "12dB";

        private string _DTMF_Relay_MIME_Type = "application/dtmf-relay";

        private string _EM_Enable = "No";

        private string _EM_Mobile_Password;

        private string _EM_Mobile_User_ID;

        private string _EM_Phone_Password;

        private string _EM_Phone_User_ID;

        private string _EM_User_Domain;

        private string _Enable_BT = "Yes";

        private string _Enable_CDP = "No";

        private string _Enable_PC_Port_VLAN_Tagging = "No";

        private string _Enable_Video_VLAN;

        private string _Enable_Web_Admin_Access = "Yes";

        private string _Enable_Web_Server = "yes";

        private string _enableBonjour = "No";

        private string _EnableVLAN = "No";

        private string _EncapRTP_Codec_Name = "encaprtp";

        private string _EncapRTP_Dynamic_Payload = "112";

        private string _Escape_Display_Name = "No";

        private string _EXT_IP = string.Empty;

        private string _EXT_RTP_Port_Min = string.Empty;

        private string _First_Name_Filter;

        private string _Force_G711a_Code = "*027111";

        private string _Force_G711u_Code = "*017111";

        private string _Force_G722_Code = "*02722";

        private string _Force_G726r32_Code = "*0272632";

        private string _Force_G729a_Code = "*02729";

        private string _Force_L16_Code = "*02016";

        private string _Force_LAN_Codec = "none";

        private string _Forced_Resync_Delay = "14400";

        private string _G711a_Codec_Name = "PCMA";

        private string _G711u_Codec_Name = "PCMU";

        private string _G722_Codec_Name = "G722";

        private string _G726r16_Dynamic_Payload = "98";

        private string _G726r24_Dynamic_Payload = "97";

        private string _G726r32_Codec_Name = "G726-32";

        private string _G726r32_Dynamic_Payload = "2";

        private string _G726r40_Dynamic_Payload = "96";

        private string _G729a_Codec_Name = "G729a";

        private string _G729b_Codec_Name = "G729ab";

        private string _G729b_Dynamic_Payload = "99";

        private string _Group_Call_Pick_Up_Serv = "Yes";

        private string _Group_Paging_Script = "pggrp=224.168.168.168:34560;name=All;num=800;listen=yes;";

        private string _Handle_VIA_received = "No";

        private string _Handle_VIA_rport = "No";

        private string _Handset_Input_Gain = "0";

        private string _Handset_Volume = "9";

        private string _Headset_Input_Gain = "0";

        private string _Headset_Volume = "9";

        private string _Hold_Key_List = "resume|1;endcall|2;newcall|3;redial;dir;cfwd;dnd;";

        private string _Hold_Package = "No";

        private string _Hold_Target_Before_REFER = "No";

        private string _Holding_Tone = "600@-19;25(.1/.1/1,.1/.1/1,.1/9.5/1)";

        private string _Hook_Flash_MIME_Type = "application/hook-flash";

        private string _hostName = string.Empty;

        private string _Idle_Key_List = "em_login;acd_login;acd_logout;avail;unavail;redial;dir;cfwd;dnd;lcr;pickup;gpickup;unpark;em_logout;";

        private string _Idle_LED;

        private string _Inband_DTMF_Boost = "-16";

        private string _INFOREQ_Dynamic_Payload = string.Empty;

        private string _Insert_VIA_received = "No";

        private string _Insert_VIA_rport = "No";

        private string _Interdigit_Long_Timer = "10";

        private string _Interdigit_Short_Timer = "3";

        private string _INVITE_Expires = "240";

        private string _Key_System_Auto_Discovery = "Yes";

        private string _Key_System_IP_Address = string.Empty;

        private string _L16_Codec_Name = "L16";

        private string _L16_Dynamic_Payload = "104";

        private string _Language_Selection = "English-US";

        private string _Last_Name_Filter;

        private string _LCD_Contrast = "15";

        private string _LDAP_Dir_Enable = "No";

        private string _License_Keys = string.Empty;

        private string _Line = "5";

        private string _Linksys_Key_System = "No";

        private string _Local_Active_LED;

        private string _Local_Held_LED;

        private string _Local_Progressing_LED;

        private string _Local_Ringing_LED;

        private string _Local_Seized_LED;

        private string _Log_Missed_Calls_for_EXT_1 = "Yes";

        private string _Log_Missed_Calls_for_EXT_2 = "Yes";

        private string _Log_Missed_Calls_for_EXT_3 = "Yes";

        private string _Log_Missed_Calls_for_EXT_4 = "Yes";

        private string _Log_Missed_Calls_for_EXT_5 = "Yes";

        private string _Log_Resync_Failure_Msg = "$PN $MAC -- Resync failed: $ERR";

        private string _Log_Resync_Request_Msg = "$PN $MAC -- Requesting resync $SCHEME://$SERVIP:$PORT$PATH";

        private string _Log_Resync_Success_Msg = "$PN $MAC -- Successful resync $SCHEME://$SERVIP:$PORT$PATH";

        private string _Log_Upgrade_Failure_Msg = "$PN $MAC -- Upgrade failed: $ERR";

        private string _Log_Upgrade_Request_Msg = "$PN $MAC -- Requesting upgrade $SCHEME://$SERVIP:$PORT$PATH";

        private string _Log_Upgrade_Success_Msg = "$PN $MAC -- Successful upgrade $SCHEME://$SERVIP:$PORT$PATH -- $ERR";

        private string _Logo_Type = string.Empty;

        private string _Low_Battery_Tone = "1600@-16;2(.05/0.05/1,.05/.05/1,0/.5/0)";

        private string _Mark_All_AVT_Packets = "Yes";

        private string _Max_Auth = "2";

        private string _Max_Forward = "70";

        private string _Max_Redirection = "5";

        private string _Max_RTP_ICMP_Err = "0";

        private string _Media_Loopback_Mode = "source";

        private string _Media_Loopback_Type = "media";

        private string _Miss_Call_Shortcut = "Yes";

        private string _Missed_Call_Key_List = "lcr|1;miss|4;";

        private string _Multicast_Address = "24.168.168.168:6061";

        private string _MWI_Dial_Tone = "350@-19,440@-19;2(.1/.1/1+2);10(*/0/1+2)";

        private string _NAT_Keep_Alive_Intvl = "15";

        private string _No_UDP_Checksum = "No";

        private string _Notify_Conference = "No";

        private string _NTPEnabeled = "Yes";

        private string _Number_Mapping;

        private string _Off_Hook_Key_List = "option;redial;dir;cfwd;dnd;lcr;unpark;pickup;gpickup;";

        private string _Off_Hook_Warning_Tone = "480@-10,620@0;10(.125/.125/1+2)";

        private string _Outside_Dial_Tone = "420@-16;10(*/0/1)";

        private string _Page_Tone = "600@-16;.3(.05/0.05/1)";

        private string _Paging_Serv = "Yes";

        private string _Parking_Lot_Busy_LED;

        private string _Parking_Lot_Idle_LED;

        private string _Password;

        private string _PC_Port_VLAN_Highest_Priority = "No Limit";

        private string _PC_Port_VLAN_ID = "1";

        private PhoneProtocolType _phoneProtocolType = PhoneProtocolType.SIP;

        private string _PIN_Code = "0000";

        private string _pppoe_loginname;

        private string _pppoe_password;

        private string _pppoe_service_name;

        private string _Prefer_G711u_Code = "*017110";

        private string _Prefer_G722_Code = "*01722";

        private string _Prefer_G726r32_Code = "*0172632";

        private string _Prefer_G729a_Code = "*01729";

        private string _Prefer_L16_Code = "*01016";

        private string _primary_DNS = string.Empty;

        private string _primaryNTPServer = string.Empty;

        private string _Profile_Rule = "/xml/spa$PSN.cfg";

        private string _Profile_Rule_B = string.Empty;

        private string _Profile_Rule_C = string.Empty;

        private string _Profile_Rule_D = string.Empty;

        private string _Programmable_Softkey_Enable = "No";

        private string _Progressing_Key_List = "endcall|2;";

        private string _Prompt_Tone = "520@-19,620@-19;10(*/0/1+2)";

        private string _Provision_Enable = "Yes";

        private string _PSK_1;

        private string _PSK_2;

        private string _PSK_3;

        private string _PSK_4;

        private string _PSK_5;

        private string _PSK_6;

        private string _Random_REG_CID_On_Reboot = "No";

        private string _Reg_Max_Expires = "7200";

        private string _Reg_Min_Expires = "1";

        private string _Reg_Retry_Intvl = "30";

        private string _Reg_Retry_Intvl_Cap = string.Empty;

        private string _Reg_Retry_Long_Intvl = "1200";

        private string _Reg_Retry_Long_Random_Delay = string.Empty;

        private string _Reg_Retry_Random_Delay = string.Empty;

        private string _Register_Failed_LED;

        private string _Registering_LED;

        private string _ReINVITE_Expires = "30";

        private string _Releasing_Key_List = "endcall|2";

        private string _Remote_Active_LED;

        private string _Remote_Held_LED;

        private string _Remote_Progressing_LED;

        private string _Remote_Ringing_LED;

        private string _Remote_Seized_LED;

        private string _Remote_Undefined_LED;

        private string _Remove_Last_Reg = "No";

        private string _Reorder_Delay = "5";

        private string _Reorder_Tone = "480@-19,620@-19;10(.25/.25/1+2)";

        private string _Report_Rule = string.Empty;

        private string _Restricted_Access_DomainsNode = string.Empty;

        private string _Resync_After_Upgrade_Attempt = "Yes";

        private string _Resync_Error_Retry_Delay = "3600";

        private string _Resync_Fails_On_FNF = "Yes";

        private string _Resync_From_SIP = "Yes";

        private string _Resync_On_Reset = "Yes";

        private string _Resync_Periodic = "3600";

        private string _Resync_Random_Delay = "2";

        private string _Resync_Trigger_1 = string.Empty;

        private string _Resync_Trigger_2 = string.Empty;

        private string _Retry_Reg_RSC = string.Empty;

        private string _RFC_2543_Call_Hold = "Yes";

        private string _Ring_Back_Tone = "440@-19,480@-19;*(2/4/1+2)";

        private string _Ring1 = "n=Cisco Synth;w=file://Cisco_synth_ring1.mp3;c=0";

        private string _Ring10 = "n=Piano;w=file://Piano2.raw;c=1";

        private string _Ring2 = "n=Retro;w=file://ringin.726;c=1";

        private string _Ring3 = "n=Office;w=file://thx-short.726;c=1";

        private string _Ring4 = "n=Analog Synth;w=file://Analog1.raw;c=1";

        private string _Ring5 = "n=Are You There;w=file://AreYouThereF.raw;c=1";

        private string _Ring6 = "n=Chime;w=file://Chime.raw;c=1";

        private string _Ring7 = "n=Clock Shop;w=file://ClockShop.raw;c=1";

        private string _Ring8 = "n=Film Score;w=file://FilmScore.raw;c=1";

        private string _Ring9 = "n=Koto Effect;w=file://KotoEffect.raw;c=1";

        private string _Ringer_Volume = "9";

        private string _Ringing_Key_List = "answer|1;ignore|2;";

        private string _RSS_Feed_URL_1 = "name=Local News;url=http://rss.cnn.com/rss/cnn_us.rss";

        private string _RSS_Feed_URL_2 = "name=World News; url=http://newsrss.bbc.co.uk/rss/newsonline_uk_edition/world/rss.xml";

        private string _RSS_Feed_URL_3 = "name=Finance News;url=http://finance.yahoo.com/rss/topstories";

        private string _RSS_Feed_URL_4 = "name=Sports News;url=http://rss.news.yahoo.com/rss/sports";

        private string _RSS_Feed_URL_5 = "name=Politics News;url=http://rss.news.yahoo.com/rss/politics";

        private string _RTCP_Tx_Interval = "0";

        private string _RTP_Packet_Size = "0.020";

        private string _RTP_Port_Max = "16482";

        private string _RTP_Port_Min = "16384";

        private string _RTP_Start_Loopback_Codec = "G711u";

        private string _RTP_Start_Loopback_Dynamic_Payload = "113";

        private string _SCA_Barge_In_Enable = "No";

        private string _SCA_Line_ID_Mapping = "Vertical First";

        private string _SCA_Sticky_Auto_Line_Seize = "No";

        private string _Screen_Saver_Enable = "Yes";

        private string _Screen_Saver_Refresh_Time = "10";

        private string _Screen_Saver_Trigger_Time = "300";

        private string _Screen_Saver_Type = "Clock";

        private string _Search_Base;

        private string _Search_Item_3;

        private string _Search_Item_3_Filter;

        private string _Search_Item_4;

        private string _Search_Item_4_Filter;

        private string _secondary_DNS = string.Empty;

        private string _secondaryNTPServer = string.Empty;

        private string _Secure_Call_Indication_Tone = "397@-19,507@-19;15(0/2/0,.2/.1/1,.1/2.1/2)";

        private string _Secure_Call_Serv = "Yes";

        private string _Send_Resp_To_Src_Port = "No";

        private string _Serv_Subscribe_Failed_LED;

        private string _Serv_Subscribing_LED;

        private string _Server;

        private string _Server_Type = "Asterisk";

        private string _Service_Annc_Base_Number;

        private string _Service_Annc_Extension_Codes;

        private string _Service_Annc_Serv = "No";

        private ServiceActivationCodes _serviceActivationCodes;

        private string _Shared_Active_Key_List = "newcall|1;barge|2;cfwd|3;dnd|4;";

        private string _Shared_Held_Key_List = "resume|1;barge|2;cfwd|3;dnd|4;";

        private string _Short_Name = string.Empty;

        private string _SIP_Accept_Language = string.Empty;

        private string _SIP_B_Enable = "No";

        private string _SIP_Reg_User_Agent_Name = string.Empty;

        private string _SIP_Server_Name = "$VERSION";

        private string _SIP_T1 = ".5";

        private string _SIP_T2 = "4";

        private string _SIP_T4 = "5";

        private string _SIP_TCP_Port_Max = "5080";

        private string _SIP_TCP_Port_Min = "5060";

        private string _SIP_Timer_B = "16";

        private string _SIP_Timer_D = "16";

        private string _SIP_Timer_F = "16";

        private string _SIP_Timer_H = "16";

        private string _SIP_Timer_J = "16";

        private string _SIP_User_Agent_Name = "$VERSION";

        private string _SIT1_RSC = string.Empty;

        private string _SIT1_Tone = "985@-16,1428@-16,1777@-16;20(.380/0/1,.380/0/2,.380/0/3,0/4/0)";

        private string _SIT2_RSC = string.Empty;

        private string _SIT2_Tone = "914@-16,1371@-16,1777@-16;20(.274/0/1,.274/0/2,.380/0/3,0/4/0)";

        private string _SIT3_RSC = string.Empty;

        private string _SIT3_Tone = "914@-16,1371@-16,1777@-16;20(.380/0/1,.380/0/2,.380/0/3,0/4/0)";

        private string _SIT4_RSC = string.Empty;

        private string _SIT4_Tone = "985@-16,1371@-16,1777@-16;20(.380/0/1,.274/0/2,.380/0/3,0/4/0)";

        private string _SMS_Serv = "Yes";

        private string _SNRM_Day_Mode_LED;

        private string _SNRM_Night_Mode_LED;

        private string _SPA525_wifi_on = "No";

        private string _SPA525autodetectsccp = "No";

        private string _SPA525readonly = "No";

        private string _Speaker_Volume = "11";

        private string _Speakerphone_DTMF_Masking = "No";

        private string _Speakerphone_Input_Gain = "0";

        private string _Speed_Dial_2;

        private string _Speed_Dial_3;

        private string _Speed_Dial_4;

        private string _Speed_Dial_5;

        private string _Speed_Dial_6;

        private string _Speed_Dial_7;

        private string _Speed_Dial_8;

        private string _Speed_Dial_9;

        private string _SRTP_Method = "x-sipura";

        private string _Start_Conf_Key_List = "hold|1;endcall|2;conf|3;";

        private string _Start_Xfer_Key_List = "hold|1;endcall|2;xfer|4;";

        private string _static_duplex_mode = "Auto";

        private string _static_gateway;

        private string _static_ipAddress;

        private string _static_lan_MTU = "1500";

        private string _static_netmask;

        private string _Station_Display_Name = "Place xxx";

        private string _Station_Name = "Place_xxx";

        private string _Stats_In_BYE = "No";

        private string _STUN_Enable = "No";

        private string _STUN_Server = string.Empty;

        private string _STUN_Test_Enable = "No";

        private string _Sub_Max_Expires = "7200";

        private string _Sub_Min_Expires = "10";

        private string _Sub_Retry_Intvl = "10";

        private string _Subscribe_Delay = "1";

        private string _Subscribe_Expires = "1800";

        private string _Subscribe_Retry_Interval = "30";

        private string _Substitute_VIA_Addr = "No";

        private string _Symmetric_RTP = "No";

        private string _syslogServer = string.Empty;

        private string _System_Beep = "600@-16;.1(.05/0.05/1)";

        private string _Talk_Package = "No";

        private string _Test_Mode_Enable = "No";

        private string _Text_Logo = string.Empty;

        private string _Text_Message_From_3rd_Party = "Yes";

        private string _Time_Format = "25hr";

        private string _Time_Offset__HH_mm_;

        private string _Time_Zone = "GMT+02:00";

        private string _Transport_Protocol = "tftp";

        private string _Trunk_In_use_LED;

        private string _Trunk_No_Service_LED;

        private string _Trunk_Reserved_LED;

        private string _Try_Backup_RSC = string.Empty;

        private string _Unit_1_Enable = "No";

        private string _Unit_2_Enable = "No";

        private string _Upgrade_Enable = "Yes";

        private string _Upgrade_Error_Retry_Delay = "3600";

        private string _Upgrade_Rule = string.Empty;

        private string _Use_Compact_Header = "No";

        private string _User_Configurable_Resync = "Yes";

        private string _User_Friendly_ID = string.Empty;

        private string _User_Name;

        private string _User_Password = string.Empty;

        private string _Video_VLAN_ID;

        private string _VLANID = "1";

        private string _Voice_Mail_Number = "*98";

        private string _VPN_Password = string.Empty;

        private string _VPN_Server = string.Empty;

        private string _VPN_Tunnel_Group = string.Empty;

        private string _VPN_User_Name = string.Empty;

        private string _Weather_Temperature_Unit = "Celsius";

        private string _Web_Serv = "Yes";

        private string _Web_Server_Port = "80";

        private string _XML_Application_Service_Name;

        private string _XML_Application_Service_URL;

        private string _XML_Directory_Service_Name;

        private string _XML_Directory_Service_URL;

        private string _XSI_Host_Server;

        private List<AttConsoleLineKey> attConsole1LineKeys;

        private List<AttConsoleLineKey> attConsole2LineKeys;

        private List<CameraProfile> cameraProfiles;

        private List<LineExt> lineExts;

        private List<LineKey> lineKeys;

        private List<WifiProfile> wifiProfiles;

        public CiscoSPA525GConfigGenerator(string macAddress, string ProvisonServer, ServiceActivationCodes serviceActivationCodes = null)
        {
            provisonIp = ProvisonServer;
            MAC = macAddress;
            if (serviceActivationCodes == null)
            {
                _serviceActivationCodes = new ServiceActivationCodes();
            }
            else
            {
                _serviceActivationCodes = serviceActivationCodes;
            }

        }

        /// <summary>
        /// Adds a CameraProfile to the config
        /// </summary>
        /// <param name="cameraProfile">The Camera Profile to add</param>
        public void AddCameraProfile(CameraProfile cameraProfile)
        {
            if (cameraProfiles == null)
            {
                cameraProfiles = new List<CameraProfile>(4);
            }

            cameraProfiles.Add(cameraProfile);
        }

        /// <summary>
        /// Adds a Line Extension
        /// </summary>
        /// <param name="ext">Line Extension to add</param>
        public void AddLineExt(LineExt ext)
        {
            if (lineExts == null)
            {
                lineExts = new List<LineExt>(5);
            }

            lineExts.Add(ext);

        }

        /// <summary>
        /// Adds a LineKey to config
        /// </summary>
        /// <param name="key">Key to add</param>
        public void AddLineKey(LineKey key)
        {
            if (lineKeys == null)
            {
                lineKeys = new List<LineKey>(5);
            }

            lineKeys.Add(key);
        }

        /// <summary>
        /// Adds WifiProfile to ConfigFile
        /// </summary>
        /// <param name="profile">The Profile to add</param>
        public void AddWifiProfile(WifiProfile profile)
        {
            if (wifiProfiles == null)
            {
                wifiProfiles = new List<WifiProfile>(3);
            }

            wifiProfiles.Add(profile);
        }

        /// <summary>
        /// Enables or disables Cisco Discovery protocoll
        /// </summary>
        /// <param name="EnableCDP">Yes | No</param>
        public void CDPConfig(string EnableCDP)
        {
            _Enable_CDP = EnableCDP;
        }

        /// <summary>
        /// Configure ProvisoningRules
        /// </summary>
        /// <param name="ProvisonEnabeled">"Yes" |"No"</param>
        /// <param name="ResyncOnReset">"Yes" |"No"</param>
        /// <param name="ResyncRandomDelay"> Random Delay For Resyncs</param>
        /// <param name="ResynkPeriod">Beriod between resync</param>
        /// <param name="ResyncErrorRetryDelay">Delay Between Faulty Resync</param>
        /// <param name="ForcedResynkDelay"> Delay Between Forced Resync</param>
        /// <param name="ResynkFromSIP">"Yes" |"No"</param>
        /// <param name="UserConfiguraboleResynk">"Yes" |"No"</param>
        /// <param name="ResyncAfterUpgrade">"Yes" |"No"</param>
        /// <param name="ResyncTrigger1"></param>
        /// <param name="ResynkTrigger2"></param>
        /// <param name="ResyncFailsOnFNF">"Yes" |"No"</param>
        public void ConfigureProvisonig(string ProvisonEnabeled, string ResyncOnReset, string ResyncRandomDelay,
            string ResynkPeriod, string ResyncErrorRetryDelay, string ForcedResynkDelay, string ResynkFromSIP, string UserConfiguraboleResynk,
            string ResyncAfterUpgrade, string ResyncTrigger1, string ResynkTrigger2, string ResyncFailsOnFNF)
        {

            _Provision_Enable = ProvisonEnabeled;
            _Resync_On_Reset = ResyncOnReset;
            _Resync_Random_Delay = ResyncRandomDelay;
            _Resync_Periodic = ResynkPeriod;
            _Resync_Error_Retry_Delay = ResyncErrorRetryDelay;
            _Forced_Resync_Delay = ForcedResynkDelay;
            _Resync_From_SIP = ResynkFromSIP;
            _User_Configurable_Resync = UserConfiguraboleResynk;
            _Resync_After_Upgrade_Attempt = ResyncAfterUpgrade;
            _Resync_Trigger_1 = ResyncTrigger1;
            _Resync_Trigger_2 = ResynkTrigger2;
            _Resync_Fails_On_FNF = ResyncFailsOnFNF;
        }

        /// <summary>
        /// Disables Bluetooth
        /// </summary>
        public void DisableBluetooth()
        {
            _Enable_BT = "No";
        }

        /// <summary>
        /// Setts The Sip Params
        /// </summary>
        /// <param name="MaxForward"></param>
        /// <param name="MaxRedirection"></param>
        /// <param name="MaxAuth"></param>
        /// <param name="SIPUserAgentName"></param>
        /// <param name="SIPServerName"></param>
        /// <param name="SIPRegUserAgentName"></param>
        /// <param name="SIPAcceptLanguage"></param>
        /// <param name="DTMFRelayMIMEType"></param>
        /// <param name="HookFlashMIMEType"></param>
        /// <param name="RemoveLastReg"></param>
        /// <param name="UseCompactHeader"></param>
        /// <param name="EscapeDisplayName"></param>
        /// <param name="SIPBEnable"></param>
        /// <param name="TalkPackage"></param>
        /// <param name="HoldPackage"></param>
        /// <param name="ConferencePackage"></param>
        /// <param name="NotifyConference"></param>
        /// <param name="RFC2543CallHold"></param>
        /// <param name="RandomREGCIDOnReboot"></param>
        /// <param name="MarkAllAVTPackets"></param>
        /// <param name="SIPTCPPortMin"></param>
        /// <param name="SIPTCPPortMax"></param>
        /// <param name="CTIEnable"></param>
        /// <param name="CallerIDHeader"></param>
        /// <param name="SRTPMethod"></param>
        /// <param name="HoldTargetBeforeREFER"></param>
        public void EditSipParams(string MaxForward, string MaxRedirection, string MaxAuth, string SIPUserAgentName,
            string SIPServerName, string SIPRegUserAgentName, string SIPAcceptLanguage, string DTMFRelayMIMEType,
            string HookFlashMIMEType, string RemoveLastReg, string UseCompactHeader, string EscapeDisplayName,
            string SIPBEnable, string TalkPackage, string HoldPackage, string ConferencePackage, string NotifyConference,
            string RFC2543CallHold, string RandomREGCIDOnReboot, string MarkAllAVTPackets, string SIPTCPPortMin,
            string SIPTCPPortMax, string CTIEnable, string CallerIDHeader, string SRTPMethod,
            string HoldTargetBeforeREFER)
        {
            _Max_Forward = MaxForward;
            _Max_Redirection = MaxRedirection;
            _Max_Auth = MaxAuth;
            _SIP_User_Agent_Name = SIPUserAgentName;
            _SIP_Server_Name = SIPServerName;
            _SIP_Reg_User_Agent_Name = SIPRegUserAgentName;
            _SIP_Accept_Language = SIPAcceptLanguage;
            _DTMF_Relay_MIME_Type = DTMFRelayMIMEType;
            _Hook_Flash_MIME_Type = HookFlashMIMEType;
            _Remove_Last_Reg = RemoveLastReg;
            _Use_Compact_Header = UseCompactHeader;
            _Escape_Display_Name = EscapeDisplayName;
            _SIP_B_Enable = SIPBEnable;
            _Talk_Package = TalkPackage;
            _Hold_Package = HoldPackage;
            _Conference_Package = ConferencePackage;
            _Notify_Conference = NotifyConference;
            _RFC_2543_Call_Hold = RFC2543CallHold;
            _Random_REG_CID_On_Reboot = RandomREGCIDOnReboot;
            _Mark_All_AVT_Packets = MarkAllAVTPackets;
            _SIP_TCP_Port_Min = SIPTCPPortMin;
            _SIP_TCP_Port_Max = SIPTCPPortMax;
            _CTI_Enable = CTIEnable;
            _Caller_ID_Header = CallerIDHeader;
            _SRTP_Method = SRTPMethod;
            _Hold_Target_Before_REFER = HoldTargetBeforeREFER;
        }

        /// <summary>
        /// Sets List Of Restricted Access Domains
        /// </summary>
        /// <param name="Restricted_Access_Domains"> string of domains</param>
        public void Enable_Restricted_Access_Domains(string Restricted_Access_Domains)
        {
            _Restricted_Access_DomainsNode = Restricted_Access_Domains;
        }

        /// <summary>
        /// Configure Bluetooth for Handsfree
        /// </summary>
        /// <param name="Pin">Phones Bluetooth pin</param>
        public void EnableBluetoothHandsfree(int Pin)
        {
            _Enable_BT = "Yes";
            _Bluetooth_Mode = "Handsfree";
            _PIN_Code = Pin.ToString();

        }

        /// <summary>
        /// Enables Bluetooth for use in PhoneMode
        /// </summary>
        /// <param name="LineKey">Witch line Key to use for Phone Line</param>
        /// <param name="Pin">Phones Pin for Connecting</param>
        /// <param name="ShortName">Internal LineName</param>
        /// <param name="UserFrendlyId">Label on Line Key</param>
        public void EnableBlutoothPhoneMode(int LineKey, int Pin, string ShortName, string UserFrendlyId)
        {
            _Enable_BT = "Yes";
            _Bluetooth_Mode = "Phone";
            _Line = LineKey.ToString();
            _PIN_Code = Pin.ToString();
            _Short_Name = ShortName;
            _User_Friendly_ID = UserFrendlyId;
        }

        /// <summary>
        /// Enables Bluetooth for use in PhoneMode And HandsfreeMode
        /// </summary>
        /// <param name="LineKey">Witch line Key to use for Phone Line</param>
        /// <param name="Pin">Phones Pin for Connecting</param>
        /// <param name="ShortName">Internal LineName</param>
        /// <param name="UserFrendlyId">Label on Line Key</param>
        public void EnableBothBluetooth(int LineKey, int Pin, string ShortName, string UserFrendlyId)
        {
            _Enable_BT = "Yes";
            _Bluetooth_Mode = "Both";
            _Line = LineKey.ToString();
            _PIN_Code = Pin.ToString();
            _Short_Name = ShortName;
            _User_Friendly_ID = UserFrendlyId;
        }

        /// <summary>
        /// Enables Use Of VideVlan
        /// </summary>
        /// <param name="enableVideoVlan">| "Yes" | "No" |</param>
        /// <param name="videoVLANId">Video VLAN Id</param>
        public void EnableVideoVlan(string enableVideoVlan, int videoVLANId)
        {
            _Enable_Video_VLAN = enableVideoVlan;
            _Video_VLAN_ID = videoVLANId.ToString();
        }

        /// <summary>
        /// Configure phone to use vpn 
        /// </summary>
        /// <param name="VPNServer">Address of VPN Server</param>
        /// <param name="VPNUserName"> Username for VPN Server</param>
        /// <param name="VPNPassword">Password for VPN Server</param>
        /// <param name="VPNTunnelGroup">VPN TunnelGroup</param>
        /// <param name="ConnectOnBoot"> Connect to VPN on boot,"Yes" |"No"</param>
        public void EnableVPN(string VPNServer, string VPNUserName, string VPNPassword, string VPNTunnelGroup,
            string ConnectOnBoot)
        {
            _VPN_Server = VPNServer;
            _VPN_User_Name = VPNUserName;
            _VPN_Password = VPNPassword;
            _VPN_Tunnel_Group = VPNTunnelGroup;
            _Connect_on_Bootup = ConnectOnBoot;
        }

        public string GenerateConfigFile()
        {
            // ReSharper disable once InconsistentNaming
            var configMACDocument = new XmlDocument();

            // default Attiibutes
            var naAttribute = configMACDocument.CreateAttribute("ua");
            naAttribute.InnerText = "na";

            var rwAttribute = configMACDocument.CreateAttribute("ua");
            naAttribute.InnerText = "rw";

            var roAttribute = configMACDocument.CreateAttribute("ua");
            roAttribute.InnerText = "ro";

            // DOC NODE
            XmlNode docNode = configMACDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            configMACDocument.AppendChild(docNode);

            XmlNode flatProfileNode = configMACDocument.CreateElement("flat-profile");

            // Restricted_Access_Domains
            var Restricted_Access_DomainsNode = configMACDocument.CreateElement("Restricted_Access_Domains");
            Restricted_Access_DomainsNode.Attributes.Append(naAttribute);
            Restricted_Access_DomainsNode.InnerText = _Restricted_Access_DomainsNode;
            flatProfileNode.AppendChild(Restricted_Access_DomainsNode);

            #region Web Server

            // Enable_Web_Server
            var Enable_Web_Server = configMACDocument.CreateElement("Enable_Web_Server");
            Enable_Web_Server.InnerText = _Enable_Web_Server;
            Enable_Web_Server.Attributes.Append(naAttribute);
            flatProfileNode.AppendChild(Enable_Web_Server);

            // Web_Server_Port
            var Web_Server_Port = configMACDocument.CreateElement("Web_Server_Port");
            Web_Server_Port.Attributes.Append(naAttribute);
            Web_Server_Port.InnerText = _Web_Server_Port;
            flatProfileNode.AppendChild(Web_Server_Port);

            // Enable_Web_Admin_Access
            var Enable_Web_Admin_Access = configMACDocument.CreateElement("Enable_Web_Admin_Access");
            Enable_Web_Admin_Access.Attributes.Append(naAttribute);
            Enable_Web_Admin_Access.InnerText = _Enable_Web_Admin_Access;
            flatProfileNode.AppendChild(Enable_Web_Admin_Access);

            // Admin_Password
            var Admin_Password = configMACDocument.CreateElement("Admin_Password");
            Admin_Password.Attributes.Append(naAttribute);
            Admin_Password.InnerText = _Admin_Password;
            flatProfileNode.AppendChild(Admin_Password);

            // User_Password
            var User_Password = configMACDocument.CreateElement("User_Password");
            User_Password.Attributes.Append(rwAttribute);
            User_Password.InnerText = _User_Password;
            flatProfileNode.AppendChild(User_Password);

            #endregion

            #region Protocoll

            // SPA525-protocol
            var SPA525protocol = configMACDocument.CreateElement("SPA525-protocol");
            SPA525protocol.Attributes.Append(naAttribute);
            SPA525protocol.InnerText = _phoneProtocolType.ToString();
            flatProfileNode.AppendChild(SPA525protocol);

            // SPA525-auto-detect-sccp
            var SPA525autodetectsccp = configMACDocument.CreateElement("SPA525-auto-detect-sccp");
            SPA525autodetectsccp.Attributes.Append(naAttribute);
            SPA525autodetectsccp.InnerText = _SPA525autodetectsccp;
            flatProfileNode.AppendChild(SPA525autodetectsccp);

            // Enable_CDP
            var Enable_CDP = configMACDocument.CreateElement("Enable_CDP");
            Enable_CDP.Attributes.Append(naAttribute);
            Enable_CDP.InnerText = _Enable_CDP;
            flatProfileNode.AppendChild(Enable_CDP);

            #endregion

            #region Read Only

            // SPA525-readonly
            var SPA525readonly = configMACDocument.CreateElement("SPA525-readonly");
            SPA525readonly.Attributes.Append(naAttribute);
            SPA525readonly.InnerText = _SPA525readonly;
            flatProfileNode.AppendChild(SPA525readonly);

            #endregion

            #region Internet Connection Type 

            // Connection_Type
            var ConnectionType = configMACDocument.CreateElement("Connection_Type");
            ConnectionType.Attributes.Append(rwAttribute);
            ConnectionType.InnerText = IpType.ToString();
            flatProfileNode.AppendChild(ConnectionType);

            #endregion

            #region NetworkType

            switch (IpType)
            {
                case Telephony.ConnectionType.DHCP:
                    break;
                case Telephony.ConnectionType.Static:

                    // Static_IP
                    var Static_IP = configMACDocument.CreateElement("Static_IP");
                    Static_IP.Attributes.Append(rwAttribute);
                    Static_IP.InnerText = _static_ipAddress;
                    flatProfileNode.AppendChild(Static_IP);

                    // NetMask
                    var NetMask = configMACDocument.CreateElement("NetMask");
                    NetMask.Attributes.Append(rwAttribute);
                    NetMask.InnerText = _static_netmask;
                    flatProfileNode.AppendChild(NetMask);

                    // Gateway
                    var Gateway = configMACDocument.CreateElement("Gateway");
                    Gateway.Attributes.Append(rwAttribute);
                    Gateway.InnerText = _static_gateway;
                    flatProfileNode.AppendChild(Gateway);

                    // Lan_MTU
                    var Lan_MTU = configMACDocument.CreateElement("Lan_MTU");
                    Lan_MTU.Attributes.Append(naAttribute);
                    Lan_MTU.InnerText = _static_lan_MTU;
                    flatProfileNode.AppendChild(Lan_MTU);

                    // Duplex_Mode
                    var Duplex_Mode = configMACDocument.CreateElement("Duplex_Mode");
                    Duplex_Mode.Attributes.Append(naAttribute);
                    Duplex_Mode.InnerText = _static_duplex_mode;
                    flatProfileNode.AppendChild(Duplex_Mode);
                    break;

                case Telephony.ConnectionType.PPPoE:

                    // PPPoE_Login_Name
                    var PPPoE_Login_Name = configMACDocument.CreateElement("PPPoE_Login_Name");
                    PPPoE_Login_Name.Attributes.Append(rwAttribute);
                    PPPoE_Login_Name.InnerText = _pppoe_loginname;
                    flatProfileNode.AppendChild(PPPoE_Login_Name);

                    // PPPoE_Login_Password
                    var PPPoE_Login_Password = configMACDocument.CreateElement("PPPoE_Login_Password");
                    PPPoE_Login_Password.Attributes.Append(rwAttribute);
                    PPPoE_Login_Password.InnerText = _pppoe_password;
                    flatProfileNode.AppendChild(PPPoE_Login_Password);

                    // PPPoE_Service_Name
                    var PPPoE_Service_Name = configMACDocument.CreateElement("PPPoE_Service_Name");
                    PPPoE_Service_Name.Attributes.Append(rwAttribute);
                    PPPoE_Service_Name.InnerText = _pppoe_service_name;
                    flatProfileNode.AppendChild(PPPoE_Service_Name);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            #endregion

            #region Network optional

            // HostName
            var HostName = configMACDocument.CreateElement("HostName");
            HostName.Attributes.Append(rwAttribute);
            HostName.InnerText = _hostName;
            flatProfileNode.AppendChild(HostName);

            // Domain
            var Domain = configMACDocument.CreateElement("Domain");
            Domain.Attributes.Append(rwAttribute);
            Domain.InnerText = _domain;
            flatProfileNode.AppendChild(Domain);

            // Primary_DNS
            var Primary_DNS = configMACDocument.CreateElement("Primary_DNS");
            Primary_DNS.Attributes.Append(rwAttribute);
            Primary_DNS.InnerText = _primary_DNS;
            flatProfileNode.AppendChild(Primary_DNS);

            // Secondary_DNS
            var Secondary_DNS = configMACDocument.CreateElement("Secondary_DNS");
            Secondary_DNS.Attributes.Append(rwAttribute);
            Secondary_DNS.InnerText = _secondary_DNS;
            flatProfileNode.AppendChild(Secondary_DNS);

            // DNS_Server_Order
            var DNS_Server_Order = configMACDocument.CreateElement("DNS_Server_Order");
            DNS_Server_Order.Attributes.Append(naAttribute);
            DNS_Server_Order.InnerText = _DNS_serverorder;
            flatProfileNode.AppendChild(DNS_Server_Order);

            // Syslog_Server
            var Syslog_Server = configMACDocument.CreateElement("Syslog_Server");
            Syslog_Server.Attributes.Append(naAttribute);
            Syslog_Server.InnerText = _syslogServer;
            flatProfileNode.AppendChild(Syslog_Server);

            // Debug_Server
            var Debug_Server = configMACDocument.CreateElement("Debug_Server");
            Debug_Server.Attributes.Append(naAttribute);
            Debug_Server.InnerText = _debugServer;
            flatProfileNode.AppendChild(Debug_Server);

            // Debug_Level
            var Debug_Level = configMACDocument.CreateElement("Debug_Level");
            Debug_Level.Attributes.Append(naAttribute);
            Debug_Level.InnerText = _debugLevel;
            flatProfileNode.AppendChild(Debug_Level);

            // NTP_Enable
            var NTP_Enable = configMACDocument.CreateElement("NTP_Enable");
            Syslog_Server.Attributes.Append(naAttribute);
            Syslog_Server.InnerText = _NTPEnabeled;
            flatProfileNode.AppendChild(NTP_Enable);

            // Primary_NTP_Server
            var Primary_NTP_Server = configMACDocument.CreateElement("Primary_NTP_Server");
            Primary_NTP_Server.Attributes.Append(naAttribute);
            Primary_NTP_Server.InnerText = _primaryNTPServer;
            flatProfileNode.AppendChild(Primary_NTP_Server);

            // Secondary_NTP_Server
            var Secondary_NTP_Server = configMACDocument.CreateElement("Secondary_NTP_Server");
            Secondary_NTP_Server.Attributes.Append(naAttribute);
            Secondary_NTP_Server.InnerText = _secondaryNTPServer;
            flatProfileNode.AppendChild(Secondary_NTP_Server);

            // Enable_Bonjour
            var Enable_Bonjour = configMACDocument.CreateElement("Enable_Bonjour");
            Enable_Bonjour.Attributes.Append(naAttribute);
            Enable_Bonjour.InnerText = _enableBonjour;
            flatProfileNode.AppendChild(Enable_Bonjour);

            #endregion

            #region VLAN    

            // Enable_VLAN
            var Enable_VLAN = configMACDocument.CreateElement("Enable_VLAN");
            Enable_VLAN.Attributes.Append(rwAttribute);
            Enable_VLAN.InnerText = _EnableVLAN;
            flatProfileNode.AppendChild(Enable_VLAN);

            // VLAN_ID
            var VLAN_ID = configMACDocument.CreateElement("VLAN_ID");
            VLAN_ID.Attributes.Append(naAttribute);
            VLAN_ID.InnerText = _VLANID;
            flatProfileNode.AppendChild(VLAN_ID);

            // PC_Port_VLAN_Highest_Priority
            var PC_Port_VLAN_Highest_Priority = configMACDocument.CreateElement("PC_Port_VLAN_Highest_Priority");
            PC_Port_VLAN_Highest_Priority.Attributes.Append(naAttribute);
            PC_Port_VLAN_Highest_Priority.InnerText = _PC_Port_VLAN_Highest_Priority;
            flatProfileNode.AppendChild(PC_Port_VLAN_Highest_Priority);

            // Enable_PC_Port_VLAN_Tagging
            var Enable_PC_Port_VLAN_Tagging = configMACDocument.CreateElement("Enable_PC_Port_VLAN_Tagging");
            Enable_PC_Port_VLAN_Tagging.Attributes.Append(naAttribute);
            Enable_PC_Port_VLAN_Tagging.InnerText = _Enable_PC_Port_VLAN_Tagging;
            flatProfileNode.AppendChild(Enable_PC_Port_VLAN_Tagging);

            // PC_Port_VLAN_ID
            var PC_Port_VLAN_ID = configMACDocument.CreateElement("PC_Port_VLAN_ID");
            PC_Port_VLAN_ID.Attributes.Append(naAttribute);
            PC_Port_VLAN_ID.InnerText = _PC_Port_VLAN_ID;
            flatProfileNode.AppendChild(PC_Port_VLAN_ID);

            #endregion

            #region Bluetooth

            // Enable_BT
            var Enable_BT = configMACDocument.CreateElement("Enable_BT");
            Enable_BT.Attributes.Append(rwAttribute);
            Enable_BT.InnerText = _Enable_BT;
            flatProfileNode.AppendChild(Enable_BT);

            #endregion

            #region BluePhone

            // Bluetooth_Mode
            var Bluetooth_Mode = configMACDocument.CreateElement("Bluetooth_Mode");
            Bluetooth_Mode.Attributes.Append(naAttribute);
            Bluetooth_Mode.InnerText = _Bluetooth_Mode;
            flatProfileNode.AppendChild(Bluetooth_Mode);

            // Line
            var Line = configMACDocument.CreateElement("Line");
            Line.Attributes.Append(naAttribute);
            Line.InnerText = _Line;
            flatProfileNode.AppendChild(Line);

            // Short_Name
            var Short_Name = configMACDocument.CreateElement("Short_Name");
            Short_Name.Attributes.Append(naAttribute);
            Short_Name.InnerText = _Short_Name;
            flatProfileNode.AppendChild(Short_Name);

            // User_Friendly_ID
            var User_Friendly_ID = configMACDocument.CreateElement("User_Friendly_ID");
            User_Friendly_ID.Attributes.Append(naAttribute);
            User_Friendly_ID.InnerText = _User_Friendly_ID;
            flatProfileNode.AppendChild(User_Friendly_ID);

            // PIN_Code
            var PIN_Code = configMACDocument.CreateElement("PIN_Code");
            PIN_Code.Attributes.Append(naAttribute);
            PIN_Code.InnerText = _PIN_Code;
            flatProfileNode.AppendChild(PIN_Code);

            #endregion

            #region WIFI

            // SPA525-wifi-on
            var SPA525_wifi_on = configMACDocument.CreateElement("SPA525-wifi-on");
            SPA525_wifi_on.Attributes.Append(rwAttribute);
            SPA525_wifi_on.InnerText = _SPA525_wifi_on;
            flatProfileNode.AppendChild(SPA525_wifi_on);

            // WIFI profiles
            if (wifiProfiles != null)
            {
                var i = 1;
                foreach (var profile in wifiProfiles)
                {
                    // profileName_1_
                    var profileName_1_ = configMACDocument.CreateElement(string.Format("profileName_{0}_", i));
                    profileName_1_.Attributes.Append(naAttribute);
                    profileName_1_.InnerText = profile.profileName;
                    flatProfileNode.AppendChild(profileName_1_);

                    // ssid_1_
                    var ssid_1_ = configMACDocument.CreateElement(string.Format("ssid_{0}_", i));
                    ssid_1_.Attributes.Append(naAttribute);
                    ssid_1_.InnerText = profile.ssid;
                    flatProfileNode.AppendChild(ssid_1_);

                    // securityMode_1_
                    var securityMode_1_ = configMACDocument.CreateElement(string.Format("securityMode_{0}_", i));
                    securityMode_1_.Attributes.Append(naAttribute);
                    securityMode_1_.InnerText = profile.securityMode;
                    flatProfileNode.AppendChild(securityMode_1_);

                    // cipherType_1_
                    var cipherType_1_ = configMACDocument.CreateElement(string.Format("cipherType_{0}_", i));
                    cipherType_1_.Attributes.Append(naAttribute);
                    cipherType_1_.InnerText = profile.cipherType;
                    flatProfileNode.AppendChild(cipherType_1_);

                    // wepKeyId_1_
                    var wepKeyId_1_ = configMACDocument.CreateElement(string.Format("wepKeyId_{0}_", i));
                    wepKeyId_1_.Attributes.Append(naAttribute);
                    wepKeyId_1_.InnerText = profile.wepKeyId;
                    flatProfileNode.AppendChild(wepKeyId_1_);

                    // wepKeyLen_1_
                    var wepKeyLen_1_ = configMACDocument.CreateElement(string.Format("wepKeyLen_{0}_", i));
                    wepKeyLen_1_.Attributes.Append(naAttribute);
                    wepKeyLen_1_.InnerText = profile.wepKeyLen;
                    flatProfileNode.AppendChild(wepKeyLen_1_);

                    // wepKey0_1_
                    var wepKey0_1_ = configMACDocument.CreateElement(string.Format("wepKey0_{0}_", i));
                    wepKey0_1_.Attributes.Append(naAttribute);
                    wepKey0_1_.InnerText = profile.wepKey0;
                    flatProfileNode.AppendChild(wepKey0_1_);

                    // wepKey1_1_
                    var wepKey1_1_ = configMACDocument.CreateElement(string.Format("wepKey1_{0}_", i));
                    wepKey1_1_.Attributes.Append(naAttribute);
                    wepKey1_1_.InnerText = profile.wepKey1;
                    flatProfileNode.AppendChild(wepKey1_1_);

                    // wepKey2_1_
                    var wepKey2_1_ = configMACDocument.CreateElement(string.Format("wepKey2_{0}_", i));
                    wepKey2_1_.Attributes.Append(naAttribute);
                    wepKey2_1_.InnerText = profile.wepKey2;
                    flatProfileNode.AppendChild(wepKey2_1_);

                    // wepKey3_1_
                    var wepKey3_1_ = configMACDocument.CreateElement(string.Format("wepKey3_{0}_", i));
                    wepKey3_1_.Attributes.Append(naAttribute);
                    wepKey3_1_.InnerText = profile.wepKey3;
                    flatProfileNode.AppendChild(wepKey3_1_);

                    // pskKey_1_
                    var pskKey_1_ = configMACDocument.CreateElement(string.Format("pskKey_{0}_", i));
                    pskKey_1_.Attributes.Append(naAttribute);
                    pskKey_1_.InnerText = profile.pskKey;
                    flatProfileNode.AppendChild(pskKey_1_);

                    // eapType_1_
                    var eapType_1_ = configMACDocument.CreateElement(string.Format("eapType_{0}_", i));
                    eapType_1_.Attributes.Append(naAttribute);
                    eapType_1_.InnerText = profile.eapType;
                    flatProfileNode.AppendChild(eapType_1_);

                    // identity_1_
                    var identity_1_ = configMACDocument.CreateElement(string.Format("identity_{0}_", i));
                    identity_1_.Attributes.Append(naAttribute);
                    identity_1_.InnerText = profile.identity;
                    flatProfileNode.AppendChild(identity_1_);

                    // password_1_
                    var password_1_ = configMACDocument.CreateElement(string.Format("password_{0}_", i));
                    password_1_.Attributes.Append(naAttribute);
                    password_1_.InnerText = profile.password;
                    flatProfileNode.AppendChild(password_1_);

                    // anonymousIdentity_1_
                    var anonymousIdentity_1_ =
                        configMACDocument.CreateElement(string.Format("anonymousIdentity_{0}_", i));
                    anonymousIdentity_1_.Attributes.Append(naAttribute);
                    anonymousIdentity_1_.InnerText = profile.anonymousIdentity;
                    flatProfileNode.AppendChild(anonymousIdentity_1_);

                    // serverCert_1_
                    var serverCert_1_ = configMACDocument.CreateElement(string.Format("serverCert_{0}_", i));
                    serverCert_1_.Attributes.Append(naAttribute);
                    serverCert_1_.InnerText = profile.serverCert;
                    flatProfileNode.AppendChild(serverCert_1_);

                    // clientCert_1_
                    var clientCert_1_ = configMACDocument.CreateElement(string.Format("clientCert_{0}_", i));
                    clientCert_1_.Attributes.Append(naAttribute);
                    clientCert_1_.InnerText = profile.clientCert;
                    flatProfileNode.AppendChild(clientCert_1_);

                    // ttlsAuthProto_1_
                    var ttlsAuthProto_1_ = configMACDocument.CreateElement(string.Format("ttlsAuthProto_{0}_", i));
                    ttlsAuthProto_1_.Attributes.Append(naAttribute);
                    ttlsAuthProto_1_.InnerText = profile.ttlsAuthProto;
                    flatProfileNode.AppendChild(ttlsAuthProto_1_);

                    // profileLock_1_
                    var profileLock_1_ = configMACDocument.CreateElement(string.Format("profileLock_{0}_", i));
                    profileLock_1_.Attributes.Append(naAttribute);
                    profileLock_1_.InnerText = profile.profileLock;
                    flatProfileNode.AppendChild(profileLock_1_);

                    // profileEnable_1_
                    var profileEnable_1_ = configMACDocument.CreateElement(string.Format("profileEnable_{0}_", i));
                    profileEnable_1_.Attributes.Append(naAttribute);
                    profileEnable_1_.InnerText = profile.profileEnable;
                    flatProfileNode.AppendChild(profileEnable_1_);

                    i++;
                }
            }

            #endregion

            #region VPN Settings

            // VPN_Server
            var VPN_Server = configMACDocument.CreateElement("VPN_Server");
            VPN_Server.Attributes.Append(rwAttribute);
            VPN_Server.InnerText = _VPN_Server;
            flatProfileNode.AppendChild(VPN_Server);

            // VPN_User_Name
            var VPN_User_Name = configMACDocument.CreateElement("VPN_User_Name");
            VPN_User_Name.Attributes.Append(rwAttribute);
            VPN_User_Name.InnerText = _VPN_User_Name;
            flatProfileNode.AppendChild(VPN_User_Name);

            // VPN_Password
            var VPN_Password = configMACDocument.CreateElement("VPN_Password");
            VPN_Password.Attributes.Append(rwAttribute);
            VPN_Password.InnerText = _VPN_Password;
            flatProfileNode.AppendChild(VPN_Password);

            // VPN_Tunnel_Group
            var VPN_Tunnel_Group = configMACDocument.CreateElement("VPN_Tunnel_Group");
            VPN_Tunnel_Group.Attributes.Append(naAttribute);
            VPN_Tunnel_Group.InnerText = _VPN_Tunnel_Group;
            flatProfileNode.AppendChild(VPN_Tunnel_Group);

            // Connect_on_Bootup
            var Connect_on_Bootup = configMACDocument.CreateElement("Connect_on_Bootup");
            Connect_on_Bootup.Attributes.Append(rwAttribute);
            Connect_on_Bootup.InnerText = _Connect_on_Bootup;
            flatProfileNode.AppendChild(Connect_on_Bootup);

            #endregion

            #region Configuration Profile

            // Provision_Enable
            var Provision_Enable = configMACDocument.CreateElement("Provision_Enable");
            Provision_Enable.Attributes.Append(naAttribute);
            Provision_Enable.InnerText = _Provision_Enable;
            flatProfileNode.AppendChild(Provision_Enable);

            // Resync_On_Reset
            var Resync_On_Reset = configMACDocument.CreateElement("Resync_On_Reset");
            Resync_On_Reset.Attributes.Append(naAttribute);
            Resync_On_Reset.InnerText = _Resync_On_Reset;
            flatProfileNode.AppendChild(Resync_On_Reset);

            // Resync_Random_Delay
            var Resync_Random_Delay = configMACDocument.CreateElement("Resync_Random_Delay");
            Resync_Random_Delay.Attributes.Append(naAttribute);
            Resync_Random_Delay.InnerText = _Resync_Random_Delay;
            flatProfileNode.AppendChild(Resync_Random_Delay);

            // Resync_Periodic
            var Resync_Periodic = configMACDocument.CreateElement("Resync_Periodic");
            Resync_Periodic.Attributes.Append(naAttribute);
            Resync_Periodic.InnerText = _Resync_Periodic;
            flatProfileNode.AppendChild(Resync_Periodic);

            // Resync_Error_Retry_Delay
            var Resync_Error_Retry_Delay = configMACDocument.CreateElement("Resync_Error_Retry_Delay");
            Resync_Error_Retry_Delay.Attributes.Append(naAttribute);
            Resync_Error_Retry_Delay.InnerText = _Resync_Error_Retry_Delay;
            flatProfileNode.AppendChild(Resync_Error_Retry_Delay);

            // Forced_Resync_Delay
            var Forced_Resync_Delay = configMACDocument.CreateElement("Forced_Resync_Delay");
            Forced_Resync_Delay.Attributes.Append(naAttribute);
            Forced_Resync_Delay.InnerText = _Forced_Resync_Delay;
            flatProfileNode.AppendChild(Forced_Resync_Delay);

            // Resync_From_SIP
            var Resync_From_SIP = configMACDocument.CreateElement("Resync_From_SIP");
            Resync_From_SIP.Attributes.Append(naAttribute);
            Resync_From_SIP.InnerText = _Resync_From_SIP;
            flatProfileNode.AppendChild(Resync_From_SIP);

            // Resync_After_Upgrade_Attempt
            var Resync_After_Upgrade_Attempt = configMACDocument.CreateElement("Resync_After_Upgrade_Attempt");
            Resync_After_Upgrade_Attempt.Attributes.Append(naAttribute);
            Resync_After_Upgrade_Attempt.InnerText = _Resync_After_Upgrade_Attempt;
            flatProfileNode.AppendChild(Resync_After_Upgrade_Attempt);

            // Resync_Trigger_1
            var Resync_Trigger_1 = configMACDocument.CreateElement("Resync_Trigger_1");
            Resync_Trigger_1.Attributes.Append(naAttribute);
            Resync_Trigger_1.InnerText = _Resync_Trigger_1;
            flatProfileNode.AppendChild(Resync_Trigger_1);

            // Resync_Trigger_2
            var Resync_Trigger_2 = configMACDocument.CreateElement("Resync_Trigger_2");
            Resync_Trigger_2.Attributes.Append(naAttribute);
            Resync_Trigger_2.InnerText = _Resync_Trigger_2;
            flatProfileNode.AppendChild(Resync_Trigger_2);

            // Resync_Fails_On_FNF
            var Resync_Fails_On_FNF = configMACDocument.CreateElement("Resync_Fails_On_FNF");
            Resync_Fails_On_FNF.Attributes.Append(naAttribute);
            Resync_Fails_On_FNF.InnerText = _Resync_Fails_On_FNF;
            flatProfileNode.AppendChild(Resync_Fails_On_FNF);

            // Profile_Rule
            var Profile_Rule = configMACDocument.CreateElement("Profile_Rule");
            Profile_Rule.Attributes.Append(naAttribute);
            Profile_Rule.InnerText = _Profile_Rule;
            flatProfileNode.AppendChild(Profile_Rule);

            // Profile_Rule_B
            var Profile_Rule_B = configMACDocument.CreateElement("Profile_Rule_B");
            Profile_Rule_B.Attributes.Append(naAttribute);
            Profile_Rule_B.InnerText = _Profile_Rule_B;
            flatProfileNode.AppendChild(Profile_Rule_B);

            // Profile_Rule_C
            var Profile_Rule_C = configMACDocument.CreateElement("Profile_Rule_C");
            Profile_Rule_C.Attributes.Append(naAttribute);
            Profile_Rule_C.InnerText = _Profile_Rule_C;
            flatProfileNode.AppendChild(Profile_Rule_C);

            // Profile_Rule_D
            var Profile_Rule_D = configMACDocument.CreateElement("Profile_Rule_D");
            Profile_Rule_D.Attributes.Append(naAttribute);
            Profile_Rule_D.InnerText = _Profile_Rule_D;
            flatProfileNode.AppendChild(Profile_Rule_D);

            // DHCP_Option_To_Use
            var DHCP_Option_To_Use = configMACDocument.CreateElement("DHCP_Option_To_Use");
            DHCP_Option_To_Use.Attributes.Append(naAttribute);
            DHCP_Option_To_Use.InnerText = _DHCP_Option_To_Use;
            flatProfileNode.AppendChild(DHCP_Option_To_Use);

            // Transport_Protocol
            var Transport_Protocol = configMACDocument.CreateElement("Transport_Protocol");
            Transport_Protocol.Attributes.Append(naAttribute);
            Transport_Protocol.InnerText = _Transport_Protocol;
            flatProfileNode.AppendChild(Transport_Protocol);

            // Log_Resync_Request_Msg
            var Log_Resync_Request_Msg = configMACDocument.CreateElement("Log_Resync_Request_Msg");
            Log_Resync_Request_Msg.Attributes.Append(naAttribute);
            Log_Resync_Request_Msg.InnerText = _Log_Resync_Request_Msg;
            flatProfileNode.AppendChild(Log_Resync_Request_Msg);

            // Log_Resync_Success_Msg
            var Log_Resync_Success_Msg = configMACDocument.CreateElement("Log_Resync_Success_Msg");
            Log_Resync_Success_Msg.Attributes.Append(naAttribute);
            Log_Resync_Success_Msg.InnerText = _Log_Resync_Success_Msg;
            flatProfileNode.AppendChild(Log_Resync_Success_Msg);

            // Log_Resync_Failure_Msg
            var Log_Resync_Failure_Msg = configMACDocument.CreateElement("Log_Resync_Failure_Msg");
            Log_Resync_Failure_Msg.Attributes.Append(naAttribute);
            Log_Resync_Failure_Msg.InnerText = _Log_Resync_Failure_Msg;
            flatProfileNode.AppendChild(Log_Resync_Failure_Msg);

            // Report_Rule
            var Report_Rule = configMACDocument.CreateElement("Report_Rule");
            Report_Rule.Attributes.Append(naAttribute);
            Report_Rule.InnerText = _Report_Rule;
            flatProfileNode.AppendChild(Report_Rule);

            // User_Configurable_Resync
            var User_Configurable_Resync = configMACDocument.CreateElement("User_Configurable_Resync");
            User_Configurable_Resync.Attributes.Append(naAttribute);
            User_Configurable_Resync.InnerText = _User_Configurable_Resync;
            flatProfileNode.AppendChild(User_Configurable_Resync);

            #endregion

            #region Firmware Upgrade

            // Upgrade_Enable
            var Upgrade_Enable = configMACDocument.CreateElement("Upgrade_Enable");
            Upgrade_Enable.Attributes.Append(naAttribute);
            Upgrade_Enable.InnerText = _Upgrade_Enable;
            flatProfileNode.AppendChild(Upgrade_Enable);

            // Upgrade_Error_Retry_Delay
            var Upgrade_Error_Retry_Delay = configMACDocument.CreateElement("Upgrade_Error_Retry_Delay");
            Upgrade_Error_Retry_Delay.Attributes.Append(naAttribute);
            Upgrade_Error_Retry_Delay.InnerText = _Upgrade_Error_Retry_Delay;
            flatProfileNode.AppendChild(Upgrade_Error_Retry_Delay);

            // Downgrade_Rev_Limit
            var Downgrade_Rev_Limit = configMACDocument.CreateElement("Downgrade_Rev_Limit");
            Downgrade_Rev_Limit.Attributes.Append(naAttribute);
            Downgrade_Rev_Limit.InnerText = _Downgrade_Rev_Limit;
            flatProfileNode.AppendChild(Downgrade_Rev_Limit);

            // Upgrade_Rule
            var Upgrade_Rule = configMACDocument.CreateElement("Upgrade_Rule");
            Upgrade_Rule.Attributes.Append(naAttribute);
            Upgrade_Rule.InnerText = _Upgrade_Rule;
            flatProfileNode.AppendChild(Upgrade_Rule);

            // Log_Upgrade_Request_Msg
            var Log_Upgrade_Request_Msg = configMACDocument.CreateElement("Log_Upgrade_Request_Msg");
            Log_Upgrade_Request_Msg.Attributes.Append(naAttribute);
            Log_Upgrade_Request_Msg.InnerText = _Log_Upgrade_Request_Msg;
            flatProfileNode.AppendChild(Log_Upgrade_Request_Msg);

            // Log_Upgrade_Success_Msg
            var Log_Upgrade_Success_Msg = configMACDocument.CreateElement("Log_Upgrade_Success_Msg");
            Log_Upgrade_Success_Msg.Attributes.Append(naAttribute);
            Log_Upgrade_Success_Msg.InnerText = _Log_Upgrade_Success_Msg;
            flatProfileNode.AppendChild(Log_Upgrade_Success_Msg);

            // Log_Upgrade_Failure_Msg
            var Log_Upgrade_Failure_Msg = configMACDocument.CreateElement("Log_Upgrade_Failure_Msg");
            Log_Upgrade_Failure_Msg.Attributes.Append(naAttribute);
            Log_Upgrade_Failure_Msg.InnerText = _Log_Upgrade_Failure_Msg;
            flatProfileNode.AppendChild(Log_Upgrade_Failure_Msg);

            // License_Keys
            var License_Keys = configMACDocument.CreateElement("License_Keys");
            License_Keys.Attributes.Append(naAttribute);
            License_Keys.InnerText = _License_Keys;
            flatProfileNode.AppendChild(License_Keys);

            #endregion

            #region SIP Parameters

            // Max_Forward
            var Max_Forward = configMACDocument.CreateElement("Max_Forward");
            Max_Forward.Attributes.Append(naAttribute);
            Max_Forward.InnerText = _Max_Forward;
            flatProfileNode.AppendChild(Max_Forward);

            // Max_Redirection
            var Max_Redirection = configMACDocument.CreateElement("Max_Redirection");
            Max_Redirection.Attributes.Append(naAttribute);
            Max_Redirection.InnerText = _Max_Redirection;
            flatProfileNode.AppendChild(Max_Redirection);

            // Max_Auth
            var Max_Auth = configMACDocument.CreateElement("Max_Auth");
            Max_Auth.Attributes.Append(naAttribute);
            Max_Auth.InnerText = _Max_Auth;
            flatProfileNode.AppendChild(Max_Auth);

            // SIP_User_Agent_Name
            var SIP_User_Agent_Name = configMACDocument.CreateElement("SIP_User_Agent_Name");
            SIP_User_Agent_Name.Attributes.Append(naAttribute);
            SIP_User_Agent_Name.InnerText = _SIP_User_Agent_Name;
            flatProfileNode.AppendChild(SIP_User_Agent_Name);

            // SIP_Server_Name
            var SIP_Server_Name = configMACDocument.CreateElement("SIP_Server_Name");
            SIP_Server_Name.Attributes.Append(naAttribute);
            SIP_Server_Name.InnerText = _SIP_Server_Name;
            flatProfileNode.AppendChild(SIP_Server_Name);

            // SIP_Reg_User_Agent_Name
            var SIP_Reg_User_Agent_Name = configMACDocument.CreateElement("SIP_Reg_User_Agent_Name");
            SIP_Reg_User_Agent_Name.Attributes.Append(naAttribute);
            SIP_Reg_User_Agent_Name.InnerText = _SIP_Reg_User_Agent_Name;
            flatProfileNode.AppendChild(SIP_Reg_User_Agent_Name);

            // SIP_Accept_Language
            var SIP_Accept_Language = configMACDocument.CreateElement("SIP_Accept_Language");
            SIP_Accept_Language.Attributes.Append(naAttribute);
            SIP_Accept_Language.InnerText = _SIP_Accept_Language;
            flatProfileNode.AppendChild(SIP_Accept_Language);

            // DTMF_Relay_MIME_Type
            var DTMF_Relay_MIME_Type = configMACDocument.CreateElement("DTMF_Relay_MIME_Type");
            DTMF_Relay_MIME_Type.Attributes.Append(naAttribute);
            DTMF_Relay_MIME_Type.InnerText = _DTMF_Relay_MIME_Type;
            flatProfileNode.AppendChild(DTMF_Relay_MIME_Type);

            // Hook_Flash_MIME_Type
            var Hook_Flash_MIME_Type = configMACDocument.CreateElement("Hook_Flash_MIME_Type");
            Hook_Flash_MIME_Type.Attributes.Append(naAttribute);
            Hook_Flash_MIME_Type.InnerText = _Hook_Flash_MIME_Type;
            flatProfileNode.AppendChild(Hook_Flash_MIME_Type);

            // Remove_Last_Reg
            var Remove_Last_Reg = configMACDocument.CreateElement("Remove_Last_Reg");
            Remove_Last_Reg.Attributes.Append(naAttribute);
            Remove_Last_Reg.InnerText = _Remove_Last_Reg;
            flatProfileNode.AppendChild(Remove_Last_Reg);

            // Use_Compact_Header
            var Use_Compact_Header = configMACDocument.CreateElement("Use_Compact_Header");
            Use_Compact_Header.Attributes.Append(naAttribute);
            Use_Compact_Header.InnerText = _Use_Compact_Header;
            flatProfileNode.AppendChild(Use_Compact_Header);

            // Escape_Display_Name
            var Escape_Display_Name = configMACDocument.CreateElement("Escape_Display_Name");
            Escape_Display_Name.Attributes.Append(naAttribute);
            Escape_Display_Name.InnerText = _Escape_Display_Name;
            flatProfileNode.AppendChild(Escape_Display_Name);

            // SIP-B_Enable
            var SIP_B_Enable = configMACDocument.CreateElement("SIP-B_Enable");
            SIP_B_Enable.Attributes.Append(naAttribute);
            SIP_B_Enable.InnerText = _SIP_B_Enable;
            flatProfileNode.AppendChild(SIP_B_Enable);

            // Talk_Package
            var Talk_Package = configMACDocument.CreateElement("Talk_Package");
            Talk_Package.Attributes.Append(naAttribute);
            Talk_Package.InnerText = _Talk_Package;
            flatProfileNode.AppendChild(Talk_Package);

            // Hold_Package
            var Hold_Package = configMACDocument.CreateElement("Hold_Package");
            Hold_Package.Attributes.Append(naAttribute);
            Hold_Package.InnerText = _Hold_Package;
            flatProfileNode.AppendChild(Hold_Package);

            // Conference_Package
            var Conference_Package = configMACDocument.CreateElement("Conference_Package");
            Conference_Package.Attributes.Append(naAttribute);
            Conference_Package.InnerText = _Conference_Package;
            flatProfileNode.AppendChild(Conference_Package);

            // Notify_Conference
            var Notify_Conference = configMACDocument.CreateElement("Notify_Conference");
            Notify_Conference.Attributes.Append(naAttribute);
            Notify_Conference.InnerText = _Notify_Conference;
            flatProfileNode.AppendChild(Notify_Conference);

            // RFC_2543_Call_Hold
            var RFC_2543_Call_Hold = configMACDocument.CreateElement("RFC_2543_Call_Hold");
            RFC_2543_Call_Hold.Attributes.Append(naAttribute);
            RFC_2543_Call_Hold.InnerText = _RFC_2543_Call_Hold;
            flatProfileNode.AppendChild(RFC_2543_Call_Hold);

            // Random_REG_CID_On_Reboot
            var Random_REG_CID_On_Reboot = configMACDocument.CreateElement("Random_REG_CID_On_Reboot");
            Random_REG_CID_On_Reboot.Attributes.Append(naAttribute);
            Random_REG_CID_On_Reboot.InnerText = _Random_REG_CID_On_Reboot;
            flatProfileNode.AppendChild(Random_REG_CID_On_Reboot);

            // Mark_All_AVT_Packets
            var Mark_All_AVT_Packets = configMACDocument.CreateElement("Mark_All_AVT_Packets");
            Mark_All_AVT_Packets.Attributes.Append(naAttribute);
            Mark_All_AVT_Packets.InnerText = _Mark_All_AVT_Packets;
            flatProfileNode.AppendChild(Mark_All_AVT_Packets);

            // SIP_TCP_Port_Min
            var SIP_TCP_Port_Min = configMACDocument.CreateElement("SIP_TCP_Port_Min");
            SIP_TCP_Port_Min.Attributes.Append(naAttribute);
            SIP_TCP_Port_Min.InnerText = _SIP_TCP_Port_Min;
            flatProfileNode.AppendChild(SIP_TCP_Port_Min);

            // SIP_TCP_Port_Max
            var SIP_TCP_Port_Max = configMACDocument.CreateElement("SIP_TCP_Port_Max");
            SIP_TCP_Port_Max.Attributes.Append(naAttribute);
            SIP_TCP_Port_Max.InnerText = _SIP_TCP_Port_Max;
            flatProfileNode.AppendChild(SIP_TCP_Port_Max);

            // CTI_Enable
            var CTI_Enable = configMACDocument.CreateElement("CTI_Enable");
            CTI_Enable.Attributes.Append(naAttribute);
            CTI_Enable.InnerText = _CTI_Enable;
            flatProfileNode.AppendChild(CTI_Enable);

            // Caller_ID_Header
            var Caller_ID_Header = configMACDocument.CreateElement("Caller_ID_Header");
            Caller_ID_Header.Attributes.Append(naAttribute);
            Caller_ID_Header.InnerText = _Caller_ID_Header;
            flatProfileNode.AppendChild(Caller_ID_Header);

            // SRTP_Method
            var SRTP_Method = configMACDocument.CreateElement("SRTP_Method");
            SRTP_Method.Attributes.Append(naAttribute);
            SRTP_Method.InnerText = _SRTP_Method;
            flatProfileNode.AppendChild(SRTP_Method);

            // Hold_Target_Before_REFER
            var Hold_Target_Before_REFER = configMACDocument.CreateElement("Hold_Target_Before_REFER");
            Hold_Target_Before_REFER.Attributes.Append(naAttribute);
            Hold_Target_Before_REFER.InnerText = _Hold_Target_Before_REFER;
            flatProfileNode.AppendChild(Hold_Target_Before_REFER);

            #endregion

            #region SIP Timer Values

            // SIP_T1
            var SIP_T1 = configMACDocument.CreateElement("SIP_T1");
            SIP_T1.Attributes.Append(naAttribute);
            SIP_T1.InnerText = _SIP_T1;
            flatProfileNode.AppendChild(SIP_T1);

            // SIP_T2
            var SIP_T2 = configMACDocument.CreateElement("SIP_T2");
            SIP_T2.Attributes.Append(naAttribute);
            SIP_T2.InnerText = _SIP_T2;
            flatProfileNode.AppendChild(SIP_T2);

            // SIP_T4
            var SIP_T4 = configMACDocument.CreateElement("SIP_T4");
            SIP_T4.Attributes.Append(naAttribute);
            SIP_T4.InnerText = _SIP_T4;
            flatProfileNode.AppendChild(SIP_T4);

            // SIP_Timer_B
            var SIP_Timer_B = configMACDocument.CreateElement("SIP_Timer_B");
            SIP_Timer_B.Attributes.Append(naAttribute);
            SIP_Timer_B.InnerText = _SIP_Timer_B;
            flatProfileNode.AppendChild(SIP_Timer_B);

            // SIP_Timer_F
            var SIP_Timer_F = configMACDocument.CreateElement("SIP_Timer_F");
            SIP_Timer_F.Attributes.Append(naAttribute);
            SIP_Timer_F.InnerText = _SIP_Timer_F;
            flatProfileNode.AppendChild(SIP_Timer_F);

            // SIP_Timer_H
            var SIP_Timer_H = configMACDocument.CreateElement("SIP_Timer_H");
            SIP_Timer_H.Attributes.Append(naAttribute);
            SIP_Timer_H.InnerText = _SIP_Timer_H;
            flatProfileNode.AppendChild(SIP_Timer_H);

            // SIP_Timer_D
            var SIP_Timer_D = configMACDocument.CreateElement("SIP_Timer_D");
            SIP_Timer_D.Attributes.Append(naAttribute);
            SIP_Timer_D.InnerText = _SIP_Timer_D;
            flatProfileNode.AppendChild(SIP_Timer_D);

            // SIP_Timer_J
            var SIP_Timer_J = configMACDocument.CreateElement("SIP_Timer_J");
            SIP_Timer_J.Attributes.Append(naAttribute);
            SIP_Timer_J.InnerText = _SIP_Timer_J;
            flatProfileNode.AppendChild(SIP_Timer_J);

            // INVITE_Expires
            var INVITE_Expires = configMACDocument.CreateElement("INVITE_Expires");
            INVITE_Expires.Attributes.Append(naAttribute);
            INVITE_Expires.InnerText = _INVITE_Expires;
            flatProfileNode.AppendChild(INVITE_Expires);

            // ReINVITE_Expires
            var ReINVITE_Expires = configMACDocument.CreateElement("ReINVITE_Expires");
            ReINVITE_Expires.Attributes.Append(naAttribute);
            ReINVITE_Expires.InnerText = _ReINVITE_Expires;
            flatProfileNode.AppendChild(ReINVITE_Expires);

            // Reg_Min_Expires
            var Reg_Min_Expires = configMACDocument.CreateElement("Reg_Min_Expires");
            Reg_Min_Expires.Attributes.Append(naAttribute);
            Reg_Min_Expires.InnerText = _Reg_Min_Expires;
            flatProfileNode.AppendChild(Reg_Min_Expires);

            // Reg_Max_Expires
            var Reg_Max_Expires = configMACDocument.CreateElement("Reg_Max_Expires");
            Reg_Max_Expires.Attributes.Append(naAttribute);
            Reg_Max_Expires.InnerText = _Reg_Max_Expires;
            flatProfileNode.AppendChild(Reg_Max_Expires);

            // Reg_Retry_Intvl
            var Reg_Retry_Intvl = configMACDocument.CreateElement("Reg_Retry_Intvl");
            Reg_Retry_Intvl.Attributes.Append(naAttribute);
            Reg_Retry_Intvl.InnerText = _Reg_Retry_Intvl;
            flatProfileNode.AppendChild(Reg_Retry_Intvl);

            // Reg_Retry_Long_Intvl
            var Reg_Retry_Long_Intvl = configMACDocument.CreateElement("Reg_Retry_Long_Intvl");
            Syslog_Server.Attributes.Append(naAttribute);
            Syslog_Server.InnerText = _Reg_Retry_Long_Intvl;
            flatProfileNode.AppendChild(Reg_Retry_Long_Intvl);

            // Reg_Retry_Random_Delay
            var Reg_Retry_Random_Delay = configMACDocument.CreateElement("Reg_Retry_Random_Delay");
            Reg_Retry_Random_Delay.Attributes.Append(naAttribute);
            Reg_Retry_Random_Delay.InnerText = _Reg_Retry_Random_Delay;
            flatProfileNode.AppendChild(Reg_Retry_Random_Delay);

            // Reg_Retry_Long_Random_Delay
            var Reg_Retry_Long_Random_Delay = configMACDocument.CreateElement("Reg_Retry_Long_Random_Delay");
            Reg_Retry_Long_Random_Delay.Attributes.Append(naAttribute);
            Reg_Retry_Long_Random_Delay.InnerText = _Reg_Retry_Long_Random_Delay;
            flatProfileNode.AppendChild(Reg_Retry_Long_Random_Delay);

            // Reg_Retry_Intvl_Cap
            var Reg_Retry_Intvl_Cap = configMACDocument.CreateElement("Reg_Retry_Intvl_Cap");
            Reg_Retry_Intvl_Cap.Attributes.Append(naAttribute);
            Reg_Retry_Intvl_Cap.InnerText = _Reg_Retry_Intvl_Cap;
            flatProfileNode.AppendChild(Reg_Retry_Intvl_Cap);

            // Sub_Min_Expires
            var Sub_Min_Expires = configMACDocument.CreateElement("Sub_Min_Expires");
            Sub_Min_Expires.Attributes.Append(naAttribute);
            Sub_Min_Expires.InnerText = _Sub_Min_Expires;
            flatProfileNode.AppendChild(Sub_Min_Expires);

            // Sub_Max_Expires
            var Sub_Max_Expires = configMACDocument.CreateElement("Sub_Max_Expires");
            Sub_Max_Expires.Attributes.Append(naAttribute);
            Sub_Max_Expires.InnerText = _Sub_Max_Expires;
            flatProfileNode.AppendChild(Sub_Max_Expires);

            // Sub_Retry_Intvl
            var Sub_Retry_Intvl = configMACDocument.CreateElement("Sub_Retry_Intvl");
            Sub_Retry_Intvl.Attributes.Append(naAttribute);
            Sub_Retry_Intvl.InnerText = _Sub_Retry_Intvl;
            flatProfileNode.AppendChild(Sub_Retry_Intvl);

            #endregion

            #region  Response Status Code Handling 

            // SIT1_RSC
            var SIT1_RSC = configMACDocument.CreateElement("SIT1_RSC");
            SIT1_RSC.Attributes.Append(naAttribute);
            SIT1_RSC.InnerText = _SIT1_RSC;
            flatProfileNode.AppendChild(SIT1_RSC);

            // SIT2_RSC
            var SIT2_RSC = configMACDocument.CreateElement("SIT2_RSC");
            SIT2_RSC.Attributes.Append(naAttribute);
            SIT2_RSC.InnerText = _SIT2_RSC;
            flatProfileNode.AppendChild(SIT2_RSC);

            // SIT3_RSC
            var SIT3_RSC = configMACDocument.CreateElement("SIT3_RSC");
            SIT3_RSC.Attributes.Append(naAttribute);
            SIT3_RSC.InnerText = _SIT3_RSC;
            flatProfileNode.AppendChild(SIT3_RSC);

            // SIT4_RSC
            var SIT4_RSC = configMACDocument.CreateElement("SIT4_RSC");
            SIT4_RSC.Attributes.Append(naAttribute);
            SIT4_RSC.InnerText = _SIT4_RSC;
            flatProfileNode.AppendChild(SIT4_RSC);

            // Try_Backup_RSC
            var Try_Backup_RSC = configMACDocument.CreateElement("Try_Backup_RSC");
            Try_Backup_RSC.Attributes.Append(naAttribute);
            Try_Backup_RSC.InnerText = _Try_Backup_RSC;
            flatProfileNode.AppendChild(Try_Backup_RSC);

            // Retry_Reg_RSC
            var Retry_Reg_RSC = configMACDocument.CreateElement("Retry_Reg_RSC");
            Retry_Reg_RSC.Attributes.Append(naAttribute);
            Retry_Reg_RSC.InnerText = _Retry_Reg_RSC;
            flatProfileNode.AppendChild(Retry_Reg_RSC);

            #endregion

            #region RTP Parameters 

            // RTP_Port_Min
            var RTP_Port_Min = configMACDocument.CreateElement("RTP_Port_Min");
            RTP_Port_Min.Attributes.Append(naAttribute);
            RTP_Port_Min.InnerText = _RTP_Port_Min;
            flatProfileNode.AppendChild(RTP_Port_Min);

            // RTP_Port_Max
            var RTP_Port_Max = configMACDocument.CreateElement("RTP_Port_Max");
            RTP_Port_Max.Attributes.Append(naAttribute);
            RTP_Port_Max.InnerText = _RTP_Port_Max;
            flatProfileNode.AppendChild(RTP_Port_Max);

            // RTP_Packet_Size
            var RTP_Packet_Size = configMACDocument.CreateElement("RTP_Packet_Size");
            RTP_Packet_Size.Attributes.Append(naAttribute);
            RTP_Packet_Size.InnerText = _RTP_Packet_Size;
            flatProfileNode.AppendChild(RTP_Packet_Size);

            // Max_RTP_ICMP_Err
            var Max_RTP_ICMP_Err = configMACDocument.CreateElement("Max_RTP_ICMP_Err");
            Max_RTP_ICMP_Err.Attributes.Append(naAttribute);
            Max_RTP_ICMP_Err.InnerText = _Max_RTP_ICMP_Err;
            flatProfileNode.AppendChild(Max_RTP_ICMP_Err);

            // RTCP_Tx_Interval
            var RTCP_Tx_Interval = configMACDocument.CreateElement("RTCP_Tx_Interval");
            RTCP_Tx_Interval.Attributes.Append(naAttribute);
            RTCP_Tx_Interval.InnerText = _RTCP_Tx_Interval;
            flatProfileNode.AppendChild(RTCP_Tx_Interval);

            // No_UDP_Checksum
            var No_UDP_Checksum = configMACDocument.CreateElement("No_UDP_Checksum");
            No_UDP_Checksum.Attributes.Append(naAttribute);
            No_UDP_Checksum.InnerText = _No_UDP_Checksum;
            flatProfileNode.AppendChild(No_UDP_Checksum);

            // Symmetric_RTP
            var Symmetric_RTP = configMACDocument.CreateElement("Symmetric_RTP");
            Symmetric_RTP.Attributes.Append(naAttribute);
            Symmetric_RTP.InnerText = _Symmetric_RTP;
            flatProfileNode.AppendChild(Symmetric_RTP);

            // Stats_In_BYE
            var Stats_In_BYE = configMACDocument.CreateElement("Stats_In_BYE");
            Stats_In_BYE.Attributes.Append(naAttribute);
            Stats_In_BYE.InnerText = _Stats_In_BYE;
            flatProfileNode.AppendChild(Stats_In_BYE);

            #endregion

            #region SDP Payload Types

            // AVT_Dynamic_Payload
            var AVT_Dynamic_Payload = configMACDocument.CreateElement("AVT_Dynamic_Payload");
            AVT_Dynamic_Payload.Attributes.Append(naAttribute);
            AVT_Dynamic_Payload.InnerText = _AVT_Dynamic_Payload;
            flatProfileNode.AppendChild(AVT_Dynamic_Payload);

            // INFOREQ_Dynamic_Payload
            var INFOREQ_Dynamic_Payload = configMACDocument.CreateElement("INFOREQ_Dynamic_Payload");
            INFOREQ_Dynamic_Payload.Attributes.Append(naAttribute);
            INFOREQ_Dynamic_Payload.InnerText = _INFOREQ_Dynamic_Payload;
            flatProfileNode.AppendChild(INFOREQ_Dynamic_Payload);

            // G726r16_Dynamic_Payload
            var G726r16_Dynamic_Payload = configMACDocument.CreateElement("G726r16_Dynamic_Payload");
            G726r16_Dynamic_Payload.Attributes.Append(naAttribute);
            G726r16_Dynamic_Payload.InnerText = _G726r16_Dynamic_Payload;
            flatProfileNode.AppendChild(G726r16_Dynamic_Payload);

            // G726r24_Dynamic_Payload
            var G726r24_Dynamic_Payload = configMACDocument.CreateElement("G726r24_Dynamic_Payload");
            G726r24_Dynamic_Payload.Attributes.Append(naAttribute);
            G726r24_Dynamic_Payload.InnerText = _G726r24_Dynamic_Payload;
            flatProfileNode.AppendChild(G726r24_Dynamic_Payload);

            // G726r32_Dynamic_Payload
            var G726r32_Dynamic_Payload = configMACDocument.CreateElement("G726r32_Dynamic_Payload");
            G726r32_Dynamic_Payload.Attributes.Append(naAttribute);
            G726r32_Dynamic_Payload.InnerText = _G726r32_Dynamic_Payload;
            flatProfileNode.AppendChild(G726r32_Dynamic_Payload);

            // G726r40_Dynamic_Payload
            var G726r40_Dynamic_Payload = configMACDocument.CreateElement("G726r40_Dynamic_Payload");
            G726r40_Dynamic_Payload.Attributes.Append(naAttribute);
            G726r40_Dynamic_Payload.InnerText = _G726r40_Dynamic_Payload;
            flatProfileNode.AppendChild(G726r40_Dynamic_Payload);

            // G729b_Dynamic_Payload
            var G729b_Dynamic_Payload = configMACDocument.CreateElement("G729b_Dynamic_Payload");
            G729b_Dynamic_Payload.Attributes.Append(naAttribute);
            G729b_Dynamic_Payload.InnerText = _G729b_Dynamic_Payload;
            flatProfileNode.AppendChild(G729b_Dynamic_Payload);

            // L16_Dynamic_Payload
            var L16_Dynamic_Payload = configMACDocument.CreateElement("L16_Dynamic_Payload");
            L16_Dynamic_Payload.Attributes.Append(naAttribute);
            L16_Dynamic_Payload.InnerText = _L16_Dynamic_Payload;
            flatProfileNode.AppendChild(L16_Dynamic_Payload);

            // EncapRTP_Dynamic_Payload
            var EncapRTP_Dynamic_Payload = configMACDocument.CreateElement("EncapRTP_Dynamic_Payload");
            EncapRTP_Dynamic_Payload.Attributes.Append(naAttribute);
            EncapRTP_Dynamic_Payload.InnerText = _EncapRTP_Dynamic_Payload;
            flatProfileNode.AppendChild(EncapRTP_Dynamic_Payload);

            // RTP-Start-Loopback_Dynamic_Payload
            var RTP_Start_Loopback_Dynamic_Payload =
                configMACDocument.CreateElement("RTP-Start-Loopback_Dynamic_Payload");
            RTP_Start_Loopback_Dynamic_Payload.Attributes.Append(naAttribute);
            RTP_Start_Loopback_Dynamic_Payload.InnerText = _RTP_Start_Loopback_Dynamic_Payload;
            flatProfileNode.AppendChild(RTP_Start_Loopback_Dynamic_Payload);

            // RTP-Start-Loopback_Codec
            var RTP_Start_Loopback_Codec = configMACDocument.CreateElement("RTP-Start-Loopback_Codec");
            RTP_Start_Loopback_Codec.Attributes.Append(naAttribute);
            RTP_Start_Loopback_Codec.InnerText = _RTP_Start_Loopback_Codec;
            flatProfileNode.AppendChild(RTP_Start_Loopback_Codec);

            // AVT_Codec_Name
            var AVT_Codec_Name = configMACDocument.CreateElement("AVT_Codec_Name");
            AVT_Codec_Name.Attributes.Append(naAttribute);
            AVT_Codec_Name.InnerText = _AVT_Codec_Name;
            flatProfileNode.AppendChild(AVT_Codec_Name);

            // G711u_Codec_Name
            var G711u_Codec_Name = configMACDocument.CreateElement("G711u_Codec_Name");
            G711u_Codec_Name.Attributes.Append(naAttribute);
            G711u_Codec_Name.InnerText = _G711u_Codec_Name;
            flatProfileNode.AppendChild(G711u_Codec_Name);

            // G711a_Codec_Name
            var G711a_Codec_Name = configMACDocument.CreateElement("G711a_Codec_Name");
            G711a_Codec_Name.Attributes.Append(naAttribute);
            G711a_Codec_Name.InnerText = _G711a_Codec_Name;
            flatProfileNode.AppendChild(G711a_Codec_Name);

            // G726r32_Codec_Name
            var G726r32_Codec_Name = configMACDocument.CreateElement("G726r32_Codec_Name");
            G726r32_Codec_Name.Attributes.Append(naAttribute);
            G726r32_Codec_Name.InnerText = _G726r32_Codec_Name;
            flatProfileNode.AppendChild(G726r32_Codec_Name);

            // G729a_Codec_Name
            var G729a_Codec_Name = configMACDocument.CreateElement("G729a_Codec_Name");
            G729a_Codec_Name.Attributes.Append(naAttribute);
            G729a_Codec_Name.InnerText = _G729a_Codec_Name;
            flatProfileNode.AppendChild(G729a_Codec_Name);

            // G729b_Codec_Name
            var G729b_Codec_Name = configMACDocument.CreateElement("G729b_Codec_Name");
            G729b_Codec_Name.Attributes.Append(naAttribute);
            G729b_Codec_Name.InnerText = _G729b_Codec_Name;
            flatProfileNode.AppendChild(G729b_Codec_Name);

            // G722_Codec_Name
            var G722_Codec_Name = configMACDocument.CreateElement("G722_Codec_Name");
            G722_Codec_Name.Attributes.Append(naAttribute);
            G722_Codec_Name.InnerText = _G722_Codec_Name;
            flatProfileNode.AppendChild(G722_Codec_Name);

            // L16_Codec_Name
            var L16_Codec_Name = configMACDocument.CreateElement("L16_Codec_Name");
            L16_Codec_Name.Attributes.Append(naAttribute);
            L16_Codec_Name.InnerText = _L16_Codec_Name;
            flatProfileNode.AppendChild(L16_Codec_Name);

            // EncapRTP_Codec_Name
            var EncapRTP_Codec_Name = configMACDocument.CreateElement("EncapRTP_Codec_Name");
            EncapRTP_Codec_Name.Attributes.Append(naAttribute);
            EncapRTP_Codec_Name.InnerText = _EncapRTP_Codec_Name;
            flatProfileNode.AppendChild(EncapRTP_Codec_Name);

            #endregion

            #region NAT Support Parameters

            // Handle_VIA_received
            var Handle_VIA_received = configMACDocument.CreateElement("Handle_VIA_received");
            Handle_VIA_received.Attributes.Append(naAttribute);
            Handle_VIA_received.InnerText = _Handle_VIA_received;
            flatProfileNode.AppendChild(Handle_VIA_received);

            // Handle_VIA_rport
            var Handle_VIA_rport = configMACDocument.CreateElement("Handle_VIA_rport");
            Handle_VIA_rport.Attributes.Append(naAttribute);
            Handle_VIA_rport.InnerText = _Handle_VIA_rport;
            flatProfileNode.AppendChild(Handle_VIA_rport);

            // Insert_VIA_received
            var Insert_VIA_received = configMACDocument.CreateElement("Insert_VIA_received");
            Insert_VIA_received.Attributes.Append(naAttribute);
            Insert_VIA_received.InnerText = _Insert_VIA_received;
            flatProfileNode.AppendChild(Insert_VIA_received);

            // Insert_VIA_rport
            var Insert_VIA_rport = configMACDocument.CreateElement("Insert_VIA_rport");
            Insert_VIA_rport.Attributes.Append(naAttribute);
            Insert_VIA_rport.InnerText = _Insert_VIA_rport;
            flatProfileNode.AppendChild(Insert_VIA_rport);

            // Substitute_VIA_Addr
            var Substitute_VIA_Addr = configMACDocument.CreateElement("Substitute_VIA_Addr");
            Substitute_VIA_Addr.Attributes.Append(naAttribute);
            Substitute_VIA_Addr.InnerText = _Substitute_VIA_Addr;
            flatProfileNode.AppendChild(Substitute_VIA_Addr);

            // Send_Resp_To_Src_Port
            var Send_Resp_To_Src_Port = configMACDocument.CreateElement("Send_Resp_To_Src_Port");
            Send_Resp_To_Src_Port.Attributes.Append(naAttribute);
            Send_Resp_To_Src_Port.InnerText = _Send_Resp_To_Src_Port;
            flatProfileNode.AppendChild(Send_Resp_To_Src_Port);

            // STUN_Enable
            var STUN_Enable = configMACDocument.CreateElement("STUN_Enable");
            STUN_Enable.Attributes.Append(naAttribute);
            STUN_Enable.InnerText = _STUN_Enable;
            flatProfileNode.AppendChild(STUN_Enable);

            // STUN_Test_Enable
            var STUN_Test_Enable = configMACDocument.CreateElement("STUN_Test_Enable");
            STUN_Test_Enable.Attributes.Append(naAttribute);
            STUN_Test_Enable.InnerText = _STUN_Test_Enable;
            flatProfileNode.AppendChild(STUN_Test_Enable);

            // STUN_Server
            var STUN_Server = configMACDocument.CreateElement("STUN_Server");
            STUN_Server.Attributes.Append(naAttribute);
            STUN_Server.InnerText = _STUN_Server;
            flatProfileNode.AppendChild(STUN_Server);

            // EXT_IP
            var EXT_IP = configMACDocument.CreateElement("EXT_IP");
            EXT_IP.Attributes.Append(naAttribute);
            EXT_IP.InnerText = _EXT_IP;
            flatProfileNode.AppendChild(EXT_IP);

            // EXT_RTP_Port_Min
            var EXT_RTP_Port_Min = configMACDocument.CreateElement("EXT_RTP_Port_Min");
            EXT_RTP_Port_Min.Attributes.Append(naAttribute);
            EXT_RTP_Port_Min.InnerText = _EXT_RTP_Port_Min;
            flatProfileNode.AppendChild(EXT_RTP_Port_Min);

            // NAT_Keep_Alive_Intvl
            var NAT_Keep_Alive_Intvl = configMACDocument.CreateElement("NAT_Keep_Alive_Intvl");
            NAT_Keep_Alive_Intvl.Attributes.Append(naAttribute);
            NAT_Keep_Alive_Intvl.InnerText = _NAT_Keep_Alive_Intvl;
            flatProfileNode.AppendChild(NAT_Keep_Alive_Intvl);

            #endregion

            #region Linksys Key System Parameters 

            // Linksys_Key_System
            var Linksys_Key_System = configMACDocument.CreateElement("Linksys_Key_System");
            Linksys_Key_System.Attributes.Append(naAttribute);
            Linksys_Key_System.InnerText = _Linksys_Key_System;
            flatProfileNode.AppendChild(Linksys_Key_System);

            // Multicast_Address
            var Multicast_Address = configMACDocument.CreateElement("Multicast_Address");
            Multicast_Address.Attributes.Append(naAttribute);
            Multicast_Address.InnerText = _Multicast_Address;
            flatProfileNode.AppendChild(Multicast_Address);

            // Key_System_Auto_Discovery
            var Key_System_Auto_Discovery = configMACDocument.CreateElement("Key_System_Auto_Discovery");
            Key_System_Auto_Discovery.Attributes.Append(naAttribute);
            Key_System_Auto_Discovery.InnerText = _Key_System_Auto_Discovery;
            flatProfileNode.AppendChild(Key_System_Auto_Discovery);

            // Key_System_IP_Address
            var Key_System_IP_Address = configMACDocument.CreateElement("Key_System_IP_Address");
            Key_System_IP_Address.Attributes.Append(naAttribute);
            Key_System_IP_Address.InnerText = _Key_System_IP_Address;
            flatProfileNode.AppendChild(Key_System_IP_Address);

            // Force_LAN_Codec
            var Force_LAN_Codec = configMACDocument.CreateElement("Force_LAN_Codec");
            Force_LAN_Codec.Attributes.Append(naAttribute);
            Force_LAN_Codec.InnerText = _Force_LAN_Codec;
            flatProfileNode.AppendChild(Force_LAN_Codec);

            #endregion

            #region Line Ext

            if (lineExts != null)
            {
                var y = 1;

                foreach (var ext in lineExts)
                {
                    // Line_Enable_1_
                    var Line_Enable_1_ = configMACDocument.CreateElement(string.Format("Line_Enable_{0}_", y));
                    Line_Enable_1_.Attributes.Append(naAttribute);
                    Line_Enable_1_.InnerText = ext.Enable;
                    flatProfileNode.AppendChild(Line_Enable_1_);

                    // ShareLineApperance

                    // Share_Ext_1_
                    var Share_Ext_1_ = configMACDocument.CreateElement(string.Format("Share_Ext_{0}_", y));
                    Share_Ext_1_.Attributes.Append(naAttribute);
                    Share_Ext_1_.InnerText = ext.ShareExt;
                    flatProfileNode.AppendChild(Share_Ext_1_);

                    // Shared_User_ID_1_
                    var Shared_User_ID_1_ = configMACDocument.CreateElement(string.Format("Shared_User_ID_{0}_", y));
                    Shared_User_ID_1_.Attributes.Append(naAttribute);
                    Shared_User_ID_1_.InnerText = ext.SharedUserID;
                    flatProfileNode.AppendChild(Shared_User_ID_1_);

                    // Subscription_Expires_1_
                    var Subscription_Expires_1_ =
                        configMACDocument.CreateElement(string.Format("Subscription_Expires_{0}_", y));
                    Subscription_Expires_1_.Attributes.Append(naAttribute);
                    Subscription_Expires_1_.InnerText = ext.SubscriptionExpires;
                    flatProfileNode.AppendChild(Subscription_Expires_1_);

                    // Restrict_MWI_1_
                    var Restrict_MWI_1_ = configMACDocument.CreateElement(string.Format("Restrict_MWI_{0}_", y));
                    Restrict_MWI_1_.Attributes.Append(naAttribute);
                    Restrict_MWI_1_.InnerText = ext.RestrictMWI;
                    flatProfileNode.AppendChild(Restrict_MWI_1_);

                    // NAT Settings

                    // NAT_Mapping_Enable_1_
                    var NAT_Mapping_Enable_1_ =
                        configMACDocument.CreateElement(string.Format("NAT_Mapping_Enable_{0}_", y));
                    NAT_Mapping_Enable_1_.Attributes.Append(naAttribute);
                    NAT_Mapping_Enable_1_.InnerText = ext.NATMappingEnable;
                    flatProfileNode.AppendChild(NAT_Mapping_Enable_1_);

                    // NAT_Keep_Alive_Enable_1_
                    var NAT_Keep_Alive_Enable_1_ =
                        configMACDocument.CreateElement(string.Format("NAT_Keep_Alive_Enable_{0}_", y));
                    NAT_Keep_Alive_Enable_1_.Attributes.Append(naAttribute);
                    NAT_Keep_Alive_Enable_1_.InnerText = ext.NATKeepAliveEnable;
                    flatProfileNode.AppendChild(NAT_Keep_Alive_Enable_1_);

                    // NAT_Keep_Alive_Msg_1_
                    var NAT_Keep_Alive_Msg_1_ =
                        configMACDocument.CreateElement(string.Format("NAT_Keep_Alive_Msg_{0}_", y));
                    NAT_Keep_Alive_Msg_1_.Attributes.Append(naAttribute);
                    NAT_Keep_Alive_Msg_1_.InnerText = ext.NATKeepAliveMsg;
                    flatProfileNode.AppendChild(NAT_Keep_Alive_Msg_1_);

                    // NAT_Keep_Alive_Dest_1_
                    var NAT_Keep_Alive_Dest_1_ =
                        configMACDocument.CreateElement(string.Format("NAT_Keep_Alive_Dest_{0}_", y));
                    NAT_Keep_Alive_Dest_1_.Attributes.Append(naAttribute);
                    NAT_Keep_Alive_Dest_1_.InnerText = ext.NATKeepAliveDest;
                    flatProfileNode.AppendChild(NAT_Keep_Alive_Dest_1_);

                    // Network

                    // SIP_TOS_DiffServ_Value_1_
                    var SIP_TOS_DiffServ_Value_1_ =
                        configMACDocument.CreateElement(string.Format("SIP_TOS_DiffServ_Value_{0}_", y));
                    SIP_TOS_DiffServ_Value_1_.Attributes.Append(naAttribute);
                    SIP_TOS_DiffServ_Value_1_.InnerText = ext.SIPTOSDiffServValue;
                    flatProfileNode.AppendChild(SIP_TOS_DiffServ_Value_1_);

                    // SIP_CoS_Value_1_
                    var SIP_CoS_Value_1_ = configMACDocument.CreateElement(string.Format("SIP_CoS_Value_{0}_", y));
                    SIP_CoS_Value_1_.Attributes.Append(naAttribute);
                    SIP_CoS_Value_1_.InnerText = ext.SIPCoSValue;
                    flatProfileNode.AppendChild(SIP_CoS_Value_1_);

                    // RTP_TOS_DiffServ_Value_1_
                    var RTP_TOS_DiffServ_Value_1_ =
                        configMACDocument.CreateElement(string.Format("RTP_TOS_DiffServ_Value_{0}_", y));
                    RTP_TOS_DiffServ_Value_1_.Attributes.Append(naAttribute);
                    RTP_TOS_DiffServ_Value_1_.InnerText = ext.RTPTOSDiffServValue;
                    flatProfileNode.AppendChild(RTP_TOS_DiffServ_Value_1_);

                    // RTP_CoS_Value_1_
                    var RTP_CoS_Value_1_ = configMACDocument.CreateElement(string.Format("RTP_CoS_Value_{0}_", y));
                    RTP_CoS_Value_1_.Attributes.Append(naAttribute);
                    RTP_CoS_Value_1_.InnerText = ext.RTPCoSValue;
                    flatProfileNode.AppendChild(RTP_CoS_Value_1_);

                    // Network_Jitter_Level_1_
                    var Network_Jitter_Level_1_ =
                        configMACDocument.CreateElement(string.Format("Network_Jitter_Level_{0}_", y));
                    Network_Jitter_Level_1_.Attributes.Append(naAttribute);
                    Network_Jitter_Level_1_.InnerText = ext.NetworkJitterLevel;
                    flatProfileNode.AppendChild(Network_Jitter_Level_1_);

                    // Jitter_Buffer_Adjustment_1_
                    var Jitter_Buffer_Adjustment_1_ =
                        configMACDocument.CreateElement(string.Format("Jitter_Buffer_Adjustment_{0}_", y));
                    Jitter_Buffer_Adjustment_1_.Attributes.Append(naAttribute);
                    Jitter_Buffer_Adjustment_1_.InnerText = ext.JitterBufferAdjustment;
                    flatProfileNode.AppendChild(Jitter_Buffer_Adjustment_1_);

                    // SIP Settings

                    // SIP_Transport_1_
                    var SIP_Transport_1_ = configMACDocument.CreateElement(string.Format("SIP_Transport_{0}_", y));
                    SIP_Transport_1_.Attributes.Append(naAttribute);
                    SIP_Transport_1_.InnerText = ext.SIPTransport;
                    flatProfileNode.AppendChild(SIP_Transport_1_);

                    // SIP_Port_1_
                    var SIP_Port_1_ = configMACDocument.CreateElement(string.Format("SIP_Port_{0}_", y));
                    SIP_Port_1_.Attributes.Append(naAttribute);
                    SIP_Port_1_.InnerText = ext.SIPPort;
                    flatProfileNode.AppendChild(SIP_Port_1_);

                    // SIP_100REL_Enable_1_
                    var SIP_100REL_Enable_1_ =
                        configMACDocument.CreateElement(string.Format("SIP_100REL_Enable_{0}_", y));
                    SIP_100REL_Enable_1_.Attributes.Append(naAttribute);
                    SIP_100REL_Enable_1_.InnerText = ext.SIP100RELEnable;
                    flatProfileNode.AppendChild(SIP_100REL_Enable_1_);

                    // EXT_SIP_Port_1_
                    var EXT_SIP_Port_1_ = configMACDocument.CreateElement(string.Format("EXT_SIP_Port_{0}_", y));
                    EXT_SIP_Port_1_.Attributes.Append(naAttribute);
                    EXT_SIP_Port_1_.InnerText = ext.EXTSIPPort;
                    flatProfileNode.AppendChild(EXT_SIP_Port_1_);

                    // Auth_Resync-Reboot_1_
                    var Auth_Resync_Reboot_1_ =
                        configMACDocument.CreateElement(string.Format("Auth_Resync-Reboot_{0}_", y));
                    Auth_Resync_Reboot_1_.Attributes.Append(naAttribute);
                    Auth_Resync_Reboot_1_.InnerText = ext.AuthResyncReboot;
                    flatProfileNode.AppendChild(Auth_Resync_Reboot_1_);

                    // SIP_Proxy_Require_1_
                    var SIP_Proxy_Require_1_ =
                        configMACDocument.CreateElement(string.Format("SIP_Proxy-Require_{0}_", y));
                    SIP_Proxy_Require_1_.Attributes.Append(naAttribute);
                    SIP_Proxy_Require_1_.InnerText = ext.SIPProxyRequire;
                    flatProfileNode.AppendChild(SIP_Proxy_Require_1_);

                    // SIP_Remote_Party-ID_1_
                    var SIP_Remote_Party_ID_1_ =
                        configMACDocument.CreateElement(string.Format("SIP_Remote-Party-ID_{0}_", y));
                    SIP_Remote_Party_ID_1_.Attributes.Append(naAttribute);
                    SIP_Remote_Party_ID_1_.InnerText = ext.SIPRemotePartyID;
                    flatProfileNode.AppendChild(SIP_Remote_Party_ID_1_);

                    // Referor_Bye_Delay_1_
                    var Referor_Bye_Delay_1_ =
                        configMACDocument.CreateElement(string.Format("Referor_Bye_Delay_{0}_", y));
                    Referor_Bye_Delay_1_.Attributes.Append(naAttribute);
                    Referor_Bye_Delay_1_.InnerText = ext.ReferorByeDelay;
                    flatProfileNode.AppendChild(Referor_Bye_Delay_1_);

                    // Refer-To_Target_Contact_1_
                    var Refer_To_Target_Contact_1_ =
                        configMACDocument.CreateElement(string.Format("Refer-To_Target_Contact_{0}_", y));
                    Refer_To_Target_Contact_1_.Attributes.Append(naAttribute);
                    Refer_To_Target_Contact_1_.InnerText = ext.ReferToTargetContact;
                    flatProfileNode.AppendChild(Refer_To_Target_Contact_1_);

                    // Referee_Bye_Delay_1_
                    var Referee_Bye_Delay_1_ =
                        configMACDocument.CreateElement(string.Format("Referee_Bye_Delay_{0}_", y));
                    Referee_Bye_Delay_1_.Attributes.Append(naAttribute);
                    Referee_Bye_Delay_1_.InnerText = ext.RefereeByeDelay;
                    flatProfileNode.AppendChild(Referee_Bye_Delay_1_);

                    // SIP_Debug_Option_1_
                    var SIP_Debug_Option_1_ = configMACDocument.CreateElement(string.Format("SIP_Debug_Option_{0}_", y));
                    SIP_Debug_Option_1_.Attributes.Append(naAttribute);
                    SIP_Debug_Option_1_.InnerText = ext.SIPDebugOption;
                    flatProfileNode.AppendChild(SIP_Debug_Option_1_);

                    // Refer_Target_Bye_Delay_1_
                    var Refer_Target_Bye_Delay_1_ =
                        configMACDocument.CreateElement(string.Format("Refer_Target_Bye_Delay_{0}_", y));
                    Refer_Target_Bye_Delay_1_.Attributes.Append(naAttribute);
                    Refer_Target_Bye_Delay_1_.InnerText = ext.ReferTargetByeDelay;
                    flatProfileNode.AppendChild(Refer_Target_Bye_Delay_1_);

                    // Sticky_183_1_
                    var Sticky_183_1_ = configMACDocument.CreateElement(string.Format("Sticky_183_{0}_", y));
                    Sticky_183_1_.Attributes.Append(naAttribute);
                    Sticky_183_1_.InnerText = ext.Sticky183;
                    flatProfileNode.AppendChild(Sticky_183_1_);

                    // Auth_INVITE_1_
                    var Auth_INVITE_1_ = configMACDocument.CreateElement(string.Format("Auth_INVITE_{0}_", y));
                    Auth_INVITE_1_.Attributes.Append(naAttribute);
                    Auth_INVITE_1_.InnerText = ext.AuthINVITE;
                    flatProfileNode.AppendChild(Auth_INVITE_1_);

                    // Ntfy_Refer_On_1xx-To-Inv_1_
                    var Ntfy_Refer_On_1xx_To_Inv_1_ =
                        configMACDocument.CreateElement(string.Format("Ntfy_Refer_On_1xx-To-Inv_{0}_", y));
                    Ntfy_Refer_On_1xx_To_Inv_1_.Attributes.Append(naAttribute);
                    Ntfy_Refer_On_1xx_To_Inv_1_.InnerText = ext.NtfyReferOn1xxToInv;
                    flatProfileNode.AppendChild(Ntfy_Refer_On_1xx_To_Inv_1_);

                    // Use_Anonymous_With_RPID_1_
                    var Use_Anonymous_With_RPID_1_ =
                        configMACDocument.CreateElement(string.Format("Use_Anonymous_With_RPID_{0}_", y));
                    Use_Anonymous_With_RPID_1_.Attributes.Append(naAttribute);
                    Use_Anonymous_With_RPID_1_.InnerText = ext.UseAnonymousWithRPID;
                    flatProfileNode.AppendChild(Use_Anonymous_With_RPID_1_);

                    // Set_G729_annexb_1_
                    var Set_G729_annexb_1_ = configMACDocument.CreateElement(string.Format("Set_G729_annexb_{0}_", y));
                    Set_G729_annexb_1_.Attributes.Append(naAttribute);
                    Set_G729_annexb_1_.InnerText = ext.SetG729annexb;
                    flatProfileNode.AppendChild(Set_G729_annexb_1_);

                    // Call FeatureSettings

                    // Blind_Attn_Xfer_Enable_1_
                    var Blind_Attn_Xfer_Enable_1_ =
                        configMACDocument.CreateElement(string.Format("Blind_Attn-Xfer_Enable_{0}_", y));
                    Blind_Attn_Xfer_Enable_1_.Attributes.Append(naAttribute);
                    Blind_Attn_Xfer_Enable_1_.InnerText = ext.BlindAttnXferEnable;
                    flatProfileNode.AppendChild(Blind_Attn_Xfer_Enable_1_);

                    // MOH_Server_1_
                    var MOH_Server_1_ = configMACDocument.CreateElement(string.Format("MOH_Server_{0}_", y));
                    MOH_Server_1_.Attributes.Append(naAttribute);
                    MOH_Server_1_.InnerText = ext.MOHServer;
                    flatProfileNode.AppendChild(MOH_Server_1_);

                    // Message_Waiting_1_
                    var Message_Waiting_1_ = configMACDocument.CreateElement(string.Format("Message_Waiting_{0}_", y));
                    Message_Waiting_1_.Attributes.Append(naAttribute);
                    Message_Waiting_1_.InnerText = ext.MessageWaiting;
                    flatProfileNode.AppendChild(Message_Waiting_1_);

                    // Auth_Page_1_
                    var Auth_Page_1_ = configMACDocument.CreateElement(string.Format("Auth_Page_{0}_", y));
                    Auth_Page_1_.Attributes.Append(naAttribute);
                    Auth_Page_1_.InnerText = ext.AuthPage;
                    flatProfileNode.AppendChild(Auth_Page_1_);

                    // Default_Ring__1__
                    var Default_Ring__1__ = configMACDocument.CreateElement(string.Format("Default_Ring__{0}__", y));
                    Default_Ring__1__.Attributes.Append(naAttribute);
                    Default_Ring__1__.InnerText = ext.DefaultRing;
                    flatProfileNode.AppendChild(Default_Ring__1__);

                    // Use_Default_Ring__1__
                    var Use_Default_Ring__1__ =
                        configMACDocument.CreateElement(string.Format("Use_Default_Ring__{0}__", y));
                    Use_Default_Ring__1__.Attributes.Append(naAttribute);
                    Use_Default_Ring__1__.InnerText = ext.UseDefaultRing;
                    flatProfileNode.AppendChild(Use_Default_Ring__1__);

                    // Auth_Page_Realm_1_
                    var Auth_Page_Realm_1_ = configMACDocument.CreateElement(string.Format("Auth_Page_Realm_{0}_", y));
                    Auth_Page_Realm_1_.Attributes.Append(naAttribute);
                    Auth_Page_Realm_1_.InnerText = ext.AuthPageRealm;
                    flatProfileNode.AppendChild(Auth_Page_Realm_1_);

                    // Conference_Bridge_URL_1_
                    var Conference_Bridge_URL_1_ =
                        configMACDocument.CreateElement(string.Format("Conference_Bridge_URL_{0}_", y));
                    Conference_Bridge_URL_1_.Attributes.Append(naAttribute);
                    Conference_Bridge_URL_1_.InnerText = ext.ConferenceBridgeURL;
                    flatProfileNode.AppendChild(Conference_Bridge_URL_1_);

                    // Auth_Page_Password_1_
                    var Auth_Page_Password_1_ =
                        configMACDocument.CreateElement(string.Format("Auth_Page_Password_{0}_", y));
                    Auth_Page_Password_1_.Attributes.Append(naAttribute);
                    Auth_Page_Password_1_.InnerText = ext.AuthPagePassword;
                    flatProfileNode.AppendChild(Auth_Page_Password_1_);

                    // Mailbox_ID_1_
                    var Mailbox_ID_1_ = configMACDocument.CreateElement(string.Format("Mailbox_ID_{0}_", y));
                    Mailbox_ID_1_.Attributes.Append(naAttribute);
                    Mailbox_ID_1_.InnerText = ext.MailboxID;
                    flatProfileNode.AppendChild(Mailbox_ID_1_);

                    // Voice_Mail_Server_1_
                    var Voice_Mail_Server_1_ =
                        configMACDocument.CreateElement(string.Format("Voice_Mail_Server_{0}_", y));
                    Voice_Mail_Server_1_.Attributes.Append(naAttribute);
                    Voice_Mail_Server_1_.InnerText = ext.VoiceMailServer;
                    flatProfileNode.AppendChild(Voice_Mail_Server_1_);

                    // Voice_Mail_Subscribe_Interval_1_
                    var Voice_Mail_Subscribe_Interval_1_ =
                        configMACDocument.CreateElement(string.Format("Voice_Mail_Subscribe_Interval_{0}_", y));
                    Voice_Mail_Subscribe_Interval_1_.Attributes.Append(naAttribute);
                    Voice_Mail_Subscribe_Interval_1_.InnerText = ext.VoiceMailSubscribeInterval;
                    flatProfileNode.AppendChild(Voice_Mail_Subscribe_Interval_1_);

                    // State_Agent_1_
                    var State_Agent_1_ = configMACDocument.CreateElement(string.Format("State_Agent_{0}_", y));
                    State_Agent_1_.Attributes.Append(naAttribute);
                    State_Agent_1_.InnerText = ext.StateAgent;
                    flatProfileNode.AppendChild(State_Agent_1_);

                    // CFWD_Notify_Serv_1_
                    var CFWD_Notify_Serv_1_ = configMACDocument.CreateElement(string.Format("CFWD_Notify_Serv_{0}_", y));
                    CFWD_Notify_Serv_1_.Attributes.Append(naAttribute);
                    CFWD_Notify_Serv_1_.InnerText = ext.CFWDNotifyServ;
                    flatProfileNode.AppendChild(CFWD_Notify_Serv_1_);

                    // CFWD_Notifier_1_
                    var CFWD_Notifier_1_ = configMACDocument.CreateElement(string.Format("CFWD_Notifier_{0}1_", y));
                    CFWD_Notifier_1_.Attributes.Append(naAttribute);
                    CFWD_Notifier_1_.InnerText = ext.CFWDNotifier;
                    flatProfileNode.AppendChild(CFWD_Notifier_1_);

                    // Proxy and Registration

                    // Proxy_1_
                    var Proxy_1_ = configMACDocument.CreateElement(string.Format("Proxy_{0}_", y));
                    Proxy_1_.Attributes.Append(naAttribute);
                    Proxy_1_.InnerText = ext.Proxy;
                    flatProfileNode.AppendChild(Proxy_1_);

                    // Outbound_Proxy_1_
                    var Outbound_Proxy_1_ = configMACDocument.CreateElement(string.Format("Outbound_Proxy_{0}_", y));
                    Outbound_Proxy_1_.Attributes.Append(naAttribute);
                    Outbound_Proxy_1_.InnerText = ext.OutboundProxy;
                    flatProfileNode.AppendChild(Outbound_Proxy_1_);

                    // Use_Outbound_Proxy_1_
                    var Use_Outbound_Proxy_1_ =
                        configMACDocument.CreateElement(string.Format("Use_Outbound_Proxy_{0}_", y));
                    Use_Outbound_Proxy_1_.Attributes.Append(naAttribute);
                    Use_Outbound_Proxy_1_.InnerText = ext.UseOutboundProxy;
                    flatProfileNode.AppendChild(Use_Outbound_Proxy_1_);

                    // Use_OB_Proxy_In_Dialog_1_
                    var Use_OB_Proxy_In_Dialog_1_ =
                        configMACDocument.CreateElement(string.Format("Use_OB_Proxy_In_Dialog_{0}_", y));
                    Use_OB_Proxy_In_Dialog_1_.Attributes.Append(naAttribute);
                    Use_OB_Proxy_In_Dialog_1_.InnerText = ext.UseOBProxyInDialog;
                    flatProfileNode.AppendChild(Use_OB_Proxy_In_Dialog_1_);

                    // Register_1_
                    var Register_1_ = configMACDocument.CreateElement(string.Format("Register_{0}_", y));
                    Register_1_.Attributes.Append(naAttribute);
                    Register_1_.InnerText = ext.Register;
                    flatProfileNode.AppendChild(Register_1_);

                    // Make_Call_Without_Reg_1_
                    var Make_Call_Without_Reg_1_ =
                        configMACDocument.CreateElement(string.Format("Make_Call_Without_Reg_{0}_", y));
                    Make_Call_Without_Reg_1_.Attributes.Append(naAttribute);
                    Make_Call_Without_Reg_1_.InnerText = ext.MakeCallWithoutReg;
                    flatProfileNode.AppendChild(Make_Call_Without_Reg_1_);

                    // Register_Expires_1_
                    var Register_Expires_1_ = configMACDocument.CreateElement(string.Format("Register_Expires_{0}_", y));
                    Register_Expires_1_.Attributes.Append(naAttribute);
                    Register_Expires_1_.InnerText = ext.RegisterExpires;
                    flatProfileNode.AppendChild(Register_Expires_1_);

                    // Ans_Call_Without_Reg_1_
                    var Ans_Call_Without_Reg_1_ =
                        configMACDocument.CreateElement(string.Format("Ans_Call_Without_Reg_{0}_", y));
                    Ans_Call_Without_Reg_1_.Attributes.Append(naAttribute);
                    Ans_Call_Without_Reg_1_.InnerText = ext.AnsCallWithoutReg;
                    flatProfileNode.AppendChild(Ans_Call_Without_Reg_1_);

                    // Use_DNS_SRV_1_
                    var Use_DNS_SRV_1_ = configMACDocument.CreateElement(string.Format("Use_DNS_SRV_{0}_", y));
                    Use_DNS_SRV_1_.Attributes.Append(naAttribute);
                    Use_DNS_SRV_1_.InnerText = ext.UseDNSSRV;
                    flatProfileNode.AppendChild(Use_DNS_SRV_1_);

                    // DNS_SRV_Auto_Prefix_1_
                    var DNS_SRV_Auto_Prefix_1_ =
                        configMACDocument.CreateElement(string.Format("DNS_SRV_Auto_Prefix_{0}_", y));
                    DNS_SRV_Auto_Prefix_1_.Attributes.Append(naAttribute);
                    DNS_SRV_Auto_Prefix_1_.InnerText = ext.DNSSRVAutoPrefix;
                    flatProfileNode.AppendChild(DNS_SRV_Auto_Prefix_1_);

                    // Proxy_Fallback_Intvl_1_
                    var Proxy_Fallback_Intvl_1_ =
                        configMACDocument.CreateElement(string.Format("Proxy_Fallback_Intvl_{0}_", y));
                    Proxy_Fallback_Intvl_1_.Attributes.Append(naAttribute);
                    Proxy_Fallback_Intvl_1_.InnerText = ext.ProxyFallbackIntvl;
                    flatProfileNode.AppendChild(Proxy_Fallback_Intvl_1_);

                    // Proxy_Redundancy_Method_1_
                    var Proxy_Redundancy_Method_1_ =
                        configMACDocument.CreateElement(string.Format("Proxy_Redundancy_Method_{0}_", y));
                    Proxy_Redundancy_Method_1_.Attributes.Append(naAttribute);
                    Proxy_Redundancy_Method_1_.InnerText = ext.ProxyRedundancyMethod;
                    flatProfileNode.AppendChild(Proxy_Redundancy_Method_1_);

                    // SubscriberInfo

                    // Display_Name_1_
                    var Display_Name_1_ = configMACDocument.CreateElement(string.Format("Display_Name_{0}_", y));
                    Display_Name_1_.Attributes.Append(naAttribute);
                    Display_Name_1_.InnerText = ext.DisplayName;
                    flatProfileNode.AppendChild(Display_Name_1_);

                    // User_ID_1_
                    var User_ID_1_ = configMACDocument.CreateElement(string.Format("User_ID_{0}_", y));
                    User_ID_1_.Attributes.Append(naAttribute);
                    User_ID_1_.InnerText = ext.UserID;
                    flatProfileNode.AppendChild(User_ID_1_);

                    // Password_1_
                    var Password_1_ = configMACDocument.CreateElement(string.Format("Password_{0}_", y));
                    Password_1_.Attributes.Append(naAttribute);
                    Password_1_.InnerText = ext.Password;
                    flatProfileNode.AppendChild(Password_1_);

                    // Use_Auth_ID_1_
                    var Use_Auth_ID_1_ = configMACDocument.CreateElement(string.Format("Use_Auth_ID_{0}_", y));
                    Use_Auth_ID_1_.Attributes.Append(naAttribute);
                    Use_Auth_ID_1_.InnerText = ext.UseAuthID;
                    flatProfileNode.AppendChild(Use_Auth_ID_1_);

                    // Auth_ID_1_
                    var Auth_ID_1_ = configMACDocument.CreateElement(string.Format("Auth_ID_{0}_", y));
                    Auth_ID_1_.Attributes.Append(naAttribute);
                    Auth_ID_1_.InnerText = ext.AuthID;
                    flatProfileNode.AppendChild(Auth_ID_1_);

                    // Mini_Certificate_1_
                    var Mini_Certificate_1_ = configMACDocument.CreateElement(string.Format("Mini_Certificate_{0}_", y));
                    Mini_Certificate_1_.Attributes.Append(naAttribute);
                    Mini_Certificate_1_.InnerText = ext.MiniCertificate;
                    flatProfileNode.AppendChild(Mini_Certificate_1_);

                    // SRTP_Private_Key_1_
                    var SRTP_Private_Key_1_ = configMACDocument.CreateElement(string.Format("SRTP_Private_Key_{0}_", y));
                    SRTP_Private_Key_1_.Attributes.Append(naAttribute);
                    SRTP_Private_Key_1_.InnerText = ext.SRTPPrivateKey;
                    flatProfileNode.AppendChild(SRTP_Private_Key_1_);

                    // Audio Config 

                    // Preferred_Codec_1_
                    var Preferred_Codec_1_ = configMACDocument.CreateElement(string.Format("Preferred_Codec_{0}_", y));
                    Preferred_Codec_1_.Attributes.Append(naAttribute);
                    Preferred_Codec_1_.InnerText = ext.PreferredCodec;
                    flatProfileNode.AppendChild(Preferred_Codec_1_);

                    // Use_Pref_Codec_Only_1_
                    var Use_Pref_Codec_Only_1_ =
                        configMACDocument.CreateElement(string.Format("Use_Pref_Codec_Only_{0}_", y));
                    Use_Pref_Codec_Only_1_.Attributes.Append(naAttribute);
                    Use_Pref_Codec_Only_1_.InnerText = ext.UsePrefCodecOnly;
                    flatProfileNode.AppendChild(Use_Pref_Codec_Only_1_);

                    // Second_Preferred_Codec_1_
                    var Second_Preferred_Codec_1_ =
                        configMACDocument.CreateElement(string.Format("Second_Preferred_Codec_{0}_", y));
                    Second_Preferred_Codec_1_.Attributes.Append(naAttribute);
                    Second_Preferred_Codec_1_.InnerText = ext.SecondPreferredCodec;
                    flatProfileNode.AppendChild(Second_Preferred_Codec_1_);

                    // Third_Preferred_Codec_1_
                    var Third_Preferred_Codec_1_ =
                        configMACDocument.CreateElement(string.Format("Third_Preferred_Codec_{0}_", y));
                    Third_Preferred_Codec_1_.Attributes.Append(naAttribute);
                    Third_Preferred_Codec_1_.InnerText = ext.ThirdPreferredCodec;
                    flatProfileNode.AppendChild(Third_Preferred_Codec_1_);

                    // G729a_Enable_1_
                    var G729a_Enable_1_ = configMACDocument.CreateElement(string.Format("G729a_Enable_{0}_", y));
                    G729a_Enable_1_.Attributes.Append(naAttribute);
                    G729a_Enable_1_.InnerText = ext.G729aEnable;
                    flatProfileNode.AppendChild(G729a_Enable_1_);

                    // G722_Enable_1_
                    var G722_Enable_1_ = configMACDocument.CreateElement(string.Format("G722_Enable_{0}_", y));
                    G722_Enable_1_.Attributes.Append(naAttribute);
                    G722_Enable_1_.InnerText = ext.G722Enable;
                    flatProfileNode.AppendChild(G722_Enable_1_);

                    // L16_Enable_1_
                    var L16_Enable_1_ = configMACDocument.CreateElement(string.Format("L16_Enable_{0}_", y));
                    L16_Enable_1_.Attributes.Append(naAttribute);
                    L16_Enable_1_.InnerText = ext.L16Enable;
                    flatProfileNode.AppendChild(L16_Enable_1_);

                    // G726-32_Enable_1_
                    var G726_32_Enable_1_ = configMACDocument.CreateElement(string.Format("G726-32_Enable_{0}_", y));
                    G726_32_Enable_1_.Attributes.Append(naAttribute);
                    G726_32_Enable_1_.InnerText = ext.G72632Enable;
                    flatProfileNode.AppendChild(G726_32_Enable_1_);

                    // Release_Unused_Codec_1_
                    var Release_Unused_Codec_1_ =
                        configMACDocument.CreateElement(string.Format("Release_Unused_Codec_{0}_", y));
                    Release_Unused_Codec_1_.Attributes.Append(naAttribute);
                    Release_Unused_Codec_1_.InnerText = ext.ReleaseUnusedCodec;
                    flatProfileNode.AppendChild(Release_Unused_Codec_1_);

                    // DTMF_Process_AVT_1_
                    var DTMF_Process_AVT_1_ = configMACDocument.CreateElement(string.Format("DTMF_Process_AVT_{0}_", y));
                    DTMF_Process_AVT_1_.Attributes.Append(naAttribute);
                    DTMF_Process_AVT_1_.InnerText = ext.DTMFProcessAVT;
                    flatProfileNode.AppendChild(DTMF_Process_AVT_1_);

                    // Silence_Supp_Enable_1_
                    var Silence_Supp_Enable_1_ =
                        configMACDocument.CreateElement(string.Format("Silence_Supp_Enable_{0}_", y));
                    Silence_Supp_Enable_1_.Attributes.Append(naAttribute);
                    Silence_Supp_Enable_1_.InnerText = ext.SilenceSuppEnable;
                    flatProfileNode.AppendChild(Silence_Supp_Enable_1_);

                    // DTMF_Tx_Method_1_
                    var DTMF_Tx_Method_1_ = configMACDocument.CreateElement(string.Format("DTMF_Tx_Method_{0}_", y));
                    DTMF_Tx_Method_1_.Attributes.Append(naAttribute);
                    DTMF_Tx_Method_1_.InnerText = ext.DTMFTxMethod;
                    flatProfileNode.AppendChild(DTMF_Tx_Method_1_);

                    // DTMF_Tx_Volume_for_AVT_Packet_1_
                    var DTMF_Tx_Volume_for_AVT_Packet_1_ =
                        configMACDocument.CreateElement(string.Format("DTMF_Tx_Volume_for_AVT_Packet_{0}_", y));
                    DTMF_Tx_Volume_for_AVT_Packet_1_.Attributes.Append(naAttribute);
                    DTMF_Tx_Volume_for_AVT_Packet_1_.InnerText = ext.DTMFTxVolumeforAVTPacket;
                    flatProfileNode.AppendChild(DTMF_Tx_Volume_for_AVT_Packet_1_);

                    // DialPlan

                    // Dial_Plan_1_
                    var Dial_Plan_1_ = configMACDocument.CreateElement(string.Format("Dial_Plan_{0}_", y));
                    Dial_Plan_1_.Attributes.Append(naAttribute);
                    Dial_Plan_1_.InnerText = ext.DialPlan;
                    flatProfileNode.AppendChild(Dial_Plan_1_);

                    // Caller_ID_Map_1_
                    var Caller_ID_Map_1_ = configMACDocument.CreateElement(string.Format("Caller_ID_Map_{0}_", y));
                    Caller_ID_Map_1_.Attributes.Append(naAttribute);
                    Caller_ID_Map_1_.InnerText = ext.CallerIDMap;
                    flatProfileNode.AppendChild(Caller_ID_Map_1_);

                    // Enable_IP_Dialing_1_
                    var Enable_IP_Dialing_1_ =
                        configMACDocument.CreateElement(string.Format("Enable_IP_Dialing_{0}_", y));
                    Enable_IP_Dialing_1_.Attributes.Append(naAttribute);
                    Enable_IP_Dialing_1_.InnerText = ext.EnableIPDialing;
                    flatProfileNode.AppendChild(Enable_IP_Dialing_1_);

                    // Emergency_Number_1_
                    var Emergency_Number_1_ = configMACDocument.CreateElement(string.Format("Emergency_Number_{0}_", y));
                    Emergency_Number_1_.Attributes.Append(naAttribute);
                    Emergency_Number_1_.InnerText = ext.EmergencyNumber;
                    flatProfileNode.AppendChild(Emergency_Number_1_);

                    y++;
                }
            }

            #endregion

            #region Call Forward

            // Cfwd_Setting
            var Cfwd_Setting = configMACDocument.CreateElement("Cfwd_Setting");
            Cfwd_Setting.Attributes.Append(rwAttribute);
            Cfwd_Setting.InnerText = _Cfwd_Setting;
            flatProfileNode.AppendChild(Cfwd_Setting);

            // Cfwd_All_Dest
            var Cfwd_All_Dest = configMACDocument.CreateElement("Cfwd_All_Dest");
            Cfwd_All_Dest.Attributes.Append(rwAttribute);
            Cfwd_All_Dest.InnerText = _Cfwd_All_Dest;
            flatProfileNode.AppendChild(Cfwd_All_Dest);

            // Cfwd_Busy_Dest
            var Cfwd_Busy_Dest = configMACDocument.CreateElement("Cfwd_Busy_Dest");
            Cfwd_Busy_Dest.Attributes.Append(rwAttribute);
            Cfwd_Busy_Dest.InnerText = _Cfwd_Busy_Dest;
            flatProfileNode.AppendChild(Cfwd_Busy_Dest);

            // Cfwd_No_Ans_Dest
            var Cfwd_No_Ans_Dest = configMACDocument.CreateElement("Cfwd_No_Ans_Dest");
            Cfwd_No_Ans_Dest.Attributes.Append(rwAttribute);
            Cfwd_No_Ans_Dest.InnerText = _Cfwd_No_Ans_Dest;
            flatProfileNode.AppendChild(Cfwd_No_Ans_Dest);

            // Cfwd_No_Ans_Delay
            var Cfwd_No_Ans_Delay = configMACDocument.CreateElement("Cfwd_No_Ans_Delay");
            Cfwd_No_Ans_Delay.Attributes.Append(rwAttribute);
            Cfwd_No_Ans_Delay.InnerText = _Cfwd_No_Ans_Delay;
            flatProfileNode.AppendChild(Cfwd_No_Ans_Delay);

            #endregion

            #region Speed Dial

            // Speed_Dial_2
            var Speed_Dial_2 = configMACDocument.CreateElement("Speed_Dial_2");
            Speed_Dial_2.Attributes.Append(rwAttribute);
            Speed_Dial_2.InnerText = _Speed_Dial_2;
            flatProfileNode.AppendChild(Speed_Dial_2);

            // Speed_Dial_3
            var Speed_Dial_3 = configMACDocument.CreateElement("Speed_Dial_3");
            Speed_Dial_3.Attributes.Append(rwAttribute);
            Speed_Dial_3.InnerText = _Speed_Dial_3;
            flatProfileNode.AppendChild(Speed_Dial_3);

            // Speed_Dial_4
            var Speed_Dial_4 = configMACDocument.CreateElement("Speed_Dial_4");
            Speed_Dial_4.Attributes.Append(rwAttribute);
            Speed_Dial_4.InnerText = _Speed_Dial_4;
            flatProfileNode.AppendChild(Speed_Dial_4);

            // Speed_Dial_5
            var Speed_Dial_5 = configMACDocument.CreateElement("Speed_Dial_5");
            Speed_Dial_5.Attributes.Append(rwAttribute);
            Speed_Dial_5.InnerText = _Speed_Dial_5;
            flatProfileNode.AppendChild(Speed_Dial_5);

            // Speed_Dial_6
            var Speed_Dial_6 = configMACDocument.CreateElement("Speed_Dial_6");
            Speed_Dial_6.Attributes.Append(rwAttribute);
            Speed_Dial_6.InnerText = _Speed_Dial_6;
            flatProfileNode.AppendChild(Speed_Dial_6);

            // Speed_Dial_7
            var Speed_Dial_7 = configMACDocument.CreateElement("Speed_Dial_7");
            Speed_Dial_7.Attributes.Append(rwAttribute);
            Speed_Dial_7.InnerText = _Speed_Dial_7;
            flatProfileNode.AppendChild(Speed_Dial_7);

            // Speed_Dial_8
            var Speed_Dial_8 = configMACDocument.CreateElement("Speed_Dial_8");
            Speed_Dial_8.Attributes.Append(rwAttribute);
            Speed_Dial_8.InnerText = _Speed_Dial_8;
            flatProfileNode.AppendChild(Speed_Dial_8);

            // Speed_Dial_9
            var Speed_Dial_9 = configMACDocument.CreateElement("Speed_Dial_9");
            Speed_Dial_9.Attributes.Append(rwAttribute);
            Speed_Dial_9.InnerText = _Speed_Dial_9;
            flatProfileNode.AppendChild(Speed_Dial_9);

            #endregion

            #region Supplementary Services

            // CW_Setting
            var CW_Setting = configMACDocument.CreateElement("CW_Setting");
            CW_Setting.Attributes.Append(rwAttribute);
            CW_Setting.InnerText = _CW_Setting;
            flatProfileNode.AppendChild(CW_Setting);

            // Block_CID_Setting
            var Block_CID_Setting = configMACDocument.CreateElement("Block_CID_Setting");
            Block_CID_Setting.Attributes.Append(rwAttribute);
            Block_CID_Setting.InnerText = _Block_CID_Setting;
            flatProfileNode.AppendChild(Block_CID_Setting);

            // Block_ANC_Setting
            var Block_ANC_Setting = configMACDocument.CreateElement("Block_ANC_Setting");
            Block_ANC_Setting.Attributes.Append(rwAttribute);
            Block_ANC_Setting.InnerText = _Block_ANC_Setting;
            flatProfileNode.AppendChild(Block_ANC_Setting);

            // DND_Setting
            var DND_Setting = configMACDocument.CreateElement("DND_Setting");
            DND_Setting.Attributes.Append(rwAttribute);
            DND_Setting.InnerText = _DND_Setting;
            flatProfileNode.AppendChild(DND_Setting);

            // Dial_Assistance
            var Dial_Assistance = configMACDocument.CreateElement("Dial_Assistance");
            Dial_Assistance.Attributes.Append(naAttribute);
            Dial_Assistance.InnerText = _Dial_Assistance;
            flatProfileNode.AppendChild(Dial_Assistance);

            // Auto_Answer_Page
            var Auto_Answer_Page = configMACDocument.CreateElement("Auto_Answer_Page");
            Auto_Answer_Page.Attributes.Append(naAttribute);
            Auto_Answer_Page.InnerText = _Auto_Answer_Page;
            flatProfileNode.AppendChild(Auto_Answer_Page);

            // Speakerphone_DTMF_Masking
            var Speakerphone_DTMF_Masking = configMACDocument.CreateElement("Speakerphone_DTMF_Masking");
            Speakerphone_DTMF_Masking.Attributes.Append(naAttribute);
            Speakerphone_DTMF_Masking.InnerText = _Speakerphone_DTMF_Masking;
            flatProfileNode.AppendChild(Speakerphone_DTMF_Masking);

            // Time_Format
            var Time_Format = configMACDocument.CreateElement("Time_Format");
            Time_Format.Attributes.Append(naAttribute);
            Time_Format.InnerText = _Time_Format;
            flatProfileNode.AppendChild(Time_Format);

            // Date_Format
            var Date_Format = configMACDocument.CreateElement("Date_Format");
            Date_Format.Attributes.Append(naAttribute);
            Date_Format.InnerText = _Date_Format;
            flatProfileNode.AppendChild(Date_Format);

            // Miss_Call_Shortcut
            var Miss_Call_Shortcut = configMACDocument.CreateElement("Miss_Call_Shortcut");
            Miss_Call_Shortcut.Attributes.Append(naAttribute);
            Miss_Call_Shortcut.InnerText = _Miss_Call_Shortcut;
            flatProfileNode.AppendChild(Miss_Call_Shortcut);

            // Accept_Media_Loopback_Request
            var Accept_Media_Loopback_Request = configMACDocument.CreateElement("Accept_Media_Loopback_Request");
            Accept_Media_Loopback_Request.Attributes.Append(naAttribute);
            Accept_Media_Loopback_Request.InnerText = _Accept_Media_Loopback_Request;
            flatProfileNode.AppendChild(Accept_Media_Loopback_Request);

            // Media_Loopback_Mode
            var Media_Loopback_Mode = configMACDocument.CreateElement("Media_Loopback_Mode");
            Media_Loopback_Mode.Attributes.Append(naAttribute);
            Media_Loopback_Mode.InnerText = _Media_Loopback_Mode;
            flatProfileNode.AppendChild(Media_Loopback_Mode);

            // Media_Loopback_Type
            var Media_Loopback_Type = configMACDocument.CreateElement("Media_Loopback_Type");
            Media_Loopback_Type.Attributes.Append(naAttribute);
            Media_Loopback_Type.InnerText = _Media_Loopback_Type;
            flatProfileNode.AppendChild(Media_Loopback_Type);

            // Display_Text_Message_on_Recv
            var Display_Text_Message_on_Recv = configMACDocument.CreateElement("Display_Text_Message_on_Recv");
            Display_Text_Message_on_Recv.Attributes.Append(rwAttribute);
            Display_Text_Message_on_Recv.InnerText = _Display_Text_Message_on_Recv;
            flatProfileNode.AppendChild(Display_Text_Message_on_Recv);

            // Text_Message_From_3rd_Party
            var Text_Message_From_3rd_Party = configMACDocument.CreateElement("Text_Message_From_3rd_Party");
            Text_Message_From_3rd_Party.Attributes.Append(rwAttribute);
            Text_Message_From_3rd_Party.InnerText = _Text_Message_From_3rd_Party;
            flatProfileNode.AppendChild(Text_Message_From_3rd_Party);

            // Alert_Tone_Off
            var Alert_Tone_Off = configMACDocument.CreateElement("Alert_Tone_Off");
            Alert_Tone_Off.Attributes.Append(rwAttribute);
            Alert_Tone_Off.InnerText = _Alert_Tone_Off;
            flatProfileNode.AppendChild(Alert_Tone_Off);

            // Log_Missed_Calls_for_EXT_1
            var Log_Missed_Calls_for_EXT_1 = configMACDocument.CreateElement("Log_Missed_Calls_for_EXT_1");
            Log_Missed_Calls_for_EXT_1.Attributes.Append(naAttribute);
            Log_Missed_Calls_for_EXT_1.InnerText = _Log_Missed_Calls_for_EXT_1;
            flatProfileNode.AppendChild(Log_Missed_Calls_for_EXT_1);

            // Log_Missed_Calls_for_EXT_2
            var Log_Missed_Calls_for_EXT_2 = configMACDocument.CreateElement("Log_Missed_Calls_for_EXT_2");
            Log_Missed_Calls_for_EXT_2.Attributes.Append(naAttribute);
            Log_Missed_Calls_for_EXT_2.InnerText = _Log_Missed_Calls_for_EXT_2;
            flatProfileNode.AppendChild(Log_Missed_Calls_for_EXT_2);

            // Log_Missed_Calls_for_EXT_3
            var Log_Missed_Calls_for_EXT_3 = configMACDocument.CreateElement("Log_Missed_Calls_for_EXT_3");
            Log_Missed_Calls_for_EXT_3.Attributes.Append(naAttribute);
            Log_Missed_Calls_for_EXT_3.InnerText = _Log_Missed_Calls_for_EXT_3;
            flatProfileNode.AppendChild(Log_Missed_Calls_for_EXT_3);

            // Log_Missed_Calls_for_EXT_4
            var Log_Missed_Calls_for_EXT_4 = configMACDocument.CreateElement("Log_Missed_Calls_for_EXT_4");
            Log_Missed_Calls_for_EXT_4.Attributes.Append(naAttribute);
            Log_Missed_Calls_for_EXT_4.InnerText = _Log_Missed_Calls_for_EXT_4;
            flatProfileNode.AppendChild(Log_Missed_Calls_for_EXT_4);

            // Log_Missed_Calls_for_EXT_5
            var Log_Missed_Calls_for_EXT_5 = configMACDocument.CreateElement("Log_Missed_Calls_for_EXT_5");
            Log_Missed_Calls_for_EXT_5.Attributes.Append(naAttribute);
            Log_Missed_Calls_for_EXT_5.InnerText = _Log_Missed_Calls_for_EXT_5;
            flatProfileNode.AppendChild(Log_Missed_Calls_for_EXT_5);

            #endregion

            #region Camera Settings

            // Enable_Video_VLAN
            var Enable_Video_VLAN = configMACDocument.CreateElement("Enable_Video_VLAN");
            Enable_Video_VLAN.Attributes.Append(roAttribute);
            Enable_Video_VLAN.InnerText = _Enable_Video_VLAN;
            flatProfileNode.AppendChild(Enable_Video_VLAN);

            // Video_VLAN_ID
            var Video_VLAN_ID = configMACDocument.CreateElement("Video_VLAN_ID");
            Video_VLAN_ID.Attributes.Append(roAttribute);
            Video_VLAN_ID.InnerText = _Video_VLAN_ID;
            flatProfileNode.AppendChild(Video_VLAN_ID);

            // Camera 1
            if (cameraProfiles != null)
            {
                var z = 1;
                foreach (var cameraProfile in cameraProfiles)
                {
                    // Camera_Name_1_
                    var Camera_Name_1_ = configMACDocument.CreateElement(string.Format("Camera_Name_{0}_", z));
                    Camera_Name_1_.Attributes.Append(roAttribute);
                    Camera_Name_1_.InnerText = cameraProfile.CameraName;
                    flatProfileNode.AppendChild(Camera_Name_1_);

                    // Access_URL_1_
                    var Access_URL_1_ = configMACDocument.CreateElement(string.Format("Access_URL_{0}_", z));
                    Access_URL_1_.Attributes.Append(roAttribute);
                    Access_URL_1_.InnerText = cameraProfile.AccessURL;
                    flatProfileNode.AppendChild(Access_URL_1_);

                    // Access_User_Name_1_
                    var Access_User_Name_1_ = configMACDocument.CreateElement(string.Format("Access_User_Name_{0}_", z));
                    Access_User_Name_1_.Attributes.Append(roAttribute);
                    Access_User_Name_1_.InnerText = cameraProfile.AccessUserName;
                    flatProfileNode.AppendChild(Access_User_Name_1_);

                    // Access_Password_1_
                    var Access_Password_1_ = configMACDocument.CreateElement(string.Format("Access_Password_{0}_", z));
                    Access_Password_1_.Attributes.Append(naAttribute);
                    Access_Password_1_.InnerText = cameraProfile.AccessPassword;
                    flatProfileNode.AppendChild(Access_Password_1_);

                    // Associated_Caller_ID_1_
                    var Associated_Caller_ID_1_ =
                        configMACDocument.CreateElement(string.Format("Associated_Caller_ID_{0}_", z));
                    Associated_Caller_ID_1_.Attributes.Append(roAttribute);
                    Associated_Caller_ID_1_.InnerText = cameraProfile.AssociatedCallerID;
                    flatProfileNode.AppendChild(Associated_Caller_ID_1_);

                    // Door_Control_URL_1_
                    var Door_Control_URL_1_ = configMACDocument.CreateElement(string.Format("Door_Control_URL_{0}_", z));
                    Door_Control_URL_1_.Attributes.Append(naAttribute);
                    Door_Control_URL_1_.InnerText = cameraProfile.DoorControlURL;
                    flatProfileNode.AppendChild(Door_Control_URL_1_);

                    z++;
                }
            }

            #endregion

            #region Web Information Service Settings

            // RSS_Feed_URL_1
            var RSS_Feed_URL_1 = configMACDocument.CreateElement("RSS_Feed_URL_1");
            RSS_Feed_URL_1.Attributes.Append(rwAttribute);
            RSS_Feed_URL_1.InnerText = _RSS_Feed_URL_1;
            flatProfileNode.AppendChild(RSS_Feed_URL_1);

            // RSS_Feed_URL_2
            var RSS_Feed_URL_2 = configMACDocument.CreateElement("RSS_Feed_URL_2");
            RSS_Feed_URL_2.Attributes.Append(rwAttribute);
            RSS_Feed_URL_2.InnerText = _RSS_Feed_URL_2;
            flatProfileNode.AppendChild(RSS_Feed_URL_2);

            // RSS_Feed_URL_3
            var RSS_Feed_URL_3 = configMACDocument.CreateElement("RSS_Feed_URL_3");
            RSS_Feed_URL_3.Attributes.Append(rwAttribute);
            RSS_Feed_URL_3.InnerText = _RSS_Feed_URL_3;
            flatProfileNode.AppendChild(RSS_Feed_URL_3);

            // RSS_Feed_URL_4
            var RSS_Feed_URL_4 = configMACDocument.CreateElement("RSS_Feed_URL_4");
            RSS_Feed_URL_4.Attributes.Append(rwAttribute);
            RSS_Feed_URL_4.InnerText = _RSS_Feed_URL_4;
            flatProfileNode.AppendChild(RSS_Feed_URL_4);

            // RSS_Feed_URL_5
            var RSS_Feed_URL_5 = configMACDocument.CreateElement("RSS_Feed_URL_5");
            RSS_Feed_URL_5.Attributes.Append(rwAttribute);
            RSS_Feed_URL_5.InnerText = _RSS_Feed_URL_5;
            flatProfileNode.AppendChild(RSS_Feed_URL_5);

            // Weather_Temperature_Unit
            var Weather_Temperature_Unit = configMACDocument.CreateElement("Weather_Temperature_Unit");
            Weather_Temperature_Unit.Attributes.Append(rwAttribute);
            Weather_Temperature_Unit.InnerText = _Weather_Temperature_Unit;
            flatProfileNode.AppendChild(Weather_Temperature_Unit);

            #endregion

            #region Audio Volume

            // Ringer_Volume
            var Ringer_Volume = configMACDocument.CreateElement("Ringer_Volume");
            Ringer_Volume.Attributes.Append(rwAttribute);
            Ringer_Volume.InnerText = _Ringer_Volume;
            flatProfileNode.AppendChild(Ringer_Volume);

            // Speaker_Volume
            var Speaker_Volume = configMACDocument.CreateElement("Speaker_Volume");
            Speaker_Volume.Attributes.Append(rwAttribute);
            Speaker_Volume.InnerText = _Speaker_Volume;
            flatProfileNode.AppendChild(Speaker_Volume);

            // Handset_Volume
            var Handset_Volume = configMACDocument.CreateElement("Handset_Volume");
            Handset_Volume.Attributes.Append(rwAttribute);
            Handset_Volume.InnerText = _Handset_Volume;
            flatProfileNode.AppendChild(Handset_Volume);

            // Headset_Volume
            var Headset_Volume = configMACDocument.CreateElement("Headset_Volume");
            Headset_Volume.Attributes.Append(rwAttribute);
            Headset_Volume.InnerText = _Headset_Volume;
            flatProfileNode.AppendChild(Headset_Volume);

            // Bluetooth_Volume
            var Bluetooth_Volume = configMACDocument.CreateElement("Bluetooth_Volume");
            Bluetooth_Volume.Attributes.Append(rwAttribute);
            Bluetooth_Volume.InnerText = _Bluetooth_Volume;
            flatProfileNode.AppendChild(Bluetooth_Volume);

            #endregion

            #region Screen

            // Screen_Saver_Enable
            var Screen_Saver_Enable = configMACDocument.CreateElement("Screen_Saver_Enable");
            Screen_Saver_Enable.Attributes.Append(rwAttribute);
            Screen_Saver_Enable.InnerText = _Screen_Saver_Enable;
            flatProfileNode.AppendChild(Screen_Saver_Enable);

            // Screen_Saver_Type
            var Screen_Saver_Type = configMACDocument.CreateElement("Screen_Saver_Type");
            Screen_Saver_Type.Attributes.Append(rwAttribute);
            Screen_Saver_Type.InnerText = _Screen_Saver_Type;
            flatProfileNode.AppendChild(Screen_Saver_Type);

            // Screen_Saver_Trigger_Time
            var Screen_Saver_Trigger_Time = configMACDocument.CreateElement("Screen_Saver_Trigger_Time");
            Screen_Saver_Trigger_Time.Attributes.Append(rwAttribute);
            Screen_Saver_Trigger_Time.InnerText = _Screen_Saver_Trigger_Time;
            flatProfileNode.AppendChild(Screen_Saver_Trigger_Time);

            // Screen_Saver_Refresh_Time
            var Screen_Saver_Refresh_Time = configMACDocument.CreateElement("Screen_Saver_Refresh_Time");
            Screen_Saver_Refresh_Time.Attributes.Append(rwAttribute);
            Screen_Saver_Refresh_Time.InnerText = _Screen_Saver_Refresh_Time;
            flatProfileNode.AppendChild(Screen_Saver_Refresh_Time);

            // Back_Light_Enable
            var Back_Light_Enable = configMACDocument.CreateElement("Back_Light_Enable");
            Back_Light_Enable.Attributes.Append(naAttribute);
            Back_Light_Enable.InnerText = _Back_Light_Enable;
            flatProfileNode.AppendChild(Back_Light_Enable);

            // Back_Light_Timer__sec_
            var Back_Light_Timer__sec_ = configMACDocument.CreateElement("Back_Light_Timer__sec_");
            Back_Light_Timer__sec_.Attributes.Append(naAttribute);
            Back_Light_Timer__sec_.InnerText = _Back_Light_Timer__sec_;
            flatProfileNode.AppendChild(Back_Light_Timer__sec_);

            // LCD_Contrast
            var LCD_Contrast = configMACDocument.CreateElement("LCD_Contrast");
            LCD_Contrast.Attributes.Append(naAttribute);
            LCD_Contrast.InnerText = _LCD_Contrast;
            flatProfileNode.AppendChild(LCD_Contrast);

            // Logo_Type
            var Logo_Type = configMACDocument.CreateElement("Logo_Type");
            Logo_Type.Attributes.Append(naAttribute);
            Logo_Type.InnerText = _Logo_Type;
            flatProfileNode.AppendChild(Logo_Type);

            // Text_Logo
            var Text_Logo = configMACDocument.CreateElement("Text_Logo");
            Text_Logo.Attributes.Append(naAttribute);
            Text_Logo.InnerText = _Text_Logo;
            flatProfileNode.AppendChild(Text_Logo);

            // Background_Picture_Type
            var Background_Picture_Type = configMACDocument.CreateElement("Background_Picture_Type");
            Background_Picture_Type.Attributes.Append(naAttribute);
            Background_Picture_Type.InnerText = _Background_Picture_Type;
            flatProfileNode.AppendChild(Background_Picture_Type);

            // BMP_Picture_Download_URL
            var BMP_Picture_Download_URL = configMACDocument.CreateElement("BMP_Picture_Download_URL");
            BMP_Picture_Download_URL.Attributes.Append(naAttribute);
            BMP_Picture_Download_URL.InnerText = _BMP_Picture_Download_URL;
            flatProfileNode.AppendChild(BMP_Picture_Download_URL);

            #endregion

            #region General

            // Station_Name
            var Station_Name = configMACDocument.CreateElement("Station_Name");
            Station_Name.Attributes.Append(naAttribute);
            Station_Name.InnerText = _Station_Name;
            flatProfileNode.AppendChild(Station_Name);

            // Station_Display_Name
            var Station_Display_Name = configMACDocument.CreateElement("Station_Display_Name");
            Station_Display_Name.Attributes.Append(naAttribute);
            Station_Display_Name.InnerText = _Station_Display_Name;
            flatProfileNode.AppendChild(Station_Display_Name);

            // Voice_Mail_Number
            var Voice_Mail_Number = configMACDocument.CreateElement("Voice_Mail_Number");
            Voice_Mail_Number.Attributes.Append(naAttribute);
            Voice_Mail_Number.InnerText = _Voice_Mail_Number;
            flatProfileNode.AppendChild(Voice_Mail_Number);

            #endregion

            #region Line Keys

            if (lineKeys != null)
            {
                var k = 1;
                foreach (var lineKey in lineKeys)
                {
                    // Extension_1_
                    var Extension_1_ = configMACDocument.CreateElement(string.Format("Extension_{0}_", k));
                    Extension_1_.Attributes.Append(naAttribute);
                    Extension_1_.InnerText = lineKey.Extension;
                    flatProfileNode.AppendChild(Extension_1_);

                    // Short_Name_1_
                    var Short_Name_1_ = configMACDocument.CreateElement(string.Format("Short_Name_{0}_", k));
                    Short_Name_1_.Attributes.Append(naAttribute);
                    Short_Name_1_.InnerText = lineKey.ShortName;
                    flatProfileNode.AppendChild(Short_Name_1_);

                    // Share_Call_Appearance_1_
                    var Share_Call_Appearance_1_ =
                        configMACDocument.CreateElement(string.Format("Share_Call_Appearance_{0}_", k));
                    Share_Call_Appearance_1_.Attributes.Append(naAttribute);
                    Share_Call_Appearance_1_.InnerText = lineKey.ShareCallAppearance;
                    flatProfileNode.AppendChild(Share_Call_Appearance_1_);

                    // Extended_Function_1_
                    var Extended_Function_1_ =
                        configMACDocument.CreateElement(string.Format("Extended_Function_{0}_", k));
                    Extended_Function_1_.Attributes.Append(naAttribute);
                    Extended_Function_1_.InnerText = lineKey.Extended_Function;
                    flatProfileNode.AppendChild(Extended_Function_1_);
                }
            }

            #endregion

            #region Miscellaneous Line Key Settings

            // SCA_Line_ID_Mapping
            var SCA_Line_ID_Mapping = configMACDocument.CreateElement("SCA_Line_ID_Mapping");
            SCA_Line_ID_Mapping.Attributes.Append(naAttribute);
            SCA_Line_ID_Mapping.InnerText = _SCA_Line_ID_Mapping;
            flatProfileNode.AppendChild(SCA_Line_ID_Mapping);

            // SCA_Barge-In_Enable
            var SCA_Barge_In_Enable = configMACDocument.CreateElement("SCA_Barge-In_Enable");
            SCA_Barge_In_Enable.Attributes.Append(naAttribute);
            SCA_Barge_In_Enable.InnerText = _SCA_Barge_In_Enable;
            flatProfileNode.AppendChild(SCA_Barge_In_Enable);

            // SCA_Sticky_Auto_Line_Seize
            var SCA_Sticky_Auto_Line_Seize = configMACDocument.CreateElement("SCA_Sticky_Auto_Line_Seize");
            SCA_Sticky_Auto_Line_Seize.Attributes.Append(naAttribute);
            SCA_Sticky_Auto_Line_Seize.InnerText = _SCA_Sticky_Auto_Line_Seize;
            flatProfileNode.AppendChild(SCA_Sticky_Auto_Line_Seize);

            #endregion

            #region Line Key LED Pattern 

            // Idle_LED
            var Idle_LED = configMACDocument.CreateElement("Idle_LED");
            Idle_LED.Attributes.Append(naAttribute);
            Idle_LED.InnerText = _Idle_LED;
            flatProfileNode.AppendChild(Idle_LED);

            // Remote_Undefined_LED
            var Remote_Undefined_LED = configMACDocument.CreateElement("Remote_Undefined_LED");
            Remote_Undefined_LED.Attributes.Append(naAttribute);
            Remote_Undefined_LED.InnerText = _Remote_Undefined_LED;
            flatProfileNode.AppendChild(Remote_Undefined_LED);

            // Local_Seized_LED
            var Local_Seized_LED = configMACDocument.CreateElement("Local_Seized_LED");
            Local_Seized_LED.Attributes.Append(naAttribute);
            Local_Seized_LED.InnerText = _Local_Seized_LED;
            flatProfileNode.AppendChild(Local_Seized_LED);

            // Remote_Seized_LED
            var Remote_Seized_LED = configMACDocument.CreateElement("Remote_Seized_LED");
            Remote_Seized_LED.Attributes.Append(naAttribute);
            Remote_Seized_LED.InnerText = _Remote_Seized_LED;
            flatProfileNode.AppendChild(Remote_Seized_LED);

            // Local_Progressing_LED
            var Local_Progressing_LED = configMACDocument.CreateElement("Local_Progressing_LED");
            Local_Progressing_LED.Attributes.Append(naAttribute);
            Local_Progressing_LED.InnerText = _Local_Progressing_LED;
            flatProfileNode.AppendChild(Local_Progressing_LED);

            // Remote_Progressing_LED
            var Remote_Progressing_LED = configMACDocument.CreateElement("Remote_Progressing_LED");
            Remote_Progressing_LED.Attributes.Append(naAttribute);
            Remote_Progressing_LED.InnerText = _Remote_Progressing_LED;
            flatProfileNode.AppendChild(Remote_Progressing_LED);

            // Local_Ringing_LED
            var Local_Ringing_LED = configMACDocument.CreateElement("Local_Ringing_LED");
            Local_Ringing_LED.Attributes.Append(naAttribute);
            Local_Ringing_LED.InnerText = _Local_Ringing_LED;
            flatProfileNode.AppendChild(Local_Ringing_LED);

            // Remote_Ringing_LED
            var Remote_Ringing_LED = configMACDocument.CreateElement("Remote_Ringing_LED");
            Remote_Ringing_LED.Attributes.Append(naAttribute);
            Remote_Ringing_LED.InnerText = _Remote_Ringing_LED;
            flatProfileNode.AppendChild(Remote_Ringing_LED);

            // Local_Active_LED
            var Local_Active_LED = configMACDocument.CreateElement("Local_Active_LED");
            Local_Active_LED.Attributes.Append(naAttribute);
            Local_Active_LED.InnerText = _Local_Active_LED;
            flatProfileNode.AppendChild(Local_Active_LED);

            // Remote_Active_LED
            var Remote_Active_LED = configMACDocument.CreateElement("Remote_Active_LED");
            Remote_Active_LED.Attributes.Append(naAttribute);
            Remote_Active_LED.InnerText = _Remote_Active_LED;
            flatProfileNode.AppendChild(Remote_Active_LED);

            // Local_Held_LED
            var Local_Held_LED = configMACDocument.CreateElement("Local_Held_LED");
            Local_Held_LED.Attributes.Append(naAttribute);
            Local_Held_LED.InnerText = _Local_Held_LED;
            flatProfileNode.AppendChild(Local_Held_LED);

            // Remote_Held_LED
            var Remote_Held_LED = configMACDocument.CreateElement("Remote_Held_LED");
            Remote_Held_LED.Attributes.Append(naAttribute);
            Remote_Held_LED.InnerText = _Remote_Held_LED;
            flatProfileNode.AppendChild(Remote_Held_LED);

            // Register_Failed_LED
            var Register_Failed_LED = configMACDocument.CreateElement("Register_Failed_LED");
            Register_Failed_LED.Attributes.Append(naAttribute);
            Register_Failed_LED.InnerText = _Register_Failed_LED;
            flatProfileNode.AppendChild(Register_Failed_LED);

            // Disabled_LED
            var Disabled_LED = configMACDocument.CreateElement("Disabled_LED");
            Disabled_LED.Attributes.Append(naAttribute);
            Disabled_LED.InnerText = _Disabled_LED;
            flatProfileNode.AppendChild(Disabled_LED);

            // Registering_LED
            var Registering_LED = configMACDocument.CreateElement("Registering_LED");
            Registering_LED.Attributes.Append(naAttribute);
            Registering_LED.InnerText = _Registering_LED;
            flatProfileNode.AppendChild(Registering_LED);

            // Call_Back_Active_LED
            var Call_Back_Active_LED = configMACDocument.CreateElement("Call_Back_Active_LED");
            Call_Back_Active_LED.Attributes.Append(naAttribute);
            Call_Back_Active_LED.InnerText = _Call_Back_Active_LED;
            flatProfileNode.AppendChild(Call_Back_Active_LED);

            // Trunk_No_Service_LED
            var Trunk_No_Service_LED = configMACDocument.CreateElement("Trunk_No_Service_LED");
            Trunk_No_Service_LED.Attributes.Append(naAttribute);
            Trunk_No_Service_LED.InnerText = _Trunk_No_Service_LED;
            flatProfileNode.AppendChild(Trunk_No_Service_LED);

            // Trunk_Reserved_LED
            var Trunk_Reserved_LED = configMACDocument.CreateElement("Trunk_Reserved_LED");
            Trunk_Reserved_LED.Attributes.Append(naAttribute);
            Trunk_Reserved_LED.InnerText = _Trunk_Reserved_LED;
            flatProfileNode.AppendChild(Trunk_Reserved_LED);

            // Trunk_In-use_LED
            var Trunk_In_use_LED = configMACDocument.CreateElement("Trunk_In-use_LED");
            Trunk_In_use_LED.Attributes.Append(naAttribute);
            Trunk_In_use_LED.InnerText = _Trunk_In_use_LED;
            flatProfileNode.AppendChild(Trunk_In_use_LED);

            #endregion

            #region Supplementary Services 

            // Conference_Serv
            var Conference_Serv = configMACDocument.CreateElement("Conference_Serv");
            Conference_Serv.Attributes.Append(naAttribute);
            Conference_Serv.InnerText = _Conference_Serv;
            flatProfileNode.AppendChild(Conference_Serv);

            // Attn_Transfer_Serv
            var Attn_Transfer_Serv = configMACDocument.CreateElement("Attn_Transfer_Serv");
            Attn_Transfer_Serv.Attributes.Append(naAttribute);
            Attn_Transfer_Serv.InnerText = _Attn_Transfer_Serv;
            flatProfileNode.AppendChild(Attn_Transfer_Serv);

            // Blind_Transfer_Serv
            var Blind_Transfer_Serv = configMACDocument.CreateElement("Blind_Transfer_Serv");
            Blind_Transfer_Serv.Attributes.Append(naAttribute);
            Blind_Transfer_Serv.InnerText = _Blind_Transfer_Serv;
            flatProfileNode.AppendChild(Blind_Transfer_Serv);

            // DND_Serv
            var DND_Serv = configMACDocument.CreateElement("DND_Serv");
            DND_Serv.Attributes.Append(naAttribute);
            DND_Serv.InnerText = _DND_Serv;
            flatProfileNode.AppendChild(DND_Serv);

            // Block_ANC_Serv
            var Block_ANC_Serv = configMACDocument.CreateElement("Block_ANC_Serv");
            Block_ANC_Serv.Attributes.Append(naAttribute);
            Block_ANC_Serv.InnerText = _Block_ANC_Serv;
            flatProfileNode.AppendChild(Block_ANC_Serv);

            // Call_Back_Serv
            var Call_Back_Serv = configMACDocument.CreateElement("Call_Back_Serv");
            Call_Back_Serv.Attributes.Append(naAttribute);
            Call_Back_Serv.InnerText = _Call_Back_Serv;
            flatProfileNode.AppendChild(Call_Back_Serv);

            // Block_CID_Serv
            var Block_CID_Serv = configMACDocument.CreateElement("Block_CID_Serv");
            Block_CID_Serv.Attributes.Append(naAttribute);
            Block_CID_Serv.InnerText = _Block_CID_Serv;
            flatProfileNode.AppendChild(Block_CID_Serv);

            // Secure_Call_Serv
            var Secure_Call_Serv = configMACDocument.CreateElement("Secure_Call_Serv");
            Secure_Call_Serv.Attributes.Append(naAttribute);
            Secure_Call_Serv.InnerText = _Secure_Call_Serv;
            flatProfileNode.AppendChild(Secure_Call_Serv);

            // Cfwd_All_Serv
            var Cfwd_All_Serv = configMACDocument.CreateElement("Cfwd_All_Serv");
            Cfwd_All_Serv.Attributes.Append(naAttribute);
            Cfwd_All_Serv.InnerText = _Cfwd_All_Serv;
            flatProfileNode.AppendChild(Cfwd_All_Serv);

            // Cfwd_Busy_Serv
            var Cfwd_Busy_Serv = configMACDocument.CreateElement("Cfwd_Busy_Serv");
            Cfwd_Busy_Serv.Attributes.Append(naAttribute);
            Cfwd_Busy_Serv.InnerText = _Cfwd_Busy_Serv;
            flatProfileNode.AppendChild(Cfwd_Busy_Serv);

            // Cfwd_No_Ans_Serv
            var Cfwd_No_Ans_Serv = configMACDocument.CreateElement("Cfwd_No_Ans_Serv");
            Cfwd_No_Ans_Serv.Attributes.Append(naAttribute);
            Cfwd_No_Ans_Serv.InnerText = _Cfwd_No_Ans_Serv;
            flatProfileNode.AppendChild(Cfwd_No_Ans_Serv);

            // Paging_Serv
            var Paging_Serv = configMACDocument.CreateElement("Paging_Serv");
            Paging_Serv.Attributes.Append(naAttribute);
            Paging_Serv.InnerText = _Paging_Serv;
            flatProfileNode.AppendChild(Paging_Serv);

            // Call_Park_Serv
            var Call_Park_Serv = configMACDocument.CreateElement("Call_Park_Serv");
            Call_Park_Serv.Attributes.Append(naAttribute);
            Call_Park_Serv.InnerText = _Call_Park_Serv;
            flatProfileNode.AppendChild(Call_Park_Serv);

            // Call_Pick_Up_Serv
            var Call_Pick_Up_Serv = configMACDocument.CreateElement("Call_Pick_Up_Serv");
            Call_Pick_Up_Serv.Attributes.Append(naAttribute);
            Call_Pick_Up_Serv.InnerText = _Call_Pick_Up_Serv;
            flatProfileNode.AppendChild(Call_Pick_Up_Serv);

            // ACD_Login_Serv
            var ACD_Login_Serv = configMACDocument.CreateElement("ACD_Login_Serv");
            ACD_Login_Serv.Attributes.Append(naAttribute);
            ACD_Login_Serv.InnerText = _ACD_Login_Serv;
            flatProfileNode.AppendChild(ACD_Login_Serv);

            // Group_Call_Pick_Up_Serv
            var Group_Call_Pick_Up_Serv = configMACDocument.CreateElement("Group_Call_Pick_Up_Serv");
            Group_Call_Pick_Up_Serv.Attributes.Append(naAttribute);
            Group_Call_Pick_Up_Serv.InnerText = _Group_Call_Pick_Up_Serv;
            flatProfileNode.AppendChild(Group_Call_Pick_Up_Serv);

            // ACD_Ext
            var ACD_Ext = configMACDocument.CreateElement("ACD_Ext");
            ACD_Ext.Attributes.Append(naAttribute);
            ACD_Ext.InnerText = _ACD_Ext;
            flatProfileNode.AppendChild(ACD_Ext);

            // Service_Annc_Serv
            var Service_Annc_Serv = configMACDocument.CreateElement("Service_Annc_Serv");
            Service_Annc_Serv.Attributes.Append(naAttribute);
            Service_Annc_Serv.InnerText = _Service_Annc_Serv;
            flatProfileNode.AppendChild(Service_Annc_Serv);

            // Web_Serv
            var Web_Serv = configMACDocument.CreateElement("Web_Serv");
            Web_Serv.Attributes.Append(naAttribute);
            Web_Serv.InnerText = _Web_Serv;
            flatProfileNode.AppendChild(Web_Serv);

            // SMS_Serv
            var SMS_Serv = configMACDocument.CreateElement("SMS_Serv");
            SMS_Serv.Attributes.Append(naAttribute);
            SMS_Serv.InnerText = _SMS_Serv;
            flatProfileNode.AppendChild(SMS_Serv);

            #endregion

            #region Ring Tone

            // Ring1
            var Ring1 = configMACDocument.CreateElement("Ring1");
            Ring1.Attributes.Append(naAttribute);
            Ring1.InnerText = _Ring1;
            flatProfileNode.AppendChild(Ring1);

            // Ring2
            var Ring2 = configMACDocument.CreateElement("Ring2");
            Ring2.Attributes.Append(naAttribute);
            Ring2.InnerText = _Ring2;
            flatProfileNode.AppendChild(Ring2);

            // Ring3
            var Ring3 = configMACDocument.CreateElement("Ring3");
            Ring3.Attributes.Append(naAttribute);
            Ring3.InnerText = _Ring3;
            flatProfileNode.AppendChild(Ring3);

            // Ring4
            var Ring4 = configMACDocument.CreateElement("Ring4");
            Ring4.Attributes.Append(naAttribute);
            Ring4.InnerText = _Ring4;
            flatProfileNode.AppendChild(Ring4);

            // Ring5
            var Ring5 = configMACDocument.CreateElement("Ring5");
            Ring5.Attributes.Append(naAttribute);
            Ring5.InnerText = _Ring5;
            flatProfileNode.AppendChild(Ring5);

            // Ring6
            var Ring6 = configMACDocument.CreateElement("Ring6");
            Ring6.Attributes.Append(naAttribute);
            Ring6.InnerText = _Ring6;
            flatProfileNode.AppendChild(Ring6);

            // Ring7
            var Ring7 = configMACDocument.CreateElement("Ring7");
            Ring7.Attributes.Append(naAttribute);
            Ring7.InnerText = _Ring7;
            flatProfileNode.AppendChild(Ring7);

            // Ring8
            var Ring8 = configMACDocument.CreateElement("Ring8");
            Ring8.Attributes.Append(naAttribute);
            Ring8.InnerText = _Ring8;
            flatProfileNode.AppendChild(Ring8);

            // Ring9
            var Ring9 = configMACDocument.CreateElement("Ring9");
            Ring9.Attributes.Append(naAttribute);
            Ring9.InnerText = _Ring9;
            flatProfileNode.AppendChild(Ring9);

            // Ring10
            var Ring10 = configMACDocument.CreateElement("Ring10");
            Ring10.Attributes.Append(naAttribute);
            Ring10.InnerText = _Ring10;
            flatProfileNode.AppendChild(Ring10);

            #endregion

            #region Audio Input Gain (dB) 

            // Handset_Input_Gain
            var Handset_Input_Gain = configMACDocument.CreateElement("Handset_Input_Gain");
            Handset_Input_Gain.Attributes.Append(naAttribute);
            Handset_Input_Gain.InnerText = _Handset_Input_Gain;
            flatProfileNode.AppendChild(Handset_Input_Gain);

            // Headset_Input_Gain
            var Headset_Input_Gain = configMACDocument.CreateElement("Headset_Input_Gain");
            Headset_Input_Gain.Attributes.Append(naAttribute);
            Headset_Input_Gain.InnerText = _Headset_Input_Gain;
            flatProfileNode.AppendChild(Headset_Input_Gain);

            // Speakerphone_Input_Gain
            var Speakerphone_Input_Gain = configMACDocument.CreateElement("Speakerphone_Input_Gain");
            Speakerphone_Input_Gain.Attributes.Append(naAttribute);
            Speakerphone_Input_Gain.InnerText = _Speakerphone_Input_Gain;
            flatProfileNode.AppendChild(Speakerphone_Input_Gain);

            // Bluetooth_Input_Gain
            var Bluetooth_Input_Gain = configMACDocument.CreateElement("Bluetooth_Input_Gain");
            Bluetooth_Input_Gain.Attributes.Append(naAttribute);
            Bluetooth_Input_Gain.InnerText = _Bluetooth_Input_Gain;
            flatProfileNode.AppendChild(Bluetooth_Input_Gain);

            #endregion

            #region Extension Mobility

            // EM_Enable
            var EM_Enable = configMACDocument.CreateElement("EM_Enable");
            EM_Enable.Attributes.Append(naAttribute);
            EM_Enable.InnerText = _EM_Enable;
            flatProfileNode.AppendChild(EM_Enable);

            // EM_User_Domain
            var EM_User_Domain = configMACDocument.CreateElement("EM_User_Domain");
            EM_User_Domain.Attributes.Append(naAttribute);
            EM_User_Domain.InnerText = _EM_User_Domain;
            flatProfileNode.AppendChild(EM_User_Domain);

            // EM_Phone_User_ID
            var EM_Phone_User_ID = configMACDocument.CreateElement("EM_Phone_User_ID");
            EM_Phone_User_ID.Attributes.Append(naAttribute);
            EM_Phone_User_ID.InnerText = _EM_Phone_User_ID;
            flatProfileNode.AppendChild(EM_Phone_User_ID);

            // EM_Phone_Password
            var EM_Phone_Password = configMACDocument.CreateElement("EM_Phone_Password");
            EM_Phone_Password.Attributes.Append(naAttribute);
            EM_Phone_Password.InnerText = _EM_Phone_Password;
            flatProfileNode.AppendChild(EM_Phone_Password);

            // EM_Mobile_User_ID
            var EM_Mobile_User_ID = configMACDocument.CreateElement("EM_Mobile_User_ID");
            EM_Mobile_User_ID.Attributes.Append(naAttribute);
            EM_Mobile_User_ID.InnerText = _EM_Mobile_User_ID;
            flatProfileNode.AppendChild(EM_Mobile_User_ID);

            // EM_Mobile_Password
            var EM_Mobile_Password = configMACDocument.CreateElement("EM_Mobile_Password");
            EM_Mobile_Password.Attributes.Append(naAttribute);
            EM_Mobile_Password.InnerText = _EM_Mobile_Password;
            flatProfileNode.AppendChild(EM_Mobile_Password);

            #endregion

            #region Broadsoft Settings

            // Directory_Enable
            var Directory_Enable = configMACDocument.CreateElement("Directory_Enable");
            Directory_Enable.Attributes.Append(naAttribute);
            Directory_Enable.InnerText = _Directory_Enable;
            flatProfileNode.AppendChild(Directory_Enable);

            // XSI_Host_Server
            var XSI_Host_Server = configMACDocument.CreateElement("XSI_Host_Server");
            XSI_Host_Server.Attributes.Append(naAttribute);
            XSI_Host_Server.InnerText = _XSI_Host_Server;
            flatProfileNode.AppendChild(XSI_Host_Server);

            // Directory_Name
            var Directory_Name = configMACDocument.CreateElement("Directory_Name");
            Directory_Name.Attributes.Append(naAttribute);
            Directory_Name.InnerText = _Directory_Name;
            flatProfileNode.AppendChild(Directory_Name);

            // Directory_Type
            var Directory_Type = configMACDocument.CreateElement("Directory_Type");
            Directory_Type.Attributes.Append(naAttribute);
            Directory_Type.InnerText = _Directory_Type;
            flatProfileNode.AppendChild(Directory_Type);

            // Directory_UserID
            var Directory_UserID = configMACDocument.CreateElement("Directory_UserID");
            Directory_UserID.Attributes.Append(naAttribute);
            Directory_UserID.InnerText = _Directory_UserID;
            flatProfileNode.AppendChild(Directory_UserID);

            // Directory_Password
            var Directory_Password = configMACDocument.CreateElement("Directory_Password");
            Directory_Password.Attributes.Append(naAttribute);
            Directory_Password.InnerText = _Directory_Password;
            flatProfileNode.AppendChild(Directory_Password);

            // Call_Feature_Sync_Ext
            var Call_Feature_Sync_Ext = configMACDocument.CreateElement("Call_Feature_Sync_Ext");
            Call_Feature_Sync_Ext.Attributes.Append(naAttribute);
            Call_Feature_Sync_Ext.InnerText = _Call_Feature_Sync_Ext;
            flatProfileNode.AppendChild(Call_Feature_Sync_Ext);

            #endregion

            #region XML Service

            // XML_Directory_Service_Name
            var XML_Directory_Service_Name = configMACDocument.CreateElement("XML_Directory_Service_Name");
            XML_Directory_Service_Name.Attributes.Append(naAttribute);
            XML_Directory_Service_Name.InnerText = _XML_Directory_Service_Name;
            flatProfileNode.AppendChild(XML_Directory_Service_Name);

            // XML_Directory_Service_URL
            var XML_Directory_Service_URL = configMACDocument.CreateElement("XML_Directory_Service_URL");
            XML_Directory_Service_URL.Attributes.Append(naAttribute);
            XML_Directory_Service_URL.InnerText = _XML_Directory_Service_URL;
            flatProfileNode.AppendChild(XML_Directory_Service_URL);

            // XML_Application_Service_Name
            var XML_Application_Service_Name = configMACDocument.CreateElement("XML_Application_Service_Name");
            XML_Application_Service_Name.Attributes.Append(naAttribute);
            XML_Application_Service_Name.InnerText = _XML_Application_Service_Name;
            flatProfileNode.AppendChild(XML_Application_Service_Name);

            // XML_Application_Service_URL
            var XML_Application_Service_URL = configMACDocument.CreateElement("XML_Application_Service_URL");
            XML_Application_Service_URL.Attributes.Append(naAttribute);
            XML_Application_Service_URL.InnerText = _XML_Application_Service_URL;
            flatProfileNode.AppendChild(XML_Application_Service_URL);

            #endregion

            #region Multiple Paging Group Parameters

            // Group_Paging_Script
            var Group_Paging_Script = configMACDocument.CreateElement("Group_Paging_Script");
            Group_Paging_Script.Attributes.Append(naAttribute);
            Group_Paging_Script.InnerText = _Group_Paging_Script;
            flatProfileNode.AppendChild(Group_Paging_Script);

            #endregion

            #region LDAP

            // LDAP_Dir_Enable
            var LDAP_Dir_Enable = configMACDocument.CreateElement("LDAP_Dir_Enable");
            LDAP_Dir_Enable.Attributes.Append(naAttribute);
            LDAP_Dir_Enable.InnerText = _LDAP_Dir_Enable;
            flatProfileNode.AppendChild(LDAP_Dir_Enable);

            // Corp_Dir_Name
            var Corp_Dir_Name = configMACDocument.CreateElement("Corp_Dir_Name");
            Corp_Dir_Name.Attributes.Append(naAttribute);
            Corp_Dir_Name.InnerText = _Corp_Dir_Name;
            flatProfileNode.AppendChild(Corp_Dir_Name);

            // Server
            var Server = configMACDocument.CreateElement("Server");
            Server.Attributes.Append(naAttribute);
            Server.InnerText = _Server;
            flatProfileNode.AppendChild(Server);

            // Search_Base
            var Search_Base = configMACDocument.CreateElement("Search_Base");
            Search_Base.Attributes.Append(naAttribute);
            Search_Base.InnerText = _Search_Base;
            flatProfileNode.AppendChild(Search_Base);

            // Client_DN
            var Client_DN = configMACDocument.CreateElement("Client_DN");
            Client_DN.Attributes.Append(naAttribute);
            Client_DN.InnerText = _Client_DN;
            flatProfileNode.AppendChild(Client_DN);

            // User_Name
            var User_Name = configMACDocument.CreateElement("User_Name");
            User_Name.Attributes.Append(naAttribute);
            User_Name.InnerText = _User_Name;
            flatProfileNode.AppendChild(User_Name);

            // Password
            var Password = configMACDocument.CreateElement("Password");
            Password.Attributes.Append(naAttribute);
            Password.InnerText = _Password;
            flatProfileNode.AppendChild(Password);

            // Auth_Type
            var Auth_Type = configMACDocument.CreateElement("Auth_Type");
            Auth_Type.Attributes.Append(naAttribute);
            Auth_Type.InnerText = _Auth_Type;
            flatProfileNode.AppendChild(Auth_Type);

            // Last_Name_Filter
            var Last_Name_Filter = configMACDocument.CreateElement("Last_Name_Filter");
            Last_Name_Filter.Attributes.Append(naAttribute);
            Last_Name_Filter.InnerText = _Last_Name_Filter;
            flatProfileNode.AppendChild(Last_Name_Filter);

            // First_Name_Filter
            var First_Name_Filter = configMACDocument.CreateElement("First_Name_Filter");
            First_Name_Filter.Attributes.Append(naAttribute);
            First_Name_Filter.InnerText = _First_Name_Filter;
            flatProfileNode.AppendChild(First_Name_Filter);

            // Search_Item_3
            var Search_Item_3 = configMACDocument.CreateElement("Search_Item_3");
            Search_Item_3.Attributes.Append(naAttribute);
            Search_Item_3.InnerText = _Search_Item_3;
            flatProfileNode.AppendChild(Search_Item_3);

            // Search_Item_3_Filter
            var Search_Item_3_Filter = configMACDocument.CreateElement("Search_Item_3_Filter");
            Search_Item_3_Filter.Attributes.Append(naAttribute);
            Search_Item_3_Filter.InnerText = _Search_Item_3_Filter;
            flatProfileNode.AppendChild(Search_Item_3_Filter);

            // Search_Item_4
            var Search_Item_4 = configMACDocument.CreateElement("Search_Item_4");
            Search_Item_4.Attributes.Append(naAttribute);
            Search_Item_4.InnerText = _Search_Item_4;
            flatProfileNode.AppendChild(Search_Item_4);

            // Search_Item_4_Filter
            var Search_Item_4_Filter = configMACDocument.CreateElement("Search_Item_4_Filter");
            Search_Item_4_Filter.Attributes.Append(naAttribute);
            Search_Item_4_Filter.InnerText = _Search_Item_4_Filter;
            flatProfileNode.AppendChild(Search_Item_4_Filter);

            // Display_Attr
            var Display_Attr = configMACDocument.CreateElement("Display_Attr");
            Display_Attr.Attributes.Append(naAttribute);
            Display_Attr.InnerText = _Display_Attr;
            flatProfileNode.AppendChild(Display_Attr);

            // Number_Mapping
            var Number_Mapping = configMACDocument.CreateElement("Number_Mapping");
            Number_Mapping.Attributes.Append(naAttribute);
            Number_Mapping.InnerText = _Number_Mapping;
            flatProfileNode.AppendChild(Number_Mapping);

            #endregion

            #region Programmable Softkeys 

            // Programmable_Softkey_Enable
            var Programmable_Softkey_Enable = configMACDocument.CreateElement("Programmable_Softkey_Enable");
            Programmable_Softkey_Enable.Attributes.Append(naAttribute);
            Programmable_Softkey_Enable.InnerText = _Programmable_Softkey_Enable;
            flatProfileNode.AppendChild(Programmable_Softkey_Enable);

            // Idle_Key_List
            var Idle_Key_List = configMACDocument.CreateElement("Idle_Key_List");
            Idle_Key_List.Attributes.Append(naAttribute);
            Idle_Key_List.InnerText = _Idle_Key_List;
            flatProfileNode.AppendChild(Idle_Key_List);

            // Missed_Call_Key_List
            var Missed_Call_Key_List = configMACDocument.CreateElement("Missed_Call_Key_List");
            Missed_Call_Key_List.Attributes.Append(naAttribute);
            Missed_Call_Key_List.InnerText = _Missed_Call_Key_List;
            flatProfileNode.AppendChild(Missed_Call_Key_List);

            // Off_Hook_Key_List
            var Off_Hook_Key_List = configMACDocument.CreateElement("Off_Hook_Key_List");
            Off_Hook_Key_List.Attributes.Append(naAttribute);
            Off_Hook_Key_List.InnerText = _Off_Hook_Key_List;
            flatProfileNode.AppendChild(Off_Hook_Key_List);

            // Dialing_Input_Key_List
            var Dialing_Input_Key_List = configMACDocument.CreateElement("Dialing_Input_Key_List");
            Dialing_Input_Key_List.Attributes.Append(naAttribute);
            Dialing_Input_Key_List.InnerText = _Dialing_Input_Key_List;
            flatProfileNode.AppendChild(Dialing_Input_Key_List);

            // Progressing_Key_List
            var Progressing_Key_List = configMACDocument.CreateElement("Progressing_Key_List");
            Progressing_Key_List.Attributes.Append(naAttribute);
            Progressing_Key_List.InnerText = _Progressing_Key_List;
            flatProfileNode.AppendChild(Progressing_Key_List);

            // Connected_Key_List
            var Connected_Key_List = configMACDocument.CreateElement("Connected_Key_List");
            Connected_Key_List.Attributes.Append(naAttribute);
            Connected_Key_List.InnerText = _Connected_Key_List;
            flatProfileNode.AppendChild(Connected_Key_List);

            // Start-Xfer_Key_List
            var Start_Xfer_Key_List = configMACDocument.CreateElement("Start-Xfer_Key_List");
            Start_Xfer_Key_List.Attributes.Append(naAttribute);
            Start_Xfer_Key_List.InnerText = _Start_Xfer_Key_List;
            flatProfileNode.AppendChild(Start_Xfer_Key_List);

            // Start-Conf_Key_List
            var Start_Conf_Key_List = configMACDocument.CreateElement("Start-Conf_Key_List");
            Start_Conf_Key_List.Attributes.Append(naAttribute);
            Start_Conf_Key_List.InnerText = _Start_Conf_Key_List;
            flatProfileNode.AppendChild(Start_Conf_Key_List);

            // Conferencing_Key_List
            var Conferencing_Key_List = configMACDocument.CreateElement("Conferencing_Key_List");
            Conferencing_Key_List.Attributes.Append(naAttribute);
            Conferencing_Key_List.InnerText = _Conferencing_Key_List;
            flatProfileNode.AppendChild(Conferencing_Key_List);

            // Releasing_Key_List
            var Releasing_Key_List = configMACDocument.CreateElement("Releasing_Key_List");
            Releasing_Key_List.Attributes.Append(naAttribute);
            Releasing_Key_List.InnerText = _Releasing_Key_List;
            flatProfileNode.AppendChild(Releasing_Key_List);

            // Hold_Key_List
            var Hold_Key_List = configMACDocument.CreateElement("Hold_Key_List");
            Hold_Key_List.Attributes.Append(naAttribute);
            Hold_Key_List.InnerText = _Hold_Key_List;
            flatProfileNode.AppendChild(Hold_Key_List);

            // Ringing_Key_List
            var Ringing_Key_List = configMACDocument.CreateElement("Ringing_Key_List");
            Ringing_Key_List.Attributes.Append(naAttribute);
            Ringing_Key_List.InnerText = _Ringing_Key_List;
            flatProfileNode.AppendChild(Ringing_Key_List);

            // Shared_Active_Key_List
            var Shared_Active_Key_List = configMACDocument.CreateElement("Shared_Active_Key_List");
            Shared_Active_Key_List.Attributes.Append(naAttribute);
            Shared_Active_Key_List.InnerText = _Shared_Active_Key_List;
            flatProfileNode.AppendChild(Shared_Active_Key_List);

            // Shared_Held_Key_List
            var Shared_Held_Key_List = configMACDocument.CreateElement("Shared_Held_Key_List");
            Shared_Held_Key_List.Attributes.Append(naAttribute);
            Shared_Held_Key_List.InnerText = _Shared_Held_Key_List;
            flatProfileNode.AppendChild(Shared_Held_Key_List);

            // PSK_1
            var PSK_1 = configMACDocument.CreateElement("PSK_1");
            PSK_1.Attributes.Append(naAttribute);
            PSK_1.InnerText = _PSK_1;
            flatProfileNode.AppendChild(PSK_1);

            // PSK_2
            var PSK_2 = configMACDocument.CreateElement("PSK_2");
            PSK_2.Attributes.Append(naAttribute);
            PSK_2.InnerText = _PSK_2;
            flatProfileNode.AppendChild(PSK_2);

            // PSK_3
            var PSK_3 = configMACDocument.CreateElement("PSK_3");
            PSK_3.Attributes.Append(naAttribute);
            PSK_3.InnerText = _PSK_3;
            flatProfileNode.AppendChild(PSK_3);

            // PSK_4
            var PSK_4 = configMACDocument.CreateElement("PSK_4");
            PSK_4.Attributes.Append(naAttribute);
            PSK_4.InnerText = _PSK_4;
            flatProfileNode.AppendChild(PSK_4);

            // PSK_5
            var PSK_5 = configMACDocument.CreateElement("PSK_5");
            PSK_5.Attributes.Append(naAttribute);
            PSK_5.InnerText = _PSK_5;
            flatProfileNode.AppendChild(PSK_5);

            // PSK_6
            var PSK_6 = configMACDocument.CreateElement("PSK_6");
            PSK_6.Attributes.Append(naAttribute);
            PSK_6.InnerText = _PSK_6;
            flatProfileNode.AppendChild(PSK_6);

            #endregion

            #region Call Progress Tones 

            // Dial_Tone
            var Dial_Tone = configMACDocument.CreateElement("Dial_Tone");
            Dial_Tone.Attributes.Append(naAttribute);
            Dial_Tone.InnerText = _Dial_Tone;
            flatProfileNode.AppendChild(Dial_Tone);

            // Bluetooth_Dial_Tone
            var Bluetooth_Dial_Tone = configMACDocument.CreateElement("Bluetooth_Dial_Tone");
            Bluetooth_Dial_Tone.Attributes.Append(naAttribute);
            Bluetooth_Dial_Tone.InnerText = _Bluetooth_Dial_Tone;
            flatProfileNode.AppendChild(Bluetooth_Dial_Tone);

            // Outside_Dial_Tone
            var Outside_Dial_Tone = configMACDocument.CreateElement("Outside_Dial_Tone");
            Outside_Dial_Tone.Attributes.Append(naAttribute);
            Outside_Dial_Tone.InnerText = _Outside_Dial_Tone;
            flatProfileNode.AppendChild(Outside_Dial_Tone);

            // Prompt_Tone
            var Prompt_Tone = configMACDocument.CreateElement("Prompt_Tone");
            Prompt_Tone.Attributes.Append(naAttribute);
            Prompt_Tone.InnerText = _Prompt_Tone;
            flatProfileNode.AppendChild(Prompt_Tone);

            // Busy_Tone
            var Busy_Tone = configMACDocument.CreateElement("Busy_Tone");
            Busy_Tone.Attributes.Append(naAttribute);
            Busy_Tone.InnerText = _Busy_Tone;
            flatProfileNode.AppendChild(Busy_Tone);

            // Reorder_Tone
            var Reorder_Tone = configMACDocument.CreateElement("Reorder_Tone");
            Reorder_Tone.Attributes.Append(naAttribute);
            Reorder_Tone.InnerText = _Reorder_Tone;
            flatProfileNode.AppendChild(Reorder_Tone);

            // Off_Hook_Warning_Tone
            var Off_Hook_Warning_Tone = configMACDocument.CreateElement("Off_Hook_Warning_Tone");
            Off_Hook_Warning_Tone.Attributes.Append(naAttribute);
            Off_Hook_Warning_Tone.InnerText = _Off_Hook_Warning_Tone;
            flatProfileNode.AppendChild(Off_Hook_Warning_Tone);

            // Ring_Back_Tone
            var Ring_Back_Tone = configMACDocument.CreateElement("Ring_Back_Tone");
            Ring_Back_Tone.Attributes.Append(naAttribute);
            Ring_Back_Tone.InnerText = _Ring_Back_Tone;
            flatProfileNode.AppendChild(Ring_Back_Tone);

            // Call_Waiting_Tone
            var Call_Waiting_Tone = configMACDocument.CreateElement("Call_Waiting_Tone");
            Call_Waiting_Tone.Attributes.Append(naAttribute);
            Call_Waiting_Tone.InnerText = _Call_Waiting_Tone;
            flatProfileNode.AppendChild(Call_Waiting_Tone);

            // Confirm_Tone
            var Confirm_Tone = configMACDocument.CreateElement("Confirm_Tone");
            Confirm_Tone.Attributes.Append(naAttribute);
            Confirm_Tone.InnerText = _Confirm_Tone;
            flatProfileNode.AppendChild(Confirm_Tone);

            // SIT1_Tone
            var SIT1_Tone = configMACDocument.CreateElement("SIT1_Tone");
            SIT1_Tone.Attributes.Append(naAttribute);
            SIT1_Tone.InnerText = _SIT1_Tone;
            flatProfileNode.AppendChild(SIT1_Tone);

            // SIT2_Tone
            var SIT2_Tone = configMACDocument.CreateElement("SIT2_Tone");
            SIT2_Tone.Attributes.Append(naAttribute);
            SIT2_Tone.InnerText = _SIT2_Tone;
            flatProfileNode.AppendChild(SIT2_Tone);

            // SIT3_Tone
            var SIT3_Tone = configMACDocument.CreateElement("SIT3_Tone");
            SIT3_Tone.Attributes.Append(naAttribute);
            SIT3_Tone.InnerText = _SIT3_Tone;
            flatProfileNode.AppendChild(SIT3_Tone);

            // SIT4_Tone
            var SIT4_Tone = configMACDocument.CreateElement("SIT4_Tone");
            SIT4_Tone.Attributes.Append(naAttribute);
            SIT4_Tone.InnerText = _SIT4_Tone;
            flatProfileNode.AppendChild(SIT4_Tone);

            // MWI_Dial_Tone
            var MWI_Dial_Tone = configMACDocument.CreateElement("MWI_Dial_Tone");
            MWI_Dial_Tone.Attributes.Append(naAttribute);
            MWI_Dial_Tone.InnerText = _MWI_Dial_Tone;
            flatProfileNode.AppendChild(MWI_Dial_Tone);

            // Cfwd_Dial_Tone
            var Cfwd_Dial_Tone = configMACDocument.CreateElement("Cfwd_Dial_Tone");
            Cfwd_Dial_Tone.Attributes.Append(naAttribute);
            Cfwd_Dial_Tone.InnerText = _Cfwd_Dial_Tone;
            flatProfileNode.AppendChild(Cfwd_Dial_Tone);

            // Holding_Tone
            var Holding_Tone = configMACDocument.CreateElement("Holding_Tone");
            Holding_Tone.Attributes.Append(naAttribute);
            Holding_Tone.InnerText = _Holding_Tone;
            flatProfileNode.AppendChild(Holding_Tone);

            // Conference_Tone
            var Conference_Tone = configMACDocument.CreateElement("Conference_Tone");
            Conference_Tone.Attributes.Append(naAttribute);
            Conference_Tone.InnerText = _Conference_Tone;
            flatProfileNode.AppendChild(Conference_Tone);

            // Secure_Call_Indication_Tone
            var Secure_Call_Indication_Tone = configMACDocument.CreateElement("Secure_Call_Indication_Tone");
            Secure_Call_Indication_Tone.Attributes.Append(naAttribute);
            Secure_Call_Indication_Tone.InnerText = _Secure_Call_Indication_Tone;
            flatProfileNode.AppendChild(Secure_Call_Indication_Tone);

            // Page_Tone
            var Page_Tone = configMACDocument.CreateElement("Page_Tone");
            Page_Tone.Attributes.Append(naAttribute);
            Page_Tone.InnerText = _Page_Tone;
            flatProfileNode.AppendChild(Page_Tone);

            // Low_Battery_Tone
            var Low_Battery_Tone = configMACDocument.CreateElement("Low_Battery_Tone");
            Low_Battery_Tone.Attributes.Append(naAttribute);
            Low_Battery_Tone.InnerText = _Low_Battery_Tone;
            flatProfileNode.AppendChild(Low_Battery_Tone);

            // Alert_Tone
            var Alert_Tone = configMACDocument.CreateElement("Alert_Tone");
            Alert_Tone.Attributes.Append(naAttribute);
            Alert_Tone.InnerText = _Alert_Tone;
            flatProfileNode.AppendChild(Alert_Tone);

            // System_Beep
            var System_Beep = configMACDocument.CreateElement("System_Beep");
            System_Beep.Attributes.Append(naAttribute);
            System_Beep.InnerText = _System_Beep;
            flatProfileNode.AppendChild(System_Beep);

            #endregion

            #region Distinctive Ring Patterns

            // Cadence_1
            var Cadence_1 = configMACDocument.CreateElement("Cadence_1");
            Cadence_1.Attributes.Append(naAttribute);
            Cadence_1.InnerText = _Cadence_1;
            flatProfileNode.AppendChild(Cadence_1);

            // Cadence_2
            var Cadence_2 = configMACDocument.CreateElement("Cadence_2");
            Cadence_2.Attributes.Append(naAttribute);
            Cadence_2.InnerText = _Cadence_2;
            flatProfileNode.AppendChild(Cadence_2);

            // Cadence_3
            var Cadence_3 = configMACDocument.CreateElement("Cadence_3");
            Cadence_3.Attributes.Append(naAttribute);
            Cadence_3.InnerText = _Cadence_3;
            flatProfileNode.AppendChild(Cadence_3);

            // Cadence_4
            var Cadence_4 = configMACDocument.CreateElement("Cadence_4");
            Cadence_4.Attributes.Append(naAttribute);
            Cadence_4.InnerText = _Cadence_4;
            flatProfileNode.AppendChild(Cadence_4);

            // Cadence_5
            var Cadence_5 = configMACDocument.CreateElement("Cadence_5");
            Cadence_5.Attributes.Append(naAttribute);
            Cadence_5.InnerText = _Cadence_5;
            flatProfileNode.AppendChild(Cadence_5);

            // Cadence_6
            var Cadence_6 = configMACDocument.CreateElement("Cadence_6");
            Cadence_6.Attributes.Append(naAttribute);
            Cadence_6.InnerText = _Cadence_6;
            flatProfileNode.AppendChild(Cadence_6);

            // Cadence_7
            var Cadence_7 = configMACDocument.CreateElement("Cadence_7");
            Cadence_7.Attributes.Append(naAttribute);
            Cadence_7.InnerText = _Cadence_7;
            flatProfileNode.AppendChild(Cadence_7);

            // Cadence_8
            var Cadence_8 = configMACDocument.CreateElement("Cadence_8");
            Cadence_8.Attributes.Append(naAttribute);
            Cadence_8.InnerText = _Cadence_8;
            flatProfileNode.AppendChild(Cadence_8);

            // Cadence_9
            var Cadence_9 = configMACDocument.CreateElement("Cadence_9");
            Cadence_9.Attributes.Append(naAttribute);
            Cadence_9.InnerText = _Cadence_9;
            flatProfileNode.AppendChild(Cadence_9);

            #endregion

            #region Control Timer Values

            // Reorder_Delay
            var Reorder_Delay = configMACDocument.CreateElement("Reorder_Delay");
            Reorder_Delay.Attributes.Append(naAttribute);
            Reorder_Delay.InnerText = _Reorder_Delay;
            flatProfileNode.AppendChild(Reorder_Delay);

            // Call_Back_Expires
            var Call_Back_Expires = configMACDocument.CreateElement("Call_Back_Expires");
            Call_Back_Expires.Attributes.Append(naAttribute);
            Call_Back_Expires.InnerText = _Call_Back_Expires;
            flatProfileNode.AppendChild(Call_Back_Expires);

            // Call_Back_Retry_Intvl
            var Call_Back_Retry_Intvl = configMACDocument.CreateElement("Call_Back_Retry_Intvl");
            Call_Back_Retry_Intvl.Attributes.Append(naAttribute);
            Call_Back_Retry_Intvl.InnerText = _Call_Back_Retry_Intvl;
            flatProfileNode.AppendChild(Call_Back_Retry_Intvl);

            // Call_Back_Delay
            var Call_Back_Delay = configMACDocument.CreateElement("Call_Back_Delay");
            Call_Back_Delay.Attributes.Append(naAttribute);
            Call_Back_Delay.InnerText = _Call_Back_Delay;
            flatProfileNode.AppendChild(Call_Back_Delay);

            // Interdigit_Long_Timer
            var Interdigit_Long_Timer = configMACDocument.CreateElement("Interdigit_Long_Timer");
            Interdigit_Long_Timer.Attributes.Append(naAttribute);
            Interdigit_Long_Timer.InnerText = _Interdigit_Long_Timer;
            flatProfileNode.AppendChild(Interdigit_Long_Timer);

            // Interdigit_Short_Timer
            var Interdigit_Short_Timer = configMACDocument.CreateElement("Interdigit_Short_Timer");
            Interdigit_Short_Timer.Attributes.Append(naAttribute);
            Interdigit_Short_Timer.InnerText = _Interdigit_Short_Timer;
            flatProfileNode.AppendChild(Interdigit_Short_Timer);

            #endregion

            #region Vertical Service Activation Codes 

            // Call_Return_Code
            var Call_Return_Code = configMACDocument.CreateElement("Call_Return_Code");
            Call_Return_Code.Attributes.Append(naAttribute);
            Call_Return_Code.InnerText = _serviceActivationCodes._Call_Return_Code;
            flatProfileNode.AppendChild(Call_Return_Code);

            // Blind_Transfer_Code
            var Blind_Transfer_Code = configMACDocument.CreateElement("Blind_Transfer_Code");
            Blind_Transfer_Code.Attributes.Append(naAttribute);
            Blind_Transfer_Code.InnerText = _serviceActivationCodes._Blind_Transfer_Code;
            flatProfileNode.AppendChild(Blind_Transfer_Code);

            // Call_Back_Act_Code
            var Call_Back_Act_Code = configMACDocument.CreateElement("Call_Back_Act_Code");
            Call_Back_Act_Code.Attributes.Append(naAttribute);
            Call_Back_Act_Code.InnerText = _serviceActivationCodes._Call_Back_Act_Code;
            flatProfileNode.AppendChild(Call_Back_Act_Code);

            // Call_Back_Deact_Code
            var Call_Back_Deact_Code = configMACDocument.CreateElement("Call_Back_Deact_Code");
            Call_Back_Deact_Code.Attributes.Append(naAttribute);
            Call_Back_Deact_Code.InnerText = _serviceActivationCodes._Call_Back_Deact_Code;
            flatProfileNode.AppendChild(Call_Back_Deact_Code);

            // Cfwd_All_Act_Code
            var Cfwd_All_Act_Code = configMACDocument.CreateElement("Cfwd_All_Act_Code");
            Cfwd_All_Act_Code.Attributes.Append(naAttribute);
            Cfwd_All_Act_Code.InnerText = _serviceActivationCodes._Cfwd_All_Act_Code;
            flatProfileNode.AppendChild(Cfwd_All_Act_Code);

            // Cfwd_All_Deact_Code
            var Cfwd_All_Deact_Code = configMACDocument.CreateElement("Cfwd_All_Deact_Code");
            Cfwd_All_Deact_Code.Attributes.Append(naAttribute);
            Cfwd_All_Deact_Code.InnerText = _serviceActivationCodes._Cfwd_All_Deact_Code;
            flatProfileNode.AppendChild(Cfwd_All_Deact_Code);

            // Cfwd_Busy_Act_Code
            var Cfwd_Busy_Act_Code = configMACDocument.CreateElement("Cfwd_Busy_Act_Code");
            Cfwd_Busy_Act_Code.Attributes.Append(naAttribute);
            Cfwd_Busy_Act_Code.InnerText = _serviceActivationCodes._Cfwd_Busy_Act_Code;
            flatProfileNode.AppendChild(Cfwd_Busy_Act_Code);

            // Cfwd_Busy_Deact_Code
            var Cfwd_Busy_Deact_Code = configMACDocument.CreateElement("Cfwd_Busy_Deact_Code");
            Cfwd_Busy_Deact_Code.Attributes.Append(naAttribute);
            Cfwd_Busy_Deact_Code.InnerText = _serviceActivationCodes._Cfwd_Busy_Deact_Code;
            flatProfileNode.AppendChild(Cfwd_Busy_Deact_Code);

            // Cfwd_No_Ans_Act_Code
            var Cfwd_No_Ans_Act_Code = configMACDocument.CreateElement("Cfwd_No_Ans_Act_Code");
            Cfwd_No_Ans_Act_Code.Attributes.Append(naAttribute);
            Cfwd_No_Ans_Act_Code.InnerText = _serviceActivationCodes._Cfwd_No_Ans_Act_Code;
            flatProfileNode.AppendChild(Cfwd_No_Ans_Act_Code);

            // Cfwd_No_Ans_Deact_Code
            var Cfwd_No_Ans_Deact_Code = configMACDocument.CreateElement("Cfwd_No_Ans_Deact_Code");
            Cfwd_No_Ans_Deact_Code.Attributes.Append(naAttribute);
            Cfwd_No_Ans_Deact_Code.InnerText = _serviceActivationCodes._Cfwd_No_Ans_Deact_Code;
            flatProfileNode.AppendChild(Cfwd_No_Ans_Deact_Code);

            // CW_Act_Code
            var CW_Act_Code = configMACDocument.CreateElement("CW_Act_Code");
            CW_Act_Code.Attributes.Append(naAttribute);
            CW_Act_Code.InnerText = _serviceActivationCodes._CW_Act_Code;
            flatProfileNode.AppendChild(CW_Act_Code);

            // CW_Deact_Code
            var CW_Deact_Code = configMACDocument.CreateElement("CW_Deact_Code");
            CW_Deact_Code.Attributes.Append(naAttribute);
            CW_Deact_Code.InnerText = _serviceActivationCodes._CW_Deact_Code;
            flatProfileNode.AppendChild(CW_Deact_Code);

            // CW_Per_Call_Act_Code
            var CW_Per_Call_Act_Code = configMACDocument.CreateElement("CW_Per_Call_Act_Code");
            CW_Per_Call_Act_Code.Attributes.Append(naAttribute);
            CW_Per_Call_Act_Code.InnerText = _serviceActivationCodes._CW_Per_Call_Act_Code;
            flatProfileNode.AppendChild(CW_Per_Call_Act_Code);

            // CW_Per_Call_Deact_Code
            var CW_Per_Call_Deact_Code = configMACDocument.CreateElement("CW_Per_Call_Deact_Code");
            CW_Per_Call_Deact_Code.Attributes.Append(naAttribute);
            CW_Per_Call_Deact_Code.InnerText = _serviceActivationCodes._CW_Per_Call_Deact_Code;
            flatProfileNode.AppendChild(CW_Per_Call_Deact_Code);

            // Block_CID_Act_Code
            var Block_CID_Act_Code = configMACDocument.CreateElement("Block_CID_Act_Code");
            Block_CID_Act_Code.Attributes.Append(naAttribute);
            Block_CID_Act_Code.InnerText = _serviceActivationCodes._Block_CID_Act_Code;
            flatProfileNode.AppendChild(Block_CID_Act_Code);

            // Block_CID_Deact_Code
            var Block_CID_Deact_Code = configMACDocument.CreateElement("Block_CID_Deact_Code");
            Block_CID_Deact_Code.Attributes.Append(naAttribute);
            Block_CID_Deact_Code.InnerText = _serviceActivationCodes._Block_CID_Deact_Code;
            flatProfileNode.AppendChild(Block_CID_Deact_Code);

            // Block_CID_Per_Call_Act_Code
            var Block_CID_Per_Call_Act_Code = configMACDocument.CreateElement("Block_CID_Per_Call_Act_Code");
            Block_CID_Per_Call_Act_Code.Attributes.Append(naAttribute);
            Block_CID_Per_Call_Act_Code.InnerText = _serviceActivationCodes._Block_CID_Per_Call_Act_Code;
            flatProfileNode.AppendChild(Block_CID_Per_Call_Act_Code);

            // Block_CID_Per_Call_Deact_Code
            var Block_CID_Per_Call_Deact_Code = configMACDocument.CreateElement("Block_CID_Per_Call_Deact_Code");
            Block_CID_Per_Call_Deact_Code.Attributes.Append(naAttribute);
            Block_CID_Per_Call_Deact_Code.InnerText = _serviceActivationCodes._Block_CID_Per_Call_Deact_Code;
            flatProfileNode.AppendChild(Block_CID_Per_Call_Deact_Code);

            // Block_ANC_Act_Code
            var Block_ANC_Act_Code = configMACDocument.CreateElement("Block_ANC_Act_Code");
            Block_ANC_Act_Code.Attributes.Append(naAttribute);
            Block_ANC_Act_Code.InnerText = _serviceActivationCodes._Block_ANC_Act_Code;
            flatProfileNode.AppendChild(Block_ANC_Act_Code);

            // Block_ANC_Deact_Code
            var Block_ANC_Deact_Code = configMACDocument.CreateElement("Block_ANC_Deact_Code");
            Block_ANC_Deact_Code.Attributes.Append(naAttribute);
            Block_ANC_Deact_Code.InnerText = _serviceActivationCodes._Block_ANC_Deact_Code;
            flatProfileNode.AppendChild(Block_ANC_Deact_Code);

            // DND_Act_Code
            var DND_Act_Code = configMACDocument.CreateElement("DND_Act_Code");
            DND_Act_Code.Attributes.Append(naAttribute);
            DND_Act_Code.InnerText = _serviceActivationCodes._DND_Act_Code;
            flatProfileNode.AppendChild(DND_Act_Code);

            // DND_Deact_Code
            var DND_Deact_Code = configMACDocument.CreateElement("DND_Deact_Code");
            DND_Deact_Code.Attributes.Append(naAttribute);
            DND_Deact_Code.InnerText = _serviceActivationCodes._DND_Deact_Code;
            flatProfileNode.AppendChild(DND_Deact_Code);

            // Secure_All_Call_Act_Code
            var Secure_All_Call_Act_Code = configMACDocument.CreateElement("Secure_All_Call_Act_Code");
            Secure_All_Call_Act_Code.Attributes.Append(naAttribute);
            Secure_All_Call_Act_Code.InnerText = _serviceActivationCodes._Secure_All_Call_Act_Code;
            flatProfileNode.AppendChild(Secure_All_Call_Act_Code);

            // Secure_No_Call_Act_Code
            var Secure_No_Call_Act_Code = configMACDocument.CreateElement("Secure_No_Call_Act_Code");
            Secure_No_Call_Act_Code.Attributes.Append(naAttribute);
            Secure_No_Call_Act_Code.InnerText = _serviceActivationCodes._Secure_No_Call_Act_Code;
            flatProfileNode.AppendChild(Secure_No_Call_Act_Code);

            // Secure_One_Call_Act_Code
            var Secure_One_Call_Act_Code = configMACDocument.CreateElement("Secure_One_Call_Act_Code");
            Secure_One_Call_Act_Code.Attributes.Append(naAttribute);
            Secure_One_Call_Act_Code.InnerText = _serviceActivationCodes._Secure_One_Call_Act_Code;
            flatProfileNode.AppendChild(Secure_One_Call_Act_Code);

            // Secure_One_Call_Deact_Code
            var Secure_One_Call_Deact_Code = configMACDocument.CreateElement("Secure_One_Call_Deact_Code");
            Secure_One_Call_Deact_Code.Attributes.Append(naAttribute);
            Secure_One_Call_Deact_Code.InnerText = _serviceActivationCodes._Secure_One_Call_Deact_Code;
            flatProfileNode.AppendChild(Secure_One_Call_Deact_Code);

            // Paging_Code
            var Paging_Code = configMACDocument.CreateElement("Paging_Code");
            Paging_Code.Attributes.Append(naAttribute);
            Paging_Code.InnerText = _serviceActivationCodes._Paging_Code;
            flatProfileNode.AppendChild(Paging_Code);

            // Call_Park_Code
            var Call_Park_Code = configMACDocument.CreateElement("Call_Park_Code");
            Call_Park_Code.Attributes.Append(naAttribute);
            Call_Park_Code.InnerText = _serviceActivationCodes._Call_Park_Code;
            flatProfileNode.AppendChild(Call_Park_Code);

            // Call_Pickup_Code
            var Call_Pickup_Code = configMACDocument.CreateElement("Call_Pickup_Code");
            Call_Pickup_Code.Attributes.Append(naAttribute);
            Call_Pickup_Code.InnerText = _serviceActivationCodes._Call_Pickup_Code;
            flatProfileNode.AppendChild(Call_Pickup_Code);

            // Call_UnPark_Code
            var Call_UnPark_Code = configMACDocument.CreateElement("Call_UnPark_Code");
            Call_UnPark_Code.Attributes.Append(naAttribute);
            Call_UnPark_Code.InnerText = _serviceActivationCodes._Call_UnPark_Code;
            flatProfileNode.AppendChild(Call_UnPark_Code);

            // Group_Call_Pickup_Code
            var Group_Call_Pickup_Code = configMACDocument.CreateElement("Group_Call_Pickup_Code");
            Group_Call_Pickup_Code.Attributes.Append(naAttribute);
            Group_Call_Pickup_Code.InnerText = _serviceActivationCodes._Group_Call_Pickup_Code;
            flatProfileNode.AppendChild(Group_Call_Pickup_Code);

            // Media_Loopback_Code
            var Media_Loopback_Code = configMACDocument.CreateElement("Media_Loopback_Code");
            Media_Loopback_Code.Attributes.Append(naAttribute);
            Media_Loopback_Code.InnerText = _serviceActivationCodes._Media_Loopback_Code;
            flatProfileNode.AppendChild(Media_Loopback_Code);

            // Referral_Services_Codes
            var Referral_Services_Codes = configMACDocument.CreateElement("Referral_Services_Codes");
            Referral_Services_Codes.Attributes.Append(naAttribute);
            Referral_Services_Codes.InnerText = _serviceActivationCodes._Referral_Services_Codes;
            flatProfileNode.AppendChild(Referral_Services_Codes);

            // Feature_Dial_Services_Codes
            var Feature_Dial_Services_Codes = configMACDocument.CreateElement("Feature_Dial_Services_Codes");
            Feature_Dial_Services_Codes.Attributes.Append(naAttribute);
            Feature_Dial_Services_Codes.InnerText = _serviceActivationCodes._Feature_Dial_Services_Codes;
            flatProfileNode.AppendChild(Feature_Dial_Services_Codes);

            #endregion

            #region Vertical Service Announcement Codes 

            // Service_Annc_Base_Number
            var Service_Annc_Base_Number = configMACDocument.CreateElement("Service_Annc_Base_Number");
            Service_Annc_Base_Number.Attributes.Append(naAttribute);
            Service_Annc_Base_Number.InnerText = _Service_Annc_Base_Number;
            flatProfileNode.AppendChild(Service_Annc_Base_Number);

            // Service_Annc_Extension_Codes
            var Service_Annc_Extension_Codes = configMACDocument.CreateElement("Service_Annc_Extension_Codes");
            Service_Annc_Extension_Codes.Attributes.Append(naAttribute);
            Service_Annc_Extension_Codes.InnerText = _Service_Annc_Extension_Codes;
            flatProfileNode.AppendChild(Service_Annc_Extension_Codes);

            #endregion

            #region Outbound Call Codec Selection Codes

            // Prefer_G711u_Code
            var Prefer_G711u_Code = configMACDocument.CreateElement("Prefer_G711u_Code");
            Prefer_G711u_Code.Attributes.Append(naAttribute);
            Prefer_G711u_Code.InnerText = _Prefer_G711u_Code;
            flatProfileNode.AppendChild(Prefer_G711u_Code);

            // Force_G711u_Code
            var Force_G711u_Code = configMACDocument.CreateElement("Force_G711u_Code");
            Force_G711u_Code.Attributes.Append(naAttribute);
            Force_G711u_Code.InnerText = _Force_G711u_Code;
            flatProfileNode.AppendChild(Force_G711u_Code);

            // Force_G711a_Code
            var Force_G711a_Code = configMACDocument.CreateElement("Force_G711a_Code");
            Force_G711a_Code.Attributes.Append(naAttribute);
            Force_G711a_Code.InnerText = _Force_G711a_Code;
            flatProfileNode.AppendChild(Force_G711a_Code);

            // Prefer_G722_Code
            var Prefer_G722_Code = configMACDocument.CreateElement("Prefer_G722_Code");
            Prefer_G722_Code.Attributes.Append(naAttribute);
            Prefer_G722_Code.InnerText = _Prefer_G722_Code;
            flatProfileNode.AppendChild(Prefer_G722_Code);

            // Force_G722_Code
            var Force_G722_Code = configMACDocument.CreateElement("Force_G722_Code");
            Force_G722_Code.Attributes.Append(naAttribute);
            Force_G722_Code.InnerText = _Force_G722_Code;
            flatProfileNode.AppendChild(Force_G722_Code);

            // Prefer_L16_Code
            var Prefer_L16_Code = configMACDocument.CreateElement("Prefer_L16_Code");
            Prefer_L16_Code.Attributes.Append(naAttribute);
            Prefer_L16_Code.InnerText = _Prefer_L16_Code;
            flatProfileNode.AppendChild(Prefer_L16_Code);

            // Force_L16_Code
            var Force_L16_Code = configMACDocument.CreateElement("Force_L16_Code");
            Force_L16_Code.Attributes.Append(naAttribute);
            Force_L16_Code.InnerText = _Force_L16_Code;
            flatProfileNode.AppendChild(Force_L16_Code);

            // Prefer_G726r32_Code
            var Prefer_G726r32_Code = configMACDocument.CreateElement("Prefer_G726r32_Code");
            Prefer_G726r32_Code.Attributes.Append(naAttribute);
            Prefer_G726r32_Code.InnerText = _Prefer_G726r32_Code;
            flatProfileNode.AppendChild(Prefer_G726r32_Code);

            // Force_G726r32_Code
            var Force_G726r32_Code = configMACDocument.CreateElement("Force_G726r32_Code");
            Force_G726r32_Code.Attributes.Append(naAttribute);
            Force_G726r32_Code.InnerText = _Force_G726r32_Code;
            flatProfileNode.AppendChild(Force_G726r32_Code);

            // Prefer_G729a_Code
            var Prefer_G729a_Code = configMACDocument.CreateElement("Prefer_G729a_Code");
            Prefer_G729a_Code.Attributes.Append(naAttribute);
            Prefer_G729a_Code.InnerText = _Prefer_G729a_Code;
            flatProfileNode.AppendChild(Prefer_G729a_Code);

            // Force_G729a_Code
            var Force_G729a_Code = configMACDocument.CreateElement("Force_G729a_Code");
            Force_G729a_Code.Attributes.Append(naAttribute);
            Force_G729a_Code.InnerText = _Force_G729a_Code;
            flatProfileNode.AppendChild(Force_G729a_Code);

            #endregion

            #region Time

            // Time_Zone
            var Time_Zone = configMACDocument.CreateElement("Time_Zone");
            Time_Zone.Attributes.Append(naAttribute);
            Time_Zone.InnerText = _Time_Zone;
            flatProfileNode.AppendChild(Time_Zone);

            // Time_Offset__HH_mm_
            var Time_Offset__HH_mm_ = configMACDocument.CreateElement("Time_Offset__HH_mm_");
            Time_Offset__HH_mm_.Attributes.Append(naAttribute);
            Time_Offset__HH_mm_.InnerText = _Time_Offset__HH_mm_;
            flatProfileNode.AppendChild(Time_Offset__HH_mm_);

            // Daylight_Saving_Time_Rule
            var Daylight_Saving_Time_Rule = configMACDocument.CreateElement("Daylight_Saving_Time_Rule");
            Daylight_Saving_Time_Rule.Attributes.Append(naAttribute);
            Daylight_Saving_Time_Rule.InnerText = _Daylight_Saving_Time_Rule;
            flatProfileNode.AppendChild(Daylight_Saving_Time_Rule);

            // Daylight_Saving_Time_Enable
            var Daylight_Saving_Time_Enable = configMACDocument.CreateElement("Daylight_Saving_Time_Enable");
            Daylight_Saving_Time_Enable.Attributes.Append(naAttribute);
            Daylight_Saving_Time_Enable.InnerText = _Daylight_Saving_Time_Enable;
            flatProfileNode.AppendChild(Daylight_Saving_Time_Enable);

            #endregion

            #region Language

            // Dictionary_Server_Script
            var Dictionary_Server_Script = configMACDocument.CreateElement("Dictionary_Server_Script");
            Dictionary_Server_Script.Attributes.Append(naAttribute);
            Dictionary_Server_Script.InnerText = _Dictionary_Server_Script;
            flatProfileNode.AppendChild(Dictionary_Server_Script);

            // Language_Selection
            var Language_Selection = configMACDocument.CreateElement("Language_Selection");
            Language_Selection.Attributes.Append(naAttribute);
            Language_Selection.InnerText = _Language_Selection;
            flatProfileNode.AppendChild(Language_Selection);

            #endregion

            #region Misc

            // DTMF_Playback_Level
            var DTMF_Playback_Level = configMACDocument.CreateElement("DTMF_Playback_Level");
            DTMF_Playback_Level.Attributes.Append(naAttribute);
            DTMF_Playback_Level.InnerText = _DTMF_Playback_Level;
            flatProfileNode.AppendChild(DTMF_Playback_Level);

            // DTMF_Playback_Length
            var DTMF_Playback_Length = configMACDocument.CreateElement("DTMF_Playback_Length");
            DTMF_Playback_Length.Attributes.Append(naAttribute);
            DTMF_Playback_Length.InnerText = _DTMF_Playback_Length;
            flatProfileNode.AppendChild(DTMF_Playback_Length);

            // Inband_DTMF_Boost
            var Inband_DTMF_Boost = configMACDocument.CreateElement("Inband_DTMF_Boost");
            Inband_DTMF_Boost.Attributes.Append(naAttribute);
            Inband_DTMF_Boost.InnerText = _Inband_DTMF_Boost;
            flatProfileNode.AppendChild(Inband_DTMF_Boost);

            #endregion

            #region General

            // Subscribe_Expires
            var Subscribe_Expires = configMACDocument.CreateElement("Subscribe_Expires");
            Subscribe_Expires.Attributes.Append(naAttribute);
            Subscribe_Expires.InnerText = _Subscribe_Expires;
            flatProfileNode.AppendChild(Subscribe_Expires);

            // Subscribe_Retry_Interval
            var Subscribe_Retry_Interval = configMACDocument.CreateElement("Subscribe_Retry_Interval");
            Subscribe_Retry_Interval.Attributes.Append(naAttribute);
            Subscribe_Retry_Interval.InnerText = _Subscribe_Retry_Interval;
            flatProfileNode.AppendChild(Subscribe_Retry_Interval);

            // Unit_1_Enable
            var Unit_1_Enable = configMACDocument.CreateElement("Unit_1_Enable");
            Unit_1_Enable.Attributes.Append(naAttribute);
            Unit_1_Enable.InnerText = _Unit_1_Enable;
            flatProfileNode.AppendChild(Unit_1_Enable);

            // Subscribe_Delay
            var Subscribe_Delay = configMACDocument.CreateElement("Subscribe_Delay");
            Subscribe_Delay.Attributes.Append(naAttribute);
            Subscribe_Delay.InnerText = _Subscribe_Delay;
            flatProfileNode.AppendChild(Subscribe_Delay);

            // Unit_2_Enable
            var Unit_2_Enable = configMACDocument.CreateElement("Unit_2_Enable");
            Unit_2_Enable.Attributes.Append(naAttribute);
            Unit_2_Enable.InnerText = _Unit_2_Enable;
            flatProfileNode.AppendChild(Unit_2_Enable);

            // Server_Type
            var Server_Type = configMACDocument.CreateElement("Server_Type");
            Server_Type.Attributes.Append(naAttribute);
            Server_Type.InnerText = _Server_Type;
            flatProfileNode.AppendChild(Server_Type);

            // Test_Mode_Enable
            var Test_Mode_Enable = configMACDocument.CreateElement("Test_Mode_Enable");
            Test_Mode_Enable.Attributes.Append(naAttribute);
            Test_Mode_Enable.InnerText = _Test_Mode_Enable;
            flatProfileNode.AppendChild(Test_Mode_Enable);

            // Attendant_Console_Call_Pickup_Code
            var Attendant_Console_Call_Pickup_Code =
                configMACDocument.CreateElement("Attendant_Console_Call_Pickup_Code");
            Attendant_Console_Call_Pickup_Code.Attributes.Append(naAttribute);
            Attendant_Console_Call_Pickup_Code.InnerText = _Attendant_Console_Call_Pickup_Code;
            flatProfileNode.AppendChild(Attendant_Console_Call_Pickup_Code);

            // BLF_List_URI
            var BLF_List_URI = configMACDocument.CreateElement("BLF_List_URI");
            BLF_List_URI.Attributes.Append(naAttribute);
            BLF_List_URI.InnerText = _BLF_List_URI;
            flatProfileNode.AppendChild(BLF_List_URI);

            // BLF_DNS_Enable
            var BLF_DNS_Enable = configMACDocument.CreateElement("BLF_DNS_Enable");
            BLF_DNS_Enable.Attributes.Append(naAttribute);
            BLF_DNS_Enable.InnerText = _BLF_DNS_Enable;
            flatProfileNode.AppendChild(BLF_DNS_Enable);

            #endregion

            #region Att Console Key LED Pattern

            // Application_LED
            var Application_LED = configMACDocument.CreateElement("Application_LED");
            Application_LED.Attributes.Append(naAttribute);
            Application_LED.InnerText = _Application_LED;
            flatProfileNode.AppendChild(Application_LED);

            // Serv_Subscribe_Failed_LED
            var Serv_Subscribe_Failed_LED = configMACDocument.CreateElement("Serv_Subscribe_Failed_LED");
            Serv_Subscribe_Failed_LED.Attributes.Append(naAttribute);
            Serv_Subscribe_Failed_LED.InnerText = _Serv_Subscribe_Failed_LED;
            flatProfileNode.AppendChild(Serv_Subscribe_Failed_LED);

            // Serv_Subscribing_LED
            var Serv_Subscribing_LED = configMACDocument.CreateElement("Serv_Subscribing_LED");
            Serv_Subscribing_LED.Attributes.Append(naAttribute);
            Serv_Subscribing_LED.InnerText = _Serv_Subscribing_LED;
            flatProfileNode.AppendChild(Serv_Subscribing_LED);

            // SNRM_Day_Mode_LED
            var SNRM_Day_Mode_LED = configMACDocument.CreateElement("SNRM_Day_Mode_LED");
            SNRM_Day_Mode_LED.Attributes.Append(naAttribute);
            SNRM_Day_Mode_LED.InnerText = _SNRM_Day_Mode_LED;
            flatProfileNode.AppendChild(SNRM_Day_Mode_LED);

            // SNRM_Night_Mode_LED
            var SNRM_Night_Mode_LED = configMACDocument.CreateElement("SNRM_Night_Mode_LED");
            SNRM_Night_Mode_LED.Attributes.Append(naAttribute);
            SNRM_Night_Mode_LED.InnerText = _SNRM_Night_Mode_LED;
            flatProfileNode.AppendChild(SNRM_Night_Mode_LED);

            // Parking_Lot_Idle_LED
            var Parking_Lot_Idle_LED = configMACDocument.CreateElement("Parking_Lot_Idle_LED");
            Parking_Lot_Idle_LED.Attributes.Append(naAttribute);
            Parking_Lot_Idle_LED.InnerText = _Parking_Lot_Idle_LED;
            flatProfileNode.AppendChild(Parking_Lot_Idle_LED);

            // Parking_Lot_Busy_LED
            var Parking_Lot_Busy_LED = configMACDocument.CreateElement("Parking_Lot_Busy_LED");
            Parking_Lot_Busy_LED.Attributes.Append(naAttribute);
            Parking_Lot_Busy_LED.InnerText = _Parking_Lot_Busy_LED;
            flatProfileNode.AppendChild(Parking_Lot_Busy_LED);

            // BLF_Idle_LED
            var BLF_Idle_LED = configMACDocument.CreateElement("BLF_Idle_LED");
            BLF_Idle_LED.Attributes.Append(naAttribute);
            BLF_Idle_LED.InnerText = _BLF_Idle_LED;
            flatProfileNode.AppendChild(BLF_Idle_LED);

            // BLF_Ringing_LED
            var BLF_Ringing_LED = configMACDocument.CreateElement("BLF_Ringing_LED");
            BLF_Ringing_LED.Attributes.Append(naAttribute);
            BLF_Ringing_LED.InnerText = _BLF_Ringing_LED;
            flatProfileNode.AppendChild(BLF_Ringing_LED);

            // BLF_Busy_LED
            var BLF_Busy_LED = configMACDocument.CreateElement("BLF_Busy_LED");
            BLF_Busy_LED.Attributes.Append(naAttribute);
            BLF_Busy_LED.InnerText = _BLF_Busy_LED;
            flatProfileNode.AppendChild(BLF_Busy_LED);

            // BLF_Held_LED
            var BLF_Held_LED = configMACDocument.CreateElement("BLF_Held_LED");
            BLF_Held_LED.Attributes.Append(naAttribute);
            BLF_Held_LED.InnerText = _BLF_Held_LED;
            flatProfileNode.AppendChild(BLF_Held_LED);

            #endregion

            #region Attendant Console Line Keyes

            if (attConsole1LineKeys != null)
            {
                var l = 1;
                foreach (var lineKey1 in attConsole1LineKeys)
                {
                    // Unit_1_Key_1
                    var Unit_1_Key_1 = configMACDocument.CreateElement(string.Format("Unit_1_Key_{0}", l));
                    Unit_1_Key_1.Attributes.Append(naAttribute);
                    Unit_1_Key_1.InnerText = lineKey1.key;
                    flatProfileNode.AppendChild(Unit_1_Key_1);
                    l++;
                }
            }

            if (attConsole2LineKeys != null)
            {
                var m = 1;
                foreach (var lineKey2 in attConsole2LineKeys)
                {
                    // Unit_2_Key_1
                    var Unit_2_Key_1 = configMACDocument.CreateElement(string.Format("Unit_2_Key_{0}", m));
                    Unit_2_Key_1.Attributes.Append(naAttribute);
                    Unit_2_Key_1.InnerText = lineKey2.key;
                    flatProfileNode.AppendChild(Unit_2_Key_1);
                    m++;
                }
            }

            #endregion

            configMACDocument.AppendChild(flatProfileNode);

            CheckAndCreateConfigsDir();
            using (var fileStream = new FileStream(string.Format(@"Configs//spa{0}.xml", MAC), FileMode.Create))
            {
                configMACDocument.Save(fileStream);

                fileStream.Flush(true);
                return fileStream.Name;
            }
        }

        public string GenerateSpa525File(bool ResyncOnReset, int ResyncPeriod, string ProfileRule)
        {
            _Profile_Rule = ProfileRule;
            var spa525cfgDocument = new XmlDocument();
            XmlNode docNode = spa525cfgDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            spa525cfgDocument.AppendChild(docNode);

            XmlNode flatProfileNode = spa525cfgDocument.CreateElement("flat-profile");

            XmlNode resyncNode = spa525cfgDocument.CreateElement("Resync_On_Reset");
            resyncNode.InnerText = ResyncOnReset.ToString();

            flatProfileNode.AppendChild(resyncNode);

            XmlNode resyncPeriodNode = spa525cfgDocument.CreateElement("Resync_Periodic");
            resyncPeriodNode.InnerText = ResyncPeriod.ToString();

            flatProfileNode.AppendChild(resyncPeriodNode);

            XmlNode profileRuleNode = spa525cfgDocument.CreateElement("Profile_Rule");
            profileRuleNode.InnerText = ProfileRule;

            flatProfileNode.AppendChild(profileRuleNode);


            spa525cfgDocument.AppendChild(flatProfileNode);

            CheckAndCreateConfigsDir();
            using (var fileStream = new FileStream(@"Configs//spa525G2.cfg", FileMode.Create))
            {

                spa525cfgDocument.Save(fileStream);

                fileStream.Flush(true);
                return fileStream.Name;
            }



        }

        /// <summary>
        /// Gets Current list of WifiProfiles
        /// </summary>
        /// <returns>List of current WifiProfiles</returns>
        public List<WifiProfile> GetWifiProfiles()
        {
            return wifiProfiles;
        }

        /// <summary>
        /// Is the phone ReadOnly
        /// </summary>
        /// <param name="IsReadOnly">"Yes" |"No"</param>
        public void IsPhoneReadOnly(string IsReadOnly)
        {
            _SPA525readonly = IsReadOnly;
        }

        /// <summary>
        /// Set custom Log Messages
        /// </summary>
        /// <param name="ResyncRequestMsg">Message On Resync Request</param>
        /// <param name="ResyncSuccsessMsg">Message On Resync Sucsess</param>
        /// <param name="resyncFailMsg">Message on resynk Fail</param>
        /// <param name="reportRule"></param>
        /// <param name="UpgrageSuccessMsg">Message on upgrade Succsess</param>
        /// <param name="UpgradeRequestMsg">Message on upgrade Request</param>
        /// <param name="UpgradeFailMsg">Message on upgrade Fail</param>
        public void SetCustomLogMessages(string ResyncRequestMsg, string ResyncSuccsessMsg, string resyncFailMsg,
            string reportRule, string UpgrageSuccessMsg, string UpgradeRequestMsg, string UpgradeFailMsg)
        {
            _Log_Resync_Request_Msg = ResyncRequestMsg;
            _Log_Resync_Success_Msg = ResyncSuccsessMsg;
            _Log_Resync_Failure_Msg = resyncFailMsg;
            _Report_Rule = reportRule;
            _Log_Upgrade_Failure_Msg = UpgradeFailMsg;
            _Log_Upgrade_Request_Msg = UpgradeRequestMsg;
            _Log_Resync_Success_Msg = UpgrageSuccessMsg;

        }

        // TODO: Add summary
        public void SetGeneralSettings(string stationName, string stationDisplayName, string voiceMailNum)
        {
            _Station_Name = stationName;
            _Station_Display_Name = stationDisplayName;
            _Voice_Mail_Number = voiceMailNum;
        }

        /// <summary>
        /// Setts License key
        /// </summary>
        /// <param name="LicenceKeyes">String of licencekeyes</param>
        public void SetLicenceKeys(string LicenceKeyes)
        {
            _License_Keys = LicenceKeyes;
        }

        /// <summary>
        /// Setts the path to ProfileRule
        /// Eks."/xml/spa$PSN.cfg"
        /// </summary>
        /// <param name="ProfileRule">Path to ProfileRuleA</param>
        /// <param name="ProfileRuleB">Path to ProfileRuleB</param>
        /// <param name="ProfileRuleC">Path to ProfileRuleC</param>
        /// <param name="ProfileRuleD">Path to ProfileRuleD</param>
        public void SetProfileRules(string ProfileRule, string ProfileRuleB, string ProfileRuleC, string ProfileRuleD)
        {
            _Profile_Rule = ProfileRule;
            _Profile_Rule_B = ProfileRuleB;
            _Profile_Rule_C = ProfileRuleC;
            _Profile_Rule_D = ProfileRuleD;
        }

        /// <summary>
        /// Setts Protocoll For phones
        /// </summary>
        /// <param name="phoneProtocolType"> Sip | SCCP </param>
        /// <param name="EnableSCCPAutodetect">Enable Autodetect of SCCP Protocoll</param>
        public void SetProtocoll(PhoneProtocolType phoneProtocolType, string EnableSCCPAutodetect)
        {
            _phoneProtocolType = phoneProtocolType;

            _SPA525autodetectsccp = EnableSCCPAutodetect;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SIT1RSC"></param>
        /// <param name="SIT2RSC"></param>
        /// <param name="SIT3RSC"></param>
        /// <param name="SIT4RSC"></param>
        /// <param name="TryBackupRSC"></param>
        /// <param name="RetryRegRSC"></param>
        public void SetRSC(string SIT1RSC, string SIT2RSC, string SIT3RSC, string SIT4RSC, string TryBackupRSC,
            string RetryRegRSC)
        {
            _SIT1_RSC = SIT1RSC;
            _SIT2_RSC = SIT2RSC;
            _SIT3_RSC = SIT3RSC;
            _SIT4_RSC = SIT4RSC;
            _Try_Backup_RSC = TryBackupRSC;
            _Retry_Reg_RSC = RetryRegRSC;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RTPPortMin"></param>
        /// <param name="RTPPortMax"></param>
        /// <param name="RTPPacketSize"></param>
        /// <param name="MaxRTPICMPErr"></param>
        /// <param name="RTCPTxInterval"></param>
        /// <param name="NoUDPChecksum"></param>
        /// <param name="SymmetricRTP"></param>
        /// <param name="StatsInBYE"></param>
        public void SetRTPParam(string RTPPortMin, string RTPPortMax, string RTPPacketSize, string MaxRTPICMPErr,
            string RTCPTxInterval, string NoUDPChecksum, string SymmetricRTP, string StatsInBYE)
        {
            _RTP_Port_Min = RTPPortMin;
            _RTP_Port_Max = RTPPortMax;
            _RTP_Packet_Size = RTPPacketSize;
            _Max_RTP_ICMP_Err = MaxRTPICMPErr;
            _RTCP_Tx_Interval = RTCPTxInterval;
            _No_UDP_Checksum = NoUDPChecksum;
            _Symmetric_RTP = SymmetricRTP;
            _Stats_In_BYE = StatsInBYE;
        }

        /// <summary>
        /// Set Screeen Settings
        /// </summary>
        /// <param name="ScreenSaverEnable"></param>
        /// <param name="ScreenSaverType"></param>
        /// <param name="ScreenSaverTriggerTime"></param>
        /// <param name="ScreenSaverRefreshTime"></param>
        /// <param name="BackLightEnable"></param>
        /// <param name="BackLightTimersec"></param>
        /// <param name="LCDContrast"></param>
        /// <param name="LogoType"></param>
        /// <param name="TextLogo"></param>
        /// <param name="BackgroundPictureType"></param>
        /// <param name="BMPPictureDownload_URL"></param>
        public void setScreenSettings(string ScreenSaverEnable, string ScreenSaverType, string ScreenSaverTriggerTime,
            string ScreenSaverRefreshTime, string BackLightEnable, string BackLightTimersec, string LCDContrast,
            string LogoType, string TextLogo, string BackgroundPictureType, string BMPPictureDownload_URL)
        {
            _Screen_Saver_Enable = ScreenSaverEnable;
            _Screen_Saver_Type = ScreenSaverType;
            _Screen_Saver_Trigger_Time = ScreenSaverTriggerTime;
            _Screen_Saver_Refresh_Time = ScreenSaverRefreshTime;
            _Back_Light_Enable = BackLightEnable;
            _Back_Light_Timer__sec_ = BackLightTimersec;
            _LCD_Contrast = LCDContrast;
            _Logo_Type = LogoType;
            _Text_Logo = TextLogo;
            _BMP_Picture_Download_URL = BMPPictureDownload_URL;
        }

        /// <summary>
        /// Sets SDP Payloads
        /// </summary>
        /// <param name="AVTDynamicPayload"></param>
        /// <param name="INFOREQDynamicPayload"></param>
        /// <param name="G726r16DynamicPayload"></param>
        /// <param name="G726r24DynamicPayload"></param>
        /// <param name="G726r32DynamicPayload"></param>
        /// <param name="G726r40DynamicPayload"></param>
        /// <param name="G729bDynamicPayload"></param>
        /// <param name="L16DynamicPayload"></param>
        /// <param name="EncapRTPDynamicPayload"></param>
        /// <param name="RTPStartLoopbackDynamicPayload"></param>
        /// <param name="RTPStartLoopback_Codec"></param>
        /// <param name="AVTCodecName"></param>
        /// <param name="G711uCodecName"></param>
        /// <param name="G711aCodecName"></param>
        /// <param name="G726r32CodecName"></param>
        /// <param name="G729aCodecName"></param>
        /// <param name="G729bCodecName"></param>
        /// <param name="G722CodecName"></param>
        /// <param name="L16CodecName"></param>
        /// <param name="EncapRTPCodecName"></param>
        public void SetSDPPayloads(string AVTDynamicPayload = "101", string INFOREQDynamicPayload = "",
            string G726r16DynamicPayload = "98", string G726r24DynamicPayload = "97", string G726r32DynamicPayload = "2",
            string G726r40DynamicPayload = "96", string G729bDynamicPayload = "99", string L16DynamicPayload = "104",
            string EncapRTPDynamicPayload = "112", string RTPStartLoopbackDynamicPayload = "113",
            string RTPStartLoopback_Codec = "G711u", string AVTCodecName = "telephone-event",
            string G711uCodecName = "PCMU", string G711aCodecName = "PCMA", string G726r32CodecName = "G726-32",
            string G729aCodecName = "G729a", string G729bCodecName = "G729ab", string G722CodecName = "G722",
            string L16CodecName = "L16", string EncapRTPCodecName = "encaprtp")
        {
            _AVT_Dynamic_Payload = AVTDynamicPayload;
            _INFOREQ_Dynamic_Payload = INFOREQDynamicPayload;
            _G726r16_Dynamic_Payload = G726r16DynamicPayload;
            _G726r24_Dynamic_Payload = G726r24DynamicPayload;
            _G726r32_Dynamic_Payload = G726r32DynamicPayload;
            _G726r40_Dynamic_Payload = G726r40DynamicPayload;
            _G729b_Dynamic_Payload = G729bDynamicPayload;
            _L16_Dynamic_Payload = L16DynamicPayload;
            _EncapRTP_Dynamic_Payload = EncapRTPDynamicPayload;
            _RTP_Start_Loopback_Dynamic_Payload = RTPStartLoopbackDynamicPayload;
            _RTP_Start_Loopback_Codec = RTPStartLoopback_Codec;
            _AVT_Codec_Name = AVTCodecName;
            _G711u_Codec_Name = G711uCodecName;
            _G711a_Codec_Name = G711aCodecName;
            _G726r32_Codec_Name = G726r32CodecName;
            _G729a_Codec_Name = G729aCodecName;
            _G729b_Codec_Name = G729bCodecName;
            _G722_Codec_Name = G722CodecName;
            _L16_Codec_Name = L16CodecName;
            _EncapRTP_Codec_Name = EncapRTPCodecName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="INVITEExpires"></param>
        /// <param name="ReINVITEExpires"></param>
        /// <param name="RegMinExpires"></param>
        /// <param name="RegMaxExpires"></param>
        /// <param name="RegRetryIntvl"></param>
        /// <param name="RegRetryLongIntvl"></param>
        /// <param name="RegRetryRandomDelay"></param>
        /// <param name="RegRetryLongRandomDelay"></param>
        /// <param name="RegRetryIntvlCap"></param>
        /// <param name="SubMinExpires"></param>
        /// <param name="SubMaxExpires"></param>
        /// <param name="SubRetryIntvl"></param>
        public void SetSipExpiery(string INVITEExpires, string ReINVITEExpires, string RegMinExpires,
            string RegMaxExpires, string RegRetryIntvl, string RegRetryLongIntvl, string RegRetryRandomDelay,
            string RegRetryLongRandomDelay, string RegRetryIntvlCap, string SubMinExpires, string SubMaxExpires,
            string SubRetryIntvl)
        {
            _INVITE_Expires = INVITEExpires;
            _ReINVITE_Expires = ReINVITEExpires;
            _Reg_Min_Expires = RegMinExpires;
            _Reg_Max_Expires = RegMaxExpires;
            _Reg_Retry_Intvl = RegRetryIntvl;
            _Reg_Retry_Long_Intvl = RegRetryLongIntvl;
            _Reg_Retry_Random_Delay = RegRetryRandomDelay;
            _Reg_Retry_Long_Random_Delay = RegRetryLongRandomDelay;
            _Reg_Retry_Intvl_Cap = RegRetryIntvlCap;
            _Sub_Min_Expires = SubMinExpires;
            _Sub_Max_Expires = SubMaxExpires;
            _Sub_Retry_Intvl = SubRetryIntvl;
        }

        /// <summary>
        /// Setts Sip TimerValues 
        /// </summary>
        /// <param name="SIPT1"></param>
        /// <param name="SIPT2"></param>
        /// <param name="SIPT4"></param>
        /// <param name="SIPTimerB"></param>
        /// <param name="SIPTimerF"></param>
        /// <param name="SIPTimerH"></param>
        /// <param name="SIPTimerD"></param>
        /// <param name="SIPTimerJ"></param>
        public void SetSipTimers(string SIPT1,
            string SIPT2, string SIPT4, string SIPTimerB, string SIPTimerF, string SIPTimerH, string SIPTimerD,
            string SIPTimerJ)
        {
            _SIP_T1 = SIPT1;
            _SIP_T2 = SIPT2;
            _SIP_T4 = SIPT4;
            _SIP_Timer_B = SIPTimerB;
            _SIP_Timer_F = SIPTimerF;
            _SIP_Timer_H = SIPTimerH;
            _SIP_Timer_D = SIPTimerD;
            _SIP_Timer_J = SIPTimerJ;
        }

        /// <summary>
        /// Set the Phones SpeedDial
        /// </summary>
        /// <param name="SpeedDial2"></param>
        /// <param name="SpeedDial3"></param>
        /// <param name="SpeedDial4"></param>
        /// <param name="SpeedDial5"></param>
        /// <param name="SpeedDial6"></param>
        /// <param name="SpeedDial7"></param>
        /// <param name="SpeedDial8"></param>
        /// <param name="SpeedDial9"></param>
        public void SetSpeedDials(string SpeedDial2, string SpeedDial3, string SpeedDial4, string SpeedDial5,
           string SpeedDial6, string SpeedDial7, string SpeedDial8, string SpeedDial9)
        {
            _Speed_Dial_2 = SpeedDial2;
            _Speed_Dial_3 = SpeedDial3;
            _Speed_Dial_4 = SpeedDial4;
            _Speed_Dial_5 = SpeedDial5;
            _Speed_Dial_6 = SpeedDial6;
            _Speed_Dial_7 = SpeedDial7;
            _Speed_Dial_8 = SpeedDial8;
            _Speed_Dial_9 = SpeedDial9;
        }

        /// <summary>
        /// Setts Time and Date format on thephone
        /// </summary>
        /// <param name="TimeFormat">| "12hr" | "24hr" |</param>
        /// <param name="DateFormat">| "day/month" | "month/day" |</param>
        public void SetTimeandDateFormat(string TimeFormat, string DateFormat)
        {
            _Time_Format = TimeFormat;
            _Date_Format = DateFormat;
        }

        /// <summary>
        /// Setts the TransportProtocol for provisoning
        /// </summary>
        /// <param name="protocol">Protocol to use, |"tftp" |"http" |"https" |"none" |</param>
        public void SetTransportProtocol(string protocol)
        {
            _Transport_Protocol = protocol;
        }

        /// <summary>
        /// Setts networkingoptions In Phone
        /// </summary>
        /// <param name="HostName">Hostname of the phone </param>
        /// <param name="Domain">Phones belonging Domain</param>
        /// <param name="PrimaryDns">Primary DNS Server</param>
        /// <param name="SecondaryDns">Secondary DNS Server</param>
        /// <param name="dnsServerOrder"> DNS Serverorder,|"Manual" |"Manual,DHCP" |"DHCP,Manual" |</param>
        /// <param name="EnableBounjor">Enable Bonjour</param>
        /// <param name="SyslogServer">Address of syslog Server</param>
        /// <param name="DebugServer">Address Of Debug Server</param>
        /// <param name="debugLevel">Verbosety of Debug output, | 0 | 1 | 2 | 3 |</param>
        public void SetupNetwork(string HostName, string Domain, string PrimaryDns, string SecondaryDns,
            string dnsServerOrder, string EnableBounjor, string SyslogServer, string DebugServer, int debugLevel)
        {
            _hostName = HostName;
            _domain = Domain;
            _primary_DNS = PrimaryDns;
            _secondary_DNS = SecondaryDns;
            _DNS_serverorder = dnsServerOrder;
            _enableBonjour = EnableBounjor;
            _syslogServer = SyslogServer;
            _debugServer = DebugServer;
            _debugLevel = debugLevel.ToString();


        }

        /// <summary>
        /// SettUp NTP
        /// </summary>
        /// <param name="Enabeled">"Yes" |"No"</param>
        /// <param name="PrimaryNtpServer">Address of Primary NtpServer</param>
        /// <param name="SecondaryNtpServer">Address of Secondary NtpServer</param>
        public void SetupNTP(string Enabeled, string PrimaryNtpServer, string SecondaryNtpServer)
        {
            _NTPEnabeled = Enabeled;
            _primaryNTPServer = PrimaryNtpServer;
            _secondaryNTPServer = SecondaryNtpServer;
        }

        /// <summary>
        /// Sets the phones VolumeLevels
        /// </summary>
        /// <param name="ringerVolume"></param>
        /// <param name="speekerVolume"></param>
        /// <param name="handsetVolume"></param>
        /// <param name="headsetVolume"></param>
        /// <param name="bluetoothVolume"></param>
        public void SetVolumes(int ringerVolume, int speekerVolume, int handsetVolume, int headsetVolume,
           int bluetoothVolume)
        {
            _Ringer_Volume = ringerVolume.ToString();
            _Bluetooth_Volume = bluetoothVolume.ToString();
            _Handset_Volume = handsetVolume.ToString();
            _Headset_Volume = headsetVolume.ToString();
            _Speaker_Volume = speekerVolume.ToString();
        }

        /// <summary>
        /// Sets the Phones RSS Feeds
        /// </summary>
        /// <param name="RSSFeedURL1"> Format: "Name= ; url= "</param>
        /// <param name="RSSFeedURL2"></param>
        /// <param name="RSSFeedURL3"></param>
        /// <param name="RSSFeedURL4"></param>
        /// <param name="RSSFeedURL5"></param>
        /// <param name="TempratureUnit">| "Fahrenheit" | "Celsius" | </param>
        public void SetWebInformationServiceSettings(string RSSFeedURL1, string RSSFeedURL2, string RSSFeedURL3,
            string RSSFeedURL4, string RSSFeedURL5, string TempratureUnit)
        {
            _RSS_Feed_URL_1 = RSSFeedURL1;
            _RSS_Feed_URL_2 = RSSFeedURL2;
            _RSS_Feed_URL_3 = RSSFeedURL3;
            _RSS_Feed_URL_4 = RSSFeedURL4;
            _RSS_Feed_URL_5 = RSSFeedURL5;
            _Weather_Temperature_Unit = TempratureUnit;
        }

        /// <summary>
        /// Configure Firmware Upgrades
        /// </summary>
        /// <param name="EnableUpgrade">|"Yes |"No" |</param>
        /// <param name="UpgradeRetryDelay">Delay Between Upgrade Retry Attempts</param>
        /// <param name="DowngradeRevLimit">Rev Limit For Downgrading</param>
        /// <param name="UpgradeRule">UpgradeRule</param>
        public void UpdateFirmwareUpgradeConfig(string EnableUpgrade, string UpgradeRetryDelay, string DowngradeRevLimit,
            string UpgradeRule)
        {
            _Upgrade_Enable = EnableUpgrade;
            _Upgrade_Error_Retry_Delay = UpgradeRetryDelay;
            _Downgrade_Rev_Limit = DowngradeRevLimit;
            _Upgrade_Rule = UpgradeRule;
        }

        /// <summary>
        /// VLanSettings For Phone
        /// </summary>
        /// <param name="EnableVLAN">"Yes" |"No"</param>
        /// <param name="PhoneVLANId">Phone Vlan ID</param>
        /// <param name="PcPortHigestPriorety">"0","1","2","3","4","5","6","7","No Limit"</param>
        /// <param name="EnablePcPortVlanTagging">"Yes" |"No"</param>
        /// <param name="PcPortVlanID">PC Vlan Id</param>
        public void VLANConfig(string EnableVLAN, int PhoneVLANId, string PcPortHigestPriorety, string EnablePcPortVlanTagging,
           int PcPortVlanID)
        {
            _EnableVLAN = EnableVLAN;
            _VLANID = PhoneVLANId.ToString();
            _PC_Port_VLAN_Highest_Priority = PcPortHigestPriorety;
            _Enable_PC_Port_VLAN_Tagging = EnablePcPortVlanTagging;
            _PC_Port_VLAN_ID = PcPortVlanID.ToString();
        }

        /// <summary>
        /// Enables or Disables Webserver in the phone
        /// </summary>
        /// <param name="isEnabled"> Yes or No</param>
        /// <param name="Port">The port weberser is running on eks. 80 </param>
        /// <param name="EnableWebAdmin">Is Web Admin Enabeled, Yes | No</param>
        /// <param name="AdminPassword">Administrator Password, Send"" for none</param>
        /// <param name="UserPassword">User Password, Send"" for none</param>
        public void WebServerConfig(string isEnabled, int Port, string EnableWebAdmin, string AdminPassword, string UserPassword)
        {
            _Enable_Web_Server = isEnabled;
            _Web_Server_Port = Port.ToString();
            _Enable_Web_Admin_Access = EnableWebAdmin;
            _Admin_Password = AdminPassword;
            _User_Password = UserPassword;

        }

        private void CheckAndCreateConfigsDir()
        {
            var configPath = @"Configs//";

            var exists = Directory.Exists(configPath);

            if (!exists)
                Directory.CreateDirectory(configPath);
        }
    }
}