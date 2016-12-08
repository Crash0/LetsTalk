namespace LetsTalk.Telephony
{
    /// <summary>
    /// The phone connection type.
    /// </summary>
    public enum ConnectionType
    {
        /// <summary>
        ///  DHCP connection.
        /// </summary>
        DHCP,

        /// <summary>
        /// Static connection.
        /// </summary>
        Static,

        /// <summary>
        /// PPPoE connection.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        PPPoE
    }
}