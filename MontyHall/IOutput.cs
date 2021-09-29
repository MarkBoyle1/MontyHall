namespace MontyHall
{
    public interface IOutput
    {
        public void DisplayPercentageOfWins(string strategy, double percentageOfWins);
        public void DisplayWinningStrategy(string winningStrategy);
    }
}