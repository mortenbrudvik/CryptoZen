using ApplicationCore;
using LanguageExt;

using static LanguageExt.Prelude;

namespace Infrastructure
{
    public class CryptoService : ICryptoService
    {
        public Option<CryptoCoin> Get(string ada) => ada.ToUpper() switch
        {
            "ADA" => new CryptoCoin("ADA", 1.97),
            _ => None
        };
    }
}