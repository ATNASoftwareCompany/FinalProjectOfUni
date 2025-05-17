namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBook : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Book_VM", "Book_VM_Id", "dbo.Book_VM");
            DropIndex("dbo.Book_VM", new[] { "Book_VM_Id" });
            DropColumn("dbo.Book_VM", "HasCollection");
            DropColumn("dbo.Book_VM", "Book_VM_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Book_VM", "Book_VM_Id", c => c.Int());
            AddColumn("dbo.Book_VM", "HasCollection", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Book_VM", "Book_VM_Id");
            AddForeignKey("dbo.Book_VM", "Book_VM_Id", "dbo.Book_VM", "Id");
        }
    }
}
