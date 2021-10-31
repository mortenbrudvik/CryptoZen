using LanguageExt;

namespace ApplicationCore
{
    public interface ICryptoService
    {
        Option<CryptoCoin> Get(string ada);
    }
}