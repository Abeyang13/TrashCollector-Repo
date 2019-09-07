namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedconfirmpickuptocustomermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ConfirmPickUp", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ConfirmPickUp");
        }
    }
}
