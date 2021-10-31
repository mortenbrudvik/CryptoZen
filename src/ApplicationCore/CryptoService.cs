using ApplicationCore.Interfaces;
using LanguageExt;

namespace ApplicationCore
{
    public class CryptoService : ICryptoService
    {
        private readonly ICryptoCoinRepository _coinRepository;

        public CryptoService(ICryptoCoinRepository coinRepository) =>
            _coinRepository = coinRepository;

        public Option<CryptoCoin> Get(string symbol)
        {
            return _coinRepository.Get(symbol);
        }
    }
}