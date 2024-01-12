﻿// <auto-generated />
using DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBContext.Migrations
{
    [DbContext(typeof(FaceContext))]
    partial class FaceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DBContext.Classi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Sezione")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Classi");
                });

            modelBuilder.Entity("DBContext.Utenti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassiId")
                        .HasColumnType("int");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClassiId");

                    b.ToTable("Utenti");
                });

            modelBuilder.Entity("DBContext.Utenti", b =>
                {
                    b.HasOne("DBContext.Classi", "Classe")
                        .WithMany()
                        .HasForeignKey("ClassiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });
#pragma warning restore 612, 618
        }
    }
}
