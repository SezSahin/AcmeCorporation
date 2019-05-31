using System;
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
                    FirstName = table.Column<string>(nullable: true),
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
                    new Guid("01db928f-2271-42b9-8a31-e7f5cf2beae0"),
                    new Guid("5a0254ad-31da-4bce-a22a-fd876a26cbc4"),
                    new Guid("a9b461ba-84db-41f3-a2cc-2b59c9122fe4"),
                    new Guid("f6aa03bf-8874-4994-a088-3fe4456520ce"),
                    new Guid("34981dea-49aa-48bf-b2e6-dfd0cb68e5b1"),
                    new Guid("bcef16f0-2de5-458e-a851-2bab1335c025"),
                    new Guid("fef0667a-20a4-4fb6-88a3-ea4610c5b793"),
                    new Guid("9ac8d427-54ff-4cb5-bfb3-ec172a6081bb"),
                    new Guid("8c45559b-701d-4380-b155-cae2622a166c"),
                    new Guid("411297e3-19f6-44df-ae2a-8e91e9dc57cc"),
                    new Guid("7e9d38ad-911f-4e24-9907-78f1e60848f8"),
                    new Guid("2e0b9728-8fe8-4070-bba4-424e8ed0bcfe"),
                    new Guid("13f96f89-255a-4107-a360-ac11215dfe4c"),
                    new Guid("24801c62-7c9d-4b2f-93d7-a98e6d4cb809"),
                    new Guid("dc9ff94f-84af-4f36-86d2-65fbf2c7938a"),
                    new Guid("a0c1a7c5-c133-4172-85c5-048e2d83f791"),
                    new Guid("1b5d945e-c95f-43ed-82f0-a3b5484cc469"),
                    new Guid("693c52ff-f1df-4754-81a1-22ceb01e4f9b"),
                    new Guid("47187713-be0d-4c5d-8567-3f93c22c6cb8"),
                    new Guid("321fea35-221d-4a3b-a4e5-ef72b893a4c4"),
                    new Guid("30fcd992-2f02-4166-b080-69b4d0132aca"),
                    new Guid("925b9f44-e02a-49a1-a185-99cb1019b997"),
                    new Guid("5d739712-7a9c-4123-8aac-4b2c3c6862ce"),
                    new Guid("2f359656-87ac-4eed-9071-45e6ea80feac"),
                    new Guid("aa1c050d-34c6-46be-983b-e1977b011ea3"),
                    new Guid("f4c5b2cb-9042-41ee-a04a-5e91a542edc8"),
                    new Guid("fbbaaa15-6589-4e44-8e78-bd27379374e3"),
                    new Guid("7535a7e0-38d3-47cd-b6db-54fde00fa927"),
                    new Guid("d2a323d3-109f-48f0-9e65-058dd44146bf"),
                    new Guid("07715865-2baf-4bed-ab39-63c69644f30f"),
                    new Guid("922dfbe5-c5b6-430a-afc1-47032914a472"),
                    new Guid("16d150ba-96dc-4c4b-9dbd-476e83e4ed2b"),
                    new Guid("0e575f50-9206-423b-883e-9b429e79da66"),
                    new Guid("e6bd3a27-804f-4a62-a750-fbf4555e35c0"),
                    new Guid("8aef82ac-e858-4e9c-8fb2-b21e39115fec"),
                    new Guid("3bdffeea-03d9-491f-9de3-5dd63ac8a497"),
                    new Guid("310390fc-f5c7-461c-a196-5801f2f30aa0"),
                    new Guid("bf58a373-97fb-48ed-97de-287bd9778b74"),
                    new Guid("5a95c609-5d3b-48d9-a783-ea3a728e3881"),
                    new Guid("37196449-2727-4d7d-b544-046df6acb8a7"),
                    new Guid("1541ea71-3b55-45d9-9116-3114b191283c"),
                    new Guid("629417ae-a975-41d1-9cc0-cdcb3c725e0a"),
                    new Guid("755ca51e-c80d-47bd-85ea-62cfe4f9fa8e"),
                    new Guid("761a29bd-08cd-41ca-b50b-5adc1cf9e22b"),
                    new Guid("c67d093c-1414-4731-9c0d-9d09e1806b43"),
                    new Guid("f67c8355-4c31-4c28-8cfb-71ce9d42632a"),
                    new Guid("678e1de2-106a-4b4c-9538-099b04b6e6db"),
                    new Guid("edca7c55-0159-4112-8067-29fe5701a5f6"),
                    new Guid("40c9a747-159c-43c6-b3bb-df1a9eb234b5"),
                    new Guid("c250af46-8611-41c0-8c71-3ccc9b1e7a68"),
                    new Guid("ef4e9d04-65d9-4b7e-b126-6308d92d89f0"),
                    new Guid("e8d11f98-f229-40ba-9d59-f7a31bed28d8"),
                    new Guid("197c1113-b64b-476a-a2e3-b60ebf0d78cf"),
                    new Guid("676e5ba2-7225-4783-8830-2f28a5073de8"),
                    new Guid("49ae2030-f133-4ba6-8a4e-8974f0878f1c"),
                    new Guid("c42a51a8-c130-4918-aca1-07e2ae4a9e56"),
                    new Guid("eb498d44-efcd-43fd-9bf9-99752d254efe"),
                    new Guid("a3bad00a-4a3f-42bd-a8b6-07fae71a1a14"),
                    new Guid("725d9144-baf4-45f4-8123-a09eb96007b4"),
                    new Guid("e042acce-59c9-49d3-8e0d-cbe47b88eeff"),
                    new Guid("72ea6063-24da-46f7-9c73-dc495a83b39f"),
                    new Guid("cdd14fb8-6495-492d-840e-907e5a548568"),
                    new Guid("b147ee40-8d77-4447-ae29-abd87065cb81"),
                    new Guid("8e16ddaa-455a-41fc-9cf0-4049fd246c37"),
                    new Guid("1aa360ab-b220-4156-b480-348fac70c979"),
                    new Guid("7d1c988b-3c35-4258-98b6-c020425ac8f6"),
                    new Guid("7551d2f4-4bd1-4b7d-845b-67c6a190dc56"),
                    new Guid("25428c1d-bccc-462f-b6d8-f855dcd41693"),
                    new Guid("87ce322a-06a0-4988-ab3c-6a75fec6a4ce"),
                    new Guid("35308c00-22cc-48f5-8c80-d0860ecd9e61"),
                    new Guid("6e537d6f-b293-4c79-9e05-85a01003ad66"),
                    new Guid("ec5d4c38-aa0e-4c3f-968b-bdddebca3eca"),
                    new Guid("11484942-b151-4344-b87b-33704dcb22ec"),
                    new Guid("588441c1-7be8-4a68-ae86-a7c812e04f0e"),
                    new Guid("9571bd08-3f39-4f82-8537-53187f09ccf4"),
                    new Guid("e25003a5-8b48-4a55-b100-e5585f193f59"),
                    new Guid("9175120f-e6bd-4dbe-bcf8-58411bd4cf9e"),
                    new Guid("3452d395-0123-417e-8cd3-03a70f6fd546"),
                    new Guid("e802b327-8787-4418-ae80-b57c21b503dc"),
                    new Guid("b4a3170e-92af-4c31-ac2c-fd4a5ac705af"),
                    new Guid("d538d99d-feef-408f-8046-6b5113d1a824"),
                    new Guid("e2be4970-7315-45b2-a22a-8ab82098bfc0"),
                    new Guid("cbf48c99-4209-4b9a-a59f-ef8bd75968fc"),
                    new Guid("5243540c-8841-4b86-be92-2cdb816bb5f9"),
                    new Guid("24b0164e-6ca1-4086-9ca3-7582ab976309"),
                    new Guid("476d7509-ad4e-456b-a0a5-de32692da8e8"),
                    new Guid("8655798e-123c-487b-8c16-1f672792472d"),
                    new Guid("4aeec7aa-2b59-4c0c-a17d-72b32df6dd01"),
                    new Guid("6a00fe0f-052d-4e05-9a92-aa63e09b73a9"),
                    new Guid("92be2070-ecbf-4138-b8f0-7dba8e84c4c8"),
                    new Guid("2f56b7d6-5ec4-4fcf-bcde-a0f8c31680bf"),
                    new Guid("91527495-853f-4609-aad4-9b636b661802"),
                    new Guid("0507ab31-bdff-4a3d-bc45-d091a43ec34e"),
                    new Guid("61ce410c-45b5-4f7a-851e-03212c6ae31b"),
                    new Guid("ab6db752-d5cb-4e50-96ac-e4de08a606ed"),
                    new Guid("963f6b2d-8b3a-415c-928c-cd8c7b22ec48"),
                    new Guid("b1d45f44-c8a4-42e0-811e-e0fffb6f2a19"),
                    new Guid("782b3602-c4d5-49bf-a108-a058ef00350f"),
                    new Guid("de5834de-6fef-49f4-97d7-e422a113011f"),
                    new Guid("5f06258d-af40-4a86-84b5-7b6740642c07")
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
