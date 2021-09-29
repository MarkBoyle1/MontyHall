using System;

namespace MontyHall
{
    public class Doors
    {
        private Random _random = new Random();
        private int _numberOfDoors;
        public int WinningDoor { get; }

        public Doors(int numberOfDoors)
        {
            _numberOfDoors = numberOfDoors;
            WinningDoor = PickDoorToPlacePrizeBehind();
        }

        private int PickDoorToPlacePrizeBehind()
        {
            return _random.Next(1, _numberOfDoors + 1);
        }
    }
}