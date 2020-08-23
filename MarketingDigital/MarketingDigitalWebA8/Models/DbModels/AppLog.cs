using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Models.DbModels
{
    [Table("AppLog")]
    public class AppLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(70)")]
        public string Email{ get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(70)")]
        public string Method { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(4000)")]
        public string Exception { get; set; }

        [Column(Order = 5, TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }
    }
}
