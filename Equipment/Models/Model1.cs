namespace Equipment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<newEquipment> newEquipments { get; set; }
        public virtual DbSet<TablesLocation> TablesLocations { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturers { get; set; }
        public virtual DbSet<TablesModel> TablesModels { get; set; }
        public virtual DbSet<TablesSize> TablesSizes { get; set; }
        public virtual DbSet<TablesStopReason> TablesStopReasons { get; set; }
        public virtual DbSet<TablesSupplier> TablesSuppliers { get; set; }
        public virtual DbSet<TableStopReason> TableStopReasons { get; set; }
        public virtual DbSet<TrackMeter> TrackMeters { get; set; }
        public virtual DbSet<TrackServiceHistory> TrackServiceHistories { get; set; }
        public virtual DbSet<TrackServiceHistoryPart> TrackServiceHistoryParts { get; set; }
        public virtual DbSet<TrackServiceHistoryProvider> TrackServiceHistoryProviders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
