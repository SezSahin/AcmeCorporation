﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    SerialNumber = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.SerialNumber);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: true),
                    DateOfBirth = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                column: "SerialNumber",
                values: new object[]
                {
                    new Guid("5776bf3a-46e9-42cc-b2d6-a44a73e08614"),
                    new Guid("b36473c7-8632-4895-85a8-785eb60c5eae"),
                    new Guid("6fde8950-1917-4d49-ae9e-59f8b3454743"),
                    new Guid("c198dfc2-2629-4639-aba8-155748f9b9b6"),
                    new Guid("e3bb4595-e20f-4f15-89ba-3e6c04c10020"),
                    new Guid("c25cfd71-52ac-498d-a89f-66c7f82fef44"),
                    new Guid("f7401a95-898e-48af-854f-5feedc14e25b"),
                    new Guid("1d52b42d-510b-4ffd-af35-ebc7685685cd"),
                    new Guid("239852b6-513b-4437-b902-a52edc9c06cc"),
                    new Guid("89276226-71d3-467a-8dec-1b6d1bc7f8ed"),
                    new Guid("65e310f6-597d-4692-babd-71c22e9dc44e"),
                    new Guid("328eb54a-6577-4a4e-b7d5-2a2aa61f913e"),
                    new Guid("bc2dde52-442d-4302-84be-69099c9d2825"),
                    new Guid("6d8875bc-290b-4b25-958f-10b42092f404"),
                    new Guid("8d5dfe88-02f2-4d2e-8f88-43259cbc5c5e"),
                    new Guid("ebdd9b62-faae-487c-af5a-e9099b34c9f5"),
                    new Guid("8c922d20-3bfd-405c-ac24-ac5280a362c6"),
                    new Guid("138f1730-45fb-428c-abae-3ffd0742ae69"),
                    new Guid("cdc60ec8-475e-42a0-8d7e-5b1bad54047f"),
                    new Guid("e65467c5-ad90-4c27-8ffa-c73f3dfea5eb"),
                    new Guid("5bf4bb92-b189-4bd3-bfef-20e6af9ae23a"),
                    new Guid("61db80b6-dd40-489c-a852-8c63482ad88f"),
                    new Guid("bcbb2544-0ff6-44c0-85e2-51437d9734bd"),
                    new Guid("dc975ce2-3974-4a1a-9c96-7591194c632b"),
                    new Guid("55cf4928-29ec-4ef2-ac56-fc23f5dfa150"),
                    new Guid("003feeb3-b7fd-463f-a6a3-0bef50911b10"),
                    new Guid("e3371f82-2d11-4660-9395-f69a5387235f"),
                    new Guid("3f0b4904-d52d-49ef-950a-57a4a8d08ec5"),
                    new Guid("ecc8b054-cdb1-4019-8e60-453937a461aa"),
                    new Guid("35ee0555-6c4e-4e83-b8f6-e030ce3ce1d9"),
                    new Guid("7c5fe78a-2b28-49d4-bce1-e26c8fd1da4a"),
                    new Guid("40399e9a-1be7-4435-8744-8551efdf410b"),
                    new Guid("3ebe9896-72cd-4d7e-b70b-04d9906148f9"),
                    new Guid("e72e51c3-fb57-4497-99cd-59b8ffc35899"),
                    new Guid("092b2917-b1fd-422e-bae9-3d735a691ca6"),
                    new Guid("40c3968c-a768-4596-99d7-f1ce20e01e6b"),
                    new Guid("ee1a8c5c-8c89-4373-bf86-7fa8872798a1"),
                    new Guid("78bedbbb-959b-458b-85f8-e8c81f3de548"),
                    new Guid("2ff86161-0273-4225-916d-b46d630e33f8"),
                    new Guid("cbfcabf5-9f98-4da3-9722-2ef220ef7076"),
                    new Guid("012b8c59-bec4-43c9-bd14-34bf46648627"),
                    new Guid("fcfa14d6-01c8-4931-bfe5-3781a5be092c"),
                    new Guid("d9e47fff-7a93-4c90-bb22-103128e3f225"),
                    new Guid("c0063fcb-135a-4354-89fd-74e915fd7beb"),
                    new Guid("969bf1f5-cca4-4a26-a134-fabddad823aa"),
                    new Guid("4687570b-8fb3-4d26-8046-164390e0fa28"),
                    new Guid("60f325ee-8422-4e30-9928-fae5ad50f809"),
                    new Guid("2aa0441e-f405-44f1-b4d0-7455f45737d1"),
                    new Guid("216a89c7-20d8-40bd-a984-8cd4fd5945f7"),
                    new Guid("0758ecd6-e62b-4389-a966-2edcc573b6f9"),
                    new Guid("498a7382-29c1-409a-aeaf-bff1ed335669"),
                    new Guid("093fb897-f806-49fb-8ff8-9fb5ae5aac37"),
                    new Guid("fbc2e6dd-d453-4725-a272-063c8031a371"),
                    new Guid("1fdb90a9-55d6-4703-a58d-e84ce4c93c67"),
                    new Guid("61d3af65-a4ea-4614-af13-0b5ed2693b7f"),
                    new Guid("275e63b2-6321-40a6-80f0-865e82a0666e"),
                    new Guid("3375aa27-3c3c-474e-a3a9-fdaf080a8133"),
                    new Guid("9256a3d9-e503-4aee-8f72-03cd0777b81c"),
                    new Guid("1155b64d-5da6-40d0-89d6-6e42ecbd8d1f"),
                    new Guid("3a6f686f-142c-44e7-8380-4f1cc77564a7"),
                    new Guid("75c0fc62-9adf-4ce3-bbfb-a089bb8acb0f"),
                    new Guid("b05f4b22-2801-4d10-b884-565ceb408d60"),
                    new Guid("d645ada1-e730-402c-b7ba-022efdb70898"),
                    new Guid("484b1c4c-8d57-4263-a449-2fe6b28d8a55"),
                    new Guid("c7707fe9-d01e-4c3a-9433-06bd9136a418"),
                    new Guid("9a9265a0-8433-47b1-8387-334f743c847b"),
                    new Guid("b6bfc773-16d8-479c-9300-ab16f6c53324"),
                    new Guid("61fb3651-8ef4-4e9d-b34a-7a7d2c2b71c0"),
                    new Guid("87c0673c-ce0f-4c7e-ad5d-bf2761de7a20"),
                    new Guid("c0286240-8f54-42ec-ac96-4ae1789a2947"),
                    new Guid("e494acbc-fbfe-4765-b7e8-91b878bd37c9"),
                    new Guid("1d8c1d18-5a9c-4269-b6f3-f9c25e292990"),
                    new Guid("fe83641a-c9bd-4e5f-b1cf-522f08bea6fb"),
                    new Guid("8f913fbe-3435-4619-b3ff-f445acf6c44f"),
                    new Guid("54ac14dc-0bb7-40e0-8d5c-e80afab4d6c1"),
                    new Guid("7dba7969-b8ef-456d-81f7-808645050989"),
                    new Guid("d578abb5-111b-4b9b-b0b0-7a882f36f1a3"),
                    new Guid("2eb55505-e551-4c8a-82e1-69ed727d597a"),
                    new Guid("79cccedc-03fd-4593-8216-97138361e91e"),
                    new Guid("5a831208-aab7-4d18-bc37-882596adafaa"),
                    new Guid("507e8990-bcff-4d94-9899-5d174d8419bf"),
                    new Guid("655720ae-ea41-40d0-bc42-f6d0c052cc05"),
                    new Guid("32fe5e09-c655-46b2-8791-edb67bedd52f"),
                    new Guid("6f4f9461-a85a-4bb0-a280-29a59062062e"),
                    new Guid("6c9bdf9c-aa79-42f6-b51e-8f21d9426f8e"),
                    new Guid("f8fa93cf-b730-42d6-8bd9-aa11994a26f7"),
                    new Guid("63d31cf3-956b-40df-923f-117b8ed28e9f"),
                    new Guid("008364e8-de65-4c92-b186-7d5d0e97c514"),
                    new Guid("4fffa02a-35a0-4d33-b7ea-49c24b7a111e"),
                    new Guid("fa3c58c5-2f27-4284-aafd-81f760c4bcfd"),
                    new Guid("d85178c1-e302-428c-ab9a-ddf90eb272a4"),
                    new Guid("748ee07c-31a1-44b3-8fd3-7534a64c1f6f"),
                    new Guid("0f428e4c-cfa9-48eb-8468-251d8a306b27"),
                    new Guid("45e87e6b-d15f-4389-8602-56612af1faf2"),
                    new Guid("c8c63d20-50f5-4871-b9a1-a92d0469de42"),
                    new Guid("e3ec0ced-7cc9-4c7f-81da-722cdee77ea3"),
                    new Guid("532211e6-e9b0-4eed-b336-993b2938b3ff"),
                    new Guid("5b92bca3-6c2a-4a91-90f0-0ceb2719532f"),
                    new Guid("93ab4876-d18e-4332-b972-d9ccd102f86c"),
                    new Guid("4c2e6f82-35ff-4c7c-90ad-b9401794d68f")
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
