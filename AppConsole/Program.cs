using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Services;

namespace AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criando Instancia do Serviço.");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();

            Console.WriteLine("Criando Instancia Objeto.");

            request.Email = "Paulo@email";

            var response = service.AutenticarJogador(null);

            //var response = service.AutenticarJogador(request);
           
            Console.ReadKey();
        }
        
    }
}
