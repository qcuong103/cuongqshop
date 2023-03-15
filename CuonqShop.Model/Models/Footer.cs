using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuonqShop.Model.Models
{
    [Table("Footer")]
    public class Footer
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
