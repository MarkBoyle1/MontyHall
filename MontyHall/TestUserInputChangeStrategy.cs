namespace MontyHall
{
    public class TestUserInputChangeStrategy : IUserInput
    {
        public int PickInitialDoor()
        {
            return 1;
        }

        public int DecideToChangeOrStay()
        {
            return 1;
        }
    }
}