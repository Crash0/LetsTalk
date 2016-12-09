namespace LetsTalk.Telephony
{
    public class LineKey
    {
        public string Extended_Function;

        public string Extension = "1";

        public string ShareCallAppearance = "private";

        public string ShortName = "$USER";

        public LineKey(string extension)
        {
            this.Extension = extension;
        }
    }
}