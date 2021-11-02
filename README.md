# TrabalhoCompDist
Necessário Habilitar o Migrations:
Utilizando o Visual Studio Community (2019): Ferramentas->Gerenciador de Pacotes Nuget-> Console do Gerenciador de Pacotes.
Selecionar a opção de infraqestrutura no Projeto Padrão e dar o seguinte comando.
PM> Enable-Migrations


Para visualização do Diagrama de Classe em anexo:

Se você não tiver instalado o componente do Designer de Classe, siga estas etapas para instalá-lo.

Abra o Instalador do Visual Studio no menu Iniciar do Windows ou selecionando Ferramentas > Obter Ferramentas e Recursos na barra de menus no Visual Studio.

O Instalador do Visual Studio é aberto.

Selecione a guia Componentes individuais e, em seguida, role para baixo até a categoria Ferramentas de código.

Selecione Designer de Classe e, em seguida, selecione Modificar.

O componente do Designer de Classe inicia a instalação.




Para Criar o Banco o comando no console deve ser:

Add-Migration CriandoBanco 


Pacotes a serem instalados:
Unity;
EntityFramework;
prmToolkit.NotificationPattern (para validação de menssagens);
Microsoft.AspNer.WebApi.Owin;
Microsoft.Owin.Host.System.Web;
Microsoft.Owin.Security.OAuth (para criar token);
Microsoft.Owin.Cors (Permissão de Acesso);

---

Dentro da pasta Jogador, por ter Classes diferentes de Request e Response para adicionar, alterar e autenticar, o sistema conta com uma melhor rastreabilidade

Não utilizamos entidades/classes anêmicas.
As classes não são apenas um DTO por onde trafegam informações

As regras de negócio, como por exemplo, o tamanho mínimo e máximo que deve ter uma senha, estão dentro das entidades/classes.
As próprias classes se validam.

Além disso, as classes tem seu set como privados para aumentar a segurança da aplicação
