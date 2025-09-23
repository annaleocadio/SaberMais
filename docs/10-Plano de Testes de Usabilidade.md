# Plano de Testes de Usabilidade

Os testes de usabilidade permitem avaliar a qualidade da interface com o usuário da aplicação interativa.

Um plano de teste de usabilidade deverá conter: 

## Definição do(s) objetivo(s)

Antes de iniciar os testes, é essencial definir o que se deseja avaliar na usabilidade do sistema. 
Alguns exemplos de objetivos são:
- Verificar se os usuários conseguem interagir com o sistema de forma eficiente e segura.
- Avaliar se o tempo de resposta e carregamento atende às expectativas.
- Identificar possíveis barreiras de acessibilidade e compatibilidade em diferentes dispositivos e navegadores.
- Testar a clareza da interface, consistência visual e responsividade.
- Validar a conformidade do sistema com os requisitos de desempenho e segurança.

## Seleção dos participantes

Para garantir que o teste reflita o uso real do sistema, escolha participantes representativos do público-alvo.

**Critérios para selecionar participantes:**
- Perfis variados (experientes e iniciantes no sistema).
- Diferentes níveis de familiaridade com tecnologia.
- Pessoas com necessidades especiais (Navegação apenas por teclado).

**Quantidade recomendada:**
Mínimo: 15 participantes.
Ideal: Entre 16 e 25 para maior diversidade.

## Definição de cenários de teste

Os cenários representam tarefas reais que os usuários executam no sistema. Cada cenário deve incluir:

- Objetivo: O que será avaliado.
- Contexto: A situação que leva o usuário a interagir com o sistema.
- Tarefa: A ação que o usuário deve realizar.
- Critério de sucesso: Como determinar se a tarefa foi concluída corretamente.

**Cenário 1**

**Objetivo:**
- Avaliar a segurança na criação de senhas.

**Contexto:**
- O usuário deseja criar uma conta no sistema.

**Tarefa(s):** 
- Inserir senha com menos de 8 caracteres.
- Pesquisar por "notebook" e utilizar os filtros para refinar a busca (exemplo: marca, preço, processador).
- Escolher um dos notebooks listados e acessar a página do produto.
- Depois senha sem caracteres especiais , até conseguir criar uma senha válida.

**Critério(s) de Sucesso(s):**
- O sistema só aceita senhas que tenham no mínimo 8 caracteres, incluindo letras, números e caracteres especiais (RNF-01).

**Cenário 2**

**Objetivo:**
- Avaliar o tempo de carregamento da página inicial.

**Contexto:**
- O usuário acessa o site pela primeira vez em uma conexão comum de internet.

**Tarefa(s):** 
- Abrir a página inicial do sistema.

**Critério(s) de Sucesso(s):**
- Página carregada em até 3 segundos (RNF-02).

**Cenário 3**

**Objetivo:**
- Testar compatibilidade entre navegadores e dispositivos.

**Contexto:**
- Diferentes usuários acessam o site em navegadores (Chrome, Firefox, Edge, Safari) e dispositivos (desktop, tablet e smartphone).

**Tarefa(s):** 
- Navegar pelo sistema e executar funções básicas (cadastro, navegação de menus).
  
**Critério(s) de Sucesso(s):**
- O sistema mantém funcionamento correto e layout consistente em todas as plataformas (RNF-04 e RNF-05).

**Cenário 4**

**Objetivo:**
- Avaliar consistência visual e identidade da interface.

**Contexto:**
- O usuário navega entre diferentes páginas do sistema.

**Tarefa(s):** 
- Acessar pelo menos três páginas distintas (ex.: inicial, cadastro, área de usuário).
  
**Critério(s) de Sucesso(s):**
- Paleta de cores, tipografia e layout permanecem consistentes em todas as telas (RNF-07).

**Cenário 5**

**Objetivo:**
- Avaliar a confiabilidade do sistema durante o processo de atualização.

**Contexto:**
- O administrador precisa atualizar o sistema para uma nova versão sem perder dados já cadastrados.

**Tarefa(s):** 
- Simular uma atualização de versão do sistema.
- Após a atualização, verificar se os dados previamente armazenados continuam disponíveis e íntegros.
  
**Critério(s) de Sucesso(s):**
- Nenhum dado é perdido ou corrompido durante/apos a atualização (RNF-09).

**Cenário 6**

**Objetivo:**
- Avaliar a acessibilidade do sistema por meio de navegação apenas com teclado.

**Contexto:**
- Um usuário que não utiliza mouse deseja navegar pelo sistema utilizando somente o teclado.

**Tarefa(s):** 
- Realizar login utilizando apenas teclado.
- Navegar entre menus, formulários e botões por meio de TAB, setas e ENTER.
- Finalizar uma ação simples, como acessar a área de perfil.
  
**Critério(s) de Sucesso(s):**
- Todos os elementos interativos são acessíveis via teclado.
- A ordem de navegação segue um fluxo lógico.
- O usuário consegue concluir a tarefa sem necessidade do mouse (RNF-011).

## Métodos de coleta de dados

Os dados coletados devem ajudar a entender a experiência dos usuários.
Serão utilizados:

- **Métricas quantitativas:**
   - Tempo gasto para cada tarefa.
   - Número de cliques/teclas até completar a ação.
   - Número de erros cometidos.
- **Métricas qualitativas:**
   - Comentários e dificuldades relatadas.
   - Observação direta do comportamento do usuário.
- **Questionário pós-teste:**
   - A interface foi fácil de entender?
   - Você encontrou dificuldades em alguma etapa?
   - O que poderia ser melhorado?


⚠️ Em conformidade com a LGPD, nenhum dado pessoal identificável dos participantes será armazenado ou publicado.

