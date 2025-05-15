namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initProject : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person_VM", "BirthDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person_VM", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
