# Especificações do Projeto

Este documento descreve os principais elementos para o desenvolvimento de uma aplicação interativa de recomendações e avaliações de cursos online e presenciais, voltada para estudantes, professores, profissionais em transição de carreira, instituições de ensino e usuários em geral.

A plataforma tem como objetivo facilitar o acesso a cursos confiáveis, centralizar recomendações e permitir a interação entre diferentes perfis de usuários, promovendo um ambiente de credibilidade e engajamento.

Neste documento apresentamos uma visão geral das Personas, Histórias de Usuários, Requisitos e do Diagrama de Casos de Uso.

## Personas

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/1JoaoHenrique.png" alt="Persona1"/>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/2MariaClara.png" alt="Persona2"/>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/3CarlosAlberto.png" alt="Persona3"/>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/4EducarMais.png" alt="Persona4"/>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/5AnaBeatriz.png" alt="Persona5"/>

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
|RF-02| O sistema deve enviar um e-mail de confirmação para ativação da conta após o cadastro. | ALTA |
|RF-03| O sistema deve permitir que o usuário visualize e edite seus dados cadastrais, incluindo nome, foto de perfil e localização aproximada. | MÉDIA |
|RF-04| O sistema deve permitir que um usuário cadastre um item, informando nome, descrição, categoria, localização e imagens. | ALTA |
|RF-05| O sistema deve permitir que edite ou exclua um item previamente cadastrado. | ALTA |
|RF-06| O sistema deve permitir que um usuário busque itens disponíveis por categoria, localização, palavra-chave, faixa de preço e data de publicação. | MÉDIA |
|RF-07| O sistema deve exibir uma lista de itens disponíveis na página inicial, organizados por categorias. | ALTA |
|RF-08| O sistema deve permitir escolher cursos presencias ou online. | ALTA |
|RF-09| O sistema deve confirmar o envio de documento seja em Ebook, PDF, ou de forma presencial. | ALTA |
|RF-010| O sistema deve permitir que o usuário siga outros usuários para acompanhar suas recomendações e avaliações. | ALTA |
|RF-011| O sistema deve permitir que o receptor marque o item como "Recebido" após a entrega ou venda efetuada. | MÉDIA |
|RF-012| O sistema deve permitir que os usuários avaliem cursos e empresas com notas e comentários. | MÉDIA |
|RF-013| O sistema deve permitir que administradores revisem denúncias de itens ou usuários e tomem ações como remoção de conteúdo ou suspensão de contas.| MÉDIA |
|RF-014| O sistema deve impedir que um usuário banido crie uma nova conta com o mesmo e-mail e CPF. | MÉDIA |
|RF-015| Acessar relatórios de engajamento das minhas recomendações para entender quais cursos têm maior interesse. | MÉDIA |




### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O sistema deve exigir que a senha tenha no mínimo 8 caracteres, incluindo letras, números e caracteres especiais. | MÉDIA | 
|RNF-02| O sistema deve carregar a página inicial em no máximo 3 segundos, considerando conexões comuns de acesso à internet. | MÉDIA | 
|RNF-03| O sistema deve suportar pelo menos 100 acessos simultâneos sem perda significativa de desempenho. | ALTA | 
|RNF-04| O sistema deve ser compatível com os principais navegadores web (como Google Chrome, Mozilla Firefox, Safari e Microsoft Edge) e dispositivos móveis (smartphones e tablets). | ALTA | 
|RNF-05| O sistema deve possuir interface responsiva, adaptando-se a diferentes tamanhos de tela (desktop, tablet e celular). | MÉDIA | 
|RNF-06| A aplicação deve garantir a proteção dos dados pessoais e financeiros dos usuários por meio de criptografias SSL/TLS para transações seguras. | ALTA | 
|RNF-07| A aplicação deve manter uma identidade visual consistente em todas as páginas, considerando a paleta de cores, a tipografia e o layout. | ALTA | 
|RNF-08| O sistema deve ser desenvolvido em linguagem C# com .NET, garantindo compatibilidade com servidores que utilizem essa tecnologia. | MÉDIA | 
|RNF-09| O sistema deve permitir atualização sem comprometer dados já armazenados. | MÉDIA | 
|RNF-010| O sistema deve realizar backups automáticos dos dados diariamente para evitar perda de informações em caso de falha. | MÉDIA |
|RNF-011| O sistema deve seguir as diretrizes de acessibilidade WCAG 2.1, permitindo navegação por teclado e suporte a leitores de tela. | MÉDIA |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |
|03| Exibir claramente as avaliações e comentários dos usuários |
|04| Implementar um sistema de verificação de cursos, com fotos e descrições detalhadas. |
|05| Implementar um sistema de verificação de produtos (curso), com fotos, documentos e descrições detalhadas. |



## Diagrama de Casos de Uso
![442520690-fe012f9e-3a33-4ac5-8643-a7d1578a85a4](https://github.com/user-attachments/assets/2560f71a-2820-4b90-b8fb-200bab5bcde9)

| Ator | Descrição                                               |
| ---- | ------------------------------------------------------- |
| Usuário | O usuário se cadastra na plataforma para poder acessar suas funcionalidades. |
| Usuário | O usuário faz login ou recupera a senha se necessário. |
| Professor e Instituição | O doador cadastra um item disponível para doação. |
| Usuário  | O doador pode editar ou excluir um item que já cadastrou. |
| Receptor | O usuário busca itens disponíveis para doação. |
| Receptor | O usuário solicita um item a um doador. |
| Instituição e Receptor | Os usuários podem conversar para combinar a doação. |
| Usuário | O sistema notifica o usuário sobre atividades relevantes. |
| Usuário  e Receptor | O doador pode indicar como prefere entregar o item. |
| Receptor | O receptor confirma que recebeu um item. |
| Usuário | Após uma doação, o usuário pode avaliar a experiência. |
| Usuário | O usuário pode denunciar problemas na plataforma. |
| Administrador | O administrador verifica e gerencia anúncios na plataforma. |
| Administrador | O administrador pode suspender ou banir usuários problemáticos. |


