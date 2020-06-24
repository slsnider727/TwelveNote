namespace TwelveNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNoteOwnerIdTypo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "OwnerId", c => c.Guid(nullable: false));
            DropColumn("dbo.Note", "OwnderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "OwnderId", c => c.Guid(nullable: false));
            DropColumn("dbo.Note", "OwnerId");
        }
    }
}
