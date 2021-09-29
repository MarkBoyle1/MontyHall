using System;

namespace MontyHall
{
    public class Gameplay
    {
        private IDoors _doors;
        private IUserInput _userInput;
        private int _chosenDoor;
        private int _numberOfDoors;
        private int _revealedDoor;
        private int _winningDoor;
        public Gameplay(int numberOfDoors, IUserInput userInput, IDoors doors)
        {
            _doors = doors;
            _userInput = userInput;
            _numberOfDoors = numberOfDoors;
        }

        public string PlayOneRound()
        {
            _winningDoor = _doors.PickDoorToPlacePrizeBehind();
            _chosenDoor = PickInitialDoor();
            _revealedDoor = RevealOneDoor();

            int decision = DecideToStayOrChange();
            _chosenDoor = AdjustChosenDoor(decision);

            return RevealResult();
        }

        private int PickInitialDoor()
        {
            return _userInput.PickInitialDoor();
        }
        
        private int RevealOneDoor()
        {
            for (int i = 1; i < _numberOfDoors + 1; i++)
            {
                if (i != _chosenDoor && i != _winningDoor)
                {
                    return i;
                }
            }

            return 0;
        }
        
        private int DecideToStayOrChange()
        {
            return _userInput.DecideToChangeOrStay();
        }

        private int AdjustChosenDoor(int decision)
        {
            if (decision == 0)
            {
                return _chosenDoor;
            }
            
            for (int i = 1; i < _numberOfDoors + 1; i++)
            {
                if (i != _chosenDoor && i != _revealedDoor)
                {
                    return i;
                }
            }

            return 1;
        }
        
        private string RevealResult()
        {
            return _chosenDoor == _winningDoor ? "won" : "lost";
        }
    }
}