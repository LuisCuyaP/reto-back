namespace Core.Domain.Events;
public record OrderUpdatedEvent(Order order) : IDomainEvent;