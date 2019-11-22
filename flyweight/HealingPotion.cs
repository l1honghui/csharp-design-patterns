namespace flyweight
 {
     public class HealingPotion : Potion
     {
         public void Drink()
         {
             System.Console.WriteLine("You feel healed. (Potion={0})", this.GetHashCode());
         }
     }
 }