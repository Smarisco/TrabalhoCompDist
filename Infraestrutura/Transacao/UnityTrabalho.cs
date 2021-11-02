using Infraestrutura.Persistencia;

namespace Infraestrutura.Transacao
{
    public class UnityTrabalho:IUnityTrabalho
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
