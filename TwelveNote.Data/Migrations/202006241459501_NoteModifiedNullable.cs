namespace TwelveNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoteModifiedNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "ModifiedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
