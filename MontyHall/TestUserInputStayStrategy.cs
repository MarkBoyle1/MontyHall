namespace MontyHall
{
    public class TestUserInputStayStrategy : IUserInput
    {
        public string PickInitialDoor()
        {
            return "1";
        }

        public string DecideToChangeOrStay()
        {
            return "0";
        }
    }
}