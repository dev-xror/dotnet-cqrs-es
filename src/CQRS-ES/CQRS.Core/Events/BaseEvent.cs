using CQRS.Core.Messages;

namespace CQRS.Core.Events;

public abstract class BaseEvent : Message
{

    public BaseEvent(string type)
    {
        this.Type = type;
    }

    public int Version { get; set; }

    // Discriminator Property
    // use when doing polymorphic data binding 
    // when serializing event objects
    public string? Type { get; set; }
}