namespace ToDo.Application.CreateItem;

internal class CreateToDoService : ICreateToDoService
{
  private readonly ICreateToDoRepository _createToDoRepository;

  public CreateToDoService(ICreateToDoRepository createToDoRepository)
  {
    _createToDoRepository = createToDoRepository;
  }
  
  public async Task<Common.ToDo> CreateToDoAsync(ToDoDto todoItem)
  {
    var newTodo = todoItem.MapToToDo();
    return await _createToDoRepository.AddAsync(newTodo);
  }
}