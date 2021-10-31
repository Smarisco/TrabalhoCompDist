using System;
using TrabalhoCompDist.Enum;
using TrabalhoCompDist.ValueObjects;
using prmToolkit.NotificationPattern;
using crabalhoCompDist.Extensões;

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

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6,12);

            Senha = Senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public EnumStatusJogador Status { get; private set; }
    }
}
