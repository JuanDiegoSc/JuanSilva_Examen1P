﻿// <auto-generated />
using System;
using JuanSilva_Examen1P.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuanSilva_Examen1P.Migrations
{
    [DbContext(typeof(JuanSilva_Examen1PContext))]
    partial class JuanSilva_Examen1PContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JuanSilva_Examen1P.Models.JS_producto", b =>
                {
                    b.Property<int>("JsProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JsProductoID"));

                    b.Property<bool>("JsDisponible")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JsFechaAgregado")
                        .HasColumnType("datetime2");

                    b.Property<string>("JsNombreProducto")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("JsnumeroSerie")
                        .HasColumnType("int");

                    b.Property<decimal>("Jsprecio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("JsProductoID");

                    b.ToTable("JS_producto");
                });
#pragma warning restore 612, 618
        }
    }
}
