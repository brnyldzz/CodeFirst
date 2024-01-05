using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Data.Model
{
    [Table("Adres")]
    public class Adres
    {
        public int adresID { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(100)]
        [MinLength(20)]
        [Required]
        public string adresAdi { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(100)]
        [Required]
        public string adresAciklama { get; set; }
    }
}
