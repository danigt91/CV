namespace CV.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioUniqueConstraint : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Usuario", "UserName", unique: true, name: "IX_Usuario_UserName_UQ");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", "IX_Usuario_UserName_UQ");
        }
    }
}
