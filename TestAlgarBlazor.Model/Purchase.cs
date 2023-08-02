using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgarBlazor.Model
{
    public class Purchase
    {
        public int purchaseId { get; set; }
        public DateTime purchaseDate { get; set; }  
        public string customerName { get; set; }    
        public string customerAdrress { get; set; }

    }

    public class PurchaseApiInfo
    {
        public DateTime purchaseDate { get; set; }
        public string customerName { get; set; }
        public string customerAdrress { get; set; }
          public string productName { get; set; }
        public string productReference { get; set; }

        public int quantity { get; set; }
        public float unitPrice { get; set; }
        public float totalPrice { get; set; }

    }

}
