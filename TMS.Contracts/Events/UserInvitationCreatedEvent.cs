using MassTransit;
using TMS.Contracts.Models;

namespace TMS.Contracts.Events
{
    [EntityName("user_invitation")]
    public class UserInvitationCreatedEvent : IEvent
    {
        public Guid InvitationId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string[] Roles { get; set; }
        public string Language { get; set; }
        public string Message { get; set; }
        public Guid InvitedBy { get; set; }
        public DateTime Expiration { get; set; }
    }
}
