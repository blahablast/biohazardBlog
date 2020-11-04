using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ContentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ContentId", "Name" },
                values: new object[,]
                {
                    { 1, null, "What's up with all these Zombies?!" },
                    { 2, null, "Spencer Mansion Updates" },
                    { 3, null, "An underground laboratory?" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Jill Valentine", "Every where I go there is a zombie. Isn't there anyone human anymore??", 1, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seems everyone these days is a Zombie..." },
                    { 2, "Barry Burton", "Thanks to Brad and his awful pilot skills, we have crashed and stuck in this creepy mansion!", 2, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "This mansion is dangerous!" },
                    { 3, "Chris Redfield", "I was just bored and inserted a couple of disks into statues that were hidden all too well... Next thing I know, I decending into an underground laboratory!", 3, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "So I drained a fountain and found a laboratory!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ContentId",
                table: "Categories",
                column: "ContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contents");
        }
    }
}
