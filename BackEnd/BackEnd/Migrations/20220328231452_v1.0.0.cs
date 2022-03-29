using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "libro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Año = table.Column<string>(type: "varchar(100)", nullable: false),
                    Genero = table.Column<string>(type: "varchar(100)", nullable: false),
                    NumeroPaginas = table.Column<string>(type: "varchar(100)", nullable: false),
                    Editorial = table.Column<string>(type: "varchar(100)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(100)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "varchar(100)", nullable: false),
                    FechaNacimiento = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ciudad = table.Column<string>(type: "varchar(100)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "varchar(100)", nullable: false),
                    NombreEditorial = table.Column<string>(type: "varchar(100)", nullable: false),
                    DirecciorCorrespondencia = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(100)", nullable: false),
                    CorreoEditorial = table.Column<string>(type: "varchar(100)", nullable: false),
                    MaximoLibros = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libro");
        }
    }
}
