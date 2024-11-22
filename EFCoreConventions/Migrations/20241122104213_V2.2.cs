using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConventions.Migrations
{
    /// <inheritdoc />
    public partial class V22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbTypeTests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestDecimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TestDecimalNull = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TestDouble = table.Column<double>(type: "float", nullable: false),
                    TestDoubleNull = table.Column<double>(type: "float", nullable: true),
                    Testint = table.Column<int>(type: "int", nullable: false),
                    TestIntNull = table.Column<int>(type: "int", nullable: true),
                    Testbool = table.Column<bool>(type: "bit", nullable: false),
                    TestboolNull = table.Column<bool>(type: "bit", nullable: true),
                    TestDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestDateTimeNull = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TestByte = table.Column<byte>(type: "tinyint", nullable: false),
                    TestByteNull = table.Column<byte>(type: "tinyint", nullable: true),
                    TestByteA = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TestUnit = table.Column<long>(type: "bigint", nullable: false),
                    TestUnitNull = table.Column<long>(type: "bigint", nullable: true),
                    TestShort = table.Column<short>(type: "smallint", nullable: false),
                    TestUShort = table.Column<int>(type: "int", nullable: false),
                    testChar = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbTypeTests", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbTypeTests");
        }
    }
}
