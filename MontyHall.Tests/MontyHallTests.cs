using System;
using System.Collections.Generic;
using Xunit;

namespace MontyHall.Tests
{
    public class MontyHallTests
    {
        [Fact]
        public void when_RunProgram_then_return_ChangeOrStay()
        {
            Results results = new Results(new DoorsFixedWinnerTo3());

            string winningStrategy = results.RunProgram();

            Assert.Equal("Change", winningStrategy);
        }
        
        [Fact]
        public void when_PlayOneRound_and_inputEqualsTestUserInputStayStrategy_then_return_wonOrLost()
        {
            Results results = new Results(new DoorsFixedWinnerTo1());

            string winningStrategy = results.RunProgram();

            Assert.Equal("Stay", winningStrategy);
        }
        
        [Fact]
        public void when_PlayOneRound_and_inputEqualsTestUserInputChangeStrategy_then_return_wonOrLost()
        {
            Results results = new Results(new DoorsFixedWinnerTo2());

            string winningStrategy = results.RunProgram();

            Assert.Equal("Change", winningStrategy);
        }
    }
}