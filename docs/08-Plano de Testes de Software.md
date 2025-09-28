# Plano de Testes de Software

| **Caso de Teste** 	| **CT01 – Cadastro de usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 – O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar uma conta corretamente utilizando e-mail e senha válidos. |
| Passos 	| - Acessar a tela de cadastro. <br> - Inserir e-mail válido.  - Inserir senha válida. <br> - Confirmar senha. <br> - Clicar em “Cadastrar”. |
| Critério de Êxito | - O sistema cria a conta e exibe uma mensagem de sucesso ou redireciona para a tela de confirmação de e-mail. |
|  	|  	|

| **Caso de Teste** 	| **CT02 – Confirmação de e-mail** 	|
|:---:	|:---:	|
| Requisito Associado | RF-02 – O sistema deve enviar um e-mail de confirmação para ativação da conta após o cadastro. |
| Objetivo do Teste 	| Garantir que o usuário receba o e-mail de ativação e consiga ativar a conta. |
| Passos 	| - Realizar o cadastro de um novo usuário. <br> - Acessar o e-mail cadastrado. <br> - Abrir o e-mail de confirmação. <br> - Clicar no link de ativação. |
| Critério de Êxito | - A conta é ativada e o usuário é redirecionado para a tela de login ou página inicial. |
|  	|  	|
| **Caso de Teste** 	| **CT03 – Visualização e edição de dados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 – Visualização e edição de dados |
| Objetivo do Teste 	| Garantir que o usuário consiga visualizar e atualizar suas informações cadastrais. |
| Passos 	| - Efetuar login. <br> - Acessar perfil. <br> - Alterar nome, foto e localização. <br> - Salvar alterações. <br> - Reabrir perfil para conferir. |
| Critério de Êxito | - Alterações são salvas e exibidas corretamente. |
|  	|  	|
| **Caso de Teste** 	| **CT04 – Cadastro de item** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-04 – Visualização e edição de dados |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um item informando todas as informações necessárias. |
| Passos 	| - Efetuar login. <br> - Acessar seção “Cadastrar Item”. <br> - Inserir nome, descrição, categoria, localização e imagens. <br> - Salvar cadastro. |
| Critério de Êxito | - Item é salvo corretamente e aparece na lista de itens. |
|  	|  	|
| **Caso de Teste** 	| **CT05 – Edição/Exclusão de item** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 – Edição/Exclusão de item |
| Objetivo do Teste 	| Garantir que o usuário consiga editar ou excluir um item previamente cadastrado. |
| Passos 	| - Efetuar login. <br> - Acessar lista de itens. <br> - Selecionar item. <br> - Editar ou excluir item. <br> - Confirmar ação. |
| Critério de Êxito | - Item é atualizado ou removido com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT06 – Busca de itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-06 – Busca de itens |
| Objetivo do Teste 	| Garantir que o usuário consiga buscar itens por categoria, localização, palavra-chave, faixa de preço e data. |
| Passos 	| - Efetuar login. <br> - Acessar tela de busca. <br> - Inserir filtros (categoria, localização, etc.). <br> - Iniciar busca. |
| Critério de Êxito | - Resultados exibidos correspondem aos filtros aplicados. |
|  	|  	|
| **Caso de Teste** 	| **CT07 – Listagem de Itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 – Lista de itens na página inicial |
| Objetivo do Teste 	| Verificar se a página inicial exibe lista de itens organizados por categorias. |
| Passos 	| - Acessar página inicial. <br> - Observar listagem de itens. |
| Critério de Êxito | - Itens aparecem agrupados por categoria corretamente. |
|  	|  	|
| **Caso de Teste** 	| **CT08 – Escolha de cursos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-08 – Escolha de cursos |
| Objetivo do Teste 	| Garantir que o usuário consiga escolher cursos presenciais ou online. |
| Passos 	| - Acessar tela de cursos. <br> - Selecionar modalidade (presencial ou online). <br> - Confirmar escolha. |
| Critério de Êxito | - Curso selecionado é exibido com a modalidade correta. |
|  	|  	|
| **Caso de Teste** 	| **CT09 – Confirmação de envio** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-09 – Confirmação de envio de documento |
| Objetivo do Teste 	| Verificar se o sistema confirma o envio de documentos (Ebook, PDF ou presencial). |
| Passos 	| - Enviar documento via sistema. <br> - Confirmar tipo de envio. <br> - Aguardar confirmação. |
| Critério de Êxito | - Sistema confirma envio corretamente de acordo com o tipo de documento. |
|  	|  	|
| **Caso de Teste** 	| **CT10 – Seguir usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-010 – Seguir usuários |
| Objetivo do Teste 	| Garantir que o usuário consiga seguir outros usuários. |
| Passos 	| - Acessar perfil de outro usuário. <br> - Clicar em “Seguir”. |
| Critério de Êxito | - Sistema atualiza lista de usuários seguidos e exibe confirmação. |
|  	|  	|
| **Caso de Teste** 	| **CT11 – Marcar recebimento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-011 – Marcar item como “Recebido” |
| Objetivo do Teste 	| Verificar se o receptor consegue marcar item como recebido após entrega ou venda. |
| Passos 	| - Efetuar login. <br> - Acessar lista de itens recebidos. <br> - Marcar item como “Recebido”. |
| Critério de Êxito | - Status do item é atualizado corretamente para “Recebido”. |
|  	|  	|
| **Caso de Teste** 	| **CT12 – Avaliar cursos e empresas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-012 – Avaliação de cursos e empresas |
| Objetivo do Teste 	| Garantir que usuários consigam avaliar cursos e empresas com nota e comentário. |
| Passos 	| - Acessar curso ou empresa. <br> - Inserir nota e comentário. <br> - Salvar avaliação. |
| Critério de Êxito | - Avaliação é registrada e exibida para outros usuários. |
|  	|  	|
| **Caso de Teste** 	| **CT13 – Revisão de denúncias** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-013 – Revisão de denúncias |
| Objetivo do Teste 	| Garantir que administradores consigam revisar denúncias e tomar ações. |
| Passos 	| - Efetuar login como administrador. <br> - Acessar lista de denúncias. <br> - Revisar denúncia. <br> - Aplicar ação (remoção ou suspensão). |
| Critério de Êxito | - Ação é aplicada corretamente e registro da denúncia é atualizado. |
|  	|  	|
| **Caso de Teste** 	| **CT14 – Bloqueio de usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-014 – Bloqueio de usuários banidos |
| Objetivo do Teste 	| Verificar que usuários banidos não conseguem criar nova conta com mesmo e-mail e CPF. |
| Passos 	| - Tentar cadastrar conta usando e-mail e CPF de usuário banido. |
| Critério de Êxito | - Sistema impede cadastro e exibe mensagem de erro adequada. |
|  	|  	|
| **Caso de Teste** 	| **CT15 – Acessar relatórios de engajamento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-015 – Acessar relatórios de engajamento |
| Objetivo do Teste 	| Garantir que usuários consigam visualizar relatórios de engajamento de recomendações. |
| Passos 	| - Efetuar login. <br> - Acessar seção de relatórios. <br> - Visualizar engajamento por curso. |
| Critério de Êxito | - Relatórios exibem dados corretos de engajamento conforme histórico de recomendações. |
