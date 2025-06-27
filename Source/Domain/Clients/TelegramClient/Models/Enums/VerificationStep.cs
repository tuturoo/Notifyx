namespace TelegramClient.Models.Enums;

/// <summary>
/// Текущий шаг верификации
/// </summary>
public enum VerificationStep
{
    /// <summary>
    /// Необходим пароль
    /// </summary>
    NeedPassword,
    
    /// <summary>
    /// Необходим СМС-код
    /// </summary>
    NeedCode,
    
    /// <summary>
    /// Верификация выполнена
    /// </summary>
    None,
}