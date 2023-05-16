using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public class Common
    {
    }

    public class Query
    {
        [Key]
        public string ArticleCode { get; set; }
    }
}
