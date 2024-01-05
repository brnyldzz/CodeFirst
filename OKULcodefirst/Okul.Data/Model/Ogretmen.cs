using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Data.Model
{
    [Table("Ogretmen")]
    public class Ogretmen
    {
        public int ogretmenID { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(10)]
        [Required]
        public string sicilNo { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(20)]
        [Required]
        public string ogretmenAdi { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(30)]
        [Required]
        public string ogretmenSoyadi { get; set; }

        public Brans brans { get; set; }

        public  Adres adres { get; set; }
    }
}
