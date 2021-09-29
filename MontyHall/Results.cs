using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Results
    {
        private List<string> _changeStrategyResultsList;
        private List<string> _stayStrategyResultsList;
        private Gameplay _changeStrategy;
        private Gameplay _stayStrategy;
        private IOutput _output;
        
        public Results()
        {
            _changeStrategyResultsList = new List<string>();
            _stayStrategyResultsList = new List<string>();
            _changeStrategy = new Gameplay(3, new TestUserInputChangeStrategy());
            _stayStrategy = new Gameplay(3, new TestUserInputStayStrategy());
            _output = new ConsoleOutput();

        }

        public string RunProgram()
        {
            _changeStrategyResultsList = PlayMultipleRounds(1000, _changeStrategy);
            double changePercentageOfWins = CalculateWinningPercentage(_changeStrategyResultsList);
            
            _stayStrategyResultsList = PlayMultipleRounds(1000, _stayStrategy);
            double stayPercentageOfWins = CalculateWinningPercentage(_stayStrategyResultsList);

            string winningStrategy = DeclareStrategyWinner(changePercentageOfWins, stayPercentageOfWins);
            
            _output.DisplayPercentageOfWins("Change", changePercentageOfWins);
            _output.DisplayPercentageOfWins("Stay", stayPercentageOfWins);

            _output.DisplayWinningStrategy(winningStrategy);

            return winningStrategy;
        }
        
        private List<string> PlayMultipleRounds(int numberOfRounds, Gameplay strategy)
        {
            List<string> resultsList = new List<string>();
            for (int i = 0; i < numberOfRounds; i++)
            {
                string result = strategy.PlayOneRound();
                resultsList.Add(result);
            }

            return resultsList;
        }
        private string DeclareStrategyWinner(double changePercentageOfWins, double stayPercentageOfWins)
        {
            if (changePercentageOfWins == stayPercentageOfWins)
            {
                return "tie";
            }
            
            return changePercentageOfWins > stayPercentageOfWins ? "Change" : "Stay";
        }

        private double CalculateWinningPercentage(List<string> results)
        {
            double numberOfWins = results.Count(x => x == "won");

            double percentageOfWins = (numberOfWins / results.Count) * 100;

            return percentageOfWins;
        }
    }
}