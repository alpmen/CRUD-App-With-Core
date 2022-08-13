using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppSinav.Models
{
    public class Departmanlar
    {
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string DepartmanAd { get; set; }


        [Column(TypeName = "VARCHAR(150)")]
        [StringLength(150)]
        public string Detay { get; set; }


        public IList<Personel> _Personels { get; set; }
    }
}
