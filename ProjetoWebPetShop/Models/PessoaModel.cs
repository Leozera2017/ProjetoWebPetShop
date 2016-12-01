using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebPetShop.Models
{
    public class PessoaModel
    {

        public string Nome { get; set; } = string.Empty;
        public string NomeEmpresa { get; set; } = string.Empty;
        public string NomeFantasia { get; set; } = string.Empty;
        public string CPFCNPJ { get; set; } = string.Empty;
        public string Telefone1 { get; set; } = string.Empty;
        public string Telefone2 { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;
    }
}