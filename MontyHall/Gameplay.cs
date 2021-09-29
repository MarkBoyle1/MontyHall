using System;

namespace MontyHall
{
    public class Gameplay
    {
        private Doors _doors;
        private IUserInput _userInput;
        private int _chosenDoor;
        private int _numberOfDoors;
        private int _revealedDoor;
        public Gameplay(int numberOfDoors, IUserInput userInput)
        {
            _doors = SetUpDoors(numberOfDoors);
            _userInput = userInput;
            _numberOfDoors = numberOfDoors;
        }

        public string PlayOneRound()
        {
            _doors = SetUpDoors(_numberOfDoors);
            _chosenDoor = PickInitialDoor();
            _revealedDoor = RevealOneDoor();
            int decision = DecideToStayOrChange();
            _chosenDoor = AdjustChosenDoor(decision);
            return RevealResult();
        }
        
        //Set up doors
        private Doors SetUpDoors(int numberOfDoors)
        {
            return new Doors(numberOfDoors);
        }
        
        //Pick initial door
        private int PickInitialDoor()
        {
            return _userInput.PickInitialDoor();
        }
        
        //Reveal one door
        private int RevealOneDoor()
        {
            for (int i = 1; i < _numberOfDoors + 1; i++)
            {
                if (i != _chosenDoor && i != _doors.WinningDoor)
                {
                    return i;
                }
            }

            return 0;
        }
        
        //Ask to stay or change
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
            
            for (int i = 1; i < _numberOfDoors; i++)
            {
                if (i != _chosenDoor && i != _revealedDoor)
                {
                    return i;
                }
            }

            return 1;
        }
        
        //Reveal result
        private string RevealResult()
        {
            return _chosenDoor == _doors.WinningDoor ? "won" : "lost";
        }
    }
}