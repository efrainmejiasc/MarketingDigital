using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Models.DbModels
{

    public class EmpresaCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Id")]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        [Column(Order = 2, TypeName = "VARCHAR(50)")]
        public string Name { get; set; }

        [DisplayName("LastName")]
        [Required]
        [Column(Order = 3, TypeName = "VARCHAR(50)")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        [Required]
        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required]
        [Column(Order = 5, TypeName = "VARCHAR(100)")]
        public string Password { get; set; }

        [DisplayName("Company")]
        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string Company { get; set; }

        [DisplayName("Phone")]
        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string Phone { get; set; }

        [DisplayName("Status")]
        [Column(Order = 8, TypeName = "BIT")]
        public bool Status { get; set; }

        [DisplayName("CreateDate")]
        [Required]
        [Column(Order = 9, TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }
    }
}
