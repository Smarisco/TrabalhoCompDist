using System;
using TrabalhoCompDist.Enum;
using TrabalhoCompDist.ValueObjects;
using prmToolkit.NotificationPattern;

namespace TrabalhoCompDist.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {
        }
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;
            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha tem que ter entre 6 e 32 caracteres.");

        }

        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; private set; }
        public EnumStatusJogador Status { get; set; }
    }
}
