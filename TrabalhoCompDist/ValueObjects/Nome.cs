using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using TrabalhoCompDist.Recursos;

namespace TrabalhoCompDist.ValueObjects
{
    public class Nome: Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, Mensagens.X0_INVALIDA.ToFormat(" "))
                .IfNullOrInvalidLength(x => x.UltimoNome, 3, 50, Mensagens.X0_INVALIDA.ToFormat(" "));
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
