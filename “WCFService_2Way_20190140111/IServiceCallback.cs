using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _WCFService_2Way_20190140111
{
    
    [ServiceContract]
    public interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void gabung(string username);
        [OperationContract(IsOneWay = true)]
        void kirimPesan(string pesan);
    }
}
