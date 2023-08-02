using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.DataAccess.Repositories;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.BusinessLogic.ApplicationServices
{
    public class PurchaseApplicationService : IPurchaseApplicationService
    {
        private IPurchaseRepository _purchaseRepository;
        public PurchaseApplicationService(string connectionString)
        {
            _purchaseRepository = new PurchaseRepository(connectionString);
        }
        public int InsertPurchase(string customerName, string customerAddress)
        {
            return _purchaseRepository.InsertPurchase(customerName, customerAddress);   
        }

        public bool InsertPurchaseDetails(PurchaseDetails details)
        {
            return _purchaseRepository.InsertPurchaseDetails(details);
            
        }
        public string getPurchaseInfoById(int purchaseId)
        {
            return _purchaseRepository.getPurchaseInfoById(purchaseId);
        }
    }
}
