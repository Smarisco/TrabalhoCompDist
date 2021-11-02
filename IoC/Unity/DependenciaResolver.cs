using Infraestrutura.Persistencia;
using Infraestrutura.Persistencia.Repositorio;
using Infraestrutura.Persistencia.Repositorio.Base;
using Infraestrutura.Transacao;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using TrabalhoCompDist.Interfaces.Repositories;
using TrabalhoCompDist.Interfaces.Repositories.Base;
using TrabalhoCompDist.Interfaces.Services;
using TrabalhoCompDist.Services;
using Unity;
using Unity.Lifetime;

namespace InversaoDeControle.Unity
{
    public static class DependenciaResolver 
    {
        public static void Resolve(UnityContainer container)
        {
            
            container.RegisterType<DbContext, Contexto>(new HierarchicalLifetimeManager());
            //Para Salvar no Banco
            //container.RegisterType<IUnityTrabalho, UnityTrabalho>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceJogador, ServiceJogador>(new HierarchicalLifetimeManager());
            //container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());

            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryJogador, RepositoryJogador>(new HierarchicalLifetimeManager());
            // container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());


        }
    }
}
