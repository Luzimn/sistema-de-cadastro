using projetocsharp.models;

Console.WriteLine("todos os campos preenchidos?");
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
                pessoaf.Nome = "lucas";
                pessoaf.Idade = 19;
                pessoaf.CpfRg = 124563;
                pessoaf.Email = "teste@teste";
                pessoaf.Contato = "196548726";
                pessoaf.Localidade = "barrio teste, 423";
                
                Console.WriteLine("deseja salvar");
                Console.WriteLine("1 - sim, 2 - nao");
                string? salvar = Console.ReadLine();
                if (salvar == "1")
                {
                    File.WriteAllText("pessoa_fisica.txt",
                    $"{pessoaf.Nome},{pessoaf.Idade},{pessoaf.CpfRg},{pessoaf.Email},{pessoaf.Contato},{pessoaf.Localidade}");
                    Console.WriteLine("Pessoa física salva com sucesso!");
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


