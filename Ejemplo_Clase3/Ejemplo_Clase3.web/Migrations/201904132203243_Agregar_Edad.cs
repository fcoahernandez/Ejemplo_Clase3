namespace Ejemplo_Clase3.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregar_Edad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "Edad", c => c.Int(nullable: false));
            AlterColumn("dbo.Personas", "Nombre", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.Personas", "Direccion", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "Direccion", c => c.String(maxLength: 100));
            AlterColumn("dbo.Personas", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.Personas", "Edad");
        }
    }
}
