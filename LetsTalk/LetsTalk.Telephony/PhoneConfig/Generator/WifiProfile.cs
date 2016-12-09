namespace LetsTalk.Telephony
{
    public class WifiProfile
    {
        public string anonymousIdentity;

        public string cipherType;

        public string clientCert;

        public string eapType;

        public string identity;

        public string password;

        public string profileEnable;

        public string profileLock;

        public string profileName;

        public string pskKey;

        public string securityMode;

        public string serverCert;

        public string ssid;

        public string ttlsAuthProto;

        public string wepKey0;

        public string wepKey1;

        public string wepKey2;

        public string wepKey3;

        public string wepKeyId;

        public string wepKeyLen;

        public WifiProfile(string profileName, string ssid, string profileEnable)
        {
            this.profileName = profileName;
            this.ssid = ssid;
            this.profileEnable = profileEnable;
        }
    }
}