﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuonqShop.Model.Models
{

    [Table("Eroors")]
    public class Error
    {
        [Key]
        public int ID { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
