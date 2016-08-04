namespace CV.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 255),
                        ConfirmPassword = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
