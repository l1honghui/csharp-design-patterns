namespace flyweight
{
    public class HolyWaterPotion : Potion
    {
        public void Drink()
        {
            System.Console.WriteLine("You feel blessed. (Potion={0})", this.GetHashCode());
        }
        
    }
}