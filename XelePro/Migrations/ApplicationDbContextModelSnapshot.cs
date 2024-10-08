﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XelePro.Context;

#nullable disable

namespace XelePro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XelePro.Entity.ModelsEntity.MyFile", b =>
                {
                    b.Property<int>("MyFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MyFileId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("MyFolderId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("MyFileId");

                    b.HasIndex("MyFolderId");

                    b.ToTable("MyFiles");

                    b.HasData(
                        new
                        {
                            MyFileId = 1,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4516),
                            FileExtension = "txt",
                            FileName = "FileName1",
                            FilePath = "C:Users-Xele-Desktop-Folder1-FileName1",
                            Isdeleted = false,
                            MyFolderId = 1
                        },
                        new
                        {
                            MyFileId = 2,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4519),
                            FileExtension = "PDF",
                            FileName = "FileName2",
                            FilePath = "C:Users-Xele-Desktop-Folder2-FileName2",
                            Isdeleted = false,
                            MyFolderId = 2
                        },
                        new
                        {
                            MyFileId = 3,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4520),
                            FileExtension = "DOCX",
                            FileName = "FileName3",
                            FilePath = "C:Users-Xele-Desktop-Folder3-FileName3",
                            Isdeleted = false,
                            MyFolderId = 3
                        },
                        new
                        {
                            MyFileId = 4,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4522),
                            FileExtension = "JPG",
                            FileName = "FileName4",
                            FilePath = "C:Users-Xele-Desktop-Folder4-FileName4",
                            Isdeleted = false,
                            MyFolderId = 4
                        },
                        new
                        {
                            MyFileId = 5,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4524),
                            FileExtension = "XLSX",
                            FileName = "FileName5",
                            FilePath = "C:Users-Xele-Desktop-Folder5-FileName5",
                            Isdeleted = false,
                            MyFolderId = 5
                        },
                        new
                        {
                            MyFileId = 6,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4525),
                            FileExtension = "PNG",
                            FileName = "FileName6",
                            FilePath = "C:Users-Xele-Desktop-Folder6-FileName6",
                            Isdeleted = false,
                            MyFolderId = 6
                        });
                });

            modelBuilder.Entity("XelePro.Entity.ModelsEntity.MyFolder", b =>
                {
                    b.Property<int>("MyFolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MyFolderId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentFolderId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MyFolderId");

                    b.HasIndex("ParentFolderId");

                    b.ToTable("MyFolders");

                    b.HasData(
                        new
                        {
                            MyFolderId = 1,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4389),
                            FolderName = "Folder1",
                            Isdeleted = false,
                            ParentFolderId = 1,
                            path = "C:Users-Xele-Desktop-Folder1"
                        },
                        new
                        {
                            MyFolderId = 2,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4411),
                            FolderName = "Folder2",
                            Isdeleted = false,
                            ParentFolderId = 2,
                            path = "C:Users-Xele-Desktop-Folder2"
                        },
                        new
                        {
                            MyFolderId = 3,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4413),
                            FolderName = "Folder3",
                            Isdeleted = false,
                            ParentFolderId = 2,
                            path = "C:Users-Xele-Desktop-Folder3"
                        },
                        new
                        {
                            MyFolderId = 4,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4414),
                            FolderName = "Folder4",
                            Isdeleted = false,
                            ParentFolderId = 3,
                            path = "C:Users-Xele-Desktop-Folder4"
                        },
                        new
                        {
                            MyFolderId = 5,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4416),
                            FolderName = "Folder5",
                            Isdeleted = false,
                            ParentFolderId = 4,
                            path = "C:Users-Xele-Desktop-Folder5"
                        },
                        new
                        {
                            MyFolderId = 6,
                            CreatedBy = "USER ADMIN",
                            CreatedOn = new DateTime(2024, 8, 28, 17, 25, 2, 761, DateTimeKind.Local).AddTicks(4418),
                            FolderName = "Folder6",
                            Isdeleted = false,
                            ParentFolderId = 4,
                            path = "C:Users-Xele-Desktop-Folder6"
                        });
                });

            modelBuilder.Entity("XelePro.Entity.ModelsEntity.MyFile", b =>
                {
                    b.HasOne("XelePro.Entity.ModelsEntity.MyFolder", "MyFolder")
                        .WithMany("Files")
                        .HasForeignKey("MyFolderId");

                    b.Navigation("MyFolder");
                });

            modelBuilder.Entity("XelePro.Entity.ModelsEntity.MyFolder", b =>
                {
                    b.HasOne("XelePro.Entity.ModelsEntity.MyFolder", "ParentFolder")
                        .WithMany("SubFolders")
                        .HasForeignKey("ParentFolderId");

                    b.Navigation("ParentFolder");
                });

            modelBuilder.Entity("XelePro.Entity.ModelsEntity.MyFolder", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("SubFolders");
                });
#pragma warning restore 612, 618
        }
    }
}
