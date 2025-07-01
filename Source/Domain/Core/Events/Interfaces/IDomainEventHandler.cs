namespace Core.Events.Interfaces;

/// <summary>
/// Обработчик доменного события
/// </summary>
/// <typeparam name="TEvent">Тип обрабатываемого события</typeparam>
public interface IDomainEventHandler<in TEvent> where TEvent : IDomainEvent 
{
    /// <summary>
    /// Обрабатывает вызванное событие
    /// </summary>
    /// <param name="raisedEvent">Вызванное событие</param>
    /// <param name="token">Токен</param>
    /// <returns>Задача</returns>
    public Task HandleAsync(TEvent raisedEvent, CancellationToken token = default);
}