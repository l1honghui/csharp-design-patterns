using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new OldToNewAdapter(new OldAdaptee());
            adapter.Request();
        }
    }
}