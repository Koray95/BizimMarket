﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimMarket.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        
        [Required,MaxLength(100)]
        public string Ad { get; set; }


        public List<Urun> Urunler { get; set; }

    }
}
