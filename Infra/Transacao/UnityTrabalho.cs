using Infra.Persistencia;
namespace Infra.Transacao
{
    public class UnityTrabalho : IUnityTrabalho
    {
        private readonly Contexto _context;
        public UnityTrabalho(Contexto context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

    }
}
