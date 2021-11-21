﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopChoiceHardware.Products.AccessData;

namespace TopChoiceHardware.Products.AccessData.Migrations
{
    [DbContext(typeof(ProductsContext))]
    partial class ProductsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Procesadores",
                            Description = "Unidad de procesamiento central del PC"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Motherboards",
                            Description = "Circuito impreso donde se conectan todos los componentes de una PC"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Memorias RAM",
                            Description = "Memoria de trabajo para un PC"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Almacenamiento",
                            Description = "Medios de almacenamiento de informacion para un pc"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Placas de video",
                            Description = "Tarjeta de expansion del motherboard para procesamiento de graficos"
                        });
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            ProductId = 1,
                            Url = "https://imgur.com/O1EfiHW"
                        });
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("OnSale")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "AMD",
                            CategoryId = 1,
                            Description = "Todos los procesadores AMD Ryzen serie 5000 cuentan con un conjunto completo de tecnologías diseñadas para elevar la potencia de procesamiento de tu PC, incluidas Precision Boost 25, Precision Boost Overdrive, PCIe 4.0 (en procesadores seleccionados) y Resizable BAR.",
                            OnSale = false,
                            ProductName = "Procesador Amd Ryzen 7 5700G 4.6 Ghz - AM4",
                            SupplierId = 1,
                            UnitPrice = 65999m,
                            UnitsInStock = 10,
                            Url = "https://www.amd.com/es/products/apu/amd-ryzen-7-5700g"
                        });
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            AddressId = 1,
                            CompanyName = "New Bytes",
                            Email = "INFO@NB.COM.AR",
                            Phone = "(11) 4011-8809"
                        },
                        new
                        {
                            SupplierId = 2,
                            AddressId = 1,
                            CompanyName = "MEGACOM",
                            Email = "ventas@megacom.com.ar",
                            Phone = "(0223) 492-4414"
                        },
                        new
                        {
                            SupplierId = 3,
                            AddressId = 1,
                            CompanyName = "PcRetail",
                            Email = "info@pc-retail.com.ar",
                            Phone = "11 49092100"
                        });
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Image", b =>
                {
                    b.HasOne("TopChoiceHardware.Products.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Products__Image")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Product", b =>
                {
                    b.HasOne("TopChoiceHardware.Products.Domain.Entities.Category", "Category")
                        .WithMany("Productos")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Productos__Descr__2C3393D0")
                        .IsRequired();

                    b.HasOne("TopChoiceHardware.Products.Domain.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK__Productos__Suppl__2D27B809")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Category", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Product", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
