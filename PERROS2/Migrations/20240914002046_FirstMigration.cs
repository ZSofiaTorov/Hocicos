using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PERROS2.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<int>(type: "int", nullable: false),
                    PrecioDeCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioDeVenta = table.Column<int>(type: "int", nullable: false),
                    FechaDeCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDProveedor = table.Column<string>(name: "ID_Proveedor", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
