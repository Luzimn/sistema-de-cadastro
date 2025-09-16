using Projetocsharp.models.boleto;


namespace Projetocsharp.servicesBoleto
{
    public class Cadastroboleto
    {
        public RegistroEmissor Emissor { get; set; } = new RegistroEmissor();
        public RegistroPagador Pagador { get; set; } = new RegistroPagador();
        public RegistroBoleto Boleto { get; set; } = new RegistroBoleto();

      
    };
    public class MenuCadastroBoleto:Cadastroboleto
    {

        private static List<Cadastroboleto> dados = new List<Cadastroboleto>();

        public static void ExecutarMenuBoleto()
        {
            Console.WriteLine("todos os campos preenchidos?");
            Console.WriteLine("sim");
            Console.WriteLine("nao");
            string? sim = Console.ReadLine();
           // var emissoresParaAdicionar = new List<RegistroEmissor>();
            var cadastro = new Cadastroboleto();
            if (sim == "sim")
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
                    Console.WriteLine("3 - sair");
                    Console.Write("Digite o número: ");
                    entradaDado = Console.ReadLine();
                    switch (entradaDado)
                    {
                        case "1":
                            //repetição para cadastrar os boeltos
                            foreach (var item in itens)
                            {
                                if (item is RegistroEmissor emissor)
                                {
                                    Console.WriteLine("emissor");
                                    emissor.NomeRazao = "lucas";//Console.ReadLine();
                                    emissor.CnpjouCpf = 02134198; //int.Parse(Console.ReadLine() ?? "");
                                    emissor.Endereco = "wrwrhwrh";//Console.ReadLine();
                                    emissor.Banco = "rygrgw";//Console.ReadLine();
                                    emissor.Agencia = "rwgwrgrwg";//Console.ReadLine();
                                    //verificador e confirmar se estao com dados os campos
                                    if (CamposPreenchidos(emissor.NomeRazao, emissor.Endereco, emissor.Banco, emissor.Agencia) && CamposInteirosPreenchidos(emissor.CnpjouCpf))
                                    {
                                        Console.WriteLine("Emissor preenchido corretamente!");
                                        cadastro.Emissor = emissor;
                                    }

                                }
                                else if (item is RegistroPagador pagador)
                                {
                                    pagador.NomePagador = "exemplox";
                                    pagador.EnderecoPagador = "rua xxx twsre";
                                    pagador.CnpjouCpfPagador = 12434;
                                    if (CamposPreenchidos(pagador.NomePagador, pagador.EnderecoPagador) && CamposInteirosPreenchidos(pagador.CnpjouCpfPagador))
                                    {
                                        Console.WriteLine("pagador preenchido corretamente!");
                                        cadastro.Pagador = pagador;
                                    }
                                }
                                else if (item is RegistroBoleto boleto)
                                {
                                    boleto.NumeroBoleto = 12434;
                                    boleto.ValorBoleto = 2124;
                                    boleto.DataEmissao = DateTime.Today;
                                    boleto.DiasPVencimento = 30;
                                    boleto.DataVencimento = DateTime.Today.AddDays(boleto.DiasPVencimento);
                                    Console.WriteLine("registro do boleto feito");
                                    cadastro.Boleto = boleto;
                                }


                            }
                            //adiciona para o array
                            dados.Add(cadastro);
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
                        default:
                            Console.WriteLine("saindo");
                            break;

                    }

                } while (entradaDado != "3");
            }
        }
    }
}
                        /*
                        Console.WriteLine("deseja salvar");
                        Console.WriteLine("1 - sim, 2 - nao");
                        string? salvar = Console.ReadLine();

                        if (CamposPreenchidos(pessoaf.Nome, pessoaf.Email, pessoaf.Contato, pessoaf.Localidade) && CamposInteirosPreenchidos(pessoaf.Idade, pessoaf.CpfRg) && salvar == "1")
                        {
                            File.WriteAllText("pessoa_fisica.txt",
                            $"{pessoaf.Nome},{pessoaf.Idade},{pessoaf.CpfRg},{pessoaf.Email},{pessoaf.Contato},{pessoaf.Localidade}");
                            Console.WriteLine("Pessoa física salva com sucesso!");
                        }
                        else if (string.IsNullOrWhiteSpace(pessoaf.Nome)  && CamposInteirosPreenchidos(pessoaf.Idade, pessoaf.CpfRg) && salvar == "1"){
                            Console.WriteLine("voce nao preencheu todos os campos!!");
                        }

                        else
                        {
                            Console.WriteLine("nao salvo");
                        }
                        break;*/