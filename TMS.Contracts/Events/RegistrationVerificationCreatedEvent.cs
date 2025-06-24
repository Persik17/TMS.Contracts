using MassTransit;
using TMS.Contracts.Models;
using TMS.Contracts.Enums;

namespace TMS.Contracts.Events
{
    /// <summary>
    /// Represents an event that is published when a registration verification is created.
    /// </summary>
    [EntityName("registration_verification")]
    public class RegistrationVerificationCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the verification record.
        /// </summary>
        public Guid VerificationId { get; set; }

        /// <summary>
        /// Gets or sets the target of the verification (e.g., email address or phone number).
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the type of verification (e.g., Email, Phone, Telegram).  See <see cref="VerificationType"/> for possible values.
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the verification code.
        /// </summary>
        public string Code { get; set; }

        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the verification expires.
        /// </summary>
        public DateTime Expiration { get; set; }
    }
}
