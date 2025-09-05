using MassTransit;
using TMS.Contracts.Models;

namespace TMS.Contracts.Events;

[EntityName("user_logged_in")]
public class UserLoggedInEvent : IEvent
{
    public Guid UserId { get; set; }
}