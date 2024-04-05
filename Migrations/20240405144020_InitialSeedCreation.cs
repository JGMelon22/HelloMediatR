using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiMediatRDemo.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Age = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Age", "FullName" },
                values: new object[,]
                {
                    { new Guid("0356d979-1b3f-2c47-e1ee-890a5b7f4c5e"), (byte)26, "Fannie Lowe" },
                    { new Guid("051ba80d-c509-b714-eeae-8e20815bbb22"), (byte)53, "Ivory Beier" },
                    { new Guid("05de7dae-116f-b90e-b8f2-c38fa40d1409"), (byte)24, "Jackeline Stracke" },
                    { new Guid("08a49c97-4e1e-c0ae-e204-ef97d2e17a5a"), (byte)64, "Sheridan Collier" },
                    { new Guid("0c0d988c-dcee-7c05-07d4-6ad967d9a5a1"), (byte)27, "Myrtle Bahringer" },
                    { new Guid("0d5f4a66-2ea0-f257-3779-87c7306c0143"), (byte)61, "Daryl Larson" },
                    { new Guid("11f3a95a-a360-ab41-d3dc-77c2af0763c4"), (byte)70, "Reyes Goyette" },
                    { new Guid("13829e89-9258-d242-4426-7824a49b7eac"), (byte)46, "Oma Renner" },
                    { new Guid("141d13d3-08f6-7c80-fa13-e6ce06fae2d7"), (byte)58, "George Buckridge" },
                    { new Guid("14206f4f-7dd9-1d53-71e0-6fcb442c5c61"), (byte)69, "Rae Halvorson" },
                    { new Guid("148cd909-23f9-3e57-ff42-05fc0d0a12c3"), (byte)34, "Arielle Romaguera" },
                    { new Guid("14f86cef-d093-242e-55f9-6693ebdb20b6"), (byte)33, "Destini Runolfsson" },
                    { new Guid("18611a98-6870-2502-dd7e-c1fd4a616f70"), (byte)75, "Lazaro Wyman" },
                    { new Guid("1881368b-90c0-f159-ac73-a6d6c16afbd4"), (byte)39, "Nelle McCullough" },
                    { new Guid("1b58c616-bae4-5541-c440-e774fa1f7da0"), (byte)71, "Elissa Hayes" },
                    { new Guid("1b7f220f-11b0-d62f-6829-7f5317b33435"), (byte)49, "Joelle Rath" },
                    { new Guid("1ff7b38e-64df-b19f-9a1a-efc116cbdfb4"), (byte)58, "Gus Konopelski" },
                    { new Guid("209bf226-3df4-cfaa-6729-77105d0a83ec"), (byte)47, "Joesph Kris" },
                    { new Guid("2144131b-9e2d-456e-8ab2-62a4390d83a2"), (byte)84, "Arvid Beer" },
                    { new Guid("230fc02e-a37e-561d-480c-a4eff37c8407"), (byte)57, "Janiya Schmidt" },
                    { new Guid("2443d8e9-93e0-c966-a72e-a456d59a8f0b"), (byte)90, "Adah Doyle" },
                    { new Guid("26446d84-0d99-e3bf-96d0-0ba4b3390a0c"), (byte)22, "Alf Braun" },
                    { new Guid("2b079ba6-2f8d-5850-2495-7f96abfb3fb0"), (byte)73, "Uriel Harber" },
                    { new Guid("2bb9199e-84fb-f592-90b3-a9aeffb7b491"), (byte)18, "Jennyfer Satterfield" },
                    { new Guid("2bd64d29-28f5-bdd1-3ede-09835b71f2cb"), (byte)86, "Xzavier Casper" },
                    { new Guid("2cbc2087-6710-61b8-66c3-db46e0b88be8"), (byte)21, "Tessie Skiles" },
                    { new Guid("2f1b50b6-46ff-26f1-9c74-c9c1d05cc31c"), (byte)88, "Merl Stanton" },
                    { new Guid("2f28e62b-f789-3228-6c43-b94d15e952a2"), (byte)84, "Adrian Nolan" },
                    { new Guid("2f85502f-aa26-9eba-6574-2bf9f28a6438"), (byte)55, "Lacey Wisoky" },
                    { new Guid("331bcbc8-c9fc-bde8-06ab-4e45fa24216c"), (byte)34, "Jadyn Johnston" },
                    { new Guid("33a70afb-90df-9beb-9b15-c5632348d982"), (byte)72, "Luigi Goldner" },
                    { new Guid("3ceacb32-729a-9485-92dd-f8de9ff31fa6"), (byte)80, "Chris Hodkiewicz" },
                    { new Guid("3e520fa4-5e39-b494-84b2-ebdba9fde0cb"), (byte)46, "Velva Wiza" },
                    { new Guid("3f90024c-608b-088f-562f-b326a82244d1"), (byte)82, "Monte Sauer" },
                    { new Guid("4056e5ed-d005-0504-30ac-d2abe96b81a1"), (byte)54, "Hershel Volkman" },
                    { new Guid("469a266f-f7bd-dfca-ebb1-d370c2d783ea"), (byte)30, "Corrine Runolfsdottir" },
                    { new Guid("46d4f8ea-3f79-80b5-40dc-e1a7e8d99595"), (byte)72, "Hazel Kunde" },
                    { new Guid("49aa0f50-81b4-4333-b676-659a1757699e"), (byte)18, "Elian Schultz" },
                    { new Guid("4cab4a64-ac08-23e2-a532-0d61dbcb49b5"), (byte)44, "Graham Schulist" },
                    { new Guid("4dcbbc7a-2ed0-72b0-6b1e-599a87755067"), (byte)44, "Jeramy Oberbrunner" },
                    { new Guid("4deb1a9a-8c88-b219-7a6b-fa2e1159220e"), (byte)69, "Laverne Braun" },
                    { new Guid("4e51d9e5-f5bf-ca02-cd64-4c6d442ff105"), (byte)38, "Moses Parker" },
                    { new Guid("4f2e04d9-5bbc-6ab1-4377-8b032bade52f"), (byte)90, "Noemie Hagenes" },
                    { new Guid("51e4b8e7-8de4-81b2-44d7-e6810787ea61"), (byte)45, "Ellen Hilll" },
                    { new Guid("51eb9f4f-3ccc-6b35-5bf6-db634d4f7d08"), (byte)43, "Theo Prosacco" },
                    { new Guid("554a2011-32dc-9a7c-5c15-0168c38a33bf"), (byte)57, "Camilla Denesik" },
                    { new Guid("55e4651b-f07a-eff3-5a68-a18ddc299acb"), (byte)71, "Lucio Pacocha" },
                    { new Guid("5d01bc40-4e4a-6242-150e-b46488978786"), (byte)49, "Columbus Conroy" },
                    { new Guid("612d76b5-2c0a-728e-bd41-8ec2359ff271"), (byte)64, "Shany Kozey" },
                    { new Guid("6237575d-d997-ec4f-7bbb-59598b844537"), (byte)33, "Consuelo Moen" },
                    { new Guid("65373130-306a-3ad0-eaec-5031603b89a7"), (byte)60, "Cloyd Feeney" },
                    { new Guid("6ad74856-bb9c-1a6a-6523-ce0a27c8ce7b"), (byte)20, "Brant Monahan" },
                    { new Guid("6cfd6d9c-f1c6-75b4-a978-04234e9fa95e"), (byte)51, "Javier Streich" },
                    { new Guid("7057ecf5-55f6-e337-2a92-6c9dc6867410"), (byte)72, "Eveline Glover" },
                    { new Guid("705c01e5-ea49-1a67-80b3-05e3b005f2b2"), (byte)38, "Alexzander Sanford" },
                    { new Guid("71167f8d-e2ae-81ba-a473-5e6a6a22db8f"), (byte)68, "Shayne Smitham" },
                    { new Guid("77662707-0555-3870-1be9-361a21609aff"), (byte)79, "Reginald Vandervort" },
                    { new Guid("87357d68-c3ad-2c9d-09a5-138937a8d233"), (byte)85, "Lois VonRueden" },
                    { new Guid("873646a0-fc95-1434-01ca-eca610ced367"), (byte)22, "Ignatius Kris" },
                    { new Guid("94fd15c7-8af7-9356-f11c-a91d0893abd2"), (byte)78, "Summer Corwin" },
                    { new Guid("965fc44b-b55b-6b4e-2866-53aa521067fb"), (byte)54, "Matteo McKenzie" },
                    { new Guid("98bfe4e9-9f26-d782-fb67-3b108ff98037"), (byte)63, "Dewayne Wolf" },
                    { new Guid("9ac5c653-63a4-52e7-bf11-7af68eb2a2b4"), (byte)41, "Jeffrey D'Amore" },
                    { new Guid("9faa1d8b-9664-473a-519b-a99097dbff2f"), (byte)36, "Rylee Bradtke" },
                    { new Guid("a217371b-4f78-adf6-0c3a-ff909cd425a6"), (byte)65, "Enos Erdman" },
                    { new Guid("a8c5423d-5ec7-6189-9e6d-007c827aa77d"), (byte)85, "Mac Nienow" },
                    { new Guid("ac00284e-e7af-56cc-26a9-a550e3acc0f0"), (byte)47, "Juanita Schiller" },
                    { new Guid("ac39048b-1e81-f2ba-cbfa-30bdfda00f37"), (byte)20, "Rylee Reichert" },
                    { new Guid("ae4a1089-3ec0-5364-84fd-9b3e188e5fc9"), (byte)48, "Brendan Braun" },
                    { new Guid("b3f5d0d5-70cf-b085-e65c-0a5e0e1da208"), (byte)30, "Jocelyn Effertz" },
                    { new Guid("b7887025-6877-57e3-14c3-96b5d7807433"), (byte)68, "Gideon Boehm" },
                    { new Guid("b84bc9b3-cf8d-1ea9-6852-27bdc061c1aa"), (byte)25, "Leone Jast" },
                    { new Guid("b9f91b00-2bb2-1a3a-1289-4aa7dd8bc314"), (byte)30, "Althea Blanda" },
                    { new Guid("bc4f2ea8-1fa6-731d-1e19-fab3de797232"), (byte)29, "Niko Mitchell" },
                    { new Guid("bf79f37b-b39c-ec0c-4667-0d632f84c1c2"), (byte)44, "Gustave Turner" },
                    { new Guid("bffc1a5b-6320-fe62-19ee-57de493d46c8"), (byte)35, "Janice Franecki" },
                    { new Guid("c11a0fbd-6b37-632b-c648-91cf54d9713c"), (byte)81, "Aric Legros" },
                    { new Guid("c4d2e238-04fd-4c77-ce4c-6569710cd9d4"), (byte)90, "Willie Runte" },
                    { new Guid("c5d1b662-c192-7769-451d-8792c41e16ff"), (byte)45, "Leola Donnelly" },
                    { new Guid("c6e27f24-7713-2fca-7095-d7c112a42819"), (byte)53, "Lorenza Torphy" },
                    { new Guid("c790ded1-4567-db8f-4315-17d9d9fec0a5"), (byte)72, "Ivy Rau" },
                    { new Guid("c93a774d-4147-3c4d-e581-6be96f5c5889"), (byte)23, "Broderick Mann" },
                    { new Guid("cb6c66ce-bd56-a2f0-322b-d0c90d20f6fc"), (byte)20, "Lacey Okuneva" },
                    { new Guid("cd55a6a1-37e1-37fb-8a46-f0e92861cd94"), (byte)31, "Merle Bashirian" },
                    { new Guid("d6ae4af4-40f7-c3ff-f846-b36e243723c2"), (byte)36, "Israel Wilderman" },
                    { new Guid("de0448cb-6818-6730-212f-8c3feee0e566"), (byte)56, "Orlando Grimes" },
                    { new Guid("df9cfe3f-6152-9663-6f18-60f045308091"), (byte)25, "Marguerite Larson" },
                    { new Guid("e09aac47-eabb-fafd-b7bd-6b2e3723b4dc"), (byte)19, "Lacy Torphy" },
                    { new Guid("e313c25d-97a1-0608-1f6a-d25866888ded"), (byte)21, "Ian Bergnaum" },
                    { new Guid("e36c2d96-fe63-8214-5fab-9862994c2759"), (byte)51, "Freddy Prohaska" },
                    { new Guid("e7d93351-032e-bbee-31b3-4609800268de"), (byte)32, "Khalid Nicolas" },
                    { new Guid("ec69e389-8199-cbf9-7d65-d638f58f9198"), (byte)81, "Tania Kshlerin" },
                    { new Guid("ed293457-dee5-8ecf-606d-0ca196e4b000"), (byte)60, "Enoch Cronin" },
                    { new Guid("ed8449ec-b693-8f5f-eef8-b62a8b048be4"), (byte)53, "Kaylin Franecki" },
                    { new Guid("edae0f3a-a24d-6df4-ad9e-8fdb8c085f52"), (byte)88, "Kyler Mraz" },
                    { new Guid("f1c1fa48-7d8d-49d4-d04d-56a5b65b19dd"), (byte)76, "Doris Wilderman" },
                    { new Guid("f2b0cde9-f3c2-e487-01eb-8b48ef169b7b"), (byte)84, "Christian Goyette" },
                    { new Guid("f5b66733-0002-e8cc-ff85-733e2a41e745"), (byte)57, "Kasey Schmidt" },
                    { new Guid("fb5a6522-3563-fab3-ab45-9f3eddd00b55"), (byte)30, "Zena Kling" },
                    { new Guid("fbd7549d-2a3a-5e54-871a-5663fe72f6f1"), (byte)70, "Nicolas Marquardt" }
                });

            migrationBuilder.CreateIndex(
                name: "Idx_Person_Id",
                table: "People",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
