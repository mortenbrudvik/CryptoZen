using System.Collections.Generic;
using LanguageExt;

namespace ApplicationCore.Interfaces
{
    public interface ICryptoCoinRepository
    {
        Option<CryptoCoin> Get(string symbol);
    }
}