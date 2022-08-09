﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2ND_Backend_Exam.DATA.Context;

#nullable disable

namespace _2ND_Backend_Exam.DATA.Migrations
{
    [DbContext(typeof(EduContext))]
    partial class EduContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.EduMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MaterialTypeId");

                    b.ToTable("EduMaterials");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.MaterialType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialTypes");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EduMaterialId")
                        .HasColumnType("int");

                    b.Property<string>("NameOfAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EduMaterialId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.EduMaterial", b =>
                {
                    b.HasOne("_2ND_Backend_Exam.DATA.Entities.Author", "Author")
                        .WithMany("Materials")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2ND_Backend_Exam.DATA.Entities.MaterialType", "MaterialType")
                        .WithMany("EduMaterials")
                        .HasForeignKey("MaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("MaterialType");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.Review", b =>
                {
                    b.HasOne("_2ND_Backend_Exam.DATA.Entities.EduMaterial", "EduMaterial")
                        .WithMany("Reviews")
                        .HasForeignKey("EduMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EduMaterial");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.Author", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.EduMaterial", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("_2ND_Backend_Exam.DATA.Entities.MaterialType", b =>
                {
                    b.Navigation("EduMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
