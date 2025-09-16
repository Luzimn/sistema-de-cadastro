using projetocsharp.models.cliente;



namespace Projetocsharp.services {
    
     public class CadastroCliente
    {
        public PessoaFisica PessoaF { get; set; } = new PessoaFisica();
        public PessoaJuridica PessoaJ { get; set; } = new PessoaJuridica();

    };

    public class MenuCadastro:CadastroCliente
    {
        private static List<CadastroCliente> dadosCliente = new List<CadastroCliente>();

        public static void ExecutarMenu()
        {
            
        Console.WriteLine("Deseja continuar com o cadastro do cliente?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - nao");
        string? sim = Console.ReadLine();
        var cadastro = new CadastroCliente();

        if (sim == "1")
        {
            List<object> itens = new List<object>{
                    new PessoaFisica(),
                    new PessoaJuridica()
                };
            //cria a confirmação para os campos serem preenchidos 
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
            string? entrada;
    do
    {


        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1 - pessoa fisica");
        Console.WriteLine("2 - pessoa juridica");
        Console.WriteLine("3 - listar cadastros");
        Console.WriteLine("4 - sair");
        Console.Write("Digite o número: ");
        entrada = Console.ReadLine();


        switch (entrada)
        {
            case "1":
             //cadastro de Pessoa fisica
                var novoCadastroPF = new CadastroCliente();
                var PessoaFisica = new PessoaFisica();
                Console.WriteLine("pessoa fisica");
                Console.WriteLine("nome");
                PessoaFisica.Nome = Console.ReadLine() ?? "";
                Console.WriteLine("idade (apenas numeros)");
                PessoaFisica.Idade = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("cpf (apenas numeros)");
                PessoaFisica.CpfRg = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Email");
                PessoaFisica.Email = Console.ReadLine() ?? "";
                Console.WriteLine("contato");
                PessoaFisica.Contato = Console.ReadLine() ?? "";
                Console.WriteLine("Localidade");
                PessoaFisica.Localidade = Console.ReadLine() ?? ""; 

                Console.WriteLine("deseja salvar");
                Console.WriteLine("1 - sim, 2 - nao");
                string? salvar = Console.ReadLine();
                 //Verifica e salva na lista 
                if (CamposPreenchidos(PessoaFisica.Nome, PessoaFisica.Email, PessoaFisica.Contato, PessoaFisica.Localidade) && CamposInteirosPreenchidos(PessoaFisica.Idade, PessoaFisica.CpfRg) && salvar == "1")
                {
                    Console.WriteLine("cadastro fisico salvo!");
                    novoCadastroPF.PessoaF = PessoaFisica;
                }
                else if (string.IsNullOrWhiteSpace(PessoaFisica.Nome)  && CamposInteirosPreenchidos(PessoaFisica.Idade, PessoaFisica.CpfRg) && salvar == "1"){
                    Console.WriteLine("voce nao preencheu todos os campos!!");
                }

                else
                {
                    Console.WriteLine("nao salvo");
                }
                //grava na lista 
                dadosCliente.Add(novoCadastroPF);
                break;

            case "2":
                //cadastro de Pessoa Juridica
                var novoCadastroPJ = new CadastroCliente();
                var PessoaJuridica = new PessoaJuridica();
                Console.WriteLine("pessoa Juridica");
                Console.WriteLine("nome");
                PessoaJuridica.Nome = Console.ReadLine() ?? "";
                Console.WriteLine("Email");
                PessoaJuridica.Email = Console.ReadLine() ?? "";
                Console.WriteLine("cnpj (apenas numeros)");
                PessoaJuridica.Cnpj = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("contato");
                PessoaJuridica.Contato = Console.ReadLine() ?? "";
                Console.WriteLine("localidade");
                PessoaJuridica.Localidade = Console.ReadLine() ?? "";

                Console.WriteLine("deseja salvar");
                Console.WriteLine("1 - sim, 2 - nao");
                string? salvarpf = Console.ReadLine();
                //Verifica e salva na lista 
                if (salvarpf == "1")
                {
                    Console.WriteLine("Pessoa física salva com sucesso!");
                    novoCadastroPJ.PessoaJ = PessoaJuridica;
                }
                else
                {
                    Console.WriteLine("nao salvo");
                }
                //grava na lista 
                dadosCliente.Add(novoCadastroPJ);
                break;
            case "3":
                //Mostra a lista
                if (dadosCliente.Any())
                    {
                        int contar = 0;
                        Console.WriteLine("lista:");
                        foreach (var registro in dadosCliente)
                        {
                            if(!string.IsNullOrWhiteSpace(registro.PessoaF.Nome)){
                            Console.WriteLine($"=== Cadastro === {contar}");
                            Console.WriteLine($"Pessoa Fisica: Nome {registro.PessoaF.Nome} - idade {registro.PessoaF.Idade} - CPF{registro.PessoaF.CpfRg}");
                            Console.WriteLine("================");
                            }
                            else if(!string.IsNullOrWhiteSpace(registro.PessoaJ.Nome)){

                            Console.WriteLine($"=== pessoa juridica === {contar}");
                            Console.WriteLine($"Pessoa Juridica: Nome {registro.PessoaJ.Nome} - CNPJ {registro.PessoaJ.Cnpj}");
                            Console.WriteLine("================");
                            }
                            contar++;
                        }
                    
                    }
                    else
                    {
                        Console.WriteLine("Não há boletos cadastrados.");
                    }
                break;

            case "4":
                Console.WriteLine("saindo");
            break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        
        }       
        
    }while (entrada != "4");
    

}
    
else
    {
        Console.WriteLine("Voce selecionou não, saindo");
    }
        }
        

    }

}
