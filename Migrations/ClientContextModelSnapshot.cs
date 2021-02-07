
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetReserve.Data;

namespace VetReserve.Migrations
{
    [DbContext(typeof(ClientContext))]
    partial class ClientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("VetReserve.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientModel");
                });

            modelBuilder.Entity("VetReserve.Models.PatientCardModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.Property<bool>("IsIll")
                        .HasColumnType("bit");

                    b.Property<string>("Medicines")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PatientCardModel");
                });

            modelBuilder.Entity("VetReserve.Models.VetModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VetSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VetModel");
                });

            modelBuilder.Entity("VetReserve.Models.VisitModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VetSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("VisitModel");
                });
#pragma warning restore 612, 618
        }
    }
}
