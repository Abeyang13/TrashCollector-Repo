namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4removeemailfromcustomerandemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            AddColumn("dbo.Employees", "LastName", c => c.String());
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Employees", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Customers", "Email", c => c.String());
            DropColumn("dbo.Employees", "LastName");
            DropColumn("dbo.Employees", "FirstName");
        }
    }
}
