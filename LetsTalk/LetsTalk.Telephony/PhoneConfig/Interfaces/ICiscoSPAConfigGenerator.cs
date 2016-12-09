using System.Collections.Generic;

namespace LetsTalk.Telephony
{
    public interface ICiscoSPAConfigGenerator
    {
        void AddCameraProfile(CameraProfile cameraProfile);

        void AddLineExt(LineExt ext);

        void AddLineKey(LineKey key);

        void AddWifiProfile(WifiProfile profile);

        void CDPConfig(string EnableCDP);

        void ConfigureProvisonig(string ProvisonEnabeled, string ResyncOnReset, string ResyncRandomDelay, string ResynkPeriod, string ResyncErrorRetryDelay, string ForcedResynkDelay, string ResynkFromSIP, string UserConfiguraboleResynk, string ResyncAfterUpgrade, string ResyncTrigger1, string ResynkTrigger2, string ResyncFailsOnFNF);

        void DisableBluetooth();

        void EditSipParams(string MaxForward, string MaxRedirection, string MaxAuth, string SIPUserAgentName, string SIPServerName, string SIPRegUserAgentName, string SIPAcceptLanguage, string DTMFRelayMIMEType, string HookFlashMIMEType, string RemoveLastReg, string UseCompactHeader, string EscapeDisplayName, string SIPBEnable, string TalkPackage, string HoldPackage, string ConferencePackage, string NotifyConference, string RFC2543CallHold, string RandomREGCIDOnReboot, string MarkAllAVTPackets, string SIPTCPPortMin, string SIPTCPPortMax, string CTIEnable, string CallerIDHeader, string SRTPMethod, string HoldTargetBeforeREFER);

        void Enable_Restricted_Access_Domains(string Restricted_Access_Domains);

        void EnableBluetoothHandsfree(int Pin);

        void EnableBlutoothPhoneMode(int LineKey, int Pin, string ShortName, string UserFrendlyId);

        void EnableBothBluetooth(int LineKey, int Pin, string ShortName, string UserFrendlyId);

        void EnableVideoVlan(string enableVideoVlan, int videoVLANId);

        void EnableVPN(string VPNServer, string VPNUserName, string VPNPassword, string VPNTunnelGroup, string ConnectOnBoot);

        string GenerateConfigFile();

        string GenerateSpa525File(bool ResyncOnReset, int ResyncPeriod, string ProfileRule);

        List<WifiProfile> GetWifiProfiles();

        void IsPhoneReadOnly(string IsReadOnly);

        void SetCustomLogMessages(string ResyncRequestMsg, string ResyncSuccsessMsg, string resyncFailMsg, string reportRule, string UpgrageSuccessMsg, string UpgradeRequestMsg, string UpgradeFailMsg);

        void SetGeneralSettings(string stationName, string stationDisplayName, string voiceMailNum);

        void SetLicenceKeys(string LicenceKeyes);

        void SetProfileRules(string ProfileRule, string ProfileRuleB, string ProfileRuleC, string ProfileRuleD);

        void SetProtocoll(PhoneProtocolType phoneProtocolType, string EnableSCCPAutodetect);

        void SetRSC(string SIT1RSC, string SIT2RSC, string SIT3RSC, string SIT4RSC, string TryBackupRSC, string RetryRegRSC);

        void SetRTPParam(string RTPPortMin, string RTPPortMax, string RTPPacketSize, string MaxRTPICMPErr, string RTCPTxInterval, string NoUDPChecksum, string SymmetricRTP, string StatsInBYE);

        void setScreenSettings(string ScreenSaverEnable, string ScreenSaverType, string ScreenSaverTriggerTime, string ScreenSaverRefreshTime, string BackLightEnable, string BackLightTimersec, string LCDContrast, string LogoType, string TextLogo, string BackgroundPictureType, string BMPPictureDownload_URL);

        void SetSDPPayloads(string AVTDynamicPayload = "101", string INFOREQDynamicPayload = "", string G726r16DynamicPayload = "98", string G726r24DynamicPayload = "97", string G726r32DynamicPayload = "2", string G726r40DynamicPayload = "96", string G729bDynamicPayload = "99", string L16DynamicPayload = "104", string EncapRTPDynamicPayload = "112", string RTPStartLoopbackDynamicPayload = "113", string RTPStartLoopback_Codec = "G711u", string AVTCodecName = "telephone-event", string G711uCodecName = "PCMU", string G711aCodecName = "PCMA", string G726r32CodecName = "G726-32", string G729aCodecName = "G729a", string G729bCodecName = "G729ab", string G722CodecName = "G722", string L16CodecName = "L16", string EncapRTPCodecName = "encaprtp");

        void SetSipExpiery(string INVITEExpires, string ReINVITEExpires, string RegMinExpires, string RegMaxExpires, string RegRetryIntvl, string RegRetryLongIntvl, string RegRetryRandomDelay, string RegRetryLongRandomDelay, string RegRetryIntvlCap, string SubMinExpires, string SubMaxExpires, string SubRetryIntvl);

        void SetSipTimers(string SIPT1, string SIPT2, string SIPT4, string SIPTimerB, string SIPTimerF, string SIPTimerH, string SIPTimerD, string SIPTimerJ);

        void SetSpeedDials(string SpeedDial2, string SpeedDial3, string SpeedDial4, string SpeedDial5, string SpeedDial6, string SpeedDial7, string SpeedDial8, string SpeedDial9);

        void SetTimeandDateFormat(string TimeFormat, string DateFormat);

        void SetTransportProtocol(string protocol);

        void SetupNetwork(string HostName, string Domain, string PrimaryDns, string SecondaryDns, string dnsServerOrder, string EnableBounjor, string SyslogServer, string DebugServer, int debugLevel);

        void SetupNTP(string Enabeled, string PrimaryNtpServer, string SecondaryNtpServer);

        void SetVolumes(int ringerVolume, int speekerVolume, int handsetVolume, int headsetVolume, int bluetoothVolume);

        void SetWebInformationServiceSettings(string RSSFeedURL1, string RSSFeedURL2, string RSSFeedURL3, string RSSFeedURL4, string RSSFeedURL5, string TempratureUnit);

        void UpdateFirmwareUpgradeConfig(string EnableUpgrade, string UpgradeRetryDelay, string DowngradeRevLimit, string UpgradeRule);

        void VLANConfig(string EnableVLAN, int PhoneVLANId, string PcPortHigestPriorety, string EnablePcPortVlanTagging, int PcPortVlanID);

        void WebServerConfig(string isEnabled, int Port, string EnableWebAdmin, string AdminPassword, string UserPassword);
    }
}