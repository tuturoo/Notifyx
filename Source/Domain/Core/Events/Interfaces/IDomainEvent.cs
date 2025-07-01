namespace Core.Events.Interfaces;

/// <summary>
/// Доменное событие
/// </summary>
public interface IDomainEvent
{
    /// <summary>
    /// Дата создания события
    /// </summary>
    public DateTime CreatedAt { get; }
}