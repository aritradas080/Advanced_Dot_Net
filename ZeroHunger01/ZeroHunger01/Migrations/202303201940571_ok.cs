namespace ZeroHunger01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ok : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        EmpStatus = c.String(),
                        Foodname = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Processes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rid = c.Int(nullable: false),
                        Eid = c.Int(nullable: false),
                        Foodname = c.String(),
                        Quantity = c.Int(nullable: false),
                        OrderStatus = c.String(),
                        EmpStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Eid, cascadeDelete: true)
                .ForeignKey("dbo.Requests", t => t.Rid, cascadeDelete: true)
                .Index(t => t.Rid)
                .Index(t => t.Eid);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        rid = c.Int(nullable: false),
                        Location = c.String(),
                        MaxTime = c.DateTime(nullable: false),
                        Foodname = c.String(),
                        Quantity = c.Int(nullable: false),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.rid, cascadeDelete: true)
                .Index(t => t.rid);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Location = c.String(),
                        MaxTime = c.DateTime(nullable: false),
                        Foodname = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processes", "Rid", "dbo.Requests");
            DropForeignKey("dbo.Requests", "rid", "dbo.Restaurants");
            DropForeignKey("dbo.Processes", "Eid", "dbo.Employees");
            DropIndex("dbo.Requests", new[] { "rid" });
            DropIndex("dbo.Processes", new[] { "Eid" });
            DropIndex("dbo.Processes", new[] { "Rid" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Requests");
            DropTable("dbo.Processes");
            DropTable("dbo.Employees");
            DropTable("dbo.Admins");
        }
    }
}
