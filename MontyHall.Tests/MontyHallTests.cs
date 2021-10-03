using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MontyHall.Tests
{
    public class MontyHallTests
    {
        [Fact]
        public void when_winningDoorEquals3_and_choosenDoorEqualsOne_when_RunProgram_then_return_Change()
        {
            Results results = new Results(new DoorsFixedWinner(3));

            string winningStrategy = results.RunProgram();

            Assert.Equal("Change", winningStrategy);
        }
        
        [Fact]
        public void when_winningDoorEquals1_and_choosenDoorEqualsOne_when_RunProgram_then_return_Stay()
        {
            Results results = new Results(new DoorsFixedWinner(1));

            string winningStrategy = results.RunProgram();

            Assert.Equal("Stay", winningStrategy);
        }
        
        [Fact]
        public void when_winningDoorEquals2_and_choosenDoorEqualsOne_when_RunProgram_then_return_Change()
        {
            Results results = new Results(new DoorsFixedWinner(2));

            string winningStrategy = results.RunProgram();

            Assert.Equal("Change", winningStrategy);
        }
        
        [Fact]
        public void when_winningDoorEqualsOneUsingMockObject_and_choosenDoorEqualsOne_when_RunProgram_then_return_Stay()
        {
            Mock<IDoors> mockDoor = new Mock<IDoors>();
            
            mockDoor.Setup(x => x.PickDoorToPlacePrizeBehind()).Returns(1);

            Results results = new Results(mockDoor.Object);

            string winningStrategy = results.RunProgram();

            Assert.Equal("Stay", winningStrategy);
        }
        
        [Fact]
        public void when_winningDoorEqualsTwoUsingMockObject_and_choosenDoorEqualsOne_when_RunProgram_then_return_Change()
        {
            Mock<IDoors> mockDoor = new Mock<IDoors>();
            
            mockDoor.Setup(x => x.PickDoorToPlacePrizeBehind()).Returns(2);

            Results results = new Results(mockDoor.Object);

            string winningStrategy = results.RunProgram();

            Assert.Equal("Change", winningStrategy);
        }
        
        [Fact]
        public void when_winningDoorEqualsThreeUsingMockObject_and_choosenDoorEqualsOne_when_RunProgram_then_return_Change()
        {
            Mock<IDoors> mockDoor = new Mock<IDoors>();
            
            mockDoor.Setup(x => x.PickDoorToPlacePrizeBehind()).Returns(3);

            Results results = new Results(mockDoor.Object);

            string winningStrategy = results.RunProgram();

            Assert.Equal("Change", winningStrategy);
        }
    }
}