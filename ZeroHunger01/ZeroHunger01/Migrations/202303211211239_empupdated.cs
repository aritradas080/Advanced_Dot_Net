namespace ZeroHunger01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empupdated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Foodname");
            DropColumn("dbo.Employees", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Foodname", c => c.String());
        }
    }
}
