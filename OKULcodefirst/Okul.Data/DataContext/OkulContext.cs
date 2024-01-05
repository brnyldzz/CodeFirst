using Okul.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Data.DataContext
{
    public class OkulContext:DbContext
    {
        public DbSet<Ogretmen> Ogretmen { get; set; }

        public DbSet<Ogrenci> Ogrenci { get; set; }

        public  DbSet<Adres> Adres { get; set; }

        public DbSet<Bolum> Bolum { get; set; }

        public  DbSet<Brans> Brans { get; set; }


    }
}
