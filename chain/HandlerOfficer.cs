namespace chain
{
    public class HandlerOfficer :RequestHandler
    {
        public HandlerOfficer(RequestHandler next) : base(next)
        {
        }
        
        public override void HandleRequest(Request req) {
            if (RequestType.TorturePrisoner == req.GetRequestType()) {
                PrintHandling(req);
                req.MarkHandled();
            } else {
                base.HandleRequest(req);
            }
        }
    }
}