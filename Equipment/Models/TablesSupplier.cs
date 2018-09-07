namespace Equipment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSupplier")]
    public partial class TablesSupplier
    {
        [Key]
        public int intSupplierId { get; set; }

        [StringLength(30)]
        public string strSupplierName { get; set; }

        public double? intLaborRate { get; set; }

        [StringLength(12)]
        public string strCraft { get; set; }

        [StringLength(1)]
        public string strShift { get; set; }

        [StringLength(20)]
        public string strOther { get; set; }

        public int intLocationId { get; set; }

        public bool isRemove { get; set; }

        public int? intLaborRateCurrency { get; set; }
    }
}
