﻿// <auto-generated />
using System;
using HotelApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelApp.Migrations
{
    [DbContext(typeof(HotelAppContext))]
    [Migration("20221024042735_Initial13")]
    partial class Initial13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelApp.Database.Feature", b =>
                {
                    b.Property<int>("FeatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureID");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("HotelApp.Database.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Available")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int?>("RoomTypeID")
                        .HasColumnType("int");

                    b.HasKey("RoomID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("HotelApp.Database.RoomImages", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RoomID")
                        .HasColumnType("int");

                    b.Property<string>("RoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomImages");
                });

            modelBuilder.Entity("HotelApp.Database.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeatureID")
                        .HasColumnType("int");

                    b.Property<int?>("MaxPersonAccept")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeID");

                    b.HasIndex("FeatureID");

                    b.ToTable("RoomType");
                });

            modelBuilder.Entity("HotelApp.Database.Room", b =>
                {
                    b.HasOne("HotelApp.Database.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeID");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("HotelApp.Database.RoomImages", b =>
                {
                    b.HasOne("HotelApp.Database.Room", "Room")
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomID");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelApp.Database.RoomType", b =>
                {
                    b.HasOne("HotelApp.Database.Feature", "Feature")
                        .WithMany("RoomTypes")
                        .HasForeignKey("FeatureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("HotelApp.Database.Feature", b =>
                {
                    b.Navigation("RoomTypes");
                });

            modelBuilder.Entity("HotelApp.Database.Room", b =>
                {
                    b.Navigation("RoomImages");
                });
#pragma warning restore 612, 618
        }
    }
}