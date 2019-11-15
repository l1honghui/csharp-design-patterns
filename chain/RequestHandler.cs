using System;

namespace chain
{
    public abstract class RequestHandler
    {
        /// <summary>
        /// 当前handler保存next handler
        /// </summary>
        private readonly RequestHandler _next;

        public RequestHandler(RequestHandler next)
        {
            this._next = next;
        }

        /// <summary>
        /// 如果当前handler匹配request则直接处理返回，如果不匹配交给next handler处理直到找到或者next为null后停止
        /// </summary>
        /// <param name="req"></param>
        public virtual void HandleRequest(Request req)
        {
            _next?.HandleRequest(req);
        }

        /// <summary>
        /// 子类重写处理逻辑 
        /// </summary>
        /// <param name="req"></param>
        protected virtual void PrintHandling(Request req)
        {
            Console.WriteLine("{0} handling request \"{1}\"", this , req.GetRequestDescription());
        }
        
        
    }
}