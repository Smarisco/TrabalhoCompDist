using prmToolkit.NotificationPattern;
using System;
using TrabalhoCompDist.Entities.Base;
using TrabalhoCompDist.Recursos;

namespace TrabalhoCompDist.Entities
{
    public class Jogos : EntidadeBase
    {
        protected Jogos()
        {

        }
        public Jogos(string nome, string descricao, string produtora, string distribuidora, string genero, string site)
        {
            NomeJogo = nome;
            DescricaoJogo = descricao;
            Produtora = produtora;
            Distribuidora = distribuidora;
            Genero = genero;
            Site = site;

            ValidarEntidade();


        }

        private void ValidarEntidade()
        {
            new AddNotifications<Jogos>(this)
                .IfNullOrInvalidLength(x => x.NomeJogo, 10,256)
                .IfNullOrInvalidLength(x => x.DescricaoJogo, 1, 255)
                .IfNullOrInvalidLength(x => x.Genero, 1, 30);
        }

        public void Alterar(string nome, string descricao, string produtora, string distribuidora, string genero, string site)
        {
            NomeJogo = nome;
            DescricaoJogo = descricao;
            Produtora = produtora;
            Distribuidora = distribuidora;
            Genero = genero;
            Site = site;

            ValidarEntidade();

        }
        public string NomeJogo { get; set; }
        public string DescricaoJogo { get; set; }
        public string Produtora { get; set; }
        public string Distribuidora { get; set; }
        public string Genero { get; set; }
        public string Site { get; set; }
    }
}
