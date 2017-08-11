using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GifShare_Lib
{
    public class ImgurShare : IPlatformShare
    {
        private string appID = "";
        private string appSecret = "";

        public void PullSecrets()
        {
            JObject imgurSecrets = JObject.Parse(File.ReadAllText("../Data/PlatformSecrets.json"));

            appID = imgurSecrets["imgur"]["appid"].ToString();
            appSecret = imgurSecrets["imgur"]["appsecret"].ToString();
        }

        public void ShareGif()
        {

        }
    }
}
