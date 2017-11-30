namespace VocabLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "StudentGroup_Id", "dbo.StudentGroups");
            DropForeignKey("dbo.StudentGroups", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "StudentGroup_Id1", "dbo.StudentGroups");
            DropForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Users");
            DropIndex("dbo.StudentGroups", new[] { "Teacher_Id" });
            DropIndex("dbo.StudentGroups", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "StudentGroup_Id" });
            DropIndex("dbo.Users", new[] { "StudentGroup_Id1" });
            DropColumn("dbo.StudentGroups", "Teacher_Id");
            DropColumn("dbo.StudentGroups", "User_Id");
            DropColumn("dbo.Users", "StudentGroup_Id");
            DropColumn("dbo.Users", "StudentGroup_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "StudentGroup_Id1", c => c.String(maxLength: 128));
            AddColumn("dbo.Users", "StudentGroup_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.StudentGroups", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.StudentGroups", "Teacher_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Users", "StudentGroup_Id1");
            CreateIndex("dbo.Users", "StudentGroup_Id");
            CreateIndex("dbo.StudentGroups", "User_Id");
            CreateIndex("dbo.StudentGroups", "Teacher_Id");
            AddForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "StudentGroup_Id1", "dbo.StudentGroups", "Id");
            AddForeignKey("dbo.StudentGroups", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "StudentGroup_Id", "dbo.StudentGroups", "Id");
        }
    }
}
