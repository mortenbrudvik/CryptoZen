using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface ICryptoCoinRepository
    {
        IEnumerable<CryptoCoin> GetAll();
    }
}