using ApplicationCore;
using FluentAssertions;
using Infrastructure;
using LanguageExt;
using Xunit;

using static LanguageExt.Prelude;

namespace UnitTests
{
    public class CryptoServiceTest
    {

        [Fact]
        public void GetCurrentValueForAda()
        {
            var cryptoService = new CryptoService();
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