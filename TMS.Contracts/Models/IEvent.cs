namespace TMS.Contracts.Models
{
    /// <summary>
    /// Marker interface for events used with a message bus (e.g., RabbitMQ).  Implementing this interface signifies that a class represents a publishable event.
    /// </summary>
    public interface IEvent { }
}