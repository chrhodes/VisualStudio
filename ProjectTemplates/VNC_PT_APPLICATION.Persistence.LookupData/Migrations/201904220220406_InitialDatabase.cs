namespace VNC_PT_APPLICATION.Persistence.LookupData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Lookup.LookupType1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayMember = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Lookup.LookupType1");
        }
    }
}
