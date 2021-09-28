using System;
using System.Collections.Generic;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Results results = new Results();
            results.CalculateWinningPercentage(new List<string>() {"won", "won", "won", "lost"});
        }
    }
}