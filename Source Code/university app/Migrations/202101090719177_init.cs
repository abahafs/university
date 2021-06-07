namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        courseName = c.String(),
                        isAvilable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Roomname = c.String(),
                        size = c.Int(nullable: false),
                        isavilable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        studentname = c.String(),
                        studentnumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        teachertname = c.String(),
                        teachernumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.teachers");
            DropTable("dbo.students");
            DropTable("dbo.rooms");
            DropTable("dbo.courses");
        }
    }
}
