using System;
using System.Collections.Generic;
using Xunit;

namespace MontyHall.Tests
{
    public class MontyHallTests
    {
        private Results _results = new Results();
  
        [Fact]
        public void when_RunProgram_then_return_ChangeOrStay()
        {
            string result = _results.RunProgram();

            List<string> possibleResults = new List<string>() {"Change", "Stay"};

            Assert.Contains(result, possibleResults);
        }
        
        [Fact]
        public void when_PlayOneRound_and_inputEqualsTestUserInputStayStrategy_then_return_wonOrLost()
        {
            Gameplay stayStrategy = new Gameplay(3, new TestUserInputStayStrategy());

            string result = stayStrategy.PlayOneRound();

            List<string> possibleResults = new List<string>() {"won", "lost"};

            Assert.Contains(result, possibleResults);
        }
        
        [Fact]
        public void when_PlayOneRound_and_inputEqualsTestUserInputChangeStrategy_then_return_wonOrLost()
        {
            Gameplay changeStrategy = new Gameplay(3, new TestUserInputChangeStrategy());

            string result = changeStrategy.PlayOneRound();

            List<string> possibleResults = new List<string>() {"won", "lost"};

            Assert.Contains(result, possibleResults);
        }
    }
}