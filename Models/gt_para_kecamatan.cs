using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Models
{
    public class gt_para_kecamatan
    {
        [Key]
        public string para_kecamatan_id { get; set; }
        public string para_kecamatan_desc { get; set; }
        public string para_kecamatan_log_id { get; set; }
        public string para_kecamatan_deleted { get; set; }
        public string para_kecamatan_kota_id { get; set; }
    }
}
