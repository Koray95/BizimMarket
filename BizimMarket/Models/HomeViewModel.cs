using System.Collections.Generic;

namespace BizimMarket.Models
{
    public class HomeViewModel
    {
        public List<Kategori> Kategoriler { get; set; }
        public List<Urun> Urunler { get; set; }

        public int? KategoriId { get; set; }
    }
}
