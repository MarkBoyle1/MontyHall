using System;
using System.Collections.Generic;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Results results = new Results(new DoorsFixedWinnerTo3());
            results.RunProgram();
        }
    }
}