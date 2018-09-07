namespace Equipment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackServiceHistoryProvider")]
    public partial class TrackServiceHistoryProvider
    {
        [Key]
        public int intServiceHistoryProviderID { get; set; }

        public int intSupplierId { get; set; }

        public double? intRepairLabor { get; set; }

        public double? intLaborRate { get; set; }

        public int? intServiceHistoryId { get; set; }

        [StringLength(12)]
        public string old_job_no { get; set; }

        public virtual TablesSupplier TablesSupplier { get; set; }
        public virtual TrackServiceHistory TrackServiceHistory { get; set; }
    }
}
