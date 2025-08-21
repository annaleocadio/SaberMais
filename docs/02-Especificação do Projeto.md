# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

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

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário avalie uma agência de intercâmbio com base na sua experiência. | MÉDIA | 
|RF-002| A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de intercâmbio. | MÉDIA |
|RF-003| A aplicação deve permitir que o usuário consulte todas as agências de intercâmbio cadastradas ordenando-as com base em suas notas.| ALTA |
|RF-004| O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. | ALTA |
|RF-005| O sistema deve enviar um e-mail de confirmação para ativação da conta após o cadastro. | ALTA |
|RF-006| O sistema deve permitir que o usuário visualize e edite seus dados cadastrais, incluindo nome, foto de perfil e localização aproximada. | MÉDIA |
|RF-007| O sistema deve permitir que um usuário cadastre um item, informando nome, descrição, categoria, localização e imagens. | ALTA |
|RF-008| O sistema deve permitir que edite ou exclua um item previamente cadastrado. | ALTA |
|RF-009| O sistema deve permitir que um usuário busque itens disponíveis por categoria, localização, palavra-chave, faixa de preço e data de publicação. | MÉDIA |
|RF-010| O sistema deve exibir uma lista de itens disponíveis na página inicial, organizados por categorias. | ALTA |
|RF-011| O sistema deve permitir escolher cursos presencias ou online. | ALTA |
|RF-012| O sistema deve confirmar o envio de documento seja em Ebook, PDF, ou de forma presencial. | ALTA |
|RF-013| O sistema deve permitir que o usuário siga outros usuários para acompanhar suas recomendações e avaliações. | ALTA |
|RF-014| A aplicação deve permitir que os usuários troquem mensagens entre si. | ALTA |
|RF-015| O sistema deve permitir que o receptor marque o item como "Recebido" após a entrega ou venda efetuada. | MÉDIA |
|RF-016| O sistema deve permitir que os usuários avaliem cursos e empresas com notas e comentários. | MÉDIA |
|RF-017| O sistema deve permitir que administradores revisem denúncias de itens ou usuários e tomem ações como remoção de conteúdo ou suspensão de contas.| MÉDIA |
|RF-018| O sistema deve impedir que um usuário banido crie uma nova conta com o mesmo e-mail e CPF. | MÉDIA |
|RF-019| Acessar relatórios de engajamento das minhas recomendações para entender quais cursos têm maior interesse. | MÉDIA |




### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva. | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s. |  BAIXA | 
|RNF-003| O sistema deve exigir que a senha tenha no mínimo 8 caracteres, incluindo letras, números e caracteres especiais. | MÉDIA | 
|RNF-004| O sistema deve carregar a página inicial em no máximo 3 segundos em conexões comuns. | MÉDIA | 
|RNF-005| O sistema deve suportar pelo menos 100 acessos simultâneos sem perda significativa de desempenho. | ALTA | 
|RNF-006| O sistema deve ser compatível com os principais navegadores web (como Google Chrome, Mozilla Firefox, Safari e Microsoft Edge) e dispositivos móveis (smartphones e tablets). | ALTA | 
|RNF-007| O sistema deve possuir interface responsiva, adaptando-se a diferentes tamanhos de tela (desktop, tablet e celular). | MÉDIA | 
|RNF-008| A aplicação deve garantir a proteção dos dados pessoais e financeiros dos usuários por meio de criptografias SSL/TLS para transações seguras. | ALTA | 
|RNF-009| A aplicação deve manter uma identidade visual consistente em todas as páginas, considerando a paleta de cores, a tipografia e o layout. | ALTA | 
|RNF-010| O sistema deve ser desenvolvido em linguagem C# com .NET, garantindo compatibilidade com servidores que utilizem essa tecnologia. | MÉDIA | 
|RNF-011| O sistema deve permitir atualização sem comprometer dados já armazenados. | MÉDIA | 
|RNF-012| O sistema deve realizar backups automáticos dos dados diariamente para evitar perda de informações em caso de falha. | MÉDIA |
|RNF-013| O sistema deve seguir as diretrizes de acessibilidade WCAG 2.1, permitindo navegação por teclado e suporte a leitores de tela. | MÉDIA |



Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |
|03| Exibir claramente as avaliações e comentários dos usuários |
|04| Implementar um sistema de verificação de cursos, com fotos e descrições detalhadas. |
|05| Implementar um sistema de verificação de produtos (curso), com fotos, documentos e descrições detalhadas. |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
