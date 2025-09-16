using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Projetocsharp.models.boleto
{
    public class RegistroEmissor
    {

        //dados do emissor
        public string? NomeRazao { get; set; }
        public int CnpjouCpf { get; set; }
        public string? Endereco { get; set; }
        public string? Banco { get; set; }
        public string? Agencia { get; set; }
    };

    public class RegistroPagador
        // dados do pagador
    {
        public string? NomePagador { get; set; }
        public int CnpjouCpfPagador { get; set; }
        public string? EnderecoPagador { get; set; }
    };

    public class RegistroBoleto
    {
        // dados do boleto
        public int NumeroBoleto { get; set; }
        public double ValorBoleto { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public int DiasPVencimento { get; set; }
    }

}