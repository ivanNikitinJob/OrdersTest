using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderTest.Repositories.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreationDate", "Name", "Status" },
                values: new object[] { new Guid("7bdc1704-c4df-4490-afa2-2fa6af2512dc"), new DateTime(2020, 2, 28, 12, 7, 31, 399, DateTimeKind.Utc).AddTicks(836), "Order 1", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "OrderId", "Price", "Quantity" },
                values: new object[] { new Guid("2b15b990-67ad-497d-acd5-0fbccb6949d0"), "Prod 1", new Guid("7bdc1704-c4df-4490-afa2-2fa6af2512dc"), 10m, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "OrderId", "Price", "Quantity" },
                values: new object[] { new Guid("da3bf0f1-029c-4331-821d-b2505b272d76"), "Prod 2", new Guid("7bdc1704-c4df-4490-afa2-2fa6af2512dc"), 1m, 15 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "OrderId", "Price", "Quantity" },
                values: new object[] { new Guid("2cbd82ad-2d40-470f-9d9f-7e61345eaa31"), "Prod 3", new Guid("7bdc1704-c4df-4490-afa2-2fa6af2512dc"), 65m, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b15b990-67ad-497d-acd5-0fbccb6949d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cbd82ad-2d40-470f-9d9f-7e61345eaa31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da3bf0f1-029c-4331-821d-b2505b272d76"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7bdc1704-c4df-4490-afa2-2fa6af2512dc"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
