using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HolidayHomeAway.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Accom> Accoms { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<BookingItem> BookingItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed Types
            modelBuilder.Entity<Type>().HasData(new Type
            { Id = 1, Name = "Static Caravan", Description = "This is a static caravan" });
            modelBuilder.Entity<Type>().HasData(new Type
            { Id = 2, Name = "Lodge", Description = "This is a lodge" });

            


            //Seed Accommodations 
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 1,
                Name = "Ambleside",
                Price = 100M,
                ShortDescription = "Ambleside static caravan",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 1,
               AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\AmblesideCara_Out.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 2,
                Name = "Arronbrook",
                Price = 100M,
                ShortDescription = "Arronbrook static caravan",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 1,
                AvailabilityType = AvailabilityType.Low,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ArronbrookCara.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 3,
                Name = "Biaritz",
                Price = 100M,
                ShortDescription = "Biaritz static caravan",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 1,
               AvailabilityType = AvailabilityType.Medium,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\BiaritzCara.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 4,
                Name = "Bordeaux",
                Price = 200M,
                ShortDescription = "Bordeaux static caravan",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 1,
                AvailabilityType = AvailabilityType.Low,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\BordeauxCara.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 5,
                Name = "Canterbury",
                Price = 200M,
                ShortDescription = "Canterbury Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\CanterburyLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 6,
                Name = "Chedder Woods",
                Price = 200M,
                ShortDescription = "Chedder Woods Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Medium,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ChedderWoodsLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 7,
                Name = "Farnham",
                Price = 200M,
                ShortDescription = "Farnham Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Medium,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\FarnhamLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 8,
                Name = "Hero",
                Price = 200M,
                ShortDescription = "Hero Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Low,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\HeroLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 9,
                Name = "Lakes",
                Price = 200M,
                ShortDescription = "Lakes Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Low,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\LakesLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 10,
                Name = "New Pines",
                Price = 100M,
                ShortDescription = "New Pines Static Caravan",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 1,
                AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\NewPinesCara.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 11,
                Name = "Parks",
                Price = 200M,
                ShortDescription = "Parks Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Low,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ParksLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 12,
                Name = "Pathfinders",
                Price = 200M,
                ShortDescription = "Pathfinders Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\PathFindersLodge_Out.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 13,
                Name = "Reacher",
                Price = 200M,
                ShortDescription = "Reacher Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Medium,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ReacherLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 14,
                Name = "Retreat",
                Price = 200M,
                ShortDescription = "Retreat Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\RetreatLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 15,
                Name = "Wareham Retreat",
                Price = 200M,
                ShortDescription = "Wareham Retreat Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.Medium,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WareehamRetreatLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 16,
                Name = "Well",
                Price = 200M,
                ShortDescription = "Well Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WellLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 17,
                Name = "Wimbledon",
                Price = 100M,
                ShortDescription = "Wimbledon Static Caravan",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 1,
                AvailabilityType = AvailabilityType.Low,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WimbledonCara.jpg",
                Notes = "Extra Notes on this holiday let"
            });
            modelBuilder.Entity<Accom>().HasData(new Accom
            {
                Id = 18,
                Name = "Woodside Bay",
                Price = 200M,
                ShortDescription = "Woodside Bay Lodge",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                AccomTypeId = 2,
                AvailabilityType = AvailabilityType.High,
                ImageUrl =
                    "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WoodsideBayLodge.jpg",
                Notes = "Extra Notes on this holiday let"
            });

        }
    }
}
