using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "There is high availability for this holiday let.", "High" },
                    { 2, "There is some abailability for this holiday let.", "Medium" },
                    { 3, "There is limited availability for this holiday let!", "Low" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "This is a static caravan", "Static Caravan" },
                    { 2, "This is a lodge", "Lodge" }
                });

            migrationBuilder.InsertData(
                table: "Accoms",
                columns: new[] { "Id", "AccomTypeId", "AvailabilityId", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\AmblesideCara_Out.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Ambleside", "Extra Notes on this holiday let", 100m, "Ambleside static caravan" },
                    { 15, 2, 2, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WareehamRetreatLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Wareham Retreat", "Extra Notes on this holiday let", 200m, "Wareham Retreat Lodge" },
                    { 14, 2, 3, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\RetreatLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Retreat", "Extra Notes on this holiday let", 200m, "Retreat Lodge" },
                    { 13, 2, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ReacherLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Reacher", "Extra Notes on this holiday let", 200m, "Reacher Lodge" },
                    { 12, 2, 2, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\PathFindersLodge_Out.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Pathfinders", "Extra Notes on this holiday let", 200m, "Pathfinders Lodge" },
                    { 11, 2, 3, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ParksLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Parks", "Extra Notes on this holiday let", 200m, "Parks Lodge" },
                    { 9, 2, 2, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\LakesLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Lakes", "Extra Notes on this holiday let", 200m, "Lakes Lodge" },
                    { 8, 2, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\HeroLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Hero", "Extra Notes on this holiday let", 200m, "Hero Lodge" },
                    { 7, 2, 3, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\FarnhamLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Farnham", "Extra Notes on this holiday let", 200m, "Farnham Lodge" },
                    { 6, 2, 2, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ChedderWoodsLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Chedder Woods", "Extra Notes on this holiday let", 200m, "Chedder Woods Lodge" },
                    { 5, 2, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\CanterburyLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Canterbury", "Extra Notes on this holiday let", 200m, "Canterbury Lodge" },
                    { 17, 1, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WimbledonCara.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Wimbledon", "Extra Notes on this holiday let", 100m, "Wimbledon Static Caravan" },
                    { 10, 1, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\NewPinesCara.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "New Pines", "Extra Notes on this holiday let", 100m, "New Pines Static Caravan" },
                    { 4, 1, 3, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\BordeauxCara.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Bordeaux", "Extra Notes on this holiday let", 200m, "Bordeaux static caravan" },
                    { 3, 1, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\BiaritzCara.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Biaritz", "Extra Notes on this holiday let", 100m, "Biaritz static caravan" },
                    { 2, 1, 2, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ArronbrookCara.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Arronbrook", "Extra Notes on this holiday let", 100m, "Arronbrook static caravan" },
                    { 16, 2, 1, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WellLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Well", "Extra Notes on this holiday let", 200m, "Well Lodge" },
                    { 18, 2, 3, "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WoodsideBayLodge.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.", "Woodside Bay", "Extra Notes on this holiday let", 200m, "Woodside Bay Lodge" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
