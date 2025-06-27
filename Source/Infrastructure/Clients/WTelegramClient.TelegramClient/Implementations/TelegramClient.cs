using TelegramClient.Abstractions;
using TelegramClient.Interfaces;
using TelegramClient.Models.Enums;
using WTelegram;

namespace WTelegramClient.TelegramClient.Implementations;

public sealed class TelegramClient : TelegramClientBase, IDisposable, IAsyncDisposable
{
    private readonly WTelegram.Client _innerClient;
    
    public TelegramClient(ITelegramAccount account, string sessionPath) : base(account)
    {
        _innerClient = new Client(account.AppId, account.AppHash, sessionPath);
    }

    public TelegramClient(string phone, int appId, string appHash, string sessionPath) : base(phone, appId, appHash)
    {
        _innerClient = new Client(appId, appHash, sessionPath);
    }

    public override async Task<AuthenticationStatus> LoginAsync(
        string? password = null, 
        string? verificationCode = null,
        CancellationToken cancellationToken = default)
    {
        const string needCode = "verification_code";
        const string needPassword = "password";
        const string? authenticated = null;
        
        string additionalData = password ?? verificationCode ?? Phone;

        var requestedInformation = await _innerClient.Login(additionalData);

        switch (requestedInformation)
        {
            case needPassword:
                AuthenticationStatus = AuthenticationStatus.Verification;
                VerificationStep = VerificationStep.NeedPassword;
                break;
            
            case needCode:
                AuthenticationStatus = AuthenticationStatus.Verification;
                VerificationStep = VerificationStep.NeedCode;
                break;
            
            case authenticated:
                AuthenticationStatus = AuthenticationStatus.Authenticated;
                VerificationStep = VerificationStep.None;
                break;
            
            default:
                throw new ArgumentOutOfRangeException(nameof(requestedInformation),
                    $"Нет нужного обработчика для {requestedInformation}");
        }

        return AuthenticationStatus;
    }

    public void Dispose() => _innerClient.Dispose();

    public async ValueTask DisposeAsync() => await _innerClient.DisposeAsync();
}