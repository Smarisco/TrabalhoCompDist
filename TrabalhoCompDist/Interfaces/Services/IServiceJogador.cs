using System;
using System.Collections.Generic;
using TrabalhoCompDist.Arguments.Base;
using TrabalhoCompDist.Arguments.Jogador;
using TrabalhoCompDist.Interfaces.Services.Base;

namespace TrabalhoCompDist.Interfaces.Services
{
    public interface IServiceJogador: IServiceBase
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionaJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
        ResponseBase ExcluirJogador(Guid id);
    }
}
