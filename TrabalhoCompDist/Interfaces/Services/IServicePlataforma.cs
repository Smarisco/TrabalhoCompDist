using TrabalhoCompDist.Arguments.Plataforma;

namespace TrabalhoCompDist.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse Adicionar(AdicionarPlataformaRequest request);
    }
}
