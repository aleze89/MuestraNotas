﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Notes.Models;

namespace Notes.Migrations
{
    [DbContext(typeof(NotasContext))]
    [Migration("20201105042923_CreacionInicial")]
    partial class CreacionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Notes.Models.Nota", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cuerpo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DuenioMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("DuenioMail");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Notes.Models.Usuario", b =>
                {
                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Mail");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Notes.Models.Nota", b =>
                {
                    b.HasOne("Notes.Models.Usuario", "Duenio")
                        .WithMany("Notas")
                        .HasForeignKey("DuenioMail");
                });
#pragma warning restore 612, 618
        }
    }
}
