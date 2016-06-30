﻿using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    // Define a service contract
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        int CalcFactorial(int i);
        [OperationContract]
        string ReversString(string param);
        [OperationContract]
        Player GetPlayer(int id);
        [OperationContract]
        void SetPlayer(Player player);
    }    
    
}
