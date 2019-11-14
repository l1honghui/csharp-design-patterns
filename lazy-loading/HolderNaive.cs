using System;

namespace lazy_loading
{
    /// <summary>
    /// 简单实现，线程不安全
    /// </summary>
    public class HolderNaive
    {
        private Heavy _heavy;

        /**
         * Constructor.
         */
        public HolderNaive() {
            Console.WriteLine("HolderNaive created");
        }

        /**
         * Get heavy object.
         */
        public Heavy GetHeavy() {
            if (_heavy == null) {
                _heavy = new Heavy();
            }
            return _heavy;
        }
    }
}