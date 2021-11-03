using System;
using System.Collections.Generic;
using TrabalhoCompDist.Arguments.Base;
using TrabalhoCompDist.Arguments.Jogo;
using TrabalhoCompDist.Interfaces.Services.Base;

namespace TrabalhoCompDist.Interfaces.Services
{
    public interface IServiceJogo : IServiceBase
    {
        IEnumerable<JogoResponse> ListarJogo();

        AdiconarJogoResponse AdicionarJogo(AdicionarJogoRequest request);

        ResponseBase AlterarJogo(AlterarJogoResquest request);

        ResponseBase ExcluirJogo(Guid id);
    }
}
