# Plano de Testes de Software

| Caso de Teste	| CT01 – Cadastro de usuário 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 – O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar uma conta corretamente utilizando e-mail e senha válidos. |
| Passos 	| - Acessar a tela de cadastro. <br> - Inserir e-mail válido.  - Inserir senha válida. <br> - Confirmar senha. <br> - Clicar em “Cadastrar”. |
| Critério de Êxito | - O sistema cria a conta e exibe uma mensagem de sucesso ou redireciona para a tela de confirmação de e-mail. |

| Caso de Teste   | CT02 – Edição de dados cadastrais                                                                                 |
| ------------------- | ------------------------------------------------------------------------------------------------------------------------ |
| Requisito Associado | RF-02 – O sistema deve permitir que o usuário visualize e edite seus dados cadastrais.                                   |
| Objetivo do Teste   | Verificar se o usuário consegue visualizar e atualizar nome e foto de perfil.                                            |
| Passos              | - Acessar conta logada. <br> - Navegar até “Perfil”. <br> - Alterar nome. <br> - Alterar foto. <br> - Salvar alterações. |
| Critério de Êxito   | - Dados são atualizados e exibidos corretamente.                                                                         |

| Caso de Teste | CT03 – Cadastro de item |
| Requisito Associado | RF-03 |
| Objetivo do Teste | Verificar se o usuário consegue cadastrar um item informando todos os campos obrigatórios. |
| Passos | - Logar no sistema. <br> - Acessar “Cadastrar item”. <br> - Informar nome, descrição, categoria, localização. <br> - Anexar imagens e documentos. <br> - Salvar. |
| Critério de Êxito | - Item cadastrado e exibido na lista de itens. |

| Caso de Teste | CT04 – Edição e exclusão de item |
| Requisito Associado | RF-04 |
| Objetivo do Teste | Validar que o usuário possa editar ou excluir um item previamente cadastrado. |
| Passos | - Logar. <br> - Acessar lista de itens cadastrados. <br> - Selecionar um item. <br> - Editar e salvar. <br> - Excluir item. |
| Critério de Êxito | - Alterações salvas corretamente e item removido quando solicitado. |

| Caso de Teste | CT05 – Busca de itens |
| Requisito Associado | RF-05 |
| Objetivo do Teste | Verificar se o usuário consegue buscar itens por filtros. |
| Passos | - Acessar busca. <br> - Inserir categoria. <br> - Inserir localização. <br> - Inserir palavra-chave. <br> - Aplicar filtros. |
| Critério de Êxito | - Resultados exibidos conforme filtros aplicados. |

| Caso de Teste | CT06 – Listagem inicial de itens |
| Requisito Associado | RF-06 |
| Objetivo do Teste | Verificar se a página inicial exibe itens organizados por categoria. |
| Passos | - Acessar página inicial. |
| Critério de Êxito | - Itens exibidos e agrupados por categoria. |

| Caso de Teste | CT07 – Escolha de modalidade de curso |
| Requisito Associado | RF-07 |
| Objetivo do Teste | Validar que o usuário possa escolher entre cursos online ou presenciais. |
| Passos | - Acessar seção de cursos. <br> - Filtrar por modalidade. <br> - Selecionar curso. |
| Critério de Êxito | - Modalidade exibida e selecionada corretamente. |

| Caso de Teste | CT08 – Confirmação de envio de documento |
| Requisito Associado | RF-08 |
| Objetivo do Teste | Verificar se o sistema confirma o envio de documentos em Ebook, PDF ou material presencial. |
| Passos | - Selecionar entrega. <br> - Enviar documento. <br> - Confirmar envio. |
| Critério de Êxito | - Sistema exibe confirmação adequada ao tipo de envio. |

| Caso de Teste | CT09 – Confirmar recebimento |
| Requisito Associado | RF-09 |
| Objetivo do Teste | Verificar se o receptor consegue marcar um item como recebido. |
| Passos | - Logar. <br> - Acessar itens adquiridos. <br> - Selecionar item. <br> - Clicar em “Marcar como recebido”. |
| Critério de Êxito | - Status do item é atualizado corretamente. |

| Caso de Teste | CT10 – Avaliação |
| Requisito Associado | RF-010 |
| Objetivo do Teste | Verificar se o usuário consegue avaliar com nota e comentário. |
| Passos | - Acessar página de curso/empresa. <br> - Inserir nota. <br> - Inserir comentário. <br> - Enviar avaliação. |
| Critério de Êxito | - Avaliação registrada e exibida. |

| Caso de Teste | CT11 – Revisão de denúncias |
| Requisito Associado | RF-011 |
| Objetivo do Teste | Validar que administradores possam revisar denúncias e aplicar ações. |
| Passos | - Logar como admin. <br> - Acessar painel de denúncias. <br> - Selecionar denúncia. <br> - Remover conteúdo ou suspender usuário. |
| Critério de Êxito | - Ação aplicada e registrada no sistema. |

| Caso de Teste | CT12 – Bloqueio de cadastro de usuário banido |
| Requisito Associado | RF-012 |
| Objetivo do Teste | Verificar se o sistema impede cadastro com mesmo e-mail e CPF de usuário banido. |
| Passos | - Tentar criar conta usando e-mail e CPF de usuário banido. |
| Critério de Êxito | - Sistema bloqueia criação e exibe mensagem de impedimento. |
