using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "f39e76e2-0987-437b-a33d-b223c8c369f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "328b00a9-9b25-414c-93cf-e4267979443e", "AQAAAAEAACcQAAAAEOMMFWGTkmd+Qrx1YcxToKaAuZE9bmlzuVoIpktXA8iL5hIvwUmkUkJM/Yp1D2jbsA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 6, 21, 10, 9, 11, 253, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 6, 21, 10, 9, 11, 252, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 6, 21, 10, 9, 11, 253, DateTimeKind.Utc).AddTicks(6690));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6fac64bc-52a6-4cbf-8bce-126a8d9e5ec2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5e91e92-2046-4eed-8c33-37111add6503", "AQAAAAEAACcQAAAAENzkPShNscPhua68DckgoAMiIuGnkacWasVV8qB9Kuqg3K9QaMe8veKNtc9TGa0/4w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 27, 10, 45, 18, 535, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 27, 10, 45, 18, 534, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 27, 10, 45, 18, 535, DateTimeKind.Utc).AddTicks(2112));
        }
    }
}
