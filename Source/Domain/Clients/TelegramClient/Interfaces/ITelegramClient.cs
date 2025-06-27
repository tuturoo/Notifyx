using TelegramClient.Models.Enums;

namespace TelegramClient.Interfaces;

/// <summary>
/// Интерфейс Телеграм клиента
/// </summary>
public interface ITelegramClient : ITelegramAccount
{
    /// <summary>
    /// Текущий статус аутентификации
    /// </summary>
    public AuthenticationStatus AuthenticationStatus { get; }
    
    /// <summary>
    /// Текущий шаг проверки
    /// </summary>
    public VerificationStep VerificationStep { get; }
    
    /// <summary>
    /// Провести аутентификацию
    /// </summary>
    /// <returns></returns>
    public Task<AuthenticationStatus> LoginAsync(
        string? password = null,
        string? verificationCode = null,
        CancellationToken cancellationToken = default);
}