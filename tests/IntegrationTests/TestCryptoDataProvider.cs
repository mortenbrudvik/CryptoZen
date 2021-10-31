using ApplicationCore;
using LanguageExt;

namespace IntegrationTests
{
    public class TestCryptoDataProvider : ICryptoDataProvider
    {
        public void LoadData()
        {
            
        }
        
        public Option<CryptoCoin> Get(string cryptoId)
        {
            throw new System.NotImplementedException();
        }
    }
}