using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.DataAccess.Repositories
{
    public interface IPurchaseRepository
    {
        int InsertPurchase(string customerName, string customerAddress);

        bool InsertPurchaseDetails(PurchaseDetails details);

        string getPurchaseInfoById(int purchaseId);
    }
}
