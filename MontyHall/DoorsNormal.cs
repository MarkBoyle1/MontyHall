using System;

namespace MontyHall
{
    public class DoorsNormal : IDoors
    {
        private Random _random = new Random();
        private int _numberOfDoors;

        public DoorsNormal(int numberOfDoors)
        {
            _numberOfDoors = numberOfDoors;
        }

        public int PickDoorToPlacePrizeBehind()
        {
            return _random.Next(1, _numberOfDoors + 1);
        }
    }
}