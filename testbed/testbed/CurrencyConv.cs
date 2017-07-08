using System;
using testbed.net.webservicex.www;

namespace testbed.net.webservicex.www
{
    class testcl
    {
        public static string testmt()
        {
            string dbg = "";

            string endpoint = "tbc";

            // Build the request URL
            string requestURL = endpoint;

            // Create the service

            string service = new 
            //eBayAPIInterfaceService service = new eBayAPIInterfaceService();
            // Assign the request URL to the service locator.
            service.Url = requestURL;

            dbg = dbg + "\r\n" + requestURL;

            return ("debug -->  " + dbg);

        }
    }
}