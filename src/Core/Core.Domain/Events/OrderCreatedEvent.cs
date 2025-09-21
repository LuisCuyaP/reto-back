namespace Core.Domain.Events;

public record OrderCreatedEvent(Order order) : IDomainEvent;