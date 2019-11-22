namespace flyweight
{
    public class StrengthPotion : Potion
    {
        public void Drink()
        {
            System.Console.WriteLine("You feel strong. (Potion={0})", this.GetHashCode());
        }
    }
}