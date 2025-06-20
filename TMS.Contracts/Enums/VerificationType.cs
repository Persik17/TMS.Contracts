namespace TMS.Contracts.Enums
{
    /// <summary>
    /// Represents the different types of verification methods.
    /// </summary>
    public enum VerificationType
    {
        /// <summary>
        /// Verification via email.
        /// </summary>
        Email = 0,

        /// <summary>
        /// Verification via phone number (e.g., SMS).
        /// </summary>
        Phone = 1,

        /// <summary>
        /// Verification via Telegram.
        /// </summary>
        Telegram = 2
    }
}