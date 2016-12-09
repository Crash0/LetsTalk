using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Telephony.PhoneConfig
{
    public class Extension
    {
        public Extension(string extension)
        {
            // TODO: Complete member initialization
            this.ExtensionName = extension;
        }

        public Extension(string extension, string password)
        {
            // TODO: Complete member initialization
            this.ExtensionName = extension;
            Secret = password;
        }

        public string Avpf { get; set; }

        public string Callcounter { get; set; }

        public string Callerid { get; set; }

        public string Callgroup { get; set; }

        public string Canreinvite { get; set; }

        public string Cc_monitor_policy { get; set; }

        public string Context { get; set; }

        public string Deny { get; set; }

        public string Dial { get; set; }

        public string Dtmfmode { get; set; }

        public string Encryption { get; set; }

        public string ExtensionName { get; private set; }

        public string Faxdetect { get; set; }

        public string Force_avp { get; set; }

        public string Host { get; set; }

        public string Icesupport { get; set; }

        public string Mediaencryption { get; set; }

        public string NAT { get; set; }

        public string Permit { get; set; }

        public string Pickupgroup { get; set; }

        public string Port { get; set; }

        public string Qualify { get; set; }

        public string Qualifyfreq { get; set; }

        public string Secret { get; set; }

        public string Sendrpid { get; set; }

        public string Transport { get; set; }

        public string Trustrpid { get; set; }

        public string Type { get; set; }
    }
}
