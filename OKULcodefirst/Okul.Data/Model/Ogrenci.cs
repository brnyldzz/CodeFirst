using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Data.Model
{
    [Table("Ogrenci")]
    public class Ogrenci
    {
        public int ogrenciID { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(10)]
        [Required]
        public string ogrenciNo { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(20)]
        [Required]
        public string ogrenciAdi { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(30)]
        [Required]
        public string ogrenciSoyadi  { get; set; }

        [Required]
        public DateTime dogumTarihi { get; set; }

        public Bolum bolum { get; set; }

        public Adres adres { get; set; }

    }
}
