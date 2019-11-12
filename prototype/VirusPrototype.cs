using System;

namespace csharp_design_patterns.CreationType
{
    class VirusPrototype : Prototype
    {
        public override Prototype Clone()
        {
            // Prototype模式中的Clone方法可以利用.NET中的Object类的MemberwiseClone()方法或者序列化来实现深拷贝。
            return (Prototype)MemberwiseClone();
        }

        public override void Eat()
        {
            Console.WriteLine($"{nameof(VirusPrototype)} was eating");
        }

    }
}
