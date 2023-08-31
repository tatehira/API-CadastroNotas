<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
  <h1>API de Gerenciamento de Tarefas</h1>

  <h2>Descrição:</h2>
  <p>
    A API de Gerenciamento de Tarefas oferece uma plataforma para cadastrar, editar e excluir tarefas. Essa API é projetada para ser usada em aplicações web, aplicativos móveis e outras soluções digitais que necessitem de funcionalidade de gerenciamento de tarefas. Com uma interface RESTful, ela permite que os usuários executem operações em tarefas de forma eficiente.
  </p>

  <h2>Recursos:</h2>
  <ul>
    <li>
      <strong>Obter Tarefa:</strong><br>
      Método: GET<br>
      Rota: <code>/api/Tarefas/GetTarefa?id={id}</code><br>
      Descrição: Obtém detalhes de uma tarefa existente.<br>
      Parâmetro: <code>id</code> - ID da tarefa a ser obtida.<br>
      Resposta de Sucesso: Status 200 (OK) e JSON contendo os detalhes da tarefa.
    </li>
    <li>
      <strong>Cadastrar Tarefa:</strong><br>
      Método: POST<br>
      Rota: <code>/api/Tarefas/CreateTarefa</code><br>
      Descrição: Cria uma nova tarefa com o assunto e a descrição fornecidos.<br>
      Corpo da Requisição: JSON contendo o assunto e a descrição da tarefa.<br>
      Resposta de Sucesso: Status 200 (OK) e JSON contendo os detalhes da tarefa criada.
    </li>
    <li>
      <strong>Editar Tarefa:</strong><br>
      Método: PUT<br>
      Rota: <code>/api/Tarefas/Edit</code><br>
      Descrição: Atualiza os detalhes de uma tarefa existente.<br>
      Corpo da Requisição: JSON contendo os detalhes atualizados da tarefa.<br>
      Resposta de Sucesso: Status 200 (OK) e JSON contendo os detalhes da tarefa atualizada.
    </li>
    <li>
      <strong>Excluir Tarefa:</strong><br>
      Método: DELETE<br>
      Rota: <code>/api/Tarefas/Delete?id={id}</code><br>
      Descrição: Remove uma tarefa existente.<br>
      Parâmetro: <code>id</code> - ID da tarefa a ser excluída.<br>
      Resposta de Sucesso: Status 200 (OK).
    </li>
  </ul>
</body>
</html>
