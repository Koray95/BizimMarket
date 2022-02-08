﻿using Microsoft.EntityFrameworkCore;

namespace BizimMarket.Models
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori() { Id = 1, Ad = "Atıştırmalık" },
                new Kategori() { Id = 2, Ad = "Dondurma" },
                new Kategori() { Id = 3, Ad = "Fırın" }
                );

            modelBuilder.Entity<Urun>().HasData(
                new Urun() { Id = 1, Ad = "Kinder Joy 20g", Fiyat = 7.90m, ResimYolu = "kinderjoy.jpg", KategoriId = 1 },
                new Urun() { Id = 2, Ad = "Toblerone Sütlü Çikolata 100 G", Fiyat = 18.90m, ResimYolu = "toblerone.jpg", KategoriId = 1 },
                new Urun() { Id = 3, Ad = "Tadelle Fındık Dolgulu Sütlü Çikolata 30 G", Fiyat = 4.95m, ResimYolu = "tadelle.jpg", KategoriId = 1 },
                new Urun() { Id = 4, Ad = "Algida Maraş Usulü Sade Çikolata Dondurma 500 Ml", Fiyat = 28.50m, ResimYolu = "algidamaras.jpg", KategoriId = 2 },
                new Urun() { Id = 5, Ad = "Carte d'Or Selection Meyve Şöleni 850 Ml", Fiyat = 36.90m, ResimYolu = "cartedormeyve.jpg", KategoriId = 2 },
                new Urun() { Id = 6, Ad = "Minik Sandviç 10'Lu", Fiyat = 17.90m, ResimYolu = "miniksandvic.jpg", KategoriId = 3}

                );

        }
    }
}
