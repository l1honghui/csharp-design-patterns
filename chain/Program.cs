using System;

namespace chain
{
    /// <summary>
    /// 责任链
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HandlerBuilder();
            builder.MakeRequest(new Request(RequestType.DefendCastle, "defend castle"));
            builder.MakeRequest(new Request(RequestType.TorturePrisoner, "torture prisoner"));
            builder.MakeRequest(new Request(RequestType.CollectTax, "collect tax"));
        }
    }
}