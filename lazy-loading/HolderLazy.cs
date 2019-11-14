using System;

namespace lazy_loading
{
    public class HolderLazy
    {
        private Lazy<Heavy> _heavy;

        /**
         * Constructor.
         */
        public HolderLazy()
        {
            _heavy = new Lazy<Heavy>(new Heavy());
            Console.WriteLine("HolderNaive created");
        }

        /**
         * Get heavy object.
         */
        public Heavy GetHeavy()
        {
            return _heavy.Value;
        }
    }
}