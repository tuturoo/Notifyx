using TelegramClient.Interfaces;
using TelegramClient.Models.Enums;

namespace TelegramClient.Abstractions;

public abstract class TelegramClientBase(string phone, int appId, string appHash) : ITelegramClient
{
    protected TelegramClientBase(ITelegramAccount account) : this(account.Phone, account.AppId, account.AppHash)
    {
        FirstName = account.FirstName;
        LastName = account.LastName;
        Username = account.Username;
        Phone = account.Phone;
        AccountStatus = account.AccountStatus;
    }

    #region Свойства
    
    /// <inheritdoc />
    public int AppId { get; } = appId;

    /// <inheritdoc />
    public string AppHash { get; } = appHash;

    /// <inheritdoc />
    public string FirstName { get; protected set; } = string.Empty;
    
    /// <inheritdoc />
    public string? LastName { get; protected set; } = string.Empty;
    
    /// <inheritdoc />
    public string? Username { get; protected set; } = string.Empty;

    /// <inheritdoc />
    public string Phone { get; protected set; } = phone;

    /// <inheritdoc />
    public AccountStatus AccountStatus { get; protected set; }

    /// <inheritdoc />
    public AuthenticationStatus AuthenticationStatus { get; protected set; }

    /// <inheritdoc />
    public VerificationStep VerificationStep { get; protected set; } = VerificationStep.None;
    
    #endregion

    #region Функции

    public abstract Task<AuthenticationStatus> LoginAsync(
        string? password = null,
        string? verificationCode = null,
        CancellationToken cancellationToken = default);
    

    #endregion
}