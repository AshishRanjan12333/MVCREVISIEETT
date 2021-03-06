// <auto-generated />
using System;
using MVCREVISIEETT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCREVISIEETT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220331195616_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCREVISIEETT.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("locationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("locationId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("MVCREVISIEETT.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("MVCREVISIEETT.Models.Customer", b =>
                {
                    b.HasOne("MVCREVISIEETT.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationId");
                });
#pragma warning restore 612, 618
        }
    }
}
