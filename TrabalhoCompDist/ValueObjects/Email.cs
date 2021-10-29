using prmToolkit.NotificationPattern;

namespace TrabalhoCompDist.ValueObjects
{
    public class Email:Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;
            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco);
        }
        public string Endereco { get; private set; }
    }
}
