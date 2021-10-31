using System;
using FluentAssertions;
using IntegrationTests.Fakes;
using Xunit;

namespace IntegrationTests
{
    public class CoinMarketCapDataProviderTest
    {
        [Fact]
        public void Get_ShouldGetAdaCoin()
        {
            var dataProvider = new TestCryptoDataProvider();
            dataProvider.Load();
            var coin = dataProvider.Get("ADA");

            coin.IsSome.Should().BeTrue();
            coin.IfSome(c =>
            {
                c.Name.Should().Equals("Cardano");
            });
        }
    }
}