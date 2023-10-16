﻿// <auto-generated />
using System;
using BlazorEComm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    [DbContext(typeof(EcommDbContext))]
    [Migration("20231015203055_LanguageConfigurationCompanyName")]
    partial class LanguageConfigurationCompanyName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEComm.Shared.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("Principal")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.CartItem", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb45ced9-b2b9-46c1-a4ae-fec858beec71"),
                            Deleted = false,
                            Name = "Books",
                            Url = "books",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("f583b982-0208-47e0-b0a6-c4cc10f0b0a2"),
                            Deleted = false,
                            Name = "Movies",
                            Url = "movie",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("5275e608-836e-42a0-8cd8-7eee86c6282c"),
                            Deleted = false,
                            Name = "Video Games",
                            Url = "video-games",
                            Visible = true
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Configuration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activ")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Configurations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("40677c0c-a973-4c4b-8c5c-060360cc2a5c"),
                            Activ = true,
                            Key = "ProductsByPage",
                            Language = "en",
                            Value = "5"
                        },
                        new
                        {
                            Id = new Guid("3cae937e-7f44-4a35-a242-9acde824f89c"),
                            Activ = true,
                            Key = "DefaultLanguage",
                            Language = "",
                            Value = "en"
                        },
                        new
                        {
                            Id = new Guid("a1603d7c-4335-4d0b-8248-7ad755cf2563"),
                            Activ = true,
                            Key = "CompanyName",
                            Language = "en",
                            Value = "TestConstante"
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPayment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.OrderItem", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f681535d-372b-4830-afac-30949a58e787"),
                            CategoryId = new Guid("fb45ced9-b2b9-46c1-a4ae-fec858beec71"),
                            Deleted = false,
                            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Title = "The Hitchhiker's Guide to the Galaxy",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("ff070e7c-5110-4352-9ee3-1d87143306ad"),
                            CategoryId = new Guid("fb45ced9-b2b9-46c1-a4ae-fec858beec71"),
                            Deleted = false,
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Title = "Ready Player One",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("34aa0258-676b-4d94-a7a8-e11b03b3753d"),
                            CategoryId = new Guid("fb45ced9-b2b9-46c1-a4ae-fec858beec71"),
                            Deleted = false,
                            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                            Featured = false,
                            ImageUrl = "https://en.wikipedia.org/wiki/File:1984_first_edition_cover.jpg",
                            Title = "Nineteen Eighty-Four",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("11a7d1ab-e20f-49b8-8e2d-b91b00be86fa"),
                            CategoryId = new Guid("f583b982-0208-47e0-b0a6-c4cc10f0b0a2"),
                            Deleted = false,
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Title = "The Matrix",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("5eacbac1-a58e-4538-b35d-8984b0d7174d"),
                            CategoryId = new Guid("f583b982-0208-47e0-b0a6-c4cc10f0b0a2"),
                            Deleted = false,
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Title = "Back to the Future",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("a4a4e2df-734a-4b75-8d1d-e4fc72cc21f1"),
                            CategoryId = new Guid("f583b982-0208-47e0-b0a6-c4cc10f0b0a2"),
                            Deleted = false,
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Title = "Toy Story",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("6c14ad0f-eb89-4114-a358-b9b92d012628"),
                            CategoryId = new Guid("5275e608-836e-42a0-8cd8-7eee86c6282c"),
                            Deleted = false,
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Title = "Half-Life 2",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("35d04f97-369b-4a30-94d3-5f02ff1dabaa"),
                            CategoryId = new Guid("5275e608-836e-42a0-8cd8-7eee86c6282c"),
                            Deleted = false,
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Title = "Diablo II",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("e2cb647c-0416-4e3a-80e7-23991d6d37e0"),
                            CategoryId = new Guid("5275e608-836e-42a0-8cd8-7eee86c6282c"),
                            Deleted = false,
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Title = "Day of the Tentacle",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("67b6c94f-b317-46ef-878a-7fbf252d45e2"),
                            CategoryId = new Guid("5275e608-836e-42a0-8cd8-7eee86c6282c"),
                            Deleted = false,
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Title = "Xbox",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("5e866665-7db8-404e-9caf-803bedb08ede"),
                            CategoryId = new Guid("5275e608-836e-42a0-8cd8-7eee86c6282c"),
                            Deleted = false,
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Title = "Super Nintendo Entertainment System",
                            Visible = true
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("31a5cfdf-03bf-4227-bf0b-f86ffe64fa75"),
                            Deleted = false,
                            Name = "Default",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("63b79d07-1f11-43dc-be9b-6505f3bfc630"),
                            Deleted = false,
                            Name = "Paperback",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("5fca0de8-f337-4495-9391-97574f31cf29"),
                            Deleted = false,
                            Name = "E-Book",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("d014d57d-20dd-45d8-9675-47770383cb59"),
                            Deleted = false,
                            Name = "Audiobook",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("6cd0f82f-7344-4ce5-8000-534306a2a197"),
                            Deleted = false,
                            Name = "Stream",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("2db608c3-343b-46a7-96bc-c73f4b378eab"),
                            Deleted = false,
                            Name = "Blu-ray",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("b0411ee6-270c-4b51-95fc-005753b6b925"),
                            Deleted = false,
                            Name = "VHS",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("34739b09-bae6-4147-a7dd-7e652ace033b"),
                            Deleted = false,
                            Name = "PC",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("c5f532ae-6a91-4673-8198-805e5170b0ed"),
                            Deleted = false,
                            Name = "PlayStation",
                            Visible = true
                        },
                        new
                        {
                            Id = new Guid("117d3eb0-41cb-4e42-af6c-10b5021eb428"),
                            Deleted = false,
                            Name = "Xbox",
                            Visible = true
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.ProductVariant", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("f681535d-372b-4830-afac-30949a58e787"),
                            ProductTypeId = new Guid("63b79d07-1f11-43dc-be9b-6505f3bfc630"),
                            Deleted = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("f681535d-372b-4830-afac-30949a58e787"),
                            ProductTypeId = new Guid("5fca0de8-f337-4495-9391-97574f31cf29"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 7.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("f681535d-372b-4830-afac-30949a58e787"),
                            ProductTypeId = new Guid("d014d57d-20dd-45d8-9675-47770383cb59"),
                            Deleted = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("ff070e7c-5110-4352-9ee3-1d87143306ad"),
                            ProductTypeId = new Guid("63b79d07-1f11-43dc-be9b-6505f3bfc630"),
                            Deleted = false,
                            OriginalPrice = 14.99m,
                            Price = 7.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("34aa0258-676b-4d94-a7a8-e11b03b3753d"),
                            ProductTypeId = new Guid("63b79d07-1f11-43dc-be9b-6505f3bfc630"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 6.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("11a7d1ab-e20f-49b8-8e2d-b91b00be86fa"),
                            ProductTypeId = new Guid("6cd0f82f-7344-4ce5-8000-534306a2a197"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 3.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("11a7d1ab-e20f-49b8-8e2d-b91b00be86fa"),
                            ProductTypeId = new Guid("2db608c3-343b-46a7-96bc-c73f4b378eab"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("11a7d1ab-e20f-49b8-8e2d-b91b00be86fa"),
                            ProductTypeId = new Guid("b0411ee6-270c-4b51-95fc-005753b6b925"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("5eacbac1-a58e-4538-b35d-8984b0d7174d"),
                            ProductTypeId = new Guid("6cd0f82f-7344-4ce5-8000-534306a2a197"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 3.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("a4a4e2df-734a-4b75-8d1d-e4fc72cc21f1"),
                            ProductTypeId = new Guid("6cd0f82f-7344-4ce5-8000-534306a2a197"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 2.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("6c14ad0f-eb89-4114-a358-b9b92d012628"),
                            ProductTypeId = new Guid("34739b09-bae6-4147-a7dd-7e652ace033b"),
                            Deleted = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("6c14ad0f-eb89-4114-a358-b9b92d012628"),
                            ProductTypeId = new Guid("c5f532ae-6a91-4673-8198-805e5170b0ed"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 69.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("6c14ad0f-eb89-4114-a358-b9b92d012628"),
                            ProductTypeId = new Guid("117d3eb0-41cb-4e42-af6c-10b5021eb428"),
                            Deleted = false,
                            OriginalPrice = 59.99m,
                            Price = 49.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("35d04f97-369b-4a30-94d3-5f02ff1dabaa"),
                            ProductTypeId = new Guid("34739b09-bae6-4147-a7dd-7e652ace033b"),
                            Deleted = false,
                            OriginalPrice = 24.99m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("e2cb647c-0416-4e3a-80e7-23991d6d37e0"),
                            ProductTypeId = new Guid("34739b09-bae6-4147-a7dd-7e652ace033b"),
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 14.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("67b6c94f-b317-46ef-878a-7fbf252d45e2"),
                            ProductTypeId = new Guid("31a5cfdf-03bf-4227-bf0b-f86ffe64fa75"),
                            Deleted = false,
                            OriginalPrice = 299m,
                            Price = 159.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = new Guid("11a7d1ab-e20f-49b8-8e2d-b91b00be86fa"),
                            ProductTypeId = new Guid("31a5cfdf-03bf-4227-bf0b-f86ffe64fa75"),
                            Deleted = false,
                            OriginalPrice = 399m,
                            Price = 79.99m,
                            Visible = true
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Address", b =>
                {
                    b.HasOne("BlazorEComm.Shared.Models.User", null)
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Image", b =>
                {
                    b.HasOne("BlazorEComm.Shared.Models.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.OrderItem", b =>
                {
                    b.HasOne("BlazorEComm.Shared.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEComm.Shared.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEComm.Shared.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Product", b =>
                {
                    b.HasOne("BlazorEComm.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.ProductVariant", b =>
                {
                    b.HasOne("BlazorEComm.Shared.Models.Product", "Product")
                        .WithMany("ProductVariants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEComm.Shared.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("ProductVariants");
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
