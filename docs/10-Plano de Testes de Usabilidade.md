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
|    **Caso de Teste**    |                                                                                                                               **Cenário 1 – Criação de senha segura**                                                                                                                               |
| :---------------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| **Requisito Associado** |                                                                                                 RNF-01 – Senhas devem ter no mínimo 8 caracteres, incluindo letras, números e caracteres especiais.                                                                                                 |
|  **Objetivo do Teste**  |                                                                                                                              Avaliar a segurança na criação de senhas.                                                                                                                              |
|        **Passos**       | - Inserir senha com menos de 8 caracteres. <br> - Inserir senha sem caracteres especiais. <br> - Pesquisar por “notebook” e aplicar filtros (marca, preço, processador). <br> - Selecionar um notebook e acessar a página do produto. <br> - Tentar novamente até conseguir criar uma senha válida. |
|  **Critério de Êxito**  |                                                                                                                  O sistema aceita apenas senhas que atendem aos requisitos mínimos.                                                                                                                 |
|                         |                                                                                                                                                                                                                                                                                                     |


**Cenário 2**
|    **Caso de Teste**    |            **Cenário 2 – Tempo de carregamento**           |
| :---------------------: | :--------------------------------------------------------: |
| **Requisito Associado** |  RNF-02 – Página inicial deve carregar em até 3 segundos.  |
|  **Objetivo do Teste**  |     Avaliar o tempo de carregamento da página inicial.     |
|        **Passos**       | - Acessar o site.<br> - Abrir a página inicial do sistema. |
|  **Critério de Êxito**  |   A página deve carregar completamente em até 3 segundos.  |
|                         |                                                            |


**Cenário 3**
|    **Caso de Teste**    |                                                           **Cenário 3 – Compatibilidade entre navegadores e dispositivos**                                                          |
| :---------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| **Requisito Associado** |                                                     RNF-04 e RNF-05 – Compatibilidade e responsividade em múltiplas plataformas.                                                    |
|  **Objetivo do Teste**  |                                                                Testar compatibilidade em navegadores e dispositivos.                                                                |
|        **Passos**       | - Acessar o sistema em Chrome, Firefox, Edge e Safari.<br> - Acessar via desktop, tablet e smartphone.<br> - Navegar e executar funções básicas como cadastro e navegação em menus. |
|  **Critério de Êxito**  |                                        O layout permanece consistente e todas as funcionalidades operam corretamente em todas as plataformas.                                       |
|                         |                                                                                                                                                                                     |


**Cenário 4**
|    **Caso de Teste**    |                   **Cenário 4 – Consistência visual**                   |
| :---------------------: | :---------------------------------------------------------------------: |
| **Requisito Associado** |                RNF-07 – Consistência visual da interface.               |
|  **Objetivo do Teste**  |          Avaliar consistência visual e identidade das páginas.          |
|        **Passos**       | - Acessar pelo menos três páginas (inicial, cadastro, área do usuário). |
|  **Critério de Êxito**  | Cores, tipografia e layout permanecem consistentes em todas as páginas. |
|                         |                                                                         |


**Cenário 5**
|    **Caso de Teste**    |                              **Cenário 5 – Confiabilidade durante atualização**                              |
| :---------------------: | :----------------------------------------------------------------------------------------------------------: |
| **Requisito Associado** |                         RNF-09 – O sistema não deve perder dados durante atualização.                        |
|  **Objetivo do Teste**  |                    Avaliar confiabilidade do sistema durante e após atualização de versão.                   |
|        **Passos**       | - Simular atualização do sistema.<br> - Verificar se dados cadastrados permanecem íntegros após atualização. |
|  **Critério de Êxito**  |                                     Nenhum dado é perdido ou corrompido.                                     |
|                         |                                                                                                              |


**Cenário 6**
|    **Caso de Teste**    |                                                    **Cenário 6 – Acessibilidade via teclado**                                                    |
| :---------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------: |
| **Requisito Associado** |                                                RNF-011 – Acessibilidade por navegação via teclado.                                               |
|  **Objetivo do Teste**  |                                         Avaliar acessibilidade e navegabilidade usando apenas o teclado.                                         |
|        **Passos**       | - Realizar login usando apenas o teclado.<br> - Navegar por menus, formulários e botões usando TAB, Setas e ENTER.<br> - Acessar área de perfil. |
|  **Critério de Êxito**  |                   Todos os elementos são acessíveis por teclado; ordem lógica de navegação; tarefa concluída sem uso do mouse.                   |
|                         |                                                                                                                                                  |


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

