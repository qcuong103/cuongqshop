using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuonqShop.Model.Models
{
    [Table("PostTags")]
    public class PostTags
    {
        [Key]
        public int PostID { get; set; }
        [Key]
        public string TagsID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagsID")]
        public virtual Tag Tags { get; set; }
    }
}
