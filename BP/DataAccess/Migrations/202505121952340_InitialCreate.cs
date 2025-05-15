namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Access_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionCode = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Action_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionCode = c.Int(nullable: false),
                        ActionName = c.String(),
                        IsMenu = c.Boolean(nullable: false),
                        IsShow = c.Boolean(nullable: false),
                        Priority = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Activation_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivationCode = c.Int(nullable: false),
                        PhoneNo = c.String(),
                        RemainingTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookAuthor_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Book_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookTitle = c.String(),
                        Summary = c.String(),
                        BookGenre = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Author = c.Int(nullable: false),
                        Publisher = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        HasDiscount = c.Boolean(nullable: false),
                        DiscountType = c.Int(nullable: false),
                        DiscountAmount = c.Int(nullable: false),
                        HasCollection = c.Boolean(nullable: false),
                        WriteDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        Book_VM_Id = c.Int(),
                        BookAuthor_VM_Id = c.Int(),
                        BookGenre_VM_Id = c.Int(),
                        BookPublisher_VM_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book_VM", t => t.Book_VM_Id)
                .ForeignKey("dbo.BookAuthor_VM", t => t.BookAuthor_VM_Id)
                .ForeignKey("dbo.BookGenre_VM", t => t.BookGenre_VM_Id)
                .ForeignKey("dbo.BookPublisher_VM", t => t.BookPublisher_VM_Id)
                .Index(t => t.Book_VM_Id)
                .Index(t => t.BookAuthor_VM_Id)
                .Index(t => t.BookGenre_VM_Id)
                .Index(t => t.BookPublisher_VM_Id);
            
            CreateTable(
                "dbo.BookGenre_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookPublisher_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PhoneNo = c.String(),
                        E_Mail = c.String(),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User_VM",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Status = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book_VM", "BookPublisher_VM_Id", "dbo.BookPublisher_VM");
            DropForeignKey("dbo.Book_VM", "BookGenre_VM_Id", "dbo.BookGenre_VM");
            DropForeignKey("dbo.Book_VM", "BookAuthor_VM_Id", "dbo.BookAuthor_VM");
            DropForeignKey("dbo.Book_VM", "Book_VM_Id", "dbo.Book_VM");
            DropIndex("dbo.Book_VM", new[] { "BookPublisher_VM_Id" });
            DropIndex("dbo.Book_VM", new[] { "BookGenre_VM_Id" });
            DropIndex("dbo.Book_VM", new[] { "BookAuthor_VM_Id" });
            DropIndex("dbo.Book_VM", new[] { "Book_VM_Id" });
            DropTable("dbo.User_VM");
            DropTable("dbo.Person_VM");
            DropTable("dbo.BookPublisher_VM");
            DropTable("dbo.BookGenre_VM");
            DropTable("dbo.Book_VM");
            DropTable("dbo.BookAuthor_VM");
            DropTable("dbo.Activation_VM");
            DropTable("dbo.Action_VM");
            DropTable("dbo.Access_VM");
        }
    }
}
