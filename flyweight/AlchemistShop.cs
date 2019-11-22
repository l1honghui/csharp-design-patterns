using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace flyweight
{
    /// <summary>
    /// 炼金术商店在货架上放着药水。它使用药水厂提供药水。
    /// </summary>
    public class AlchemistShop
    {
        private readonly IList<Potion> _topShelf;
        private readonly IList<Potion> _bottomShelf;

        /**
         * Constructor.
         */
        public AlchemistShop()
        {
            PotionFactory factory = new PotionFactory();
            _topShelf = new List<Potion>
            {
                factory.CreatePotion(PotionType.Invisibility),
                factory.CreatePotion(PotionType.Invisibility),
                factory.CreatePotion(PotionType.Strength),
                factory.CreatePotion(PotionType.Healing),
                factory.CreatePotion(PotionType.Invisibility),
                factory.CreatePotion(PotionType.Strength),
                factory.CreatePotion(PotionType.Healing),
                factory.CreatePotion(PotionType.Healing)
            };
            _bottomShelf = new List<Potion>
            {
                factory.CreatePotion(PotionType.Poison),
                factory.CreatePotion(PotionType.Poison),
                factory.CreatePotion(PotionType.Poison),
                factory.CreatePotion(PotionType.HolyWater),
                factory.CreatePotion(PotionType.HolyWater)
            };
        }

        /**
         * Get a read-only list of all the items on the top shelf.
         *
         * @return The top shelf potions
         */
        public IReadOnlyList<Potion> GetTopShelf()
        {
            return new ReadOnlyCollection<Potion>(_topShelf);
        }

        /**
         * Get a read-only list of all the items on the bottom shelf.
         *
         * @return The bottom shelf potions
         */
        public IReadOnlyList<Potion> GetBottomShelf()
        {
            return new ReadOnlyCollection<Potion>(_bottomShelf);
        }

        /**
         * Enumerate potions.
         */
        public void Enumerate()
        {
            System.Console.WriteLine("Enumerating top shelf potions\n");

            foreach (Potion p in _topShelf)
            {
                p.Drink();
            }

            System.Console.WriteLine("Enumerating bottom shelf potions\n");

            foreach (Potion p in _bottomShelf)
            {
                p.Drink();
            }
        }
    }
}