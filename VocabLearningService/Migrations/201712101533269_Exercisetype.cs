namespace VocabLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Exercisetype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentExercises", "Type_Id", c => c.String());
            AddColumn("dbo.StudentExercises", "Passed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentExercises", "Passed");
            DropColumn("dbo.StudentExercises", "Type_Id");
        }
    }
}
