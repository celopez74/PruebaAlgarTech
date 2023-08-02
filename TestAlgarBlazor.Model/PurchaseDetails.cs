using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgarBlazor.Model
{
    public class PurchaseDetails
    {
        public int purchaseDetailsId { get; set; }
        public int purchaseId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public float unitPrice { get; set; }
        public float totalPrice { get; set; }
    }
}
