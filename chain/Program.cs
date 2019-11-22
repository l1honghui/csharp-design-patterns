using System;

namespace chain
{
    /*
    责任链模式是由命令对象和一系列处理对象组成的设计模式。
    每个处理对象都包含定义其可以处理的命令对象类型的逻辑;
    其余的传递给链中的下一个处理对象。
    还有一种机制可以将新的处理对象添加到这个链的末尾。

    在本例中，我们将请求处理程序({@link RequestHandler})组织到一个链中，每个处理程序都有机会在轮到它时处理请求。
    在这里，构建器({@link handlerBuilder})构建请求处理链，({@link HandlerCommander}、{@link HandlerOfficer}、{@link HandlerSoldier})形成处理程序链。
     */
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