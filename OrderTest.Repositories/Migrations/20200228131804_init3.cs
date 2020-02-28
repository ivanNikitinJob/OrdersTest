using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderTest.Repositories.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreationDate", "Name", "Status" },
                values: new object[] { new Guid("58899e6d-14e2-4326-9af3-481ed55d44a1"), new DateTime(2020, 2, 28, 13, 18, 3, 965, DateTimeKind.Utc).AddTicks(794), "Order 1", 0 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreationDate", "Name", "Status" },
                values: new object[] { new Guid("d38d853d-03fc-4512-8ac9-d84f3c84233f"), new DateTime(2020, 2, 28, 13, 18, 3, 965, DateTimeKind.Utc).AddTicks(3778), "Order 2", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "OrderId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("9141d1d1-62c8-41ba-9519-77d6ff9c7169"), "Prod 1", new Guid("58899e6d-14e2-4326-9af3-481ed55d44a1"), 10m, 5 },
                    { new Guid("3c5a4cb0-f109-4c84-8533-ebe158d3c6aa"), "Prod 2", new Guid("58899e6d-14e2-4326-9af3-481ed55d44a1"), 1m, 15 },
                    { new Guid("d07822a5-5745-42a7-97de-f7d790e0e2c7"), "Prod 3", new Guid("58899e6d-14e2-4326-9af3-481ed55d44a1"), 65m, 1 },
                    { new Guid("d6d0fa4e-f6a0-418d-9a5d-2f0b8d580979"), "Prod 4", new Guid("58899e6d-14e2-4326-9af3-481ed55d44a1"), 100m, 50 },
                    { new Guid("b8c9e71b-76e5-40e7-90c3-87c06a7d2c55"), "Prod 5", new Guid("d38d853d-03fc-4512-8ac9-d84f3c84233f"), 10m, 150 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c5a4cb0-f109-4c84-8533-ebe158d3c6aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9141d1d1-62c8-41ba-9519-77d6ff9c7169"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8c9e71b-76e5-40e7-90c3-87c06a7d2c55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d07822a5-5745-42a7-97de-f7d790e0e2c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6d0fa4e-f6a0-418d-9a5d-2f0b8d580979"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("58899e6d-14e2-4326-9af3-481ed55d44a1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d38d853d-03fc-4512-8ac9-d84f3c84233f"));

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
        }
    }
}
