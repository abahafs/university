namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.courses", "RoomId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.courses", "RoomId");
        }
    }
}
