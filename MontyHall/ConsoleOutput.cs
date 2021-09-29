using System;

namespace MontyHall
{
    public class ConsoleOutput : IOutput
    {
        public void DisplayPercentageOfWins(string strategy, double percentageOfWins)
        {
            Console.WriteLine($"The percentage of wins for strategy {strategy} is: " + percentageOfWins);
        }

        public void DisplayWinningStrategy(string winningStrategy)
        {
            Console.WriteLine("The winning strategy is: " + winningStrategy);
        }
    }
}