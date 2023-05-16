using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMachine
    {
        public DfMachine()
        {
            WalletAgent = new HashSet<WalletAgent>();
        }

        public string BranchNo { get; set; }
        public string MachineNo { get; set; }
        public string MachineName { get; set; }
        public string MachineIp { get; set; }
        public string MachineTax { get; set; }
        public decimal VatRate { get; set; }
        public int PrintBarcode { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string LocCode { get; set; }
        public string VatCode { get; set; }
        public short MaxShift { get; set; }
        public short Channel { get; set; }
        public string CurrCode { get; set; }
        public int Preorder { get; set; }
        public int PrintSlip { get; set; }
        public int PrintInvoice { get; set; }
        public int DateRemove { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool D6 { get; set; }
        public bool D7 { get; set; }
        public bool D1 { get; set; }
        public string OdbcCenter { get; set; }
        public string SwitchLoc { get; set; }
        public bool NaDelete { get; set; }
        public bool NaEsc { get; set; }
        public bool NaChangeQty { get; set; }
        public string ArrdepTerminal { get; set; }
        public string MacStatus { get; set; }
        public bool AllowRcv { get; set; }
        public bool TbagMachine { get; set; }
        public bool ConsolFlag { get; set; }
        public bool AutoRegister { get; set; }
        public bool? AutoTake { get; set; }
        public bool RefundMachine { get; set; }
        public short PosType { get; set; }
        public string PriceList { get; set; }
        public string Dchannel { get; set; }
        public bool ECommerceFlag { get; set; }
        public bool ECommerceDelivery { get; set; }
        public bool? PrintTbag { get; set; }
        public string PlatformId { get; set; }
        public bool SignPad { get; set; }
        public string VatrefundMachineNo { get; set; }
        public bool? IsSelfCheckout { get; set; }

        public virtual ICollection<WalletAgent> WalletAgent { get; set; }
    }
}
