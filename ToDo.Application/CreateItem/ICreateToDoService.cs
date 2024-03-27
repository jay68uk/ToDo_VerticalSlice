namespace ToDo.Application.CreateItem;

internal interface ICreateToDoService
{
  Task<Common.ToDo> CreateToDoAsync(ToDoDto todoItem);
}