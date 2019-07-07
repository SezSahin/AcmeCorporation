﻿// <auto-generated />
using System;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190622184026_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Model.Product", b =>
                {
                    b.Property<Guid>("SerialNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Id");

                    b.HasKey("SerialNumber");

                    b.ToTable("Products");

                    b.HasData(
                        new { SerialNumber = new Guid("daf3002f-a830-4229-99c4-bdb1edcb90f3"), Id = 0L },
                        new { SerialNumber = new Guid("c109f27b-5b69-4cae-9332-2f070a61a301"), Id = 1L },
                        new { SerialNumber = new Guid("ba85f0e7-dd22-48a2-a09a-c7843d696b2c"), Id = 2L },
                        new { SerialNumber = new Guid("0d2ff8b4-1981-4ca8-afe7-e2ba8497cf9a"), Id = 3L },
                        new { SerialNumber = new Guid("d8643265-0ee6-4883-ad88-e1d1dffd948d"), Id = 4L },
                        new { SerialNumber = new Guid("9a9e1198-39d1-4a50-b365-79ae3eeb3d83"), Id = 5L },
                        new { SerialNumber = new Guid("57e320f6-453e-4238-90f1-379018d21c35"), Id = 6L },
                        new { SerialNumber = new Guid("fca3528f-3ef0-4300-93e9-8f10a41ecc48"), Id = 7L },
                        new { SerialNumber = new Guid("44d2eb02-f16f-4457-bd4f-e0604d362d1d"), Id = 8L },
                        new { SerialNumber = new Guid("d38f5bf4-a055-46e2-82f3-3565eda028e3"), Id = 9L },
                        new { SerialNumber = new Guid("0aac9fe6-6c63-4227-b499-79e4418e1b4b"), Id = 10L },
                        new { SerialNumber = new Guid("920d32fd-0dfc-4351-b8f4-62446179e491"), Id = 11L },
                        new { SerialNumber = new Guid("2f7d1ca3-078b-48ee-94d8-48d8438aefce"), Id = 12L },
                        new { SerialNumber = new Guid("9779bc0e-624e-4c34-a148-566ae09b4745"), Id = 13L },
                        new { SerialNumber = new Guid("a124da52-7de7-4944-9ef3-4a191d655157"), Id = 14L },
                        new { SerialNumber = new Guid("c02ff762-e77f-4044-adb8-f6cf9b405d8e"), Id = 15L },
                        new { SerialNumber = new Guid("ad864dea-0e64-4769-900d-4129c86faee6"), Id = 16L },
                        new { SerialNumber = new Guid("e23405e8-17ec-4edc-b80a-c4e99ade8981"), Id = 17L },
                        new { SerialNumber = new Guid("5e6358e3-58fe-4a38-b73e-03ddd968336a"), Id = 18L },
                        new { SerialNumber = new Guid("4fb10213-021c-4dd3-b5d0-97fab8d21508"), Id = 19L },
                        new { SerialNumber = new Guid("d8c9a4ce-4688-4347-8350-b9de8677d975"), Id = 20L },
                        new { SerialNumber = new Guid("0f792a3c-b153-4cda-ae86-32bd4eae4986"), Id = 21L },
                        new { SerialNumber = new Guid("c979d3d0-ae20-4098-b6db-76ba5a350b6e"), Id = 22L },
                        new { SerialNumber = new Guid("1dba3136-79d3-4ce3-982e-12f6707868a0"), Id = 23L },
                        new { SerialNumber = new Guid("7a9e1e8c-067b-4590-957c-e91e1baf541d"), Id = 24L },
                        new { SerialNumber = new Guid("14082b93-dacf-4c00-b51f-ab9a2617e574"), Id = 25L },
                        new { SerialNumber = new Guid("741393ff-59ce-4bff-b821-75698affc04c"), Id = 26L },
                        new { SerialNumber = new Guid("0f4f8b0d-a8e1-49d5-b333-72fb49dee4e9"), Id = 27L },
                        new { SerialNumber = new Guid("254ff079-b3b3-4372-b89e-ea87425a86b9"), Id = 28L },
                        new { SerialNumber = new Guid("b275ccf9-a4bc-4b5f-9c1a-3ef782c53e43"), Id = 29L },
                        new { SerialNumber = new Guid("e9e6a30e-8641-427a-b1ed-975caf990028"), Id = 30L },
                        new { SerialNumber = new Guid("db675a49-9dc5-47ba-a704-0824e7648565"), Id = 31L },
                        new { SerialNumber = new Guid("d06a37ad-ac08-48a2-99b4-0b10944a0132"), Id = 32L },
                        new { SerialNumber = new Guid("94afd90a-ec58-4d5e-a2fc-4121d74e4829"), Id = 33L },
                        new { SerialNumber = new Guid("8056087b-b539-4bcb-8b37-8529ce1a6415"), Id = 34L },
                        new { SerialNumber = new Guid("7ba2be6e-c1ae-4d22-9953-a1f7facf0a73"), Id = 35L },
                        new { SerialNumber = new Guid("3a3a6cd0-130f-4a2d-9318-73c64bf1b94d"), Id = 36L },
                        new { SerialNumber = new Guid("362a2d89-6733-426e-9864-9ac10c087d8a"), Id = 37L },
                        new { SerialNumber = new Guid("4874dead-2908-431d-87bc-3c892051db87"), Id = 38L },
                        new { SerialNumber = new Guid("4470b766-a707-4769-a24e-3c99fcf51af3"), Id = 39L },
                        new { SerialNumber = new Guid("cfb4d138-6dad-4167-83fd-daf79565cec1"), Id = 40L },
                        new { SerialNumber = new Guid("2f46cea3-c396-44b4-8632-3aceb6f89786"), Id = 41L },
                        new { SerialNumber = new Guid("acce14ad-a5e9-4e5d-94a3-c94a41965912"), Id = 42L },
                        new { SerialNumber = new Guid("17d62347-b65a-44f5-a53d-c2b2a88bfa16"), Id = 43L },
                        new { SerialNumber = new Guid("084196eb-fea8-4a30-bce4-5097dabf2aff"), Id = 44L },
                        new { SerialNumber = new Guid("686ddf46-8e30-444b-b031-424242155be2"), Id = 45L },
                        new { SerialNumber = new Guid("b688b7dc-4107-42c6-932a-862abb6ea4b5"), Id = 46L },
                        new { SerialNumber = new Guid("54828066-8151-402a-82b1-543cdef64e14"), Id = 47L },
                        new { SerialNumber = new Guid("f3fd8519-357c-47b1-946b-6c729497ed08"), Id = 48L },
                        new { SerialNumber = new Guid("c3f8f19c-379d-4f29-a8d1-62a5a6756d80"), Id = 49L },
                        new { SerialNumber = new Guid("f2020ee7-2d63-4cd0-b63b-aedb3ce80ec1"), Id = 50L },
                        new { SerialNumber = new Guid("ea9acbd3-6e2f-475f-845f-2b77b52a50d8"), Id = 51L },
                        new { SerialNumber = new Guid("319218b1-8ee4-4c31-a2f1-6139bc13d6e1"), Id = 52L },
                        new { SerialNumber = new Guid("b98cefdc-54d6-43cb-946f-1ac2329320b9"), Id = 53L },
                        new { SerialNumber = new Guid("379c2e15-109e-4274-9313-bbe299049f12"), Id = 54L },
                        new { SerialNumber = new Guid("edc1707f-d64c-4294-85fb-42653561a7e5"), Id = 55L },
                        new { SerialNumber = new Guid("47fa2b90-4eac-416e-bbab-85c6de77b8ca"), Id = 56L },
                        new { SerialNumber = new Guid("9159e881-2040-4ed4-b2de-837ebbf0ea0b"), Id = 57L },
                        new { SerialNumber = new Guid("5412607d-b0ef-43bf-9e64-dc47d7397df0"), Id = 58L },
                        new { SerialNumber = new Guid("5f4acf60-125d-4c64-b6e1-56b753260d9b"), Id = 59L },
                        new { SerialNumber = new Guid("ac311b8d-56c9-43fb-8fb4-19200020a60e"), Id = 60L },
                        new { SerialNumber = new Guid("c5865157-4c3d-4456-81d9-a1b665c8bcc0"), Id = 61L },
                        new { SerialNumber = new Guid("901f9f5c-81b3-4c39-9855-6d6bc763baf1"), Id = 62L },
                        new { SerialNumber = new Guid("fee5058d-85d5-4b12-b284-b7afbefcb30d"), Id = 63L },
                        new { SerialNumber = new Guid("30c7d0f9-0f0b-42c3-9a48-5d2daf668130"), Id = 64L },
                        new { SerialNumber = new Guid("432cbfb7-26d5-4ee2-b58d-263307b5e121"), Id = 65L },
                        new { SerialNumber = new Guid("b5489dbb-3e32-4bc0-8038-8569569048d2"), Id = 66L },
                        new { SerialNumber = new Guid("cb9e7a44-9c3a-44b0-9f17-062c1876e944"), Id = 67L },
                        new { SerialNumber = new Guid("b4a4ea42-6e58-4f21-9c3f-330a4f9749ac"), Id = 68L },
                        new { SerialNumber = new Guid("d4929c3d-8992-4a43-917d-74c9c678cf06"), Id = 69L },
                        new { SerialNumber = new Guid("74dcbd72-3747-42e5-b6f3-f97757d06252"), Id = 70L },
                        new { SerialNumber = new Guid("050ecb15-2f15-4d71-9490-68e7ebad44f9"), Id = 71L },
                        new { SerialNumber = new Guid("188a118b-1c6a-48a5-a8b8-913e8a0bb795"), Id = 72L },
                        new { SerialNumber = new Guid("c4aa8026-c6be-4ab9-b043-69942f446441"), Id = 73L },
                        new { SerialNumber = new Guid("7b1a5f5b-d890-4ba0-b1d4-a993e9bc6655"), Id = 74L },
                        new { SerialNumber = new Guid("3702b7ac-92a6-4dc1-a1fa-96ee0ce50a78"), Id = 75L },
                        new { SerialNumber = new Guid("9f2c4024-2bc1-4176-ae21-38b4bd2ab8fa"), Id = 76L },
                        new { SerialNumber = new Guid("f2996d4a-e282-4683-a842-4d3e51f29980"), Id = 77L },
                        new { SerialNumber = new Guid("796a3e95-0cc5-43de-aced-c405771cd5b1"), Id = 78L },
                        new { SerialNumber = new Guid("a20fd567-b6f8-4db6-b271-6e50f25ebb21"), Id = 79L },
                        new { SerialNumber = new Guid("529613e2-2e7a-4021-94f7-8ffb02d081ad"), Id = 80L },
                        new { SerialNumber = new Guid("afec8b08-5da0-4e32-9d17-9844d6cd0166"), Id = 81L },
                        new { SerialNumber = new Guid("69608f19-1019-49a6-bf17-692897cee67c"), Id = 82L },
                        new { SerialNumber = new Guid("91c394d3-94a6-4841-86e8-feb97f712941"), Id = 83L },
                        new { SerialNumber = new Guid("9acaeb2e-fc62-4c16-a2f1-d7d83cd1cdc1"), Id = 84L },
                        new { SerialNumber = new Guid("e9a78283-2113-4e9c-9a6e-5f478a00b591"), Id = 85L },
                        new { SerialNumber = new Guid("242cde26-a4bf-408b-a7ba-7376f6dac08c"), Id = 86L },
                        new { SerialNumber = new Guid("9bc0cc63-0124-4ee9-b05f-ebcc71e16f23"), Id = 87L },
                        new { SerialNumber = new Guid("e4bf993d-e50a-4b2c-9611-9f393754421d"), Id = 88L },
                        new { SerialNumber = new Guid("8f766e98-0b7b-4790-9f76-c2ecfc8cc3dc"), Id = 89L },
                        new { SerialNumber = new Guid("4648730b-8ce2-4158-890b-de46b1a6aac5"), Id = 90L },
                        new { SerialNumber = new Guid("64dc073d-e451-4209-b23a-44a7f721aa03"), Id = 91L },
                        new { SerialNumber = new Guid("b6173e63-9e88-449c-9805-7a1b7550ebd3"), Id = 92L },
                        new { SerialNumber = new Guid("1cbaef95-5669-4807-9964-665eaabe6062"), Id = 93L },
                        new { SerialNumber = new Guid("06e6fcb3-6138-4453-be36-349cd46b976f"), Id = 94L },
                        new { SerialNumber = new Guid("d490d544-a9bd-49b9-8c2c-073feacb4c8f"), Id = 95L },
                        new { SerialNumber = new Guid("314cae85-d547-4ca6-a5da-93d841d8d861"), Id = 96L },
                        new { SerialNumber = new Guid("c58ef6c2-29f6-445a-bd89-9514e283d827"), Id = 97L },
                        new { SerialNumber = new Guid("2e2d37cb-f97e-4328-904a-5accb5b766f0"), Id = 98L },
                        new { SerialNumber = new Guid("cdbf0abf-ea8b-492b-b545-4373fd39d04a"), Id = 99L }
                    );
                });

            modelBuilder.Entity("Entities.Model.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11);

                    b.Property<string>("SerialNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
