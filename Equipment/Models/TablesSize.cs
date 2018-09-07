namespace Equipment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSize")]
    public partial class TablesSize
    {
        [Key]
        public int intSizeID { get; set; }

        [StringLength(12)]
        public string strSize { get; set; }
    }
}
