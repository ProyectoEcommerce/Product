﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopChoiceHardware.Products.AccessData;

namespace TopChoiceHardware.Products.AccessData.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20211130165842_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            ProductId = 1,
                            Url = "https://i.imgur.com/7hIMXzD.png"
                        },
                        new
                        {
                            ImageId = 2,
                            ProductId = 1,
                            Url = "https://i.imgur.com/RYEET6W.png"
                        },
                        new
                        {
                            ImageId = 3,
                            ProductId = 1,
                            Url = "https://i.imgur.com/ZlfRxRX.png"
                        },
                        new
                        {
                            ImageId = 4,
                            ProductId = 1,
                            Url = "https://i.imgur.com/JHTHCvz.png"
                        },
                        new
                        {
                            ImageId = 5,
                            ProductId = 2,
                            Url = "https://i.imgur.com/pPCGtwD.png"
                        },
                        new
                        {
                            ImageId = 6,
                            ProductId = 2,
                            Url = "https://i.imgur.com/PEWRhwg.png"
                        },
                        new
                        {
                            ImageId = 7,
                            ProductId = 2,
                            Url = "https://i.imgur.com/PCh7GxO.png"
                        },
                        new
                        {
                            ImageId = 8,
                            ProductId = 2,
                            Url = "https://i.imgur.com/Z2fJ6JD.png"
                        },
                        new
                        {
                            ImageId = 9,
                            ProductId = 3,
                            Url = "https://i.imgur.com/UTodEaB.png"
                        },
                        new
                        {
                            ImageId = 10,
                            ProductId = 3,
                            Url = "https://i.imgur.com/RPnZ02l.png"
                        },
                        new
                        {
                            ImageId = 11,
                            ProductId = 3,
                            Url = "https://i.imgur.com/Rtpw8hA.png"
                        },
                        new
                        {
                            ImageId = 12,
                            ProductId = 3,
                            Url = "https://i.imgur.com/yWB9yD9.png"
                        },
                        new
                        {
                            ImageId = 13,
                            ProductId = 4,
                            Url = "https://i.imgur.com/Wy2kAhG.png"
                        },
                        new
                        {
                            ImageId = 14,
                            ProductId = 4,
                            Url = "https://i.imgur.com/niVhReS.png"
                        },
                        new
                        {
                            ImageId = 15,
                            ProductId = 4,
                            Url = "https://i.imgur.com/HHrAIAA.png"
                        },
                        new
                        {
                            ImageId = 16,
                            ProductId = 4,
                            Url = "https://i.imgur.com/tAeIvqD.png"
                        },
                        new
                        {
                            ImageId = 17,
                            ProductId = 5,
                            Url = "https://i.imgur.com/cDrubFC.png"
                        },
                        new
                        {
                            ImageId = 18,
                            ProductId = 5,
                            Url = "https://i.imgur.com/2uBQPrT.png"
                        },
                        new
                        {
                            ImageId = 19,
                            ProductId = 5,
                            Url = "https://i.imgur.com/yZVycHI.png"
                        },
                        new
                        {
                            ImageId = 20,
                            ProductId = 5,
                            Url = "https://i.imgur.com/eRw8TDf.png"
                        },
                        new
                        {
                            ImageId = 21,
                            ProductId = 6,
                            Url = "https://i.imgur.com/DBbZ0Mb.png"
                        },
                        new
                        {
                            ImageId = 22,
                            ProductId = 6,
                            Url = "https://i.imgur.com/pzX4b0s.png"
                        },
                        new
                        {
                            ImageId = 23,
                            ProductId = 6,
                            Url = "https://i.imgur.com/qz5UeSI.png"
                        },
                        new
                        {
                            ImageId = 24,
                            ProductId = 6,
                            Url = "https://i.imgur.com/ZRHXXfj.png"
                        },
                        new
                        {
                            ImageId = 25,
                            ProductId = 7,
                            Url = "https://i.imgur.com/QiD4m80.png"
                        },
                        new
                        {
                            ImageId = 26,
                            ProductId = 7,
                            Url = "https://i.imgur.com/tEVgQg6.png"
                        },
                        new
                        {
                            ImageId = 27,
                            ProductId = 7,
                            Url = "https://i.imgur.com/e3A5Y39.png"
                        },
                        new
                        {
                            ImageId = 28,
                            ProductId = 7,
                            Url = "https://i.imgur.com/bSv1zdZ.png"
                        },
                        new
                        {
                            ImageId = 29,
                            ProductId = 8,
                            Url = "https://i.imgur.com/lanfcBR.png"
                        },
                        new
                        {
                            ImageId = 30,
                            ProductId = 8,
                            Url = "https://i.imgur.com/Gh8QFgB.png"
                        },
                        new
                        {
                            ImageId = 31,
                            ProductId = 8,
                            Url = "https://i.imgur.com/4FFWiuf.png"
                        },
                        new
                        {
                            ImageId = 32,
                            ProductId = 8,
                            Url = "https://i.imgur.com/ewuljgX.png"
                        },
                        new
                        {
                            ImageId = 33,
                            ProductId = 9,
                            Url = "https://i.imgur.com/OsWivOs.png"
                        },
                        new
                        {
                            ImageId = 34,
                            ProductId = 9,
                            Url = "https://i.imgur.com/39y2gH3.png"
                        },
                        new
                        {
                            ImageId = 35,
                            ProductId = 9,
                            Url = "https://i.imgur.com/ovhu6lx.png"
                        },
                        new
                        {
                            ImageId = 36,
                            ProductId = 9,
                            Url = "https://i.imgur.com/uRVrFoJ.png"
                        },
                        new
                        {
                            ImageId = 37,
                            ProductId = 10,
                            Url = "https://i.imgur.com/l3vgS6c.png"
                        },
                        new
                        {
                            ImageId = 38,
                            ProductId = 10,
                            Url = "https://i.imgur.com/2YGPcdD.png"
                        },
                        new
                        {
                            ImageId = 39,
                            ProductId = 10,
                            Url = "https://i.imgur.com/YZJDPPS.png"
                        },
                        new
                        {
                            ImageId = 40,
                            ProductId = 10,
                            Url = "https://i.imgur.com/ohrAcNY.png"
                        },
                        new
                        {
                            ImageId = 41,
                            ProductId = 11,
                            Url = "https://i.imgur.com/C0RjbtQ.png"
                        },
                        new
                        {
                            ImageId = 42,
                            ProductId = 11,
                            Url = "https://i.imgur.com/X14tRUk.png"
                        },
                        new
                        {
                            ImageId = 43,
                            ProductId = 11,
                            Url = "https://i.imgur.com/lPNNJkG.png"
                        },
                        new
                        {
                            ImageId = 44,
                            ProductId = 11,
                            Url = "https://i.imgur.com/nw7jeAI.png"
                        },
                        new
                        {
                            ImageId = 45,
                            ProductId = 12,
                            Url = "https://i.imgur.com/ItE432j.png"
                        },
                        new
                        {
                            ImageId = 46,
                            ProductId = 12,
                            Url = "https://i.imgur.com/zNf7Ek5.png"
                        },
                        new
                        {
                            ImageId = 47,
                            ProductId = 12,
                            Url = "https://i.imgur.com/WnDpaXG.png"
                        },
                        new
                        {
                            ImageId = 48,
                            ProductId = 12,
                            Url = "https://i.imgur.com/rcK6VEW.png"
                        },
                        new
                        {
                            ImageId = 49,
                            ProductId = 13,
                            Url = "https://i.imgur.com/RS4cwAD.png"
                        },
                        new
                        {
                            ImageId = 50,
                            ProductId = 13,
                            Url = "https://i.imgur.com/8qjZ41t.png"
                        },
                        new
                        {
                            ImageId = 51,
                            ProductId = 13,
                            Url = "https://i.imgur.com/kG7R1EJ.png"
                        },
                        new
                        {
                            ImageId = 52,
                            ProductId = 13,
                            Url = "https://i.imgur.com/rbUbbcd.png"
                        },
                        new
                        {
                            ImageId = 53,
                            ProductId = 14,
                            Url = "https://i.imgur.com/mcP0luK.png"
                        },
                        new
                        {
                            ImageId = 54,
                            ProductId = 14,
                            Url = "https://i.imgur.com/Tjc0xVB.png"
                        },
                        new
                        {
                            ImageId = 55,
                            ProductId = 14,
                            Url = "https://i.imgur.com/YsH84Bu.png"
                        },
                        new
                        {
                            ImageId = 56,
                            ProductId = 14,
                            Url = "https://i.imgur.com/Pd4jqhi.png"
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

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "AMD",
                            CategoryId = 1,
                            Description = "Procesador AMD Ryzen 5ta generación equipado con gráficos integrados. Incluye 8 núcleos de CPU, una velocidad de reloj base de 3,8 GHz y 8 núcleos de GPU.",
                            Image = "https://i.imgur.com/O1EfiHW.png",
                            OnSale = false,
                            ProductName = "Procesador Amd Ryzen 7 5700G 4.6 Ghz - AM4",
                            SupplierId = 0,
                            UnitPrice = 65999m,
                            UnitsInStock = 10,
                            Url = "https://www.amd.com/es/products/apu/amd-ryzen-7-5700g"
                        },
                        new
                        {
                            ProductId = 2,
                            Brand = "INTEL",
                            CategoryId = 1,
                            Description = "Procesador Intel® Core™ de 10ma Generación. Sin gráficos integrados, Incluye 6 núcleos 4.1GHz (hasta 4.8 Ghz), Socket 1200, Caché 12 MB",
                            Image = "https://i.imgur.com/1cDE1v4.png?1",
                            OnSale = false,
                            ProductName = "Procesador  Intel Core i5 10600KF 4.8 Ghz Comet Lake 1200",
                            SupplierId = 0,
                            UnitPrice = 30499m,
                            UnitsInStock = 5,
                            Url = "https://ark.intel.com/content/www/es/es/ark/products/199315/intel-core-i5-10600kf-processor-12m-cache-up-to-4-80-ghz.html"
                        },
                        new
                        {
                            ProductId = 3,
                            Brand = "INTEL",
                            CategoryId = 1,
                            Description = "Procesador Intel Core i7-9700F de Novena Generación. Sin gráficos integrados, incluye 8 núcleos 3.0 GHz (hasta 4.7 GHz), Socket 1151, Caché 12 MB",
                            Image = "https://i.imgur.com/pPlPUe6.png",
                            OnSale = false,
                            ProductName = "Procesador  Intel Core i7 9700F 4.7 Ghz Coffee Lake 1151",
                            SupplierId = 0,
                            UnitPrice = 40499m,
                            UnitsInStock = 5,
                            Url = "https://ark.intel.com/content/www/es/es/ark/products/193738/intel-core-i7-9700f-processor-12m-cache-up-to-4-70-ghz.html"
                        },
                        new
                        {
                            ProductId = 4,
                            Brand = "AMD",
                            CategoryId = 1,
                            Description = "Procesador AMD Ryzen 5ta generación equipado con gráficos integrados. Incluye seis núcleos de CPU, una velocidad de reloj base de 3,9 GHz y siete núcleos de GPU",
                            Image = "https://i.imgur.com/BI7uFjv.png",
                            OnSale = false,
                            ProductName = "Procesador  Amd Ryzen 5 5600G 4.4 Ghz - AM4",
                            SupplierId = 0,
                            UnitPrice = 54999m,
                            UnitsInStock = 10,
                            Url = "https://www.amd.com/es/products/apu/amd-ryzen-5-5600g"
                        },
                        new
                        {
                            ProductId = 5,
                            Brand = "INTEL",
                            CategoryId = 1,
                            Description = "Procesador Intel® Core™ de 10ma Generación equipado con los gráficos Intel. Incluye 4 núcleos y 8 hilos de procesamiento, velocidad base de i3-10100 de 3.6 GHZ y turbo hasta 4.3 GHZ, Socket 1200, 6MB Caché.",
                            Image = "https://i.imgur.com/0RdBm8b.png",
                            OnSale = false,
                            ProductName = "Procesador Intel Core i3 10100 4.3 Ghz Comet Lake 1200",
                            SupplierId = 0,
                            UnitPrice = 27999m,
                            UnitsInStock = 5,
                            Url = "https://www.intel.la/content/www/xl/es/products/sku/199283/intel-core-i310100-processor-6m-cache-up-to-4-30-ghz/specifications.html"
                        },
                        new
                        {
                            ProductId = 6,
                            Brand = "AMD",
                            CategoryId = 1,
                            Description = "Procesador AMD A series de 7ma generación equipado con gráficos integrados. Incluye 2 núcleos 3.5 Ghz, Socket AM4, Caché 1 MB",
                            Image = "https://i.imgur.com/etwcYDJ.png",
                            OnSale = false,
                            ProductName = "Procesador Amd Apu A6 A6-9500 3.5 Ghz - AM4",
                            SupplierId = 0,
                            UnitPrice = 6499m,
                            UnitsInStock = 10,
                            Url = "https://www.amd.com/es/products/apu/7th-gen-a6-9500-apu"
                        },
                        new
                        {
                            ProductId = 7,
                            Brand = "Asrock",
                            CategoryId = 2,
                            Description = "Socket AMD AM4 Ryzen™ 2000, 3000, 4000 G-Series, 5000 y 5000 G-Series Desktop Processors 2 RAM DIMMs DDR4 3200 + (OC)",
                            Image = "https://i.imgur.com/U7fAUnj.png",
                            OnSale = false,
                            ProductName = "Motherboard AM4 - Asrock B450M HDV 4.0",
                            SupplierId = 0,
                            UnitPrice = 8999m,
                            UnitsInStock = 10,
                            Url = "https://www.asrock.com/mb/AMD/B450M-HDV%20R4.0/index.la.asp#Specification"
                        },
                        new
                        {
                            ProductId = 8,
                            Brand = "AORUS",
                            CategoryId = 2,
                            Description = "Socket AMD AM4 Ryzen™ 5000 Series / Ryzen™ 5000 G - Series / Ryzen™ 4000 G - Series and Ryzen™ 3000 Series Processors Dual Channel 4 DIMMs DDR4 ",
                            Image = "https://i.imgur.com/yjl0knB.png",
                            OnSale = false,
                            ProductName = "Motherboard AM4 - Gigabyte GA-B550 AORUS ELITE AX V2",
                            SupplierId = 0,
                            UnitPrice = 30999m,
                            UnitsInStock = 10,
                            Url = "https://www.gigabyte.com/ar/Motherboard/B550-AORUS-ELITE-AX-V2-rev-10#kf"
                        },
                        new
                        {
                            ProductId = 9,
                            Brand = "Asus TUF",
                            CategoryId = 2,
                            Description = "Socket AMD AM4: Listo para los procesadores AMD RyzenTM de 2da y 3ra generación. 4 x DIMM DDR4, Max. 128GB ",
                            Image = "https://i.imgur.com/4nmN1jo.png",
                            OnSale = false,
                            ProductName = "Motherboard AM4 - Asus Tuf X570-PLUS WIFI",
                            SupplierId = 0,
                            UnitPrice = 34999m,
                            UnitsInStock = 10,
                            Url = "https://www.asus.com/latin/Motherboards-Components/Motherboards/TUF-Gaming/TUF-GAMING-X570-PLUS-WI-FI/"
                        },
                        new
                        {
                            ProductId = 10,
                            Brand = "MSI",
                            CategoryId = 2,
                            Description = "Socket AMD AM4 , Soporta procesadores AMD® Ryzen™ 1ra y 2da Generación, 2 DIMMs DDR4",
                            Image = "https://i.imgur.com/SoVh1gC.png",
                            OnSale = false,
                            ProductName = "Motherboard AM4 - Msi A320M PRO VH",
                            SupplierId = 0,
                            UnitPrice = 7499m,
                            UnitsInStock = 10,
                            Url = "https://www.msi.com/Motherboard/A320M-PRO-VH"
                        },
                        new
                        {
                            ProductId = 11,
                            Brand = "Kingston",
                            CategoryId = 3,
                            Description = "Capacidad de 4 GB, velocidad de 3200 MHz, tecnología  DDR4.",
                            Image = "https://i.imgur.com/5Qx2cpJ.png",
                            OnSale = false,
                            ProductName = "Memoria Ram DDR4 - 4Gb 3200 Mhz Beast Kingston Fury",
                            SupplierId = 0,
                            UnitPrice = 4499m,
                            UnitsInStock = 10,
                            Url = "https://www.kingston.com/es/memory/gaming/kingston-fury-beast-ddr4-memory"
                        },
                        new
                        {
                            ProductId = 12,
                            Brand = "Hikvision",
                            CategoryId = 3,
                            Description = "Capacidad de 16 GB, velocidad de 2666 MHz, tecnología  DDR4.",
                            Image = "https://i.imgur.com/wdk29Tl.png",
                            OnSale = false,
                            ProductName = "Memoria Ram DDR4 - 16Gb 2666 Mhz Value Hikvision",
                            SupplierId = 0,
                            UnitPrice = 12500m,
                            UnitsInStock = 10,
                            Url = "https://www.hikvision.com/es-la/"
                        },
                        new
                        {
                            ProductId = 13,
                            Brand = "Seagate",
                            CategoryId = 4,
                            Description = "Modelo: ST1000DM010 Interfaz: SATA de 6 Gb/s Capacidad: 1 TB Buffer: 64 MB Velocidad: 7200 RPM. De uso doméstico",
                            Image = "https://i.imgur.com/bahey2J.png",
                            OnSale = false,
                            ProductName = "Seagate Barracuda 1TB",
                            SupplierId = 0,
                            UnitPrice = 5500m,
                            UnitsInStock = 10,
                            Url = "https://www.seagate.com/la/es/support/internal-hard-drives/desktop-hard-drives/barracuda-3-5/"
                        },
                        new
                        {
                            ProductId = 14,
                            Brand = "Seagate",
                            CategoryId = 4,
                            Description = "Modelo: ST1000DM010 Interfaz: SATA de 6 Gb/s Capacidad: 1 TB Buffer: 64 MB Velocidad: 7200 RPM. De uso doméstico",
                            Image = "https://i.imgur.com/VcSspi5.png",
                            OnSale = false,
                            ProductName = "SSD Gigabyte 240GB",
                            SupplierId = 0,
                            UnitPrice = 4500m,
                            UnitsInStock = 10,
                            Url = "https://www.gigabyte.com/ar/Solid-State-Drive/GIGABYTE-SSD-256GB#kf"
                        });
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Image", b =>
                {
                    b.HasOne("TopChoiceHardware.Products.Domain.Entities.Product", "Product")
                        .WithMany("Carousel")
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

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Category", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("TopChoiceHardware.Products.Domain.Entities.Product", b =>
                {
                    b.Navigation("Carousel");
                });
#pragma warning restore 612, 618
        }
    }
}