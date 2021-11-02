using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Transacao
{
    class UnityTrabalho : IUnityTrabalho
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
