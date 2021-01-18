using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog18Ocak2021.Models
{
    [Table("Yazilar")]
    public class Yazi
    {
        public int Id { get; set; }
        [Required]
        public string Baslik { get; set; }
        public string KisaAciklama { get; set; }
        public string Icerik { get; set; }
        public string Foto { get; set; }
    }
}