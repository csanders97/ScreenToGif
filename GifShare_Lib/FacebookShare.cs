using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GifShare_Lib
{
    public class FacebookShare : IPlatformShare
    {
        private string appID = "";
        private string appSecret = "";

        public void PullSecrets()
        {
            JObject facebookSecrets = JObject.Parse(File.ReadAllText("../Data/PlatformSecrets.json"));

            appID = facebookSecrets["facebook"]["appid"].ToString();
            appSecret = facebookSecrets["facebook"]["appsecret"].ToString();
        }

        public void ShareGif()
        {

        }
    }
}
