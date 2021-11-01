using ApplicationCore;
using FluentAssertions;
using Infrastructure.DataProvider;
using IntegrationTests.Fakes;
using Xunit;

namespace IntegrationTests
{
    public class CryptoServiceTest
    {

        [Fact]
        public void GetCurrentValueForAda()
        {
            var dataProvider = new TestCryptoDataProvider();
            dataProvider.Load();
            var cryptoRepository = new CryptoCoinRepository(dataProvider);
            var cryptoService = new CryptoService(cryptoRepository);
            var adaCoin = cryptoService.Get("ADA");

            adaCoin.IsSome.Should().BeTrue();
            adaCoin.IfSome(c =>
            {
                c.Symbol.Should().Be("ADA");
                c.Name.Should().Be("Cardano");
                c.Value.Should().BeGreaterThan(0);
            });
        }
    }
}