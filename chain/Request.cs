using System;

namespace chain
{
    public class Request
    { 
      /**
       * The type of this request, used by each item in the chain to see if they should or can handle
       * this particular request.
       */
        private readonly RequestType _requestType;

        /**
         * A description of the request.
         */
        private readonly string _requestDescription;

        /**
         * Indicates if the request is handled or not. A request can only switch state from unhandled to
         * handled, there's no way to 'unhandle' a request.
         */
        private bool _handled;

        public Request(RequestType requestType, string requestDescription)
        {
            this._requestType =  requestType;
            this._requestDescription = requestDescription;
        }

        public String GetRequestDescription()
        {
            return _requestDescription;
        }

        public RequestType GetRequestType()
        {
            return _requestType;
        }

        public void MarkHandled()
        {
            this._handled = true;
        }

        public bool IsHandled()
        {
            return this._handled;
        }
    }
}