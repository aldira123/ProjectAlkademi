﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.Datas;

#nullable disable

namespace eCommerce.Datas.Migrations
{
    [DbContext(typeof(eCommerceDbContext))]
    partial class eCommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("eCommerce.Datas.Entities.Admin", b =>
                {
                    b.Property<int>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_admin");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nama");

                    b.Property<string>("NoHp")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("no_hp");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("IdAdmin")
                        .HasName("PRIMARY");

                    b.ToTable("admin", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Alamat", b =>
                {
                    b.Property<int>("IdAlamat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_alamat");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("detail")
                        .HasDefaultValueSql("''");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_customer");

                    b.Property<string>("Kecamatan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("kecamatan")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Kelurahan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("kelurahan")
                        .HasDefaultValueSql("''");

                    b.Property<string>("KodePos")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("kode_pos")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Rt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("rt")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Rw")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("rw")
                        .HasDefaultValueSql("''");

                    b.HasKey("IdAlamat")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCustomer" }, "FK__customer");

                    b.ToTable("alamat", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_customer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FotoProfile")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("foto_profile");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nama");

                    b.Property<string>("NoHp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("no_hp");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("IdCustomer")
                        .HasName("PRIMARY");

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.DetailOrder", b =>
                {
                    b.Property<int>("IdDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_detail");

                    b.Property<decimal>("Harga")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("harga");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_order");

                    b.Property<int>("IdProduk")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_produk");

                    b.Property<int>("JumlahBarang")
                        .HasColumnType("int(11)")
                        .HasColumnName("jumlah_barang");

                    b.Property<decimal>("SubTotal")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("subtotal");

                    b.HasKey("IdDetail")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdOrder" }, "detail_order_FK_1");

                    b.ToTable("detail_order", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Kategori", b =>
                {
                    b.Property<int>("IdKategori")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_kategori");

                    b.Property<string>("DeskripsiKategori")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("deskripsi_kategori");

                    b.Property<string>("Icon")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("icon");

                    b.Property<string>("NamaKategori")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nama_kategori");

                    b.HasKey("IdKategori")
                        .HasName("PRIMARY");

                    b.ToTable("kategori", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Keranjang", b =>
                {
                    b.Property<int>("IdKeranjang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_keranjang");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_customer");

                    b.Property<int>("IdProduk")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_produk");

                    b.Property<int>("JumlahBarang")
                        .HasColumnType("int(11)")
                        .HasColumnName("jumlah_barang");

                    b.Property<decimal>("Subtotal")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("subtotal");

                    b.HasKey("IdKeranjang")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCustomer" }, "FK__customer_keranjang");

                    b.HasIndex(new[] { "IdProduk" }, "FK__produk_keranjang");

                    b.ToTable("keranjang", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_order");

                    b.Property<string>("Catatan")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("catatan");

                    b.Property<int>("IdAlamat")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_alamat");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_customer");

                    b.Property<decimal>("JumlahBayar")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("jumlah_bayar");

                    b.Property<int>("Status")
                        .HasColumnType("int(11)")
                        .HasColumnName("status");

                    b.Property<DateTime>("TglTransaksi")
                        .HasColumnType("datetime")
                        .HasColumnName("tgl_transaksi");

                    b.HasKey("IdOrder")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdAlamat" }, "FK__alamat");

                    b.HasIndex(new[] { "IdCustomer" }, "FK__customer_order");

                    b.HasIndex(new[] { "Status" }, "FK_order_status_order");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Pembayaran", b =>
                {
                    b.Property<int>("IdPembayaran")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_pembayaran");

                    b.Property<string>("BuktiPembayaran")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("bukti_pembayaran");

                    b.Property<string>("Catatan")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("catatan");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_customer");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_order");

                    b.Property<decimal>("JumlahBayar")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("jumlah_bayar");

                    b.Property<string>("MetodePembayaran")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("metode_pembayaran");

                    b.Property<decimal>("Pajak")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("pajak");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("status");

                    b.Property<int?>("StatusOrderIdStatus")
                        .HasColumnType("int(11)");

                    b.Property<DateOnly>("TanggalBayar")
                        .HasColumnType("date")
                        .HasColumnName("tanggal_bayar");

                    b.Property<string>("Tujuan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tujuan");

                    b.HasKey("IdPembayaran")
                        .HasName("PRIMARY");

                    b.HasIndex("StatusOrderIdStatus");

                    b.HasIndex(new[] { "IdCustomer" }, "FK__customer_pembayaran");

                    b.HasIndex(new[] { "IdOrder" }, "FK__order_pembayaran");

                    b.HasIndex(new[] { "Status" }, "FK_pembayaran_status_order");

                    b.ToTable("pembayaran", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Pengiriman", b =>
                {
                    b.Property<int>("IdPengiriman")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_pengiriman");

                    b.Property<int>("IdAlamat")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_alamat");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_order");

                    b.Property<string>("Keterangan")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("keterangan");

                    b.Property<string>("Kurir")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("kurir")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Noresi")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Ongkir")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("ongkir");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("status");

                    b.Property<int?>("StatusOrderIdStatus")
                        .HasColumnType("int(11)");

                    b.HasKey("IdPengiriman")
                        .HasName("PRIMARY");

                    b.HasIndex("StatusOrderIdStatus");

                    b.HasIndex(new[] { "IdAlamat" }, "FK__alamat_pengiriman");

                    b.HasIndex(new[] { "IdOrder" }, "FK__order_pengiriman");

                    b.ToTable("pengiriman", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Produk", b =>
                {
                    b.Property<int>("IdProduk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_produk");

                    b.Property<string>("DeskripsiProduk")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("deskripsi_produk");

                    b.Property<string>("Gambar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("gambar");

                    b.Property<decimal>("HargaProduk")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("harga_produk");

                    b.Property<string>("NamaProduk")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nama_produk");

                    b.Property<int>("Stok")
                        .HasColumnType("int(11)")
                        .HasColumnName("stok");

                    b.HasKey("IdProduk")
                        .HasName("PRIMARY");

                    b.ToTable("produk", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.ProdukKategori", b =>
                {
                    b.Property<int>("IdProdukKategori")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_produk_kategori");

                    b.Property<int>("IdKategori")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_kategori");

                    b.Property<int>("IdProduk")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_produk");

                    b.HasKey("IdProdukKategori")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdKategori" }, "FK__kategori_produk");

                    b.HasIndex(new[] { "IdProduk" }, "FK__produk");

                    b.ToTable("produk_kategori", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.StatusOrder", b =>
                {
                    b.Property<int>("IdStatus")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_status");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("deskripsi");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nama");

                    b.HasKey("IdStatus")
                        .HasName("PRIMARY");

                    b.ToTable("status_order", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Ulasan", b =>
                {
                    b.Property<int>("IdUlasan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_ulasan");

                    b.Property<string>("Gambar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("gambar");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_customer");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_order");

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("komentar");

                    b.Property<int>("Rating")
                        .HasColumnType("int(11)")
                        .HasColumnName("rating");

                    b.HasKey("IdUlasan")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdOrder" }, "FK__Order_Ulasan");

                    b.HasIndex(new[] { "IdCustomer" }, "FK__customer_Ulasan");

                    b.ToTable("ulasan", (string)null);
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Alamat", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Customer", "IdCustomerNavigation")
                        .WithMany("Alamats")
                        .HasForeignKey("IdCustomer")
                        .IsRequired()
                        .HasConstraintName("FK__customer");

                    b.Navigation("IdCustomerNavigation");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.DetailOrder", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Order", "Order")
                        .WithMany("DetailOrders")
                        .HasForeignKey("IdOrder")
                        .IsRequired()
                        .HasConstraintName("detail_order_FK_1");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Keranjang", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Customer", "IdCustomerNavigation")
                        .WithMany("Keranjangs")
                        .HasForeignKey("IdCustomer")
                        .IsRequired()
                        .HasConstraintName("FK__customer_keranjang");

                    b.HasOne("eCommerce.Datas.Entities.Produk", "IdProdukNavigation")
                        .WithMany("Keranjangs")
                        .HasForeignKey("IdProduk")
                        .IsRequired()
                        .HasConstraintName("FK__produk_keranjang");

                    b.Navigation("IdCustomerNavigation");

                    b.Navigation("IdProdukNavigation");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Order", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Alamat", "IdAlamatNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("IdAlamat")
                        .IsRequired()
                        .HasConstraintName("FK__alamat");

                    b.HasOne("eCommerce.Datas.Entities.Customer", "IdCustomerNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("IdCustomer")
                        .IsRequired()
                        .HasConstraintName("FK__customer_order");

                    b.HasOne("eCommerce.Datas.Entities.StatusOrder", "StatusNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("Status")
                        .IsRequired()
                        .HasConstraintName("FK_order_status_order");

                    b.Navigation("IdAlamatNavigation");

                    b.Navigation("IdCustomerNavigation");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Pembayaran", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Customer", "IdCustomerNavigation")
                        .WithMany("Pembayarans")
                        .HasForeignKey("IdCustomer")
                        .IsRequired()
                        .HasConstraintName("FK__customer_pembayaran");

                    b.HasOne("eCommerce.Datas.Entities.Order", "IdOrderNavigation")
                        .WithMany("Pembayarans")
                        .HasForeignKey("IdOrder")
                        .IsRequired()
                        .HasConstraintName("FK__order_pembayaran");

                    b.HasOne("eCommerce.Datas.Entities.StatusOrder", null)
                        .WithMany("Pembayarans")
                        .HasForeignKey("StatusOrderIdStatus");

                    b.Navigation("IdCustomerNavigation");

                    b.Navigation("IdOrderNavigation");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Pengiriman", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Alamat", "IdAlamatNavigation")
                        .WithMany("Pengirimen")
                        .HasForeignKey("IdAlamat")
                        .IsRequired()
                        .HasConstraintName("FK__alamat_pengiriman");

                    b.HasOne("eCommerce.Datas.Entities.Order", "IdOrderNavigation")
                        .WithMany("Pengirimen")
                        .HasForeignKey("IdOrder")
                        .IsRequired()
                        .HasConstraintName("FK__order_pengiriman");

                    b.HasOne("eCommerce.Datas.Entities.StatusOrder", null)
                        .WithMany("Pengirimen")
                        .HasForeignKey("StatusOrderIdStatus");

                    b.Navigation("IdAlamatNavigation");

                    b.Navigation("IdOrderNavigation");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.ProdukKategori", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Kategori", "IdKategoriNavigation")
                        .WithMany("ProdukKategoris")
                        .HasForeignKey("IdKategori")
                        .IsRequired()
                        .HasConstraintName("FK__kategori_produk");

                    b.HasOne("eCommerce.Datas.Entities.Produk", "IdProdukNavigation")
                        .WithMany("ProdukKategoris")
                        .HasForeignKey("IdProduk")
                        .IsRequired()
                        .HasConstraintName("FK__produk");

                    b.Navigation("IdKategoriNavigation");

                    b.Navigation("IdProdukNavigation");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Ulasan", b =>
                {
                    b.HasOne("eCommerce.Datas.Entities.Customer", "Customer")
                        .WithMany("Ulasans")
                        .HasForeignKey("IdCustomer")
                        .IsRequired()
                        .HasConstraintName("FK__customer_Ulasan");

                    b.HasOne("eCommerce.Datas.Entities.Order", "Order")
                        .WithMany("Ulasans")
                        .HasForeignKey("IdOrder")
                        .IsRequired()
                        .HasConstraintName("FK__Order_Ulasan");

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Alamat", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Pengirimen");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Customer", b =>
                {
                    b.Navigation("Alamats");

                    b.Navigation("Keranjangs");

                    b.Navigation("Orders");

                    b.Navigation("Pembayarans");

                    b.Navigation("Ulasans");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Kategori", b =>
                {
                    b.Navigation("ProdukKategoris");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Order", b =>
                {
                    b.Navigation("DetailOrders");

                    b.Navigation("Pembayarans");

                    b.Navigation("Pengirimen");

                    b.Navigation("Ulasans");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.Produk", b =>
                {
                    b.Navigation("Keranjangs");

                    b.Navigation("ProdukKategoris");
                });

            modelBuilder.Entity("eCommerce.Datas.Entities.StatusOrder", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Pembayarans");

                    b.Navigation("Pengirimen");
                });
#pragma warning restore 612, 618
        }
    }
}
