using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEP.Models
{   
    [Table("Cidades")]
    public class Cidade
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
    }
}
