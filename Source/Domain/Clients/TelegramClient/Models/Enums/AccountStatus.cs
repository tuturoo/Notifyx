namespace TelegramClient.Models.Enums;

/// <summary>
/// Текущий статус аккаунта
/// </summary>
public enum AccountStatus
{
    /// <summary>
    /// Отключен
    /// </summary>
    Disabled,
    
    /// <summary>
    /// Ограничен
    /// </summary>
    Limited,
    
    /// <summary>
    /// Заблокирован
    /// </summary>
    Banned,
    
    /// <summary>
    /// Включен
    /// </summary>
    Enabled,
}