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
| Objetivo do Teste 	| certificar a validação  da conta do usuário |
| Passos 	| - Acessar o email <br> -Clicar na confirmação 
|Critério de Êxito | - O cadastro foi realizado com sucesso. |

| **Caso de Teste** 	| **CT03– visualização e edição de dados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03- O sistema deve permitir que o usuário visualize e edite seu dados como nome ,foto. |
| Objetivo do Teste 	| Verificar se o usuário consegue se visualizar e editar os dados. |
| Passos 	| - fazer login <br> - ir para a pagina perfil do usuário<br> - realizar as alterações <br> 
|Critério de Êxito | -as alterações foi realizado com sucesso. |
| **Caso de Teste** 	| **CT04– envio do material de estudo** 	|
||
|	Requisito Associado 	| RF-09- O sistema deve permitir que o usuário tenha acesso ao meterial de estudo |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar o material apos a comprar. |
| Passos 	| -fazer login <br> - Ir para a pagina publicar <br> --Escolher o curso" <br> - Pagar <br> - Ter acesso ao material<br> 
|Critério de Êxito | - ter acesso ao meterial adquirido

 

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
