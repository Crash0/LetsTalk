namespace LetsTalk.Telephony
{
    public class LineExt
    {
        public string AnsCallWithoutReg = "No";

        public string AuthID;

        public string AuthINVITE = "No";

        public string AuthPage = string.Empty;

        public string AuthPagePassword;

        public string AuthPageRealm = "value";

        public string AuthResyncReboot = "Yes";

        // CallFeatue
        public string BlindAttnXferEnable = "No";

        public string CallerIDMap;

        public string CFWDNotifier;

        public string CFWDNotifyServ = "No";

        public string ConferenceBridgeURL;

        public string DefaultRing = "2";

        // Dial Plan
        public string DialPlan = "(*xx|[3469]11|0|00|[2-9]xxxxxx|1xxx[2-9]xxxxxxS0|xxxxxxxxxxxx.)";

        // Subscriber Information
        public string DisplayName;

        public string DNSSRVAutoPrefix = "No";

        public string DTMFProcessAVT = "Yes";

        public string DTMFTxMethod = "Auto";

        public string DTMFTxVolumeforAVTPacket = "0";

        public string EmergencyNumber;

        // General
        public string Enable = "Yes";

        public string EnableIPDialing = "No";

        public string EXTSIPPort = string.Empty;

        public string G722Enable = "Yes";

        public string G72632Enable = "Yes";

        public string G729aEnable = "Yes";

        public string JitterBufferAdjustment = "up and down";

        public string L16Enable = "Yes";

        public string MailboxID;

        public string MakeCallWithoutReg = "No";

        public string MessageWaiting = "No";

        public string MiniCertificate;

        public string MOHServer = string.Empty;

        public string NATKeepAliveDest = "$PROXY";

        public string NATKeepAliveEnable = "No";

        public string NATKeepAliveMsg = "$NOTIFY";

        // NAT Settings
        public string NATMappingEnable = "No";

        public string NetworkJitterLevel = "high";

        public string NtfyReferOn1xxToInv = "Yes";

        public string OutboundProxy;

        public string Password;

        // Audio Config
        public string PreferredCodec = "G711u";

        // Proxy and registration
        public string Proxy;

        public string ProxyFallbackIntvl = "3600";

        public string ProxyRedundancyMethod = "Normal";

        public string RefereeByeDelay = "0";

        public string ReferorByeDelay = "4";

        public string ReferTargetByeDelay = "0";

        public string ReferToTargetContact = "No";

        public string Register = "Yes";

        public string RegisterExpires = "3600";

        public string ReleaseUnusedCodec = "Yes";

        public string RestrictMWI = "No";

        public string RTPCoSValue = "6";

        public string RTPTOSDiffServValue = "0xb8";

        public string SecondPreferredCodec = "Unspecified";

        public string SetG729annexb = "none";

        public string SharedUserID = string.Empty;

        // Share Line Appearance 
        public string ShareExt = "No";

        public string SilenceSuppEnable = "No";

        public string SIP100RELEnable = "No";

        public string SIPCoSValue = "3";

        public string SIPDebugOption = "none";

        public string SIPPort = "5060";

        public string SIPProxyRequire = string.Empty;

        public string SIPRemotePartyID = "No";

        // Network Settings
        public string SIPTOSDiffServValue = "0x68";

        // SIP Settings
        public string SIPTransport = "UDP";

        public string SRTPPrivateKey;

        public string StateAgent;

        public string Sticky183 = "No";

        public string SubscriptionExpires = "3600";

        public string ThirdPreferredCodec = "Unspecified";

        public string UseAnonymousWithRPID = "Yes";

        public string UseAuthID = "No";

        public string UseDefaultRing = "No";

        public string UseDNSSRV = "No";

        public string UseOBProxyInDialog = "Yes";

        public string UseOutboundProxy = "No";

        public string UsePrefCodecOnly = "No";

        public string UserID;

        public string VoiceMailServer;

        public string VoiceMailSubscribeInterval = "86400";

        public LineExt(string proxyServer, string userId, string password)
        {
            this.Proxy = proxyServer;
            this.UserID = userId;
            this.Password = password;

        }
    }
}