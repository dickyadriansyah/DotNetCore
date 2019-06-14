using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Models
{
    public class mahasiswa
    {
        [Key]
        public string id_mahasiswa { get; set; }
        public string nama { get; set; }
        public string jenis_kelamin { get; set; }
        public string alamat { get; set; }
    }
}
