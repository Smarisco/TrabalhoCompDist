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

            //AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            //Console.WriteLine("Criando Instancia Objeto.");
            //request.Email = "Stela@gmail.com";
            //request.Senha = "123456789";


            var request = new AdicionaJogadorRequest()
            {
                Email = "Andre@gmail.com",
                Senha = "123456",
                PrimeiroNome = "Andre",
                UltimoNome = "Diogenes",

            };

            var response = service.AdicionarJogador(request);
            //var response = service.AutenticarJogador(request);

            //testar se houve algum erro de validacao
            Console.WriteLine("Serviço é valido ->" + service.IsValid());
            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();
        }

    }
}
