using Projetocsharp.models.boleto;
using System.Globalization;
using System.IO;


namespace Projetocsharp.servicesBoleto
{
    
    public class Cadastroboleto
    {
        public RegistroEmissor Emissor { get; set; } = new RegistroEmissor();
        public RegistroPagador Pagador { get; set; } = new RegistroPagador();
        public RegistroBoleto Boleto { get; set; } = new RegistroBoleto();


    };
    public class MenuCadastroBoleto : Cadastroboleto
    {


        private static List<Cadastroboleto> dados = new List<Cadastroboleto>();

        public static void ExecutarMenuBoleto()
        {
            Console.WriteLine("Deseja continuar com o cadastro do boleto?");
            Console.WriteLine("1 - sim");
            Console.WriteLine("2 - nao");
            string? sim = Console.ReadLine();
            // var emissoresParaAdicionar = new List<RegistroEmissor>();
            var cadastro = new Cadastroboleto();
            if (sim == "1")
            {
                //registros para formar uma lista de objetos 
                List<object> itens = new List<object>{
                    new RegistroEmissor(),
                    new RegistroPagador(),
                    new RegistroBoleto(),

                };
                //confirma os campos para fazer a chekagem se estao vazios ou nao
                static bool CamposPreenchidos(params string[] campos)
                {
                    return campos.All(campo => !string.IsNullOrWhiteSpace(campo));
                }
                static bool CamposInteirosPreenchidos(params int[] campos)
                {
                    return campos.All(campo => campo != 0);

                }

                Console.WriteLine("//////////////////////////////////////////////");
                Console.WriteLine(" ");
                string? entradaDado;
                do
                {
                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - cadastrar boleto");
                    Console.WriteLine("2 - listar boletos");
                    Console.WriteLine("3 - baixar");
                    Console.WriteLine("4 - sair");
                    Console.Write("Digite o número: ");
                    entradaDado = Console.ReadLine();
                    switch (entradaDado)
                    {
                        case "1":
                            var novoCadastro = new Cadastroboleto();
                            var emissor = new RegistroEmissor();
                            Console.WriteLine("Emissor");
                            emissor.NomeRazao = Console.ReadLine() ?? "";
                            Console.WriteLine("CPF ou CNPJ (apenas numeros)");
                            emissor.CnpjouCpf = int.Parse(Console.ReadLine() ?? "");
                            Console.WriteLine("Endereço");
                            emissor.Endereco = Console.ReadLine();
                            Console.WriteLine("Banco");
                            emissor.Banco = Console.ReadLine();
                            Console.WriteLine("Agencia");
                            emissor.Agencia = Console.ReadLine();
                                                          //verificador e confirmar se estao com dados os campos
                            if (CamposPreenchidos(emissor.NomeRazao, emissor.Endereco, emissor.Banco, emissor.Agencia) && CamposInteirosPreenchidos(emissor.CnpjouCpf))
                            {
                                Console.WriteLine("Emissor preenchido corretamente!");
                                novoCadastro.Emissor = emissor;
                            }
                            var pagador = new RegistroPagador();
                            Console.WriteLine("Pagador");
                            pagador.NomePagador = Console.ReadLine() ?? "";
                            Console.WriteLine("Endereço");
                            pagador.EnderecoPagador = Console.ReadLine() ?? "";
                            Console.WriteLine("CPF ou CNPJ (apenas numeros)");
                            pagador.CnpjouCpfPagador = int.Parse(Console.ReadLine() ?? "");
                            if (CamposPreenchidos(pagador.NomePagador, pagador.EnderecoPagador) && CamposInteirosPreenchidos(pagador.CnpjouCpfPagador))
                            {
                                Console.WriteLine("pagador preenchido corretamente!");
                                novoCadastro.Pagador = pagador;
                            }
                            var boleto = new RegistroBoleto();
                            Console.WriteLine("Numero do Boleto");
                            boleto.NumeroBoleto = int.Parse(Console.ReadLine() ?? "");
                            Console.WriteLine("Valor");
                            boleto.ValorBoleto = decimal.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                            Console.WriteLine("Data de Emissao");
                            boleto.DataEmissao = DateTime.Today;
                            Console.WriteLine("Dias Para Vencer");
                            boleto.DiasPVencimento = int.Parse(Console.ReadLine() ?? "");
                            boleto.DataVencimento = DateTime.Today.AddDays(boleto.DiasPVencimento);
                            Console.WriteLine($"Data de Vencimento {boleto.DataVencimento}");
                            Console.WriteLine("registro do boleto feito");
                            novoCadastro.Boleto = boleto;

                            //adiciona para o array
                            dados.Add(novoCadastro);
                            break;
                        case "2":

                            if (dados.Any())
                            {
                                int contar = 0;
                                Console.WriteLine("lista:");
                                foreach (var registro in dados)
                                {
                                    Console.WriteLine($"=== Cadastro === {contar}");
                                    Console.WriteLine($"Emissor: {registro.Emissor.NomeRazao} - {registro.Emissor.CnpjouCpf}");
                                    Console.WriteLine($"Pagador: {registro.Pagador.NomePagador} - {registro.Pagador.CnpjouCpfPagador}");
                                    Console.WriteLine($"Boleto: Nº {registro.Boleto.NumeroBoleto} | Valor: {registro.Boleto.ValorBoleto}  | Data: {registro.Boleto.DataVencimento}");
                                    Console.WriteLine("================");
                                    contar++;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Não há boletos cadastrados.");
                            }
                            break;

                        case "3":
                            Console.WriteLine("deseja salvar?");
                            Console.WriteLine("1 - sim, 2 - nao");
                            string? salvar = Console.ReadLine();

                            if (salvar == "1")
                            {
                                int contar = 0;
                                Console.WriteLine("lista:");
                                foreach (var registro in dados)
                                {
                                    File.WriteAllText($"Resgistro Numero {$"{contar}.txt"}", $"Emissor: {registro.Emissor.NomeRazao} - {registro.Emissor.CnpjouCpf} Pagador: {registro.Pagador.NomePagador} - {registro.Pagador.CnpjouCpfPagador} - Boleto: Nº {registro.Boleto.NumeroBoleto} | Valor: {registro.Boleto.ValorBoleto}  | Data de Vencimento: {registro.Boleto.DataVencimento}");
                                    Console.WriteLine($"=== Cadastro === {contar}");
                                    contar++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("nao salvo");
                            }

                            break;
                        default:
                            Console.WriteLine("saindo");
                            break;

                    }

                } while (entradaDado != "4");
            }
            else
    {
        Console.WriteLine("Voce selecionou não, saindo");
    }
        }
    }
}
                        
                       