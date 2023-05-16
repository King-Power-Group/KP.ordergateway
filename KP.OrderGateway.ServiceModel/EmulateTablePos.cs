using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class EmulateTablePos
    {
    }

    public class dfSohdrExtTable
    {
        [Key]
        public string branch_no { get; set; }
        [Key]
        public string shopping_card { get; set; }
        [Key]
        public int order_no { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
