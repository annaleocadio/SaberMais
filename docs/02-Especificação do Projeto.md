# Especificações do Projeto

Este documento descreve os principais elementos para o desenvolvimento de uma aplicação interativa de recomendações e avaliações de cursos online e presenciais, voltada para estudantes, professores, profissionais em transição de carreira, instituições de ensino e usuários em geral.

A plataforma tem como objetivo facilitar o acesso a cursos confiáveis, centralizar recomendações e permitir a interação entre diferentes perfis de usuários, promovendo um ambiente de credibilidade e engajamento.

Neste documento apresentamos uma visão geral das Personas, Histórias de Usuários, Requisitos e do Diagrama de Casos de Uso.

## Personas

<img src="/docs/img/1JoaoHenrique.png" alt="Persona1"/>

<img src="/docs/img/2MariaClara.png" alt="Persona2"/>

<img src="/docs/img/3CarlosAlberto.png" alt="Persona3"/>

<img src="/docs/img/4EducarMais.png" alt="Persona4"/>

<img src="/docs/img/5AnaBeatriz.png" alt="Persona5"/>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| João Henrique | Quero filtrar cursos por área de interesse para encontrar rapidamente formações relevantes. | Ter agilidade na procura dos cursos de meu interesse. |
| João Henrique | Quero salvar cursos favoritos para poder acessá-los facilmente depois. | Que achar meus cursos favoritos com mais facilidade.|
| Maria Clara | Como professora, quero adicionar recomendações de cursos para meus alunos para ajudá-los a acessar conteúdos de qualidade.| Melhoria na qualidade de cursos divulgados nas plataformas|
| Maria Clara | Como professora, quero ver quais alunos acessaram ou interagiram com minhas recomendações para acompanhar o engajamento.| Facilitar o compartilhamento das minhas recomendações|
| Carlos Alberto | Como profissional em transição de carreira, quero visualizar avaliações e comentários de outros usuários para escolher cursos confiáveis.| Para encontrar cursos confiáveis que auxiliem em uma mudança de carreira|
| Carlos Alberto | Como profissional em transição de carreira, quero comparar cursos similares para decidir qual é mais adequado para meus objetivos com base nas avaliações.| Quero ver qual é adequado com o que eu busco para a minha carreira com comentários de usúarios|
|Instituto Educar+|Como instituição de ensino, quero divulgar meus cursos na plataforma para alcançar alunos interessados e aumentar minha visibilidade.|Quero mais visibilidade para a minha instituição|
|Instituto Educar+|Como instituição de ensino, quero acessar relatórios de engajamento das minhas recomendações para entender quais cursos têm maior interesse.|Quero ver o meu alcance e quais cursos são mais bem avaliados.|
|Ana Beatriz|Como usuária da plataforma, quero compartilhar recomendações de cursos que já fiz para ajudar outras pessoas a encontrarem cursos confiáveis.|Quero compartilhar cursos com quem usa a plataforma|
|Ana Beatriz|Como usuária da plataforma, quero seguir recomendações de outros usuários com interesses semelhantes para descobrir novos cursos relevantes. |Quero acompanhar os conteúdos que meus amigos recomendam|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. | ALTA |
|RF-02| O sistema deve permitir que o usuário visualize e edite seus dados cadastrais, incluindo nome e foto de perfil. | MÉDIA |
|RF-03| O sistema deve permitir que um usuário cadastre um item, informando nome, descrição, categoria, localização e imagens e documentos. | ALTA |
|RF-04| O sistema deve permitir que edite ou exclua um item previamente cadastrado. | ALTA |
|RF-05| O sistema deve permitir que um usuário busque itens disponíveis por categoria, localização, palavra-chave, faixa de preço e data de publicação. | MÉDIA |
|RF-06| O sistema deve exibir uma lista de itens disponíveis na página inicial, organizados por categorias. | ALTA |
|RF-07| O sistema deve permitir escolher cursos presencias ou online. | ALTA |
|RF-08| O sistema deve confirmar o envio de documento seja em Ebook, PDF, ou de forma presencial. | ALTA |
|RF-09| O sistema deve permitir que o receptor marque o item como "Recebido" após a entrega ou venda efetuada. | MÉDIA |
|RF-010| O sistema deve permitir que os usuários avaliem cursos e empresas com notas e comentários. | MÉDIA |
|RF-011| O sistema deve permitir que administradores revisem denúncias de itens ou usuários e tomem ações como remoção de conteúdo ou suspensão de contas.| MÉDIA |
|RF-012| O sistema deve impedir que um usuário banido crie uma nova conta com o mesmo e-mail e CPF. | MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O sistema deve exigir que a senha tenha no mínimo 8 caracteres, incluindo letras, números e caracteres especiais. | MÉDIA |  
|RNF-02| O sistema deve suportar pelo menos 100 acessos simultâneos sem perda significativa de desempenho. | ALTA |  
|RNF-03| O sistema deve possuir interface responsiva, adaptando-se a diferentes tamanhos de tela (desktop, tablet e celular). | MÉDIA | 
|RNF-04| A aplicação deve manter uma identidade visual consistente em todas as páginas, considerando a paleta de cores, a tipografia e o layout. | ALTA | 
|RNF-05| O sistema deve ser desenvolvido em linguagem C# com .NET, garantindo compatibilidade com servidores que utilizem essa tecnologia. | MÉDIA | 
|RNF-06| O sistema deve seguir as diretrizes de acessibilidade WCAG 2.1, permitindo navegação por teclado e suporte a leitores de tela. | MÉDIA |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| Todo curso exibido deve conter ao menos título, descrição e uma imagem. |
|02| As avaliações e comentários dos usuários devem ser exibidos de forma clara junto ao curso. |
|03| O sistema recomendará apenas cursos de plataformas parceiras previamente definidas (ex.: Udemy, Coursera, Alura). |
|04| O projeto deve ser finalizado até o fim do semestre letivo. |
|05| O desenvolvimento será realizado apenas pelos integrantes do grupo, sem contratação de terceiros. |
|06| O projeto deverá priorizar tecnologias gratuitas ou já disponíveis para os desenvolvedores. |

## Diagrama de Casos de Uso

![Imagem do Diagrama](https://github.com/user-attachments/assets/236cb8b3-634c-4c02-a011-284ae7a9d6ea)

| Ator | Descrição                                               |
| ---- | ------------------------------------------------------- |
| Usuário | O usuário se cadastra na plataforma informando e-mail, senha, CPF/CNPJ, nome completo e tipo de pessoa (física/jurídica). (RF-01) |
| Usuário | O usuário faz login com e-mail e senha ou recupera a senha caso tenha esquecido. (RF-01) |
| Usuário | O usuário gerencia seu perfil, podendo editar dados cadastrais (nome) e alterar sua foto de perfil. (RF-02) |
| Usuário | O usuário cadastra um curso informando título, descrição, valor, modalidade (presencial/online), e faz upload de imagem e material (PDF/eBook). (RF-03, RF-07, RF-08)  |
| Usuário | O usuário edita ou exclui um curso previamente cadastrado por ele. (RF-04)  |
| Usuário | O usuário pesquisa cursos disponíveis filtrando por categoria, localização, palavra-chave, faixa de preço e data de publicação. (RF-05) |
| Usuário | O usuário visualiza a lista de cursos disponíveis na página inicial, organizados por categorias. (RF-06) |
| Usuário | O usuário visualiza o perfil completo de outro usuário, incluindo foto, nome, e avaliações recebidas com média de notas. (RF-010)  |
| Usuário | O usuário avalia outro usuário dando uma nota de 1 a 5 estrelas e opcionalmente deixando um comentário. (RF-010) |
| Usuário | O usuário envia mensagens privadas para outros usuários, recebe mensagens, lê mensagens recebidas e exclui mensagens.  |
| Usuário | O sistema notifica o usuário sobre novos cursos cadastrados e exibe contador de mensagens não lidas no menu.  |
| Usuário | O usuário marca um curso como "Recebido" após confirmar a entrega ou conclusão do curso. (RF-09) |
| Usuário | O usuário denuncia outros usuários ou cursos inadequados para revisão administrativa. (RF-011) |
| Administrador | O administrador visualiza, gerencia e pode excluir cursos cadastrados na plataforma. |
| Administrador | O administrador revisa denúncias de usuários ou cursos e toma ações como remoção de conteúdo. (RF-011) |
| Administrador | O administrador suspende ou bane usuários problemáticos, bloqueando acesso por e-mail e CPF. (RF-011, RF-012)  |
| Administrador | O administrador pode excluir permanentemente contas de usuários. |
| Administrador | O super administrador pode criar novos administradores e excluir administradores existentes (exceto super admins). |
| Sistema| O sistema envia notificações automáticas aos usuários quando novos cursos são cadastrados. |
| Sistema | O sistema exibe um contador de mensagens não lidas no ícone de mensagens do menu de navegação.  |
