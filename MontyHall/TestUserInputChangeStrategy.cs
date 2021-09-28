namespace MontyHall
{
    public class TestUserInputChangeStrategy : IUserInput
    {
        public string PickInitialDoor()
        {
            return "1";
        }

        public string DecideToChangeOrStay()
        {
            return "1";
        }
    }
}