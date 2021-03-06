namespace VocabLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Users");
            DropIndex("dbo.StudentGroups", new[] { "Teacher_Id" });
            DropColumn("dbo.StudentGroups", "Teacher_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentGroups", "Teacher_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.StudentGroups", "Teacher_Id");
            AddForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Users", "Id");
        }
    }
}
