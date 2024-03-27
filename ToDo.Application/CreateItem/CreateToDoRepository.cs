namespace ToDo.Application.CreateItem;

internal class CreateToDoRepository : ICreateToDoRepository
{
  public async Task<Common.ToDo> AddAsync(Common.ToDo todo)
  {
    return await Task.FromResult(todo);
  }
}