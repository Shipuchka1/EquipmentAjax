namespace Equipment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableStopReason")]
    public partial class TableStopReason
    {
        [Key]
        public int intStopReasonId { get; set; }

        [StringLength(255)]
        public string strReason { get; set; }
    }
}
