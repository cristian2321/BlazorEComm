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
    [Migration("20230819205753_UserAddress")]
    partial class UserAddress
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"),
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"),
                            Name = "Movies",
                            Url = "movie"
                        },
                        new
                        {
                            Id = new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"),
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
                            Id = new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"),
                            CategoryId = new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"),
                            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = new Guid("d0b2613c-f1d8-474a-9e40-34eec334562a"),
                            CategoryId = new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"),
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Title = "Ready Player One"
                        },
                        new
                        {
                            Id = new Guid("5e3ea2c9-56f5-461f-a022-99e0c759c6d8"),
                            CategoryId = new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"),
                            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                            Title = "Nineteen Eighty-Four"
                        },
                        new
                        {
                            Id = new Guid("dedb3733-b733-4825-8654-6f11e865d22d"),
                            CategoryId = new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"),
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = new Guid("47dd2199-c248-46fc-8150-703de27823fa"),
                            CategoryId = new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"),
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Title = "Back to the Future"
                        },
                        new
                        {
                            Id = new Guid("e61539c0-c1ef-49c9-ba7c-eed3c319fec2"),
                            CategoryId = new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"),
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Title = "Toy Story"
                        },
                        new
                        {
                            Id = new Guid("25aef04e-353f-471b-a540-74dc66f63add"),
                            CategoryId = new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = new Guid("67803a0a-20f9-4e99-8226-3fb13fdaabcb"),
                            CategoryId = new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"),
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Title = "Diablo II"
                        },
                        new
                        {
                            Id = new Guid("af98be76-713b-4f08-b769-122326866931"),
                            CategoryId = new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"),
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Title = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = new Guid("24a408a4-6c42-446d-a2fe-ea52662e386e"),
                            CategoryId = new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = new Guid("876b82c4-1d7d-48fb-8801-40f3edb6bb94"),
                            CategoryId = new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"),
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
                            Id = new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"),
                            Name = "Default"
                        },
                        new
                        {
                            Id = new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"),
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = new Guid("459abaff-e930-4a52-845e-6690625edbf1"),
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = new Guid("cc191e6b-5c3b-4ea6-a4de-378e45ab6766"),
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"),
                            Name = "Stream"
                        },
                        new
                        {
                            Id = new Guid("7dfbf6dc-aa93-4d6a-9339-3494b4c2bc94"),
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = new Guid("e1d9f72a-a01b-49bc-ab75-509f91ac4b05"),
                            Name = "VHS"
                        },
                        new
                        {
                            Id = new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"),
                            Name = "PC"
                        },
                        new
                        {
                            Id = new Guid("ef078cba-a4bb-4ffd-bdc4-60bc1ad87a46"),
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = new Guid("a505b208-7dc2-4e39-ae84-a999150c4988"),
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
                            ProductId = new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"),
                            ProductTypeId = new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"),
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"),
                            ProductTypeId = new Guid("459abaff-e930-4a52-845e-6690625edbf1"),
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"),
                            ProductTypeId = new Guid("cc191e6b-5c3b-4ea6-a4de-378e45ab6766"),
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = new Guid("d0b2613c-f1d8-474a-9e40-34eec334562a"),
                            ProductTypeId = new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"),
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = new Guid("5e3ea2c9-56f5-461f-a022-99e0c759c6d8"),
                            ProductTypeId = new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"),
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = new Guid("dedb3733-b733-4825-8654-6f11e865d22d"),
                            ProductTypeId = new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"),
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = new Guid("dedb3733-b733-4825-8654-6f11e865d22d"),
                            ProductTypeId = new Guid("7dfbf6dc-aa93-4d6a-9339-3494b4c2bc94"),
                            OriginalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = new Guid("dedb3733-b733-4825-8654-6f11e865d22d"),
                            ProductTypeId = new Guid("e1d9f72a-a01b-49bc-ab75-509f91ac4b05"),
                            OriginalPrice = 0m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = new Guid("47dd2199-c248-46fc-8150-703de27823fa"),
                            ProductTypeId = new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"),
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = new Guid("e61539c0-c1ef-49c9-ba7c-eed3c319fec2"),
                            ProductTypeId = new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"),
                            OriginalPrice = 0m,
                            Price = 2.99m
                        },
                        new
                        {
                            ProductId = new Guid("25aef04e-353f-471b-a540-74dc66f63add"),
                            ProductTypeId = new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"),
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = new Guid("25aef04e-353f-471b-a540-74dc66f63add"),
                            ProductTypeId = new Guid("ef078cba-a4bb-4ffd-bdc4-60bc1ad87a46"),
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = new Guid("25aef04e-353f-471b-a540-74dc66f63add"),
                            ProductTypeId = new Guid("a505b208-7dc2-4e39-ae84-a999150c4988"),
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = new Guid("67803a0a-20f9-4e99-8226-3fb13fdaabcb"),
                            ProductTypeId = new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"),
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = new Guid("af98be76-713b-4f08-b769-122326866931"),
                            ProductTypeId = new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"),
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = new Guid("24a408a4-6c42-446d-a2fe-ea52662e386e"),
                            ProductTypeId = new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"),
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = new Guid("dedb3733-b733-4825-8654-6f11e865d22d"),
                            ProductTypeId = new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"),
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
