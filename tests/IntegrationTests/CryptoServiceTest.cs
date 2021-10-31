using FluentAssertions;
using Infrastructure;
using Xunit;

namespace IntegrationTests
{
    public class CryptoServiceTest
    {

        [Fact]
        public void GetCurrentValueForAda()
        {

            var dataProvider = new TestCryptoDataProvider();
            var cryptoService = new CryptoService(dataProvider);
            var adaCoin = cryptoService.Get("ADA");

            adaCoin.IsSome.Should().BeTrue();
            adaCoin.IfSome(c =>
            {
                c.Name.Should().Be("ADA");
                c.Value.Should().BeGreaterThan(0);
            });
        }
    }
}