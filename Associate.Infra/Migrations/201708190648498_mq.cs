namespace Associate.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Week_7.AssociateApps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        MaritalStatus = c.Boolean(nullable: false),
                        District = c.String(nullable: false),
                        Town = c.String(nullable: false),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Week_7.AssociateApps");
        }
    }
}
