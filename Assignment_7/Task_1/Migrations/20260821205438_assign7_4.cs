using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_1.Migrations
{
    /// <inheritdoc />
    public partial class assign7_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsCompleted",
                table: "Tasks",
                type: "bit",
                nullable: false,
                computedColumnSql: "CASE WHEN [Status] = 'Done' THEN 1 ELSE 0 END AS BIT",
                stored: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "CASE WHEN [Status] = 'Done' THEN 1 ELSE 0 END",
                oldStored: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsCompleted",
                table: "Tasks",
                type: "bit",
                nullable: false,
                computedColumnSql: "CASE WHEN [Status] = 'Done' THEN 1 ELSE 0 END",
                stored: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "CASE WHEN [Status] = 'Done' THEN 1 ELSE 0 END AS BIT",
                oldStored: true);
        }
    }
}
