using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class Service1 : IContractNew
    {
        public int ReturnIntAdd10(int param)
        {
            return param+100;
        }
        public string ReturnString(string param)
        {
            return param;
        }
        public bool ReturnBool(bool param)
        {
            return param;
        }
    }
}
