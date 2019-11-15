namespace chain
{
    public class HandlerBuilder
    {
        RequestHandler chain;

        public HandlerBuilder()
        {
            BuildChain();
        }

        private void BuildChain()
        {
            chain = new HandlerCommander(new HandlerOfficer(new HandlerSoldier(null)));
        }

        public void MakeRequest(Request req)
        {
            chain.HandleRequest(req);
        }
    }

}