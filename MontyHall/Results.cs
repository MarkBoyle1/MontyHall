using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Results
    {
        private List<string> _results;

        public Results()
        {
            _results = new List<string>();
        }
        public string DeclareWinningStrategy()
        {
            if (CalculateWinningPercentage(_results) == 50)
            {
                return "tie";
            }
            
            return CalculateWinningPercentage(_results) > 50 ? "change" : "stay";
        }

        public double CalculateWinningPercentage(List<string> results)
        {
            double numberOfWins = results.Where(x => x == "won").Count();
            double percentageOfWins = (numberOfWins / results.Count) * 100;
     
            return percentageOfWins;
        }
    }
}