using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace BizimMarket.Models
{
    public class Urun
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }

        public decimal Fiyat { get; set; }

        public string ResimYolu { get; set; }


        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
