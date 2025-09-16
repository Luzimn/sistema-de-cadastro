using projetocsharp.models;
using Projetocsharp.services;
using Projetocsharp.servicesBoleto;
using System.Globalization;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("escolha uma das alternativas");
        Console.WriteLine("1 - executar cadastro de Usuario");
        Console.WriteLine("2 - executar cadastro de Boleto");
        string? resposta = Console.ReadLine();

        if(resposta == "1"){
            MenuCadastro.ExecutarMenu();
        }
        else if(resposta == "2"){
            MenuCadastroBoleto.ExecutarMenuBoleto();
        }
        else{
            Console.WriteLine("Digite uma opção valida");
            Console.WriteLine("o programa sera finalizado");
            Thread.Sleep(5000); 
            Environment.Exit(0); 
        }

    }
}



