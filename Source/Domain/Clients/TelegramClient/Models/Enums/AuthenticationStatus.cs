namespace TelegramClient.Models.Enums;

/// <summary>
/// Текущий статус аутентификации
/// </summary>
public enum AuthenticationStatus
{
    /// <summary>
    /// Аутентификация не проводилась
    /// </summary>
    NotAuthenticated,
    
    /// <summary>
    /// Верификация
    /// </summary>
    Verification,
    
    /// <summary>
    /// Аутентифицирован
    /// </summary>
    Authenticated
}