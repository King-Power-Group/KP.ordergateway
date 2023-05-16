using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
  public  class QuerySumPaymentModel
    {
        public string suborder_type { get; set; }
        public decimal amount { get; set; }
        public decimal amount_vat { get; set; } 
    }
}
