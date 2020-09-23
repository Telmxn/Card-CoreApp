using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardApp.Models
{
    public class Card
    {
        public int Id { get; set; }
        [Required]
        public string CardHolder { get; set; }
        [Required]
        [Column(TypeName = "bigint")]
        public long CardNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public int Balance { get; set; }
        [Required]
        public int CVC { get; set; }
    }
}
