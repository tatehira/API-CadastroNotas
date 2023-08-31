<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
  <h1>API de Gerenciamento de Notas</h1>

  <h2>Descrição:</h2>
  <p>
    A API de Gerenciamento de Notas oferece uma plataforma simples e eficiente para cadastrar, editar e excluir notas. Essa API foi projetada para ser utilizada em aplicações web, aplicativos móveis e outras soluções digitais que necessitem de uma funcionalidade de anotações. Com uma interface RESTful, ela permite que os usuários criem, atualizem e removam notas de forma intuitiva.
  </p>

  <h2>Recursos:</h2>
  <ul>
    <li>
      <strong>Cadastrar Nota:</strong><br>
      Método: POST<br>
      Rota: <code>/api/Notes/Create</code><br>
      Descrição: Cria uma nova nota com o conteúdo fornecido.<br>
      Corpo da Requisição: JSON contendo o conteúdo da nota.<br>
      Resposta de Sucesso: Status 201 (Criado) e JSON contendo a nota criada, incluindo sua ID e horário de criação.
    </li>
    <li>
      <strong>Editar Nota:</strong><br>
      Método: PUT<br>
      Rota: <code>/api/Notes/Edit/{id}</code><br>
      Descrição: Atualiza o conteúdo de uma nota existente.<br>
      Parâmetro: <code>id</code> - ID da nota a ser editada.<br>
      Corpo da Requisição: JSON contendo o novo conteúdo da nota.<br>
      Resposta de Sucesso: Status 200 (OK) e JSON contendo a nota atualizada.
    </li>
    <li>
      <strong>Excluir Nota:</strong><br>
      Método: DELETE<br>
      Rota: <code>/api/Notes/Delete/{id}</code><br>
      Descrição: Remove uma nota existente.<br>
      Parâmetro: <code>id</code> - ID da nota a ser excluída.<br>
      Resposta de Sucesso: Status 204 (No Content).
    </li>
  </ul>

  <h2>Exemplo de Uso:</h2>
  <ul>
    <li>
      <strong>Cadastrar Nova Nota:</strong><br>
      Método: POST<br>
      Rota: <code>/api/Notes/Create</code><br>
      Corpo da Requisição:<br>
      <pre>
{
  "content": "Esta é uma nova nota."
}
      </pre>
      Resposta de Sucesso:<br>
      <pre>
{
  "id": 1,
  "content": "Esta é uma nova nota.",
  "createdAt": "2023-08-29T15:30:00Z"
}
      </pre>
    </li>
    <li>
      <strong>Editar Nota Existente:</strong><br>
      Método: PUT<br>
      Rota: <code>/api/Notes/Edit/1</code><br>
      Corpo da Requisição:<br>
      <pre>
{
  "content": "Este é o conteúdo atualizado da nota."
}
      </pre>
      Resposta de Sucesso:<br>
      <pre>
{
  "id": 1,
  "content": "Este é o conteúdo atualizado da nota.",
  "createdAt": "2023-08-29T15:30:00Z"
}
      </pre>
    </li>
    <li>
      <strong>Excluir Nota:</strong><br>
      Método: DELETE<br>
      Rota: <code>/api/Notes/Delete/1</code><br>
      Resposta de Sucesso:<br>
      Status 204 (No Content)
    </li>
  </ul>
</body>
</html>
