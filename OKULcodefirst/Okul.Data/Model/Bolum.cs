using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Data.Model
{
    [Table("Bolum")]
    public class Bolum
    {
        public int bolumID { get; set; }

        [DataType(DataType.Custom)]
        [MaxLength(20)]
        [Required]
        public string bolumAdi { get; set; }
    }
}
