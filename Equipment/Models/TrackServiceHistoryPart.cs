namespace Equipment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackServiceHistoryPart")]
    public partial class TrackServiceHistoryPart
    {
        [Key]
        public int intServiceHistoryPartsId { get; set; }

        public int? intServiceHistoryId { get; set; }

        public int intMasterPartId { get; set; }

        public double? quantity { get; set; }

        public double? unit_cost { get; set; }

        [StringLength(12)]
        public string old_job_no { get; set; }

        public int? intUnitCostCurrency { get; set; }
    }
}
