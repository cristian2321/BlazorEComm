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
    [Migration("20230819231531_UserAddressRequired")]
    partial class UserAddressRequired
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

                    b.Property<bool>("IsPrincipal")
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"),
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"),
                            Name = "Movies",
                            Url = "movie"
                        },
                        new
                        {
                            Id = new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"),
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"),
                            CategoryId = new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"),
                            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = new Guid("3894edf6-db7d-4aea-9d07-17f250216ecb"),
                            CategoryId = new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"),
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Title = "Ready Player One"
                        },
                        new
                        {
                            Id = new Guid("8ff57ea8-9a7d-401e-ba27-6a59699c5aa5"),
                            CategoryId = new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"),
                            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                            Title = "Nineteen Eighty-Four"
                        },
                        new
                        {
                            Id = new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"),
                            CategoryId = new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"),
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = new Guid("ce9dc9ef-2fa0-4687-af21-a9f31425ed6d"),
                            CategoryId = new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"),
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Title = "Back to the Future"
                        },
                        new
                        {
                            Id = new Guid("dbab11f8-dc25-4b65-8c60-694f53400703"),
                            CategoryId = new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"),
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Title = "Toy Story"
                        },
                        new
                        {
                            Id = new Guid("f789632c-2b88-4fc1-a138-67d540625f38"),
                            CategoryId = new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = new Guid("61920446-24f9-48fb-9e78-50e094c8f0a7"),
                            CategoryId = new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"),
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Title = "Diablo II"
                        },
                        new
                        {
                            Id = new Guid("8c3914e7-c613-4e81-8e0a-ad0980c3ec21"),
                            CategoryId = new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"),
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Title = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = new Guid("c0bad4fd-ccfa-4fb3-8816-a884809024e6"),
                            CategoryId = new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = new Guid("2b5cc1cf-8a22-42bd-81ff-7877be249476"),
                            CategoryId = new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"),
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Title = "Super Nintendo Entertainment System"
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b333646-7735-4ea7-af10-160360f2d586"),
                            Name = "Default"
                        },
                        new
                        {
                            Id = new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"),
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = new Guid("c1894849-6416-41a9-9ad9-4e6b816747e2"),
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = new Guid("55edb47d-d9fc-4df5-ba7e-6aa52dfbbffa"),
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"),
                            Name = "Stream"
                        },
                        new
                        {
                            Id = new Guid("2bdbb0af-1b9d-49e7-92a8-d6cccd0a0bab"),
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = new Guid("7e972e36-6728-4405-8fed-6e3355e75943"),
                            Name = "VHS"
                        },
                        new
                        {
                            Id = new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"),
                            Name = "PC"
                        },
                        new
                        {
                            Id = new Guid("71ee2f35-2f43-4b87-98f9-155a7e085292"),
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = new Guid("c7f8f366-7a68-442a-a944-a3b530ccd9a3"),
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("BlazorEComm.Shared.Models.ProductVariant", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"),
                            ProductTypeId = new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"),
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"),
                            ProductTypeId = new Guid("c1894849-6416-41a9-9ad9-4e6b816747e2"),
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"),
                            ProductTypeId = new Guid("55edb47d-d9fc-4df5-ba7e-6aa52dfbbffa"),
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = new Guid("3894edf6-db7d-4aea-9d07-17f250216ecb"),
                            ProductTypeId = new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"),
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = new Guid("8ff57ea8-9a7d-401e-ba27-6a59699c5aa5"),
                            ProductTypeId = new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"),
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"),
                            ProductTypeId = new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"),
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"),
                            ProductTypeId = new Guid("2bdbb0af-1b9d-49e7-92a8-d6cccd0a0bab"),
                            OriginalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"),
                            ProductTypeId = new Guid("7e972e36-6728-4405-8fed-6e3355e75943"),
                            OriginalPrice = 0m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = new Guid("ce9dc9ef-2fa0-4687-af21-a9f31425ed6d"),
                            ProductTypeId = new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"),
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = new Guid("dbab11f8-dc25-4b65-8c60-694f53400703"),
                            ProductTypeId = new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"),
                            OriginalPrice = 0m,
                            Price = 2.99m
                        },
                        new
                        {
                            ProductId = new Guid("f789632c-2b88-4fc1-a138-67d540625f38"),
                            ProductTypeId = new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"),
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = new Guid("f789632c-2b88-4fc1-a138-67d540625f38"),
                            ProductTypeId = new Guid("71ee2f35-2f43-4b87-98f9-155a7e085292"),
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = new Guid("f789632c-2b88-4fc1-a138-67d540625f38"),
                            ProductTypeId = new Guid("c7f8f366-7a68-442a-a944-a3b530ccd9a3"),
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = new Guid("61920446-24f9-48fb-9e78-50e094c8f0a7"),
                            ProductTypeId = new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"),
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = new Guid("8c3914e7-c613-4e81-8e0a-ad0980c3ec21"),
                            ProductTypeId = new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"),
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = new Guid("c0bad4fd-ccfa-4fb3-8816-a884809024e6"),
                            ProductTypeId = new Guid("0b333646-7735-4ea7-af10-160360f2d586"),
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"),
                            ProductTypeId = new Guid("0b333646-7735-4ea7-af10-160360f2d586"),
                            OriginalPrice = 399m,
                            Price = 79.99m
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
