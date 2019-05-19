using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService.DTO;

namespace WCFService.Contracts
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract(IsOneWay = true)]
        void AddMobile(MobileDTO modile);

        [OperationContract]
        List<MobileDTO> GetMobiles();
    }
}
