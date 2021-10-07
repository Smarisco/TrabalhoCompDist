using System;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Services;

namespace TrabalhoCompDist.Services
{
    class ServiceJogador : IServiceJogador
    {
        //inversão de controle
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }
        public AdicionarJogadorResponse AdicionarJogador(AdicionaJogadorRequest request)
        {
            Guid id = _repositoryJogador.AdicionarJogador(request);
            return new AdicionarJogadorResponse() { Id = id, Mensagem = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("Autenticar jogador é obrigatório");
            }
            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um e-mail");
            }
            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um e-mail");
            }
            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma senha");
            }
            if (request.Senha.Length<6)
            {
                throw new Exception("Digite uma senha com mais de 6 caracteres");
            }
           var response = _repositoryJogador.AutenticarJogador(request);
            return response;

        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
