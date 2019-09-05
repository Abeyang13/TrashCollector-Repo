namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rdmigrationforemployeeandcustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Employees", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Customers", "Email");
        }
    }
}
