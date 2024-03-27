namespace ToDo.Application.Common;

internal interface IReadOnlyToDoRepository
{
  Task<ToDo?> GetByIdAsync(Ulid id);
  Task<List<ToDo>> ListAsync();
}