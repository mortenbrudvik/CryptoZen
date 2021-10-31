using LanguageExt;

namespace ApplicationCore.Interfaces
{
    public interface ICryptoService
    {
        Option<CryptoCoin> Get(string symbol);
    }
}