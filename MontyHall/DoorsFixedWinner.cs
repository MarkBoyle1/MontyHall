namespace MontyHall
{
    public class DoorsFixedWinner : IDoors
    {
        private int _winningDoor;
        public DoorsFixedWinner(int winningDoor)
        {
            _winningDoor = winningDoor;
        }
        public int PickDoorToPlacePrizeBehind()
        {
            return _winningDoor;
        }
    }
}