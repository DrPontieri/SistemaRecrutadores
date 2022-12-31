using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraEstrutura.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTecnologia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTecnologia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoTecnologia = table.Column<string>(type: "varchar(200)", nullable: false),
                    TipoTecnologiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnologia_TipoTecnologia_TipoTecnologiaId",
                        column: x => x.TipoTecnologiaId,
                        principalTable: "TipoTecnologia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Empresa = table.Column<string>(type: "varchar(200)", nullable: true),
                    TipoTecnologiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_TipoTecnologia_TipoTecnologiaId",
                        column: x => x.TipoTecnologiaId,
                        principalTable: "TipoTecnologia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tecnologia_TipoTecnologiaId",
                table: "Tecnologia",
                column: "TipoTecnologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TipoTecnologiaId",
                table: "User",
                column: "TipoTecnologiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tecnologia");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "TipoTecnologia");
        }
    }
}
