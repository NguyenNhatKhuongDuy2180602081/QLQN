namespace QLQN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNC { get; set; }

        public int Gia { get; set; }

        public int SoLuong { get; set; }

        public int TongTien { get; set; }

        public virtual Nuoc Nuoc { get; set; }
    }
}
