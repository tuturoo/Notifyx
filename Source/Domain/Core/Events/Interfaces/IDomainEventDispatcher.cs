namespace Core.Events.Interfaces;

/// <summary>
/// Диспетчер доменных событий
/// </summary>
public interface IDomainEventDispatcher
{
    /// <summary>
    /// Уведомляет добавленные обработчики о возникновении события 
    /// </summary>
    /// <param name="raisedEvent">Вызванное событие</param>
    /// <param name="token">Токен</param>
    /// <typeparam name="TEvent">Тип события</typeparam>
    /// <returns>Задача</returns>
    public Task DispatchAsync<TEvent>(TEvent raisedEvent, CancellationToken token = default) where TEvent : IDomainEvent;
}