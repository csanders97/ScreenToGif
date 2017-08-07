using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace GifShare_Lib
{
    public class FacebookShare : IPlatformShare
    {
        public void PullSecrets()
        {
            JObject
        }

        public void ShareGif()
        {
            throw new NotImplementedException();
        }
    }
}
