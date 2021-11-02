using prmToolkit.NotificationPattern;
using System;

namespace TrabalhoCompDist.Entities.Base
{
    public abstract class EntidadeBase : Notifiable
    {
        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
