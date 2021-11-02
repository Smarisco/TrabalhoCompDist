﻿using System;
using TrabalhoCompDist.Enum;
using TrabalhoCompDist.ValueObjects;
using prmToolkit.NotificationPattern;
using crabalhoCompDist.Extensões;
using TrabalhoCompDist.Recursos;
using TrabalhoCompDist.Entities.Base;

namespace TrabalhoCompDist.Entities
{
    public class Jogador : EntidadeBase
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
            Id = Guid.NewGuid();
            Status = EnumStatusJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 12);

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(nome, email);
        }
        public void AlterarJogador(Nome nome, Email email, EnumStatusJogador status)
        {
            Nome = nome;
            Email = email;

            new AddNotifications<Jogador>(this).IfFalse(Status == EnumStatusJogador.Ativo, Mensagens.JOGADOR__NAO_ATIVO);

            AddNotifications(nome, email);
        }

        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public EnumStatusJogador Status { get; set; }

        public override string ToString()
        {
            return this.Nome.PrimeiroNome + " " + this.Nome.UltimoNome;
        }

    }
}
