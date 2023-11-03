using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Folha01.Migrations
{
    public partial class InicialCriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficios",
                columns: table => new
                {
                    IdBeneficios = table.Column<int>(name: "IdBeneficios ", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recisaofuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorasExtras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VA = table.Column<double>(type: "float", nullable: false),
                    VT = table.Column<double>(type: "float", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficios", x => x.IdBeneficios);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    IdContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.IdContrato);
                });

            migrationBuilder.CreateTable(
                name: "Frequencia",
                columns: table => new
                {
                    IdFrequencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<double>(type: "float", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequencia", x => x.IdFrequencia);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario cadastro",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<double>(type: "float", nullable: false),
                    Cep = table.Column<double>(type: "float", nullable: false),
                    DatadeNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario cadastro", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario Cargo",
                columns: table => new
                {
                    IdCadastro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Função = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario Cargo", x => x.IdCadastro);
                });

            migrationBuilder.CreateTable(
                name: "Holerite",
                columns: table => new
                {
                    IDHolerite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    IdContrato = table.Column<int>(type: "int", nullable: false),
                    IdBeneficios = table.Column<int>(type: "int", nullable: false),
                    IdFrequencia = table.Column<int>(type: "int", nullable: false),
                    Data_Atual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Admissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalarioBase = table.Column<double>(type: "float", nullable: false),
                    SalarioLiquido = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holerite", x => x.IDHolerite);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficios");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Frequencia");

            migrationBuilder.DropTable(
                name: "Funcionario cadastro");

            migrationBuilder.DropTable(
                name: "Funcionario Cargo");

            migrationBuilder.DropTable(
                name: "Holerite");
        }
    }
}
