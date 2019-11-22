using System.Collections.Generic;

namespace flyweight
{
    public class PotionFactory
    {
        private readonly Dictionary<PotionType, Potion> _potions;

        public PotionFactory()
        {
            _potions = new Dictionary<PotionType, Potion>();
        }

        public Potion CreatePotion(PotionType type)
        {
            ;
            if (!_potions.TryGetValue(type, out Potion potion))
            {
                switch (type)
                {
                    case PotionType.Healing:
                        potion = new HealingPotion();
                        _potions.Add(type, potion);
                        break;
                    case PotionType.HolyWater:
                        potion = new HolyWaterPotion();
                        _potions.Add(type, potion);
                        break;
                    case PotionType.Invisibility:
                        potion = new InvisibilityPotion();
                        _potions.Add(type, potion);
                        break;
                    case PotionType.Poison:
                        potion = new PoisonPotion();
                        _potions.Add(type, potion);
                        break;
                    case PotionType.Strength:
                        potion = new StrengthPotion();
                        _potions.Add(type, potion);
                        break;
                    default:
                        break;
                }
            }

            return potion;
        }
    }
}