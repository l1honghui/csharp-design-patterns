namespace flyweight
{
    public class InvisibilityPotion: Potion
    {
        public void Drink()
        {
            System.Console.WriteLine("You become invisible. (Potion={0})", this.GetHashCode());
        }

    }
}