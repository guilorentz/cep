using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEP.Models
{
    [Table("Estados")]
    public class Estado
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        public List<Cidade> Cidades { get; set; }

        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    
    }
}
