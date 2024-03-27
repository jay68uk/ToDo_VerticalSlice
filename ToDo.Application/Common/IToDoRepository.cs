namespace ToDo.Application.Common;

internal interface IToDoRepository : IReadOnlyToDoRepository
{
  Task DeleteAsync(ToDo todo);
  Task SaveChangesAsync();
}