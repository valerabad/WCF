using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    [ServiceContract]
    public interface IContractOld
    {
        [OperationContract]
        int ReturnInt(int param);
        [OperationContract]
        string ReturnString(string param);

    }
    [ServiceContract (Name = "IContract")]
    public interface IContractNew
    {
        [OperationContract(Name ="ReturnInt")]
        int ReturnIntAdd10(int param);
    }
}
