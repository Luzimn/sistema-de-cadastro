using projetocsharp.models;
using Projetocsharp.services;
using Projetocsharp.servicesBoleto;

class Program
{
    static void Main(string[] args)
    {
        MenuCadastroBoleto.ExecutarMenuBoleto();
        //MenuCadastro.ExecutarMenu();

    }
}





























/*Console.WriteLine("todos os campos preenchidos?");
    Console.WriteLine("sim");
    Console.WriteLine("nao");
string? sim = Console.ReadLine();

if (sim == "sim")
{
    Console.WriteLine("//////////////////////////////////////////////");
    Console.WriteLine(" ");
    string? entrada;
    do
    {


        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1 - pessoa fisica");
        Console.WriteLine("2 - pessoa juridica");
        Console.WriteLine("3 - sair");
        Console.Write("Digite o número: ");
        entrada = Console.ReadLine();


        switch (entrada)
        {
            case "1":
                PessoaFisica pessoaf = new PessoaFisica();
                Console.WriteLine("pessoa fisica");
                pessoaf.Nome = "";
                pessoaf.Idade = 19;
                pessoaf.CpfRg = 124563;
                pessoaf.Email = "teste@teste";
                pessoaf.Contato = "196548726";
                pessoaf.Localidade = "barrio teste, 423"; 
                static bool CamposPreenchidos(params string[] campos)
                {
                    return campos.All(campo => !string.IsNullOrWhiteSpace(campo));
                }
                static bool CamposInteirosPreenchidos(params int[] campos)
                {
                    return campos.All(campo => campo != 0);
                }

                Console.WriteLine("deseja salvar");
                Console.WriteLine("1 - sim, 2 - nao");
                string? salvar = Console.ReadLine();

                if (CamposPreenchidos(pessoaf.Nome, pessoaf.Email, pessoaf.Contato, pessoaf.Localidade) && CamposInteirosPreenchidos(pessoaf.Idade, pessoaf.CpfRg) && salvar == "1")
                {
                    File.WriteAllText("pessoa_fisica.txt",
                    $"{pessoaf.Nome},{pessoaf.Idade},{pessoaf.CpfRg},{pessoaf.Email},{pessoaf.Contato},{pessoaf.Localidade}");
                    Console.WriteLine("Pessoa física salva com sucesso!");
                }
                else if (string.IsNullOrWhiteSpace(pessoaf.Nome) && salvar == "1"){
                    Console.WriteLine("voce nao preencheu todos os campos!!");
                }

                else
                {
                    Console.WriteLine("nao salvo");
                }
                break;

            case "2":
                PessoaJuridica juridica = new PessoaJuridica();
                Console.WriteLine("pessoa Juridica");
                juridica.Nome = "empresajss";
                juridica.Email = "empresajss@tesste";
                juridica.Cnpj = 166645121;
                juridica.Contato = "4123546";
                juridica.Localidade = "teste, terse321";

                Console.WriteLine("deseja salvar");
                Console.WriteLine("1 - sim, 2 - nao");
                string? salvarpf = Console.ReadLine();
                if (salvarpf == "1")
                {
                    File.WriteAllText("pessoa_juridica.txt",
                    $"{juridica.Nome},{juridica.Cnpj},{juridica.Email},{juridica.Contato},{juridica.Localidade}");
                    Console.WriteLine("Pessoa física salva com sucesso!");
                }
                else
                {
                    Console.WriteLine("nao salvo");
                }
                break;
            case "3":
                Console.WriteLine("saindo");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        
        }       
        
    }while (entrada != "3");
    

}
    
else
    {
        Console.WriteLine("preencha todos os campos");
    }


*/