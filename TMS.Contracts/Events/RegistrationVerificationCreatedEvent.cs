using MassTransit;
using TMS.Contracts.Models;

namespace TMS.Contracts.Events
{
    [EntityName("registration_verification")]
    public class RegistrationVerificationCreatedEvent : IEvent
    {
        public Guid VerificationId { get; set; }
        public string Target { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
