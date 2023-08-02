using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.BusinessLogic.ApplicationServices
{
    public interface IPurchaseApplicationService
    {
        public int InsertPurchase(string customerName, string customerAddress);

        public bool InsertPurchaseDetails(PurchaseDetails details);

        string getPurchaseInfoById(int purchaseId);
    }
}
    