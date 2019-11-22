using System;

namespace bridge
{
    /// <summary>
    /// 刀剑
    /// </summary>
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public Sword(IEnchantment enchantment)
        {
            this._enchantment = enchantment;
        }

        public void Wield()
        {
            Console.WriteLine("The sword is wielded.");
            _enchantment.OnActivate();
        }

        public void Swing()
        {
            Console.WriteLine("The sword is swinged.");
            _enchantment.Apply();
        }

        public void UnWield()
        {
            Console.WriteLine("The sword is unwielded.");
            _enchantment.OnDeactivate();
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}