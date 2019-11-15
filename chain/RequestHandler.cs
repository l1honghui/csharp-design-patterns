using System;

namespace chain
{
    public abstract class RequestHandler
    {
        private readonly RequestHandler _next;

        public RequestHandler(RequestHandler next)
        {
            this._next = next;
        }

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