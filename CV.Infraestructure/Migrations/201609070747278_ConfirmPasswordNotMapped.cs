namespace CV.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfirmPasswordNotMapped : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "ConfirmPassword", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
