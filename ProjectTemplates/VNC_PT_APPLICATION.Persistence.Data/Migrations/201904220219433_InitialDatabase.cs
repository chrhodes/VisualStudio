namespace VNC_PT_APPLICATION.Persistence.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Domain.TYPE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FieldString = c.String(maxLength: 50),
                        FieldInt = c.Int(nullable: false),
                        FieldDouble = c.Double(nullable: false),
                        DateModified = c.DateTime(),
                        DateCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Domain.TYPE");
        }
    }
}
