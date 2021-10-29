using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using TrabalhoCompDist.Recursos;

namespace TrabalhoCompDist.ValueObjects
{
    public class Email:Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;
            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, Mensagens.X0_INVALIDO.ToFormat("Email"));
        }
        public string Endereco { get; private set; }
    }
}
