using System;
using testbed.com.ebay.developer;

namespace testbed.com.ebay.developer
{
    class GeteBayOfficialTime
    {
        public static string ebaytime()
        {

            string endpoint = "https://api.sandbox.ebay.com/wsapi";
            string callName = "GeteBayOfficialTime";
            string siteId = "0";
            string appId = "Private92-3d36-4442-8881-1b52d163268";     // use your app ID
            string devId = "301c8b78-4318-48ae-a825-84a6bde6f137";     // use your dev ID
            string certId = "3d0c5934-c325-4a5b-a9f5-dc28cf84f13d";   // use your cert ID
            string version = "405";

            // Build the request URL
            string requestURL = endpoint
            + "?callname=" + callName
            + "&siteid=" + siteId
            + "&appid=" + appId
            + "&version=" + version
            + "&routing=default";

            // Create the service
            eBayAPIInterfaceService service = new eBayAPIInterfaceService();
            // Assign the request URL to the service locator.
            service.Url = requestURL;

            // Set credentials
            service.RequesterCredentials = new CustomSecurityHeaderType();
            service.RequesterCredentials.eBayAuthToken = "AgAAAA**AQAAAA**aAAAAA**UWN5VQ**nY+sHZ2PrBmdj6wVnY+sEZ2PrA2dj6wFk4GhDZeKpQudj6x9nY+seQ**3HoDAA**AAMAAA**2babZNpL6Q8PvLhxSkE42UeJUsJ943AV42duhbHvUj54sg2Rl59cr29Pca56Zs0NouehEBz3GbDLdn8PJbqPK6kYi1COtPiN1qUyZBOWjxvU9G977ntsLh4MijbKycskL5GV0VZj504vuZsU9swT9lrVevT3I5amBbPa5jLOwHymgFZm6UUztduvEN/7krvNebmrQbze7FYHraMkDO9lTuw02MnaAGSMutJqnhdo+aIKiguOV+oEF7BJpCJumwan3zAEFoE9yQo2/uNTGsDKdXdXTj5vlGVVD2mFKG73MO2J6CRBilSAlDHSNSWbValjlvetvGfDQBRi0cV1bqJCWmsFGLAS/sQec6fmbroyk6Cs0gS5CRnYzm9BXBiYr8TRmWl9qx3gIPA5Kgqo/AiZu3AkUOYJlwcVeAGcGTGZgRFT0gO9wTzmHfSJka76tXfSHzxO6/nKWoa71BoxhjL6qbcjD1HAiBrJoj3y1+b3JFd17L02A17kvUOfQyoS0u/VyH8cgHwL3IkP6S1KQtOLeUDD3QimMPBiTnuXEqqzqT38LreMCirrNHvNf5HzDv6ijJZmHco5y6havfiFgp+oDl/pbMeDSOi3KC47Uft2sI6+/SNyS6GpMwTdAzAEmqI0Jhau0ZkWf1egx1mNzS4AFervg+P/oi4zk6vYDUN6EK0OZu/QBJRQM+TSj6/cWsiutzd+Wtu43WfkIBGh5uTXCEXTgmAPsFoCk26tgUFEt9chwYiSiFXx5l+amTbbajff";    // use your token
            service.RequesterCredentials.Credentials = new UserIdPasswordType();
            service.RequesterCredentials.Credentials.AppId = appId;
            service.RequesterCredentials.Credentials.DevId = devId;
            service.RequesterCredentials.Credentials.AuthCert = certId;

            // Make the call to GeteBayOfficialTime
            GeteBayOfficialTimeRequestType request = new GeteBayOfficialTimeRequestType();
            request.Version = "405";

            GeteBayOfficialTimeResponseType response = service.GeteBayOfficialTime(request);
            Console.WriteLine("The time at eBay headquarters in San Jose, California, USA, is:");
            Console.WriteLine(response.Timestamp);

            return ("ebay time : " + response.Timestamp.ToString());
        }
    }
}