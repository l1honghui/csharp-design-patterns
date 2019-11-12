using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var appleBuilder = new AppleBuilder();
            var director = new Director(appleBuilder);
            director.Constuct();
            var product = director.GetProduct();
            product.ShowFunction();
        }
    }
}