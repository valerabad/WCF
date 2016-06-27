using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormApp
{
    class Proxy : ClientBase<Service.IContract>, Service.IContract
    {
        public int ReturnInt(int param)
        {
            return base.Channel.ReturnInt(param);
        }

        public string ReturnString(string param)
        {
            return base.Channel.ReturnString(param);
        }
    }
}
