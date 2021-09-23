using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaCEPWeb.Domain
{
    public class Endereco : Entity<int>
    {
        [Required]
        [Column("Rua")]
        public string Rua { get; set; }
        [Column("Bairro")]
        public string Bairro { get; set; }
        [Required]
        [Column("Cep")]
        public string Cep { get; set; }
        [Required]
        [Column("Cidade")]
        public string Cidade { get; set; }
        [Required]
        [Column("Uf")]
        public string Uf { get; set; }
    }
}
