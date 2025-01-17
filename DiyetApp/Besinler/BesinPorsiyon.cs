﻿using DiyetApp.Ogunler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Besinler
{
    public class BesinPorsiyon
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Porsiyon { get; set; }
        public double Kalori { get; set; }
        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public List<UyeYemek> UyeYemekler { get; set; }
    }
}
