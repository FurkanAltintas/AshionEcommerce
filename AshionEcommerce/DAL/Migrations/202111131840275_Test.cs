namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "StockId", c => c.Int(nullable: true));
            AddColumn("dbo.Products", "ColorId", c => c.Int(nullable: true));
            CreateIndex("dbo.Products", "StockId");
            CreateIndex("dbo.Products", "ColorId");
            AddForeignKey("dbo.Products", "ColorId", "dbo.Colors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "StockId", "dbo.Stocks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Products", "ColorId", "dbo.Colors");
            DropIndex("dbo.Products", new[] { "ColorId" });
            DropIndex("dbo.Products", new[] { "StockId" });
            DropColumn("dbo.Products", "ColorId");
            DropColumn("dbo.Products", "StockId");
        }
    }
}
