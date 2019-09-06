namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedcustomerpickupdatetoday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpDay", c => c.String());
            DropColumn("dbo.Customers", "PickUpDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PickUpDate", c => c.String());
            DropColumn("dbo.Customers", "PickUpDay");
        }
    }
}
