namespace decorator
{
    public class SimpleTroll : ITroll
    {
        public void Attack()
        {
            System.Console.WriteLine("The troll tries to grab you!");
        }


        public int GetAttackPower()
        {
            return 10;
        }


        public void FleeBattle()
        {
            System.Console.WriteLine("The troll shrieks in horror and runs away!");
        }
    }
}