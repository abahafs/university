namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nnnn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.courses", "TeachId", c => c.Int());
            CreateIndex("dbo.courses", "TeachId");
            AddForeignKey("dbo.courses", "TeachId", "dbo.teachers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "TeachId", "dbo.teachers");
            DropIndex("dbo.courses", new[] { "TeachId" });
            DropColumn("dbo.courses", "TeachId");
        }
    }
}
