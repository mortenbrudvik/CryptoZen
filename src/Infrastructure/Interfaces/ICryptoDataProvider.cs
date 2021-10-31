using ApplicationCore;
using LanguageExt;

namespace Infrastructure.Interfaces
{
    public interface ICryptoDataProvider
    {
        Option<CryptoCoin> Get(string symbol);
    }
}