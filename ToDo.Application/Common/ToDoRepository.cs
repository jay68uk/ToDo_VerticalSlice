using ToDo.Application.CreateItem;

namespace ToDo.Application.Common;

internal class ToDoRepository : IToDoRepository
{
  public Task AddAsync(ToDo todo)
  {
    throw new NotImplementedException();
  }

  public Task DeleteAsync(ToDo todo)
  {
    throw new NotImplementedException();
  }

  public Task SaveChangesAsync()
  {
    throw new NotImplementedException();
  }

  public Task<ToDo?> GetByIdAsync(Ulid id)
  {
    throw new NotImplementedException();
  }

  public Task<List<ToDo>> ListAsync()
  {
    throw new NotImplementedException();
  }
}