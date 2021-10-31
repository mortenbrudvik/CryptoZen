using ApplicationCore;
using ApplicationCore.Interfaces;
using Infrastructure.Interfaces;
using LanguageExt;

using static LanguageExt.Prelude;

namespace Infrastructure
{
    public class CryptoService : ICryptoService
    {
        private readonly ICryptoDataProvider _dataProvider;

        public CryptoService(ICryptoDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public Option<CryptoCoin> Get(string cryptoId) => cryptoId.ToUpper() switch
        {
            "ADA" => _dataProvider.Get(cryptoId),
            _ => None
        };
    }
}