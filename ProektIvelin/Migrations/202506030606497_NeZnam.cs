namespace ProektIvelin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NeZnam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vegetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Type = c.String(),
                        VegetableTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VegetableTypes", t => t.VegetableTypeId, cascadeDelete: true)
                .Index(t => t.VegetableTypeId);
            
            CreateTable(
                "dbo.VegetableTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VegetableType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VegetableTypes", t => t.VegetableType_Id)
                .Index(t => t.VegetableType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegetables", "VegetableTypeId", "dbo.VegetableTypes");
            DropForeignKey("dbo.VegetableTypes", "VegetableType_Id", "dbo.VegetableTypes");
            DropIndex("dbo.VegetableTypes", new[] { "VegetableType_Id" });
            DropIndex("dbo.Vegetables", new[] { "VegetableTypeId" });
            DropTable("dbo.VegetableTypes");
            DropTable("dbo.Vegetables");
        }
    }
}
