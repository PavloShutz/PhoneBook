using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phone_Book.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Callers_Category_CategoryId",
                table: "Callers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Callers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Callers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 1,
                columns: new[] { "Address", "Email" },
                values: new object[] { "123 Main St", "pasha@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 2,
                columns: new[] { "Address", "Email" },
                values: new object[] { "456 Elm St", "olga@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 3,
                columns: new[] { "Address", "Email" },
                values: new object[] { "789 Oak St", "ivan@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 4,
                columns: new[] { "Address", "Email" },
                values: new object[] { "101 Pine St", "sofia@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 5,
                columns: new[] { "Address", "Email" },
                values: new object[] { "202 Maple St", "dmytro@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 6,
                columns: new[] { "Address", "Email" },
                values: new object[] { "303 Birch St", "kateryna@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 7,
                columns: new[] { "Address", "Email" },
                values: new object[] { "404 Cedar St", "andriy@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 8,
                columns: new[] { "Address", "Email" },
                values: new object[] { "505 Walnut St", "natalia@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 9,
                columns: new[] { "Address", "Email" },
                values: new object[] { "606 Chestnut St", "oleh@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 10,
                columns: new[] { "Address", "Email" },
                values: new object[] { "707 Spruce St", "mariya@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 11,
                columns: new[] { "Address", "Email" },
                values: new object[] { "808 Fir St", "serhiy@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 12,
                columns: new[] { "Address", "Email" },
                values: new object[] { "909 Willow St", "yulia@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 13,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1010 Poplar St", "volodymyr@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 14,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1111 Aspen St", "anastasia@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 15,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1212 Redwood St", "bohdan@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 16,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1313 Sequoia St", "viktoria@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 17,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1414 Cypress St", "mykola@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 18,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1515 Magnolia St", "iryna@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 19,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1616 Dogwood St", "taras@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 20,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1717 Hickory St", "liliya@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 21,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1818 Sycamore St", "petro@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 22,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1919 Beech St", "oksana@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 23,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2020 Alder St", "hanna@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 24,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2121 Maple St", "ruslan@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 25,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2222 Elm St", "ludmila@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 26,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2323 Oak St", "roman@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 27,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2424 Pine St", "vasyl@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 28,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2525 Cedar St", "oleksii@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 29,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2626 Walnut St", "alina@example.com" });

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 30,
                columns: new[] { "Address", "Email" },
                values: new object[] { "2727 Chestnut St", "denys@example.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_Callers_Categories_CategoryId",
                table: "Callers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Callers_Categories_CategoryId",
                table: "Callers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Callers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Callers");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Callers_Category_CategoryId",
                table: "Callers",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
