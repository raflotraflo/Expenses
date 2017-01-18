namespace Expenses.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtionNewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shopping",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Timestamp = c.DateTime(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 30),
                        Password = c.String(),
                        Name = c.String(nullable: false),
                        Surname = c.String(),
                        Age = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shopping", "UserId", "dbo.User");
            DropForeignKey("dbo.Shopping", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Shopping", new[] { "CategoryId" });
            DropIndex("dbo.Shopping", new[] { "UserId" });
            DropTable("dbo.User");
            DropTable("dbo.Categories");
            DropTable("dbo.Shopping");
        }
    }
}
