namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDataModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Access_VM", "ActionCode_Id", c => c.Int());
            CreateIndex("dbo.Access_VM", "ActionCode_Id");
            AddForeignKey("dbo.Access_VM", "ActionCode_Id", "dbo.Action_VM", "Id");
            DropColumn("dbo.Access_VM", "ActionCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Access_VM", "ActionCode", c => c.Int(nullable: false));
            DropForeignKey("dbo.Access_VM", "ActionCode_Id", "dbo.Action_VM");
            DropIndex("dbo.Access_VM", new[] { "ActionCode_Id" });
            DropColumn("dbo.Access_VM", "ActionCode_Id");
        }
    }
}
