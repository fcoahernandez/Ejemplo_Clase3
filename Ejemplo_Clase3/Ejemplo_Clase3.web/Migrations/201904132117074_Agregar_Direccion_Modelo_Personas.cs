namespace Ejemplo_Clase3.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregar_Direccion_Modelo_Personas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "Direccion", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personas", "Direccion");
        }
    }
}
