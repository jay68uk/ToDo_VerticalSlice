namespace ToDo.Application.CreateItem;

internal interface ICreateToDoRepository
{
  Task<Common.ToDo> AddAsync(Common.ToDo todo);
}