using TelegramClient.Models.Enums;

namespace TelegramClient.Interfaces;

/// <summary>
/// Информация об Телеграм аккаунте
/// </summary>
public interface ITelegramAccount
{
    /// <summary>
    /// Идентификатор приложения аккаунта
    /// </summary>
    public int AppId { get; }
    
    /// <summary>
    /// Хэш приложения аккаунта
    /// </summary>
    public string AppHash { get; }
    
    /// <summary>
    /// Имя установленное на аккаунте
    /// </summary>
    public string FirstName { get; }
    
    /// <summary>
    /// Фамилия установленная на аккаунте
    /// </summary>
    public string? LastName { get; }
    
    /// <summary>
    /// Идентификатор аккаунта
    /// </summary>
    public string? Username { get; }
    
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string Phone { get; }
    
    /// <summary>
    /// Статус аккаунта
    /// </summary>
    public AccountStatus AccountStatus { get; }
}