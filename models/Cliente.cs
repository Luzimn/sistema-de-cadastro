using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocsharp.models
{
    public class VarIguais()
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Contato { get; set; }
        public string? Localidade { get; set; }
       
    }




    public class PessoaFisica : VarIguais
    {
        public int Idade { get; set; }
        public int CpfRg{ get; set; }

    }

    public class PessoaJuridica : VarIguais
    {

        public int Cnpj { get; set; }
    }
}   
