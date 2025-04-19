using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Phone_Book.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Callers",
                columns: table => new
                {
                    CallerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Number = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Callers", x => x.CallerId);
                    table.ForeignKey(
                        name: "FK_Callers_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Work" },
                    { 3, "Friends" },
                    { 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Callers",
                columns: new[] { "CallerId", "CategoryId", "Name", "Number" },
                values: new object[,]
                {
                    { 1, 1, "Pasha", "+380-096-123-0001" },
                    { 2, 2, "Olga", "+380-068-987-0002" },
                    { 3, 3, "Ivan", "+380-096-654-0003" },
                    { 4, 4, "Sofia", "+380-068-321-0004" },
                    { 5, 1, "Dmytro", "+380-096-555-0005" },
                    { 6, 2, "Kateryna", "+380-068-789-0006" },
                    { 7, 3, "Andriy", "+380-096-345-0007" },
                    { 8, 4, "Natalia", "+380-068-234-0008" },
                    { 9, 1, "Oleh", "+380-096-876-0009" },
                    { 10, 2, "Mariya", "+380-068-543-0010" },
                    { 11, 3, "Serhiy", "+380-096-432-0011" },
                    { 12, 4, "Yulia", "+380-068-765-0012" },
                    { 13, 1, "Volodymyr", "+380-096-678-0013" },
                    { 14, 2, "Anastasia", "+380-068-890-0014" },
                    { 15, 3, "Bohdan", "+380-096-210-0015" },
                    { 16, 4, "Viktoria", "+380-068-432-0016" },
                    { 17, 1, "Mykola", "+380-096-543-0017" },
                    { 18, 2, "Iryna", "+380-068-654-0018" },
                    { 19, 3, "Taras", "+380-096-765-0019" },
                    { 20, 4, "Liliya", "+380-068-876-0020" },
                    { 21, 1, "Petro", "+380-096-987-0021" },
                    { 22, 2, "Oksana", "+380-068-109-0022" },
                    { 23, 3, "Hanna", "+380-096-218-0023" },
                    { 24, 4, "Ruslan", "+380-068-327-0024" },
                    { 25, 1, "Ludmila", "+380-096-436-0025" },
                    { 26, 2, "Roman", "+380-068-545-0026" },
                    { 27, 3, "Vasyl", "+380-096-654-0027" },
                    { 28, 4, "Oleksii", "+380-068-763-0028" },
                    { 29, 1, "Alina", "+380-096-872-0029" },
                    { 30, 2, "Denys", "+380-068-981-0030" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Callers_CategoryId",
                table: "Callers",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Callers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
