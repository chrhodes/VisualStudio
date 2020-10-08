namespace VNC_PT_APPLICATION.Persistence.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreDatatypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("Domain.TYPE", "FieldSingle", c => c.Single(nullable: false));
            AddColumn("Domain.TYPE", "FieldDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Domain.TYPE", "FieldDate");
            DropColumn("Domain.TYPE", "FieldSingle");
        }
    }
}
