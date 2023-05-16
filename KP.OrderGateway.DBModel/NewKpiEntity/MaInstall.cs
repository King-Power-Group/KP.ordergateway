using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MaInstall
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileVersion { get; set; }
        public byte[] FileBinary { get; set; }
        public decimal FileSize { get; set; }
        public DateTime? FileDatetime { get; set; }
        public DateTime? FileRelease { get; set; }
    }
}
