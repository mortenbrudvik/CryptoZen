using System.Collections.Generic;
using ApplicationCore;
using ApplicationCore.Interfaces;
using Infrastructure.Interfaces;
using LanguageExt;

namespace Infrastructure.DataProvider
{
    public class CryptoCoinRepository : ICryptoCoinRepository
    {
        private readonly ICryptoDataProvider _dataProvider;

        public CryptoCoinRepository(ICryptoDataProvider dataProvider) =>
            _dataProvider = dataProvider;

        public Option<CryptoCoin> Get(string symbol) =>
            _dataProvider.Get(symbol);
    }
}