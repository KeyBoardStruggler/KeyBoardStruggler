using System;
using System.Collections.Generic;
using System.Text;

namespace FakeNotMoreThanThat.Contracts
{
    public interface IThanThat
    {
        bool ThakeThat { get; }
        int PickIt(int countOfPickups);
    }
}
