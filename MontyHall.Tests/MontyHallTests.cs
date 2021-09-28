using System;
using System.Collections.Generic;
using Xunit;

namespace MontyHall.Tests
{
    public class MontyHallTests
    {
        private Results _results = new Results();
        [Fact]
        public void Test1()
        {
            string winningStrategy = "stay";
            
            Assert.Equal(winningStrategy, _results.DeclareWinningStrategy());
        }
        
        [Fact]
        public void Test2()
        {
            List<string> results = new List<string>() {"won", "won", "won", "lost"};
            
            Assert.Equal(75, _results.CalculateWinningPercentage(results));
        }
        
        [Fact]
        public void Test3()
        {
            Doors doors = new Doors(3);

            Assert.True(doors._winningDoor > 0 && doors._winningDoor < 4);
        }
    }
}