using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SAPTransferOrder
    {
      [Key]
      public long  TransOrderKey { get; set; }
      public string branch_no { get; set; }
      public long RecNo { get; set; }
      public string shopping_card { get; set; }
      public int order_no { get; set; }
      public string suborder_type { get; set; }
      public DateTime order_date { get; set; }
      public string cashier_mac { get; set; }
      public string taxabb_no { get; set; }
      public string order_status { get; set; }
      public string pack_no { get; set; }
      public string HangingNo { get; set; }
      public string transfer_status { get; set; }
      public DateTime add_datetime { get; set; }
      public DateTime? hang_rq_dt { get; set; }
      public string hang_rq_json { get; set; }
      public string hang_rs_json { get; set; }
      public string hang_rs_status { get; set; }
      public string sap_status { get; set; }
      public string sap_message { get; set; }
      public string SAP_Request { get; set; }
      public string SAP_Response { get; set; }
    }
}
