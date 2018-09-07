namespace Equipment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TrackServiceHistory", "intStopReason");
            AddForeignKey("dbo.TrackServiceHistory", "intStopReason", "dbo.TablesStopReason", "intStopReason");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrackServiceHistory", "intStopReason", "dbo.TablesStopReason");
            DropIndex("dbo.TrackServiceHistory", new[] { "intStopReason" });
        }
    }
}
