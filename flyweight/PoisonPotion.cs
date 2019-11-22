namespace flyweight
{
    public class PoisonPotion: Potion
    {
        public void Drink()
        {
            System.Console.WriteLine("Urgh! This is poisonous. (Potion={0})", this.GetHashCode());
        }

    }
}