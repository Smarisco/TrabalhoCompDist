using System;
using System.Linq;
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
            request.Senha = "123456";

           //var response = service.AutenticarJogador(null);

            var response = service.AutenticarJogador(request);

            //testar se houve algum erro de validacao
            Console.WriteLine("Serviço é valido ->"+service.IsValid());
            service.Notifications.ToList().ForEach(x=>{
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();
        }
        
    }
}
