using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppSinav.Models
{
    public class Personel
    {
        [Key]
        public int perid { get; set; }


        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string ad { get; set; }


        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string soyad { get; set; }


        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string sehir { get; set; }


        public int departid { get; set; }

        public Departmanlar depart { get; set; }
    }
}
