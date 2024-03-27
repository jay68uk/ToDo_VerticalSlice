namespace ToDo.Application.CreateItem;

internal record ToDoDto(Ulid Id, string Description, DateTimeOffset Created, bool Completed)
{
  public Common.ToDo MapToToDo()
  {
    return new Common.ToDo(Id, Description, Created, Completed);
  }
}