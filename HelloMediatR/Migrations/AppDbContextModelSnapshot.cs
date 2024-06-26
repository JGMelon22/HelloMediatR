﻿// <auto-generated />
using System;
using ApiMediaRDemo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HelloMediatR.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiMediaRDemo.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("UNIQUEIDENTIFIER")
                        .HasColumnName("PersonId");

                    b.Property<byte>("Age")
                        .HasColumnType("TINYINT")
                        .HasColumnName("Age");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("FullName");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("Idx_Person_Id");

                    b.ToTable("People", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("87357d68-c3ad-2c9d-09a5-138937a8d233"),
                            Age = (byte)85,
                            FullName = "Lois VonRueden"
                        },
                        new
                        {
                            Id = new Guid("14206f4f-7dd9-1d53-71e0-6fcb442c5c61"),
                            Age = (byte)69,
                            FullName = "Rae Halvorson"
                        },
                        new
                        {
                            Id = new Guid("b7887025-6877-57e3-14c3-96b5d7807433"),
                            Age = (byte)68,
                            FullName = "Gideon Boehm"
                        },
                        new
                        {
                            Id = new Guid("5d01bc40-4e4a-6242-150e-b46488978786"),
                            Age = (byte)49,
                            FullName = "Columbus Conroy"
                        },
                        new
                        {
                            Id = new Guid("7057ecf5-55f6-e337-2a92-6c9dc6867410"),
                            Age = (byte)72,
                            FullName = "Eveline Glover"
                        },
                        new
                        {
                            Id = new Guid("2144131b-9e2d-456e-8ab2-62a4390d83a2"),
                            Age = (byte)84,
                            FullName = "Arvid Beer"
                        },
                        new
                        {
                            Id = new Guid("26446d84-0d99-e3bf-96d0-0ba4b3390a0c"),
                            Age = (byte)22,
                            FullName = "Alf Braun"
                        },
                        new
                        {
                            Id = new Guid("f1c1fa48-7d8d-49d4-d04d-56a5b65b19dd"),
                            Age = (byte)76,
                            FullName = "Doris Wilderman"
                        },
                        new
                        {
                            Id = new Guid("c5d1b662-c192-7769-451d-8792c41e16ff"),
                            Age = (byte)45,
                            FullName = "Leola Donnelly"
                        },
                        new
                        {
                            Id = new Guid("51eb9f4f-3ccc-6b35-5bf6-db634d4f7d08"),
                            Age = (byte)43,
                            FullName = "Theo Prosacco"
                        },
                        new
                        {
                            Id = new Guid("2f1b50b6-46ff-26f1-9c74-c9c1d05cc31c"),
                            Age = (byte)88,
                            FullName = "Merl Stanton"
                        },
                        new
                        {
                            Id = new Guid("2f85502f-aa26-9eba-6574-2bf9f28a6438"),
                            Age = (byte)55,
                            FullName = "Lacey Wisoky"
                        },
                        new
                        {
                            Id = new Guid("4e51d9e5-f5bf-ca02-cd64-4c6d442ff105"),
                            Age = (byte)38,
                            FullName = "Moses Parker"
                        },
                        new
                        {
                            Id = new Guid("bf79f37b-b39c-ec0c-4667-0d632f84c1c2"),
                            Age = (byte)44,
                            FullName = "Gustave Turner"
                        },
                        new
                        {
                            Id = new Guid("a217371b-4f78-adf6-0c3a-ff909cd425a6"),
                            Age = (byte)65,
                            FullName = "Enos Erdman"
                        },
                        new
                        {
                            Id = new Guid("4056e5ed-d005-0504-30ac-d2abe96b81a1"),
                            Age = (byte)54,
                            FullName = "Hershel Volkman"
                        },
                        new
                        {
                            Id = new Guid("2b079ba6-2f8d-5850-2495-7f96abfb3fb0"),
                            Age = (byte)73,
                            FullName = "Uriel Harber"
                        },
                        new
                        {
                            Id = new Guid("33a70afb-90df-9beb-9b15-c5632348d982"),
                            Age = (byte)72,
                            FullName = "Luigi Goldner"
                        },
                        new
                        {
                            Id = new Guid("4deb1a9a-8c88-b219-7a6b-fa2e1159220e"),
                            Age = (byte)69,
                            FullName = "Laverne Braun"
                        },
                        new
                        {
                            Id = new Guid("ae4a1089-3ec0-5364-84fd-9b3e188e5fc9"),
                            Age = (byte)48,
                            FullName = "Brendan Braun"
                        },
                        new
                        {
                            Id = new Guid("873646a0-fc95-1434-01ca-eca610ced367"),
                            Age = (byte)22,
                            FullName = "Ignatius Kris"
                        },
                        new
                        {
                            Id = new Guid("1881368b-90c0-f159-ac73-a6d6c16afbd4"),
                            Age = (byte)39,
                            FullName = "Nelle McCullough"
                        },
                        new
                        {
                            Id = new Guid("0c0d988c-dcee-7c05-07d4-6ad967d9a5a1"),
                            Age = (byte)27,
                            FullName = "Myrtle Bahringer"
                        },
                        new
                        {
                            Id = new Guid("209bf226-3df4-cfaa-6729-77105d0a83ec"),
                            Age = (byte)47,
                            FullName = "Joesph Kris"
                        },
                        new
                        {
                            Id = new Guid("fb5a6522-3563-fab3-ab45-9f3eddd00b55"),
                            Age = (byte)30,
                            FullName = "Zena Kling"
                        },
                        new
                        {
                            Id = new Guid("13829e89-9258-d242-4426-7824a49b7eac"),
                            Age = (byte)46,
                            FullName = "Oma Renner"
                        },
                        new
                        {
                            Id = new Guid("b9f91b00-2bb2-1a3a-1289-4aa7dd8bc314"),
                            Age = (byte)30,
                            FullName = "Althea Blanda"
                        },
                        new
                        {
                            Id = new Guid("c4d2e238-04fd-4c77-ce4c-6569710cd9d4"),
                            Age = (byte)90,
                            FullName = "Willie Runte"
                        },
                        new
                        {
                            Id = new Guid("18611a98-6870-2502-dd7e-c1fd4a616f70"),
                            Age = (byte)75,
                            FullName = "Lazaro Wyman"
                        },
                        new
                        {
                            Id = new Guid("ac39048b-1e81-f2ba-cbfa-30bdfda00f37"),
                            Age = (byte)20,
                            FullName = "Rylee Reichert"
                        },
                        new
                        {
                            Id = new Guid("b84bc9b3-cf8d-1ea9-6852-27bdc061c1aa"),
                            Age = (byte)25,
                            FullName = "Leone Jast"
                        },
                        new
                        {
                            Id = new Guid("051ba80d-c509-b714-eeae-8e20815bbb22"),
                            Age = (byte)53,
                            FullName = "Ivory Beier"
                        },
                        new
                        {
                            Id = new Guid("c6e27f24-7713-2fca-7095-d7c112a42819"),
                            Age = (byte)53,
                            FullName = "Lorenza Torphy"
                        },
                        new
                        {
                            Id = new Guid("08a49c97-4e1e-c0ae-e204-ef97d2e17a5a"),
                            Age = (byte)64,
                            FullName = "Sheridan Collier"
                        },
                        new
                        {
                            Id = new Guid("1b58c616-bae4-5541-c440-e774fa1f7da0"),
                            Age = (byte)71,
                            FullName = "Elissa Hayes"
                        },
                        new
                        {
                            Id = new Guid("71167f8d-e2ae-81ba-a473-5e6a6a22db8f"),
                            Age = (byte)68,
                            FullName = "Shayne Smitham"
                        },
                        new
                        {
                            Id = new Guid("3e520fa4-5e39-b494-84b2-ebdba9fde0cb"),
                            Age = (byte)46,
                            FullName = "Velva Wiza"
                        },
                        new
                        {
                            Id = new Guid("49aa0f50-81b4-4333-b676-659a1757699e"),
                            Age = (byte)18,
                            FullName = "Elian Schultz"
                        },
                        new
                        {
                            Id = new Guid("c11a0fbd-6b37-632b-c648-91cf54d9713c"),
                            Age = (byte)81,
                            FullName = "Aric Legros"
                        },
                        new
                        {
                            Id = new Guid("1ff7b38e-64df-b19f-9a1a-efc116cbdfb4"),
                            Age = (byte)58,
                            FullName = "Gus Konopelski"
                        },
                        new
                        {
                            Id = new Guid("965fc44b-b55b-6b4e-2866-53aa521067fb"),
                            Age = (byte)54,
                            FullName = "Matteo McKenzie"
                        },
                        new
                        {
                            Id = new Guid("148cd909-23f9-3e57-ff42-05fc0d0a12c3"),
                            Age = (byte)34,
                            FullName = "Arielle Romaguera"
                        },
                        new
                        {
                            Id = new Guid("f2b0cde9-f3c2-e487-01eb-8b48ef169b7b"),
                            Age = (byte)84,
                            FullName = "Christian Goyette"
                        },
                        new
                        {
                            Id = new Guid("fbd7549d-2a3a-5e54-871a-5663fe72f6f1"),
                            Age = (byte)70,
                            FullName = "Nicolas Marquardt"
                        },
                        new
                        {
                            Id = new Guid("a8c5423d-5ec7-6189-9e6d-007c827aa77d"),
                            Age = (byte)85,
                            FullName = "Mac Nienow"
                        },
                        new
                        {
                            Id = new Guid("c93a774d-4147-3c4d-e581-6be96f5c5889"),
                            Age = (byte)23,
                            FullName = "Broderick Mann"
                        },
                        new
                        {
                            Id = new Guid("ac00284e-e7af-56cc-26a9-a550e3acc0f0"),
                            Age = (byte)47,
                            FullName = "Juanita Schiller"
                        },
                        new
                        {
                            Id = new Guid("05de7dae-116f-b90e-b8f2-c38fa40d1409"),
                            Age = (byte)24,
                            FullName = "Jackeline Stracke"
                        },
                        new
                        {
                            Id = new Guid("469a266f-f7bd-dfca-ebb1-d370c2d783ea"),
                            Age = (byte)30,
                            FullName = "Corrine Runolfsdottir"
                        },
                        new
                        {
                            Id = new Guid("cb6c66ce-bd56-a2f0-322b-d0c90d20f6fc"),
                            Age = (byte)20,
                            FullName = "Lacey Okuneva"
                        },
                        new
                        {
                            Id = new Guid("edae0f3a-a24d-6df4-ad9e-8fdb8c085f52"),
                            Age = (byte)88,
                            FullName = "Kyler Mraz"
                        },
                        new
                        {
                            Id = new Guid("705c01e5-ea49-1a67-80b3-05e3b005f2b2"),
                            Age = (byte)38,
                            FullName = "Alexzander Sanford"
                        },
                        new
                        {
                            Id = new Guid("141d13d3-08f6-7c80-fa13-e6ce06fae2d7"),
                            Age = (byte)58,
                            FullName = "George Buckridge"
                        },
                        new
                        {
                            Id = new Guid("e36c2d96-fe63-8214-5fab-9862994c2759"),
                            Age = (byte)51,
                            FullName = "Freddy Prohaska"
                        },
                        new
                        {
                            Id = new Guid("c790ded1-4567-db8f-4315-17d9d9fec0a5"),
                            Age = (byte)72,
                            FullName = "Ivy Rau"
                        },
                        new
                        {
                            Id = new Guid("2bd64d29-28f5-bdd1-3ede-09835b71f2cb"),
                            Age = (byte)86,
                            FullName = "Xzavier Casper"
                        },
                        new
                        {
                            Id = new Guid("0d5f4a66-2ea0-f257-3779-87c7306c0143"),
                            Age = (byte)61,
                            FullName = "Daryl Larson"
                        },
                        new
                        {
                            Id = new Guid("14f86cef-d093-242e-55f9-6693ebdb20b6"),
                            Age = (byte)33,
                            FullName = "Destini Runolfsson"
                        },
                        new
                        {
                            Id = new Guid("e09aac47-eabb-fafd-b7bd-6b2e3723b4dc"),
                            Age = (byte)19,
                            FullName = "Lacy Torphy"
                        },
                        new
                        {
                            Id = new Guid("9faa1d8b-9664-473a-519b-a99097dbff2f"),
                            Age = (byte)36,
                            FullName = "Rylee Bradtke"
                        },
                        new
                        {
                            Id = new Guid("0356d979-1b3f-2c47-e1ee-890a5b7f4c5e"),
                            Age = (byte)26,
                            FullName = "Fannie Lowe"
                        },
                        new
                        {
                            Id = new Guid("55e4651b-f07a-eff3-5a68-a18ddc299acb"),
                            Age = (byte)71,
                            FullName = "Lucio Pacocha"
                        },
                        new
                        {
                            Id = new Guid("f5b66733-0002-e8cc-ff85-733e2a41e745"),
                            Age = (byte)57,
                            FullName = "Kasey Schmidt"
                        },
                        new
                        {
                            Id = new Guid("9ac5c653-63a4-52e7-bf11-7af68eb2a2b4"),
                            Age = (byte)41,
                            FullName = "Jeffrey D'Amore"
                        },
                        new
                        {
                            Id = new Guid("df9cfe3f-6152-9663-6f18-60f045308091"),
                            Age = (byte)25,
                            FullName = "Marguerite Larson"
                        },
                        new
                        {
                            Id = new Guid("6cfd6d9c-f1c6-75b4-a978-04234e9fa95e"),
                            Age = (byte)51,
                            FullName = "Javier Streich"
                        },
                        new
                        {
                            Id = new Guid("94fd15c7-8af7-9356-f11c-a91d0893abd2"),
                            Age = (byte)78,
                            FullName = "Summer Corwin"
                        },
                        new
                        {
                            Id = new Guid("98bfe4e9-9f26-d782-fb67-3b108ff98037"),
                            Age = (byte)63,
                            FullName = "Dewayne Wolf"
                        },
                        new
                        {
                            Id = new Guid("11f3a95a-a360-ab41-d3dc-77c2af0763c4"),
                            Age = (byte)70,
                            FullName = "Reyes Goyette"
                        },
                        new
                        {
                            Id = new Guid("6237575d-d997-ec4f-7bbb-59598b844537"),
                            Age = (byte)33,
                            FullName = "Consuelo Moen"
                        },
                        new
                        {
                            Id = new Guid("3f90024c-608b-088f-562f-b326a82244d1"),
                            Age = (byte)82,
                            FullName = "Monte Sauer"
                        },
                        new
                        {
                            Id = new Guid("4f2e04d9-5bbc-6ab1-4377-8b032bade52f"),
                            Age = (byte)90,
                            FullName = "Noemie Hagenes"
                        },
                        new
                        {
                            Id = new Guid("2443d8e9-93e0-c966-a72e-a456d59a8f0b"),
                            Age = (byte)90,
                            FullName = "Adah Doyle"
                        },
                        new
                        {
                            Id = new Guid("e7d93351-032e-bbee-31b3-4609800268de"),
                            Age = (byte)32,
                            FullName = "Khalid Nicolas"
                        },
                        new
                        {
                            Id = new Guid("ed8449ec-b693-8f5f-eef8-b62a8b048be4"),
                            Age = (byte)53,
                            FullName = "Kaylin Franecki"
                        },
                        new
                        {
                            Id = new Guid("46d4f8ea-3f79-80b5-40dc-e1a7e8d99595"),
                            Age = (byte)72,
                            FullName = "Hazel Kunde"
                        },
                        new
                        {
                            Id = new Guid("612d76b5-2c0a-728e-bd41-8ec2359ff271"),
                            Age = (byte)64,
                            FullName = "Shany Kozey"
                        },
                        new
                        {
                            Id = new Guid("3ceacb32-729a-9485-92dd-f8de9ff31fa6"),
                            Age = (byte)80,
                            FullName = "Chris Hodkiewicz"
                        },
                        new
                        {
                            Id = new Guid("ed293457-dee5-8ecf-606d-0ca196e4b000"),
                            Age = (byte)60,
                            FullName = "Enoch Cronin"
                        },
                        new
                        {
                            Id = new Guid("2cbc2087-6710-61b8-66c3-db46e0b88be8"),
                            Age = (byte)21,
                            FullName = "Tessie Skiles"
                        },
                        new
                        {
                            Id = new Guid("1b7f220f-11b0-d62f-6829-7f5317b33435"),
                            Age = (byte)49,
                            FullName = "Joelle Rath"
                        },
                        new
                        {
                            Id = new Guid("6ad74856-bb9c-1a6a-6523-ce0a27c8ce7b"),
                            Age = (byte)20,
                            FullName = "Brant Monahan"
                        },
                        new
                        {
                            Id = new Guid("b3f5d0d5-70cf-b085-e65c-0a5e0e1da208"),
                            Age = (byte)30,
                            FullName = "Jocelyn Effertz"
                        },
                        new
                        {
                            Id = new Guid("65373130-306a-3ad0-eaec-5031603b89a7"),
                            Age = (byte)60,
                            FullName = "Cloyd Feeney"
                        },
                        new
                        {
                            Id = new Guid("2f28e62b-f789-3228-6c43-b94d15e952a2"),
                            Age = (byte)84,
                            FullName = "Adrian Nolan"
                        },
                        new
                        {
                            Id = new Guid("bc4f2ea8-1fa6-731d-1e19-fab3de797232"),
                            Age = (byte)29,
                            FullName = "Niko Mitchell"
                        },
                        new
                        {
                            Id = new Guid("554a2011-32dc-9a7c-5c15-0168c38a33bf"),
                            Age = (byte)57,
                            FullName = "Camilla Denesik"
                        },
                        new
                        {
                            Id = new Guid("ec69e389-8199-cbf9-7d65-d638f58f9198"),
                            Age = (byte)81,
                            FullName = "Tania Kshlerin"
                        },
                        new
                        {
                            Id = new Guid("77662707-0555-3870-1be9-361a21609aff"),
                            Age = (byte)79,
                            FullName = "Reginald Vandervort"
                        },
                        new
                        {
                            Id = new Guid("de0448cb-6818-6730-212f-8c3feee0e566"),
                            Age = (byte)56,
                            FullName = "Orlando Grimes"
                        },
                        new
                        {
                            Id = new Guid("e313c25d-97a1-0608-1f6a-d25866888ded"),
                            Age = (byte)21,
                            FullName = "Ian Bergnaum"
                        },
                        new
                        {
                            Id = new Guid("2bb9199e-84fb-f592-90b3-a9aeffb7b491"),
                            Age = (byte)18,
                            FullName = "Jennyfer Satterfield"
                        },
                        new
                        {
                            Id = new Guid("4dcbbc7a-2ed0-72b0-6b1e-599a87755067"),
                            Age = (byte)44,
                            FullName = "Jeramy Oberbrunner"
                        },
                        new
                        {
                            Id = new Guid("cd55a6a1-37e1-37fb-8a46-f0e92861cd94"),
                            Age = (byte)31,
                            FullName = "Merle Bashirian"
                        },
                        new
                        {
                            Id = new Guid("d6ae4af4-40f7-c3ff-f846-b36e243723c2"),
                            Age = (byte)36,
                            FullName = "Israel Wilderman"
                        },
                        new
                        {
                            Id = new Guid("51e4b8e7-8de4-81b2-44d7-e6810787ea61"),
                            Age = (byte)45,
                            FullName = "Ellen Hilll"
                        },
                        new
                        {
                            Id = new Guid("bffc1a5b-6320-fe62-19ee-57de493d46c8"),
                            Age = (byte)35,
                            FullName = "Janice Franecki"
                        },
                        new
                        {
                            Id = new Guid("230fc02e-a37e-561d-480c-a4eff37c8407"),
                            Age = (byte)57,
                            FullName = "Janiya Schmidt"
                        },
                        new
                        {
                            Id = new Guid("331bcbc8-c9fc-bde8-06ab-4e45fa24216c"),
                            Age = (byte)34,
                            FullName = "Jadyn Johnston"
                        },
                        new
                        {
                            Id = new Guid("4cab4a64-ac08-23e2-a532-0d61dbcb49b5"),
                            Age = (byte)44,
                            FullName = "Graham Schulist"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
