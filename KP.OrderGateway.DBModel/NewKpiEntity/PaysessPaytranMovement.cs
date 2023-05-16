using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PaysessPaytranMovement
    {
        public long TranMovementId { get; set; }
        public long TranId { get; set; }
        public int TranMovementType { get; set; }
        public decimal? CurrAmt { get; set; }
        public string CurrCode { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public DateTime CreateDatetime { get; set; }

        public virtual PaysessPaytran Tran { get; set; }
    }
}
