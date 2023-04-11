namespace FinaleDemo03DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pid = c.Int(nullable: false),
                        Role = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Pid);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Status = c.String(),
                        Startdate = c.DateTime(nullable: false),
                        Enddate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Pid", "dbo.Projects");
            DropIndex("dbo.Members", new[] { "Pid" });
            DropTable("dbo.Projects");
            DropTable("dbo.Members");
        }
    }
}
