namespace chain
{
    public class HandlerSoldier :RequestHandler
    {
        public HandlerSoldier(RequestHandler next) : base(next)
        {
        }
        
        public override void HandleRequest(Request req) {
            if (RequestType.CollectTax == req.GetRequestType()) {
                PrintHandling(req);
                req.MarkHandled();
            } else {
                base.HandleRequest(req);
            }
        }
    }
}