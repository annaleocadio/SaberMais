# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT01 – Cadastrar perfil** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-01 – O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. |
| Objetivo do Teste | Verificar se o usuário consegue criar uma conta corretamente utilizando e-mail e senha válidos. |
| Resultado do Teste | Sucesso, o sistema cadastra o usuário validando os dados inseridos e retorna uma mensagem de sucesso. |
| Registro de evidência | [Evidência CT01](https://www.youtube.com/watch?v=kbXDaK5rUBs&list=PLKaK7-baMbforZHbkwPwvWBVsXbkVLgHM) |


| **Caso de Teste** 	| **CT02 – Edição de dados cadastrais** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-02 – O sistema deve permitir que o usuário visualize e edite seus dados cadastrais. |
| Objetivo do Teste | Verificar se o usuário consegue visualizar e atualizar nome e foto de perfil. |
| Resultado do Teste | Sucesso, sistema permite que o usuário logado altere suas informações dos dados cadastrais. |
| Registro de evidência | [Evidência CT02](https://youtu.be/E4q3_q6qlwE) |


| **Caso de Teste** 	| **CT03 – Cadastro de item** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-03 – O sistema deve permitir que um usuário cadastre um item, informando nome, descrição, categoria, localização e imagens e documentos. |
| Objetivo do Teste | Verificar se o usuário consegue cadastrar um item informando todos os campos obrigatórios. |
| Resultado do Teste | Sucesso, o sistema permite o cadastro de novos cursos, retornando uma mensagem de sucesso após o cadastro do mesmo. |
| Registro de evidência | [Evidência CT03](https://youtu.be/uc-6MDWHWac) |

| **Caso de Teste** 	| **CT04 – Edição e exclusão de item** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-04 – O sistema deve permitir que edite ou exclua um item previamente cadastrado. |
| Objetivo do Teste | Validar que o usuário possa editar ou excluir um item previamente cadastrado. |
| Resultado do Teste | Falhou, o sistema não permitiu que o usuário editasse ou excluísse um item previamente cadastrado. |
| Registro de evidência | [Evidência CT04](https://youtu.be/nvr1jbF_CLM) |

| **Caso de Teste** 	| **CT05 – Busca de itens** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-05 – O sistema deve permitir que um usuário busque itens disponíveis por categoria, localização, palavra-chave, faixa de preço e data de publicação. |
| Objetivo do Teste | Verificar se o usuário consegue buscar itens por filtros. |
| Resultado do Teste | Parcialmente Sucesso, o usuário consegue buscar por meio de uma barra de pesquisas, mas sem filtros. |
| Registro de evidência | [Evidência CT05](https://youtu.be/MMS9nHg7B24) |

| **Caso de Teste** 	| **CT06 – Listagem inicial de itens** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-06 – O sistema deve exibir uma lista de itens disponíveis na página inicial, organizados por categorias. |
| Objetivo do Teste | Verificar se a página inicial exibe itens organizados por categoria. |
| Resultado do Teste | Parcialmente Sucesso, a tela Inicial categoriza os cursos upados, mas apenas por "Em Alta" e "Recomendados". |
| Registro de evidência | [Evidência CT06](https://youtu.be/HTFxHQ_afg8) |

| **Caso de Teste** 	| **CT07 – Escolha de modalidade de curso** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-07 – O sistema deve permitir escolher cursos presencias ou online. |
| Objetivo do Teste | Validar que o usuário possa escolher entre cursos online ou presenciais. |
| Resultado do Teste | Falha, o usuário não consegue pesquisar cursos pela modalidade. |
| Registro de evidência | [Evidência CT07](https://youtu.be/JahiBFh_tXg) |

| **Caso de Teste** 	| **CT08 – Confirmação de envio de documento** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-08 – O sistema deve confirmar o envio de documento seja em Ebook, PDF, ou de forma presencial. |
| Objetivo do Teste | Verificar se o sistema confirma o envio de documentos em Ebook, PDF ou material presencial. |
| Resultado do Teste | Sucesso, o sistema valida o documento enviado do curso, ou se a modalidade for presencial, com os campos de Endereço. |
| Registro de evidência | [Evidência CT08](https://youtu.be/prN2DUn4_8E) |

| **Caso de Teste** 	| **CT09 – Confirmar recebimento** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-09 – O sistema deve permitir que o receptor marque o item como "Recebido" após a entrega ou venda efetuada. |
| Objetivo do Teste | Verificar se o receptor consegue marcar um item como recebido. |
| Resultado do Teste | Falha, o sistema não permite que o usuário marque como "Recebido" um curso pelo qual ele se interessou. |
| Registro de evidência | [Evidência CT09](https://youtu.be/fXQBXktekJk) |

| **Caso de Teste** 	| **CT10 – Avaliação** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-10 – O sistema deve permitir que os usuários avaliem cursos e empresas com notas e comentários. |
| Objetivo do Teste | Verificar se o usuário consegue avaliar com nota e comentário. |
| Resultado do Teste | Sucesso, o sistema permite que o usuário avalie o curso e deixe seu comentário no perfil do responsável. |
| Registro de evidência | [Evidência CT10](https://youtu.be/6sEX2vRLQDk) |

## Relatório de testes de software

Durante os testes realizados na aplicação, foi possível observar que ela ainda se encontra em um estágio bastante inicial de desenvolvimento. No momento, atende apenas aos requisitos mais básicos, como login, cadastro, registro de itens e visualização dos conteúdos postados na plataforma. Essa limitação faz com que a experiência de teste pareça um pouco incompleta, transmitindo a impressão de que a aplicação ainda não oferece muitas funcionalidades.

A aplicação ainda apresenta muita falha nos retornos, sejam positivos ou negativos. Além da falta de algumas funcionalidades mais básicas.

Com base nos testes foi possível identificar uma necessidade de aprimorar e melhorar os processos realizados durante o uso da aplicação. Além da falta de uma melhor comunicaçao da aplicação com o usuário.

Melhorias necessárias para a aplicação:
* Retornos de Status das operações realizadas.
* Melhora na acessibilidade do usuário.
