using TrabalhoCompDist.Arguments.Plataforma;
using TrabalhoCompDist.Interfaces.Services.Base;

namespace TrabalhoCompDist.Interfaces.Services
{
    public interface IServicePlataforma :IServiceBase
    {
        AdicionarPlataformaResponse Adicionar(AdicionarPlataformaRequest request);
    }
}
