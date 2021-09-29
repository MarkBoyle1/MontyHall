namespace MontyHall
{
    public class TestUserInputStayStrategy : IUserInput
    {
        public int PickInitialDoor()
        {
            return 1;
        }

        public int DecideToChangeOrStay()
        {
            return 0;
        }
    }
}