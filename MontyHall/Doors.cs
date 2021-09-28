using System;

namespace MontyHall
{
    public class Doors
    {
        private Random _random = new Random();
        private int _numberOfDoors;
        public int _winningDoor { get; }

        public Doors(int numberOfDoors)
        {
            _numberOfDoors = numberOfDoors;
            _winningDoor = PickDoorToPlacePrizeBehind();
        }

        private int PickDoorToPlacePrizeBehind()
        {
            return _random.Next(_numberOfDoors);
        }
    }
}