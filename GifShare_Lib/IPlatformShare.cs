using System;
using System.Collections.Generic;
using System.Text;

namespace GifShare_Lib
{
    public interface IPlatformShare
    {
        void PullSecrets();
        void ShareGif();
    }
}
