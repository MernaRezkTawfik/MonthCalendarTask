namespace CalendarSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Attendees", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Attendees");
        }
    }
}
