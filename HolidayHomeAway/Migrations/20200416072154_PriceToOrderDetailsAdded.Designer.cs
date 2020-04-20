﻿// <auto-generated />
using System;
using HolidayHomeAway.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HolidayHomeAway.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200416072154_PriceToOrderDetailsAdded")]
    partial class PriceToOrderDetailsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HolidayHomeAway.Models.Accom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccomTypeId")
                        .HasColumnType("int");

                    b.Property<int>("AvailabilityId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccomTypeId");

                    b.HasIndex("AvailabilityId");

                    b.ToTable("Accoms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccomTypeId = 1,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\AmblesideCara_Out.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Ambleside",
                            Notes = "Extra Notes on this holiday let",
                            Price = 100m,
                            ShortDescription = "Ambleside static caravan"
                        },
                        new
                        {
                            Id = 2,
                            AccomTypeId = 1,
                            AvailabilityId = 2,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ArronbrookCara.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Arronbrook",
                            Notes = "Extra Notes on this holiday let",
                            Price = 100m,
                            ShortDescription = "Arronbrook static caravan"
                        },
                        new
                        {
                            Id = 3,
                            AccomTypeId = 1,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\BiaritzCara.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Biaritz",
                            Notes = "Extra Notes on this holiday let",
                            Price = 100m,
                            ShortDescription = "Biaritz static caravan"
                        },
                        new
                        {
                            Id = 4,
                            AccomTypeId = 1,
                            AvailabilityId = 3,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\BordeauxCara.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Bordeaux",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Bordeaux static caravan"
                        },
                        new
                        {
                            Id = 5,
                            AccomTypeId = 2,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\CanterburyLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Canterbury",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Canterbury Lodge"
                        },
                        new
                        {
                            Id = 6,
                            AccomTypeId = 2,
                            AvailabilityId = 2,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ChedderWoodsLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Chedder Woods",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Chedder Woods Lodge"
                        },
                        new
                        {
                            Id = 7,
                            AccomTypeId = 2,
                            AvailabilityId = 3,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\FarnhamLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Farnham",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Farnham Lodge"
                        },
                        new
                        {
                            Id = 8,
                            AccomTypeId = 2,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\HeroLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Hero",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Hero Lodge"
                        },
                        new
                        {
                            Id = 9,
                            AccomTypeId = 2,
                            AvailabilityId = 2,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\LakesLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Lakes",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Lakes Lodge"
                        },
                        new
                        {
                            Id = 10,
                            AccomTypeId = 1,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\NewPinesCara.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "New Pines",
                            Notes = "Extra Notes on this holiday let",
                            Price = 100m,
                            ShortDescription = "New Pines Static Caravan"
                        },
                        new
                        {
                            Id = 11,
                            AccomTypeId = 2,
                            AvailabilityId = 3,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ParksLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Parks",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Parks Lodge"
                        },
                        new
                        {
                            Id = 12,
                            AccomTypeId = 2,
                            AvailabilityId = 2,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\PathFindersLodge_Out.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Pathfinders",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Pathfinders Lodge"
                        },
                        new
                        {
                            Id = 13,
                            AccomTypeId = 2,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\ReacherLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Reacher",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Reacher Lodge"
                        },
                        new
                        {
                            Id = 14,
                            AccomTypeId = 2,
                            AvailabilityId = 3,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\RetreatLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Retreat",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Retreat Lodge"
                        },
                        new
                        {
                            Id = 15,
                            AccomTypeId = 2,
                            AvailabilityId = 2,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WareehamRetreatLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Wareham Retreat",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Wareham Retreat Lodge"
                        },
                        new
                        {
                            Id = 16,
                            AccomTypeId = 2,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WellLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Well",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Well Lodge"
                        },
                        new
                        {
                            Id = 17,
                            AccomTypeId = 1,
                            AvailabilityId = 1,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WimbledonCara.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Wimbledon",
                            Notes = "Extra Notes on this holiday let",
                            Price = 100m,
                            ShortDescription = "Wimbledon Static Caravan"
                        },
                        new
                        {
                            Id = 18,
                            AccomTypeId = 2,
                            AvailabilityId = 3,
                            ImageUrl = "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\WoodsideBayLodge.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut accumsan neque sem, id faucibus lacus facilisis vel. Ut ac iaculis mi. Cras at tortor ullamcorper sem tincidunt dignissim ut finibus nisi. Nullam ut tellus in mauris maximus euismod eget faucibus est. Nullam at maximus augue, sit amet molestie tellus. Sed sodales ante neque, vel pellentesque nisl egestas rutrum. Ut quis tempor lorem, vitae cursus purus. Aenean urna orci, porta sed eleifend ac, fermentum a nisi. In faucibus nec arcu nec porta. Fusce pharetra commodo lacus, quis ullamcorper risus hendrerit congue.",
                            Name = "Woodside Bay",
                            Notes = "Extra Notes on this holiday let",
                            Price = 200m,
                            ShortDescription = "Woodside Bay Lodge"
                        });
                });

            modelBuilder.Entity("HolidayHomeAway.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Availabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "There is high availability for this holiday let.",
                            Name = "High"
                        },
                        new
                        {
                            Id = 2,
                            Description = "There is some abailability for this holiday let.",
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Description = "There is limited availability for this holiday let!",
                            Name = "Low"
                        });
                });

            modelBuilder.Entity("HolidayHomeAway.Models.BookingItem", b =>
                {
                    b.Property<int>("BookingItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccomId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingItemId");

                    b.HasIndex("AccomId");

                    b.ToTable("BookingItems");
                });

            modelBuilder.Entity("HolidayHomeAway.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HolidayHomeAway.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccomId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("AccomId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("HolidayHomeAway.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is a static caravan",
                            Name = "Static Caravan"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is a lodge",
                            Name = "Lodge"
                        });
                });

            modelBuilder.Entity("HolidayHomeAway.Models.Accom", b =>
                {
                    b.HasOne("HolidayHomeAway.Models.Type", "AccomType")
                        .WithMany("Accoms")
                        .HasForeignKey("AccomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolidayHomeAway.Models.Availability", "Availability")
                        .WithMany("Accoms")
                        .HasForeignKey("AvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HolidayHomeAway.Models.BookingItem", b =>
                {
                    b.HasOne("HolidayHomeAway.Models.Accom", "Accom")
                        .WithMany()
                        .HasForeignKey("AccomId");
                });

            modelBuilder.Entity("HolidayHomeAway.Models.OrderDetails", b =>
                {
                    b.HasOne("HolidayHomeAway.Models.Accom", "Accom")
                        .WithMany()
                        .HasForeignKey("AccomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolidayHomeAway.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
