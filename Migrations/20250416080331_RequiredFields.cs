using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phone_Book.Migrations
{
    /// <inheritdoc />
    public partial class RequiredFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Callers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Callers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Callers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Callers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 1,
                column: "Number",
                value: "(+38)-096-123-0001");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 2,
                column: "Number",
                value: "(+38)-068-987-0002");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 3,
                column: "Number",
                value: "(+38)-096-654-0003");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 4,
                column: "Number",
                value: "(+38)-068-321-0004");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 5,
                column: "Number",
                value: "(+38)-096-555-0005");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 6,
                column: "Number",
                value: "(+38)-068-789-0006");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 7,
                column: "Number",
                value: "(+38)-096-345-0007");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 8,
                column: "Number",
                value: "(+38)-068-234-0008");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 9,
                column: "Number",
                value: "(+38)-096-876-0009");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 10,
                column: "Number",
                value: "(+38)-068-543-0010");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 11,
                column: "Number",
                value: "(+38)-096-432-0011");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 12,
                column: "Number",
                value: "(+38)-068-765-0012");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 13,
                column: "Number",
                value: "(+38)-096-678-0013");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 14,
                column: "Number",
                value: "(+38)-068-890-0014");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 15,
                column: "Number",
                value: "(+38)-096-210-0015");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 16,
                column: "Number",
                value: "(+38)-068-432-0016");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 17,
                column: "Number",
                value: "(+38)-096-543-0017");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 18,
                column: "Number",
                value: "(+38)-068-654-0018");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 19,
                column: "Number",
                value: "(+38)-096-765-0019");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 20,
                column: "Number",
                value: "(+38)-068-876-0020");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 21,
                column: "Number",
                value: "(+38)-096-987-0021");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 22,
                column: "Number",
                value: "(+38)-068-109-0022");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 23,
                column: "Number",
                value: "(+38)-096-218-0023");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 24,
                column: "Number",
                value: "(+38)-068-327-0024");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 25,
                column: "Number",
                value: "(+38)-096-436-0025");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 26,
                column: "Number",
                value: "(+38)-068-545-0026");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 27,
                column: "Number",
                value: "(+38)-096-654-0027");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 28,
                column: "Number",
                value: "(+38)-068-763-0028");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 29,
                column: "Number",
                value: "(+38)-096-872-0029");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 30,
                column: "Number",
                value: "(+38)-068-981-0030");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "All" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Callers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Callers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Callers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Callers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 1,
                column: "Number",
                value: "+380-096-123-0001");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 2,
                column: "Number",
                value: "+380-068-987-0002");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 3,
                column: "Number",
                value: "+380-096-654-0003");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 4,
                column: "Number",
                value: "+380-068-321-0004");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 5,
                column: "Number",
                value: "+380-096-555-0005");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 6,
                column: "Number",
                value: "+380-068-789-0006");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 7,
                column: "Number",
                value: "+380-096-345-0007");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 8,
                column: "Number",
                value: "+380-068-234-0008");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 9,
                column: "Number",
                value: "+380-096-876-0009");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 10,
                column: "Number",
                value: "+380-068-543-0010");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 11,
                column: "Number",
                value: "+380-096-432-0011");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 12,
                column: "Number",
                value: "+380-068-765-0012");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 13,
                column: "Number",
                value: "+380-096-678-0013");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 14,
                column: "Number",
                value: "+380-068-890-0014");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 15,
                column: "Number",
                value: "+380-096-210-0015");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 16,
                column: "Number",
                value: "+380-068-432-0016");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 17,
                column: "Number",
                value: "+380-096-543-0017");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 18,
                column: "Number",
                value: "+380-068-654-0018");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 19,
                column: "Number",
                value: "+380-096-765-0019");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 20,
                column: "Number",
                value: "+380-068-876-0020");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 21,
                column: "Number",
                value: "+380-096-987-0021");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 22,
                column: "Number",
                value: "+380-068-109-0022");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 23,
                column: "Number",
                value: "+380-096-218-0023");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 24,
                column: "Number",
                value: "+380-068-327-0024");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 25,
                column: "Number",
                value: "+380-096-436-0025");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 26,
                column: "Number",
                value: "+380-068-545-0026");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 27,
                column: "Number",
                value: "+380-096-654-0027");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 28,
                column: "Number",
                value: "+380-068-763-0028");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 29,
                column: "Number",
                value: "+380-096-872-0029");

            migrationBuilder.UpdateData(
                table: "Callers",
                keyColumn: "CallerId",
                keyValue: 30,
                column: "Number",
                value: "+380-068-981-0030");
        }
    }
}
