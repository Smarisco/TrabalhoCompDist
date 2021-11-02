using System;
using System.Collections.Generic;
using TrabalhoCompDist.Arguments.Base;
using TrabalhoCompDist.Arguments.Jogador;


namespace TrabalhoCompDist.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionaJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
        ResponseBase ExcluirJogador(Guid id);
    }
}
