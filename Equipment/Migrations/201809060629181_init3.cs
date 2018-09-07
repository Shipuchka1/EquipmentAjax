namespace Equipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TrackServiceHistoryProvider", "intSupplierId");
            CreateIndex("dbo.TrackServiceHistoryProvider", "intServiceHistoryId");
            AddForeignKey("dbo.TrackServiceHistoryProvider", "intSupplierId", "dbo.TablesSupplier", "intSupplierId", cascadeDelete: true);
            AddForeignKey("dbo.TrackServiceHistoryProvider", "intServiceHistoryId", "dbo.TrackServiceHistory", "intServiceHistoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrackServiceHistoryProvider", "intServiceHistoryId", "dbo.TrackServiceHistory");
            DropForeignKey("dbo.TrackServiceHistoryProvider", "intSupplierId", "dbo.TablesSupplier");
            DropIndex("dbo.TrackServiceHistoryProvider", new[] { "intServiceHistoryId" });
            DropIndex("dbo.TrackServiceHistoryProvider", new[] { "intSupplierId" });
        }
    }
}
