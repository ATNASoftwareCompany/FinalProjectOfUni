namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useraccess : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Access_VM", "UserId");
            AddForeignKey("dbo.Access_VM", "UserId", "dbo.User_VM", "Id", cascadeDelete: true);
            DropColumn("dbo.Action_VM", "IsMenu");
            DropColumn("dbo.Action_VM", "IsShow");
            DropColumn("dbo.Action_VM", "Priority");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Action_VM", "Priority", c => c.Int(nullable: false));
            AddColumn("dbo.Action_VM", "IsShow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Action_VM", "IsMenu", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Access_VM", "UserId", "dbo.User_VM");
            DropIndex("dbo.Access_VM", new[] { "UserId" });
        }
    }
}
