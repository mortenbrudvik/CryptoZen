using LanguageExt;

namespace ApplicationCore
{
    public interface ICryptoDataProvider
    {
        Option<CryptoCoin> Get(string cryptoId);
    }
}