# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01- O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT02 – email de confirmação** 	|
|Requisito Associado | RF-02	- A aplicação deve enviar um email de confirmação para a ativação da conta apos o cadastro |
| Objetivo do Teste 	| Certificar a validação  da conta do usuário |
| Passos 	| - Acessar o email <br> -Clicar na confirmação 
|Critério de Êxito | - O cadastro foi realizado com sucesso. |

| **Caso de Teste** 	| **CT03– visualização e edição de dados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03- O sistema deve permitir que o usuário visualize e edite seus dados como nome ,foto. |
| Objetivo do Teste 	| Verificar se o usuário consegue se visualizar e editar os dados. |
| Passos 	| - Fazer login <br> - Ir para a pagina perfil do usuário<br> - Realizar as alterações <br> 
|Critério de Êxito | - As alterações foram realizadas com sucesso. |
| **Caso de Teste** 	| **CT04– Envio do material de estudo** 	|
|	||
|	Requisito Associado 	| RF-09- O sistema deve permitir que o usuário tenha acesso ao meterial de estudo  |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar o material de estudo.  |
| Passos 	| - Fazer login <br> - Ir para a pagina publicar <br> 
|Critério de Êxito | - Ter acesso ao meterial desejado. |
| **Caso de Teste** 	| **CT05 – Permitir aviliações com notas e comentarios** 	|
|	|
|	Requisito Associado 	| RF-12- O sistema deve permitir que os usuários avaliem curso e empresas com notas e comentarios. |
| Objetivo do Teste 	| verificar  feedback e notas avaliativas. |
| Passos 	| - Fazer login <br> - Ir para a pagina visualização do perfil do outro usuário <br> - fazer um comentario<br> 
|Critério de Êxito | - verificar se o comentario recebido. |
| **Caso de Teste** 	| **CT06– Permitir que administradores revisem itens e usuários** 	|
||
|	Requisito Associado 	| RF-013-O sistema deve permitir que os administradores revisem denúncias de itens ou usuários e tomem ações como remoção de conteúdo ou suspensão de contas.  |
| Objetivo do Teste 	| Verificar se o login de administradores podem fazer algumas ações que os logins comuns não fazer. |
| Passos 	| -  Fazer login <br> - Ir para a pagina visualização do usuário <br> - 
|Critério de Êxito | - Conseguir ações como revisão de contas e suspenção de contas. |



