using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel
{
    public partial class DbConnection
    {
        public string ConCode { get; set; }
        public string DbType { get; set; }
        public string DbBranch { get; set; }
        public string DbServer { get; set; }
        public string DbName { get; set; }
        public string DbUser { get; set; }
        public string DbPass { get; set; }
        public bool? IsCancel { get; set; }
        public string SubBranch { get; set; }
    }
}
