using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class ChangedCatsAndContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Here in Spencer Mansion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Undead, Weapons, Herbs and other arbitrary items...");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "There's an Underground Laboratory?!");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Thanks to Brad and his awful piloting skills, we have crashed and stuck in this creepy mansion! Thank God we have Wesker here to take care of us!", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "This Mansion is a real downer" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "I open a door, Zombie! Go down a hall, Zombie! Check out the dormitory, a giant plant trying to eat Jill! Always something else with this place!", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Is it just me or are all these 'residents evil...'" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "I was stuck, with nowhere to go and decided to insert a couple of disks (that were hidden all too well...) into statues and the next thing I know, I'm decending into an underground laboratory!", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "So I drained a fountain and found a Laboratory!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "What's up with all these Zombies?!");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Spencer Mansion Updates");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "An underground laboratory?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Every where I go there is a zombie. Isn't there anyone human anymore??", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seems everyone these days is a Zombie..." });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Thanks to Brad and his awful pilot skills, we have crashed and stuck in this creepy mansion!", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "This mansion is dangerous!" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "I was just bored and inserted a couple of disks into statues that were hidden all too well... Next thing I know, I decending into an underground laboratory!", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "So I drained a fountain and found a laboratory!" });
        }
    }
}
