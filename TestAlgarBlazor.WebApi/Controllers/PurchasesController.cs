using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TestAlgarBlazor.BusinessLogic.ApplicationServices;

//inject IPurchaseApplicationService PurchaseApplicationService;

namespace TestAlgarBlazor.WebApi.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly IPurchaseApplicationService _purchaseApplicationService;

        public PurchasesController(IPurchaseApplicationService purchaseApplicationService)
        { 
            _purchaseApplicationService = purchaseApplicationService;
        }

        // GET: PurchasesController/GetPurchaseDetailsById/5
        [HttpGet]
        [Route("GetPurchaseDetailsById")]
        public string GetPurchaseDetailsById(int id)
        {
            return _purchaseApplicationService.getPurchaseInfoById(id);
            
        }

        
    }
}
