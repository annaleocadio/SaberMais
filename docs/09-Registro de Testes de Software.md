# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

### CT01 – Cadastro de usuário
| Campo               | Descrição                                                                                                                              | Vídeo (RAW)          |
| ------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------- |
| Caso de Teste       | CT01 – Cadastro de usuário                                                                                                             | **CT01** – [Vídeo](https://github.com/user-attachments/assets/3f2bb043-84c6-462b-ab87-8a5da6dc6b77) |
| Requisito Associado | RF-01 – O sistema deve permitir que o usuário crie uma conta utilizando e-mail e senha.                                                |                      |
| Objetivo do Teste   | Verificar se o usuário consegue criar uma conta corretamente utilizando e-mail e senha válidos.                                        |                      |
| Passos              | - Acessar a tela de cadastro.<br>- Inserir e-mail válido.<br>- Inserir senha válida.<br>- Confirmar senha.<br>- Clicar em “Cadastrar”. |                      |
| Critério de Êxito   | - O sistema cria a conta e exibe mensagem de sucesso.                                                                                  |                      |
| Resultado do Teste  | Sucesso, o sistema cadastra o usuário validando os dados inseridos e retorna uma mensagem de sucesso.                                  |                      |

### CT02 – Edição de dados cadastrais
| Campo               | Descrição                                                                         | Vídeo (RAW)          |
| ------------------- | --------------------------------------------------------------------------------- | -------------------- |
| Caso de Teste       | CT02 – Edição de dados cadastrais                                                 | **CT02** – [Vídeo](https://github.com/user-attachments/assets/6dbfb036-59b9-4177-9db7-aa1eaa7122af) |
| Requisito Associado | RF-02                                                                             |                      |
| Objetivo do Teste   | Verificar se o usuário consegue visualizar e atualizar nome e foto.               |                      |
| Passos              | - Acessar conta logada.<br>- Ir ao perfil.<br>- Alterar nome e foto.<br>- Salvar. |                      |
| Critério de Êxito   | Dados atualizados e exibidos corretamente.                                        |                      |
| Resultado do Teste   | Sucesso, sistema permite que o usuário logado altere suas informações dos dados cadastrais.                                        |                      |

### CT03 – Cadastro de item
| Campo               | Descrição                                                                                        | Vídeo (RAW)          |
| ------------------- | ------------------------------------------------------------------------------------------------ | -------------------- |
| Caso de Teste       | CT03 – Cadastro de item                                                                          | **CT03** – [Vídeo](https://github.com/user-attachments/assets/428d8879-fede-4751-81f1-428a994c3161) |
| Requisito Associado | RF-03                                                                                            |                      |
| Objetivo do Teste   | Verificar cadastro de item com todos os campos obrigatórios.                                     |                      |
| Passos              | - Logar.<br>- Acessar “Cadastrar item”.<br>- Preencher dados.<br>- Anexar arquivos.<br>- Salvar. |                      |
| Critério de Êxito   | Item cadastrado e exibido.                                                                       |                      |
| Resultado do Teste  | Sucesso, o sistema permite o cadastro de novos cursos, retornando uma mensagem de sucesso após o cadastro do mesmo.                                        |                      |

### CT04 – Edição e exclusão de item
| Campo               | Descrição                                                  | Vídeo (RAW)          |
| ------------------- | ---------------------------------------------------------- | -------------------- |
| Caso de Teste       | CT04 – Edição e exclusão de item                           | **CT04** – [Vídeo](https://github.com/user-attachments/assets/c985dad8-165f-42d2-a7f4-7182d1233c3d) |
| Requisito Associado | RF-04                                                      |                      |
| Objetivo do Teste   | Validar edição e exclusão de item.                         |                      |
| Passos              | - Logar.<br>- Abrir lista.<br>- Editar item.<br>- Excluir. |                      |
| Critério de Êxito   | Edição salva e exclusão realizada.                         |                      |
| Resultado do Teste  | Falhou, o sistema não permitiu que o usuário editasse ou excluísse um item previamente cadastrado.                |                      |

### CT05 – Busca de itens
| Campo               | Descrição                                                    | Vídeo (RAW)          |
| ------------------- | ------------------------------------------------------------ | -------------------- |
| Caso de Teste       | CT05 – Busca de itens                                        | **CT05** – [Vídeo](https://github.com/user-attachments/assets/b924e45d-9566-486c-9737-538615abba5b) |
| Requisito Associado | RF-05                                                        |                      |
| Objetivo do Teste   | Verificar busca por filtros.                                 |                      |
| Passos              | - Inserir filtros.<br>- Aplicar.<br>- Visualizar resultados. |                      |
| Critério de Êxito   | Resultados corretos.                                         |                      |
| Resultado do Teste  | Parcialmente Sucesso, o usuário consegue buscar por meio de uma barra de pesquisas, mas sem filtros.           |                      |

### CT06 – Listagem inicial de itens
| Campo               | Descrição                                 | Vídeo (RAW)          |
| ------------------- | ----------------------------------------- | -------------------- |
| Caso de Teste       | CT06 – Listagem inicial                   | **CT06** – [Vídeo](https://github.com/user-attachments/assets/12c3a7a8-f79d-4154-bfff-4f2c4abe449c) |
| Requisito Associado | RF-06                                     |                      |
| Objetivo do Teste   | Verificar exibição inicial por categoria. |                      |
| Passos              | - Acessar página inicial.                 |                      |
| Critério de Êxito   | Itens exibidos por categoria.             |                      |
| Resultado do Teste  | Parcialmente Sucesso, a tela Inicial categoriza os cursos upados, mas apenas por "Em Alta" e "Recomendados".           |                      |

### CT07 – Escolha de modalidade de curso
| Campo               | Descrição                                                 | Vídeo (RAW)          |
| ------------------- | --------------------------------------------------------- | -------------------- |
| Caso de Teste       | CT07 – Escolha de modalidade                              | **CT07** – [Vídeo](https://github.com/user-attachments/assets/dc139c11-e4ab-4b45-8efd-14cc0533a3bd) |
| Requisito Associado | RF-07                                                     |                      |
| Objetivo do Teste   | Validar escolha entre modalidades.                        |                      |
| Passos              | - Abrir cursos.<br>- Filtrar modalidade.<br>- Selecionar. |                      |
| Critério de Êxito   | Modalidade correta exibida.                               |                      |
| Resultado do Teste  | Falha, o usuário não consegue pesquisar cursos pela modalidade.          |                      |

### CT08 – Confirmação de envio de documento
| Campo               | Descrição                                                    | Vídeo (RAW)          |
| ------------------- | ------------------------------------------------------------ | -------------------- |
| Caso de Teste       | CT08 – Envio de documento                                    | **CT08** – [Vídeo](https://github.com/user-attachments/assets/41d106c0-5977-4d83-b8bf-f1035e2b8747) |
| Requisito Associado | RF-08                                                        |                      |
| Objetivo do Teste   | Verificar confirmação conforme tipo de envio.                |                      |
| Passos              | - Selecionar entrega.<br>- Enviar documento.<br>- Confirmar. |                      |
| Critério de Êxito   | Confirmação correta.                                         |                      |
| Resultado do Teste  | Sucesso, o sistema valida o documento enviado do curso, ou se a modalidade for presencial, com os campos de Endereço.        |                      |

### CT09 – Confirmar recebimento
| Campo               | Descrição                                                        | Vídeo (RAW)          |
| ------------------- | ---------------------------------------------------------------- | -------------------- |
| Caso de Teste       | CT09 – Confirmar recebimento                                     | **CT09** – [Vídeo](https://github.com/user-attachments/assets/05426559-1470-417b-a2aa-9ad3a316045e) |
| Requisito Associado | RF-09                                                            |                      |
| Objetivo do Teste   | Validar marcação de item recebido.                               |                      |
| Passos              | - Logar.<br>- Abrir itens adquiridos.<br>- Marcar como recebido. |                      |
| Critério de Êxito   | Status atualizado.                                               |                      |
| Resultado do Teste  | Falha, o sistema não permite que o usuário marque como "Recebido" um curso pelo qual ele se interessou.       |                      |

### CT10 – Avaliação
| Campo               | Descrição                                                                | Vídeo (RAW)          |
| ------------------- | ------------------------------------------------------------------------ | -------------------- |
| Caso de Teste       | CT10 – Avaliação                                                         | **CT10** – [Vídeo](https://github.com/user-attachments/assets/e8b677f3-4bb8-4fea-9b68-69c7d16ab3c4) |
| Requisito Associado | RF-010                                                                   |                      |
| Objetivo do Teste   | Verificar envio de nota e comentário.                                    |                      |
| Passos              | - Abrir página.<br>- Inserir nota.<br>- Inserir comentário.<br>- Enviar. |                      |
| Critério de Êxito   | Avaliação registrada.                                                    |                      |
| Resultado do Teste  | Sucesso, o sistema permite que o usuário avalie o curso e deixe seu comentário no perfil do responsável.       |                      |

### CT11 – Revisão de denúncias
| Campo               | Descrição                                                  | Vídeo (RAW)          |
| ------------------- | ---------------------------------------------------------- | -------------------- |
| Caso de Teste       | CT11 – Revisão de denúncias                                | *(fazer upload)* |
| Requisito Associado | RF-011                                                     |                      |
| Objetivo do Teste   | Validar ações de admin.                                    |                      |
| Passos              | - Logar como admin.<br>- Abrir denúncias.<br>- Tomar ação. |                      |
| Critério de Êxito   | Ação aplicada.                                             |                      |

### CT12 – Bloqueio de cadastro de banido
| Campo               | Descrição                                   | Vídeo (RAW)          |
| ------------------- | ------------------------------------------- | -------------------- |
| Caso de Teste       | CT12 – Bloqueio de usuário banido           | *(fazer upload)* |
| Requisito Associado | RF-012                                      |                      |
| Objetivo do Teste   | Impedir cadastro de banidos.                |                      |
| Passos              | - Tentar criar conta com e-mail/CPF banido. |                      |
| Critério de Êxito   | Bloqueio e mensagem exibida.                |                      |
