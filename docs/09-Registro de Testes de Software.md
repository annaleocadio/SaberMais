# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT01 – Cadastrar perfil** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-01 – O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha. |
|Registro de evidência | [Evidência CT01](https://youtu.be/OrNtsWZ2sZw) |
|Objetivo do Teste | Conseguir realizar o cadastro do usuário, informando os dados para cadastro. |
|Resultado do Teste | Sucesso, porém falta um retorno. |

<video 
  src="/docs/img/registros-de-teste/CT-01.mp4"
  controls="controls"
  muted="muted"
  style="max-height:640px; min-height: 200px">
</video>

- Necessário adicionar um retorno após conclusão do cadastro, em caso de sucesso ou falha.

| **Caso de Teste** 	| **CT02 – Confirmação de e-mail** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-02 – O sistema deve enviar um e-mail de confirmação para ativação da conta após o cadastro. |
|Registro de evidência | [Evidência CT02](https://youtu.be/1iIg46Lx5ZY) |
|Objetivo do Teste | Enviar para o usuário, um E-mail para validar e confirmar o cadastro e a identidade do usuário. |
|Resultado do Teste | Falhou, o sistema ainda não encaminha um E-mail vinculado pelo usuário. |

- Necessário revisar se será possível realizar esta feature.

| **Caso de Teste** 	| **CT03 – Visualização e edição de dados** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-03 – Visualização e edição de dados. |
|Registro de evidência | [Evidência CT03](https://youtu.be/yI6w3-nDg0s) |
|Objetivo do Teste | Permitir que o usuário Edite e visualize os dados de seu perfil. |
|Resultado do Teste | Falhou, o sistema não permitia o acesso e edição de dados do usuário. |

- Foi desenvolvido uma página própria do usuário onde ele pode acessar suas informações e também edita-las.

| **Caso de Teste** 	| **CT04 – Cadastro de item** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-04 – Visualização e edição de dados. |
|Registro de evidência | [Evidência CT04](https://youtu.be/A9rNs5yIhaU) |
|Objetivo do Teste | Permitir que o usuário cadastre seus cursos no sistema. |
|Resultado do Teste | Sucesso, o sistema cadastrou curso normalmente,  retornando uma mensagem de sucesso |

| **Caso de Teste** 	| **CT05 – Edição/Exclusão de item** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-05 – Edição/Exclusão de item. |
|Registro de evidência | [Evidência CT05](https://youtu.be/epev3X_lr_U) |
|Objetivo do Teste | Permitir que o usuário faça a edição e exclusão dos itens posteriormente postados. |
|Resultado do Teste | Falhou, o não disponibilizou uma página própria do usuário para Editar e Cadastrar item. |

- Necessário desenvolver uma página de gerenciamento, listando os cursos publicados pelo usuário, permitindo edição e exclusão dos mesmos.

| **Caso de Teste** 	| **CT06 – Busca de itens** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-06 – Busca de itens. |
|Registro de evidência | [Evidência CT06](https://youtu.be/TuLn0l2CxzE) |
|Objetivo do Teste | Permitir que o usuário busque cursos por palavras-chave na tela de Inicio. |
|Resultado do Teste | Falhou, o sistema não tinha função de busca e filtragem de cursos por palavras-chave. |

- Necessário desenvolver método que permita ao usuário buscar cursos por palavras-chave.

| **Caso de Teste** 	| **CT07 – Listagem de Itens** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-07 – Lista de itens na página inicial. |
|Registro de evidência | [Evidência CT07](https://youtu.be/qz1RkOyTzGg) |
|Objetivo do Teste | Listar os itens de forma classificada e filtrada por categorias para o usuário. |
|Resultado do Teste | Parcialmente sucesso, o sistema lista os cursos cadastrados porém não os filtra por categorias. |

- Necessário desenvolver um método que filtre cursos similares na listagem da página inicial.

| **Caso de Teste** 	| **CT08 – Escolha de cursos** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-08 – Escolha de cursos. |
|Registro de evidência | [Evidência CT08](https://youtu.be/pTAzZE_zhy8) |
|Objetivo do Teste | Permitir que o usuário filtre os tipos de curso de seu interesse. |
|Resultado do Teste | Falha, o sistema não permitia filtro dos tipos de curso por interesse do usuário. |

- Necessário desenvolver métodos que permitam ao usuário filtrar cursos por categorias, tipo e palavras-chave.

| **Caso de Teste** 	| **CT09 – Confirmação de envio** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-09 – Confirmação de envio de documento. |
|Registro de evidência | [Evidência CT09](https://youtu.be/DIaYzDlctCg) |
|Objetivo do Teste | Retornar uma mensagem informativa para o usuário sobre o envio de um documento na aplicação. |
|Resultado do Teste | Parcialmente sucesso, o sistema retorno apenas o conjunto inteiro do curso, mas não faz validação da imagem e documento enviado. |

- Adicionar um retorno após realizar o Upload do Banner do Curso e o Documento.

| **Caso de Teste** 	| **CT11 – Confirmação de recebimento** 	|
|--------------------|---------------------------------------|
|	Requisito Associado 	| RF-011 – Marcar item como “Recebido” |
|Registro de evidência | [Evidência CT11](https://youtu.be/dHLkptJCZZg) |
|Objetivo do Teste | Permitir que o usuário marque como "Recebido" o curso comprado na plataforma. |
|Resultado do Teste | Falhou, a plataforma ainda não permitia ao usuário marcar um curso como "Recebido". |

- Desenvolver uma página que liste todos os Cursos cujo o usuário adquiriu, permitindo que o mesmo os marque como "Recebido".

## Relatório de testes de software

Durante os testes realizados na aplicação, foi possível observar que ela ainda se encontra em um estágio bastante inicial de desenvolvimento. No momento, atende apenas aos requisitos mais básicos, como login, cadastro, registro de itens e visualização dos conteúdos postados na plataforma. Essa limitação faz com que a experiência de teste pareça um pouco incompleta, transmitindo a impressão de que a aplicação ainda não oferece muitas funcionalidades.

A aplicação ainda apresenta muita falha nos retornos, sejam positivos ou negativos. Além da falta de algumas funcionalidades mais básicas.

Com base nos testes foi possível identificar uma necessidade de aprimorar e melhorar os processos realizados durante o uso da aplicação. Além da falta de uma melhor comunicaçao da aplicação com o usuário.

Melhorias necessárias para a aplicação:
* Retornos de Status das operações realizadas.
* Melhora na acessibilidade do usuário.
