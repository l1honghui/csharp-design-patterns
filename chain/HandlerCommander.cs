namespace chain
{
    public class HandlerCommander : RequestHandler
    {
        public HandlerCommander(RequestHandler next) : base(next)
        {
        }
        
        public override void HandleRequest(Request req) {
            if (RequestType.DefendCastle == req.GetRequestType()) {
                PrintHandling(req);
                req.MarkHandled();
            } else {
                base.HandleRequest(req);
            }
        }
    }
}