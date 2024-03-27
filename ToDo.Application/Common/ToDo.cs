using Ardalis.GuardClauses;
using ToDo.Application.CreateItem;

namespace ToDo.Application.Common;

internal class ToDo
{
  public Ulid Id { get; private set; }
  public string Description { get; private set; }
  public DateTimeOffset Created { get; private set; } = DateTimeOffset.Now;
  public bool Completed { get; private set; } = false;

  internal ToDo(Ulid id, string description, DateTimeOffset created, bool completed)
  {
    Id = Guard.Against.Default(id);
    Description = Guard.Against.NullOrEmpty(description);
  }

  public ToDoDto MapToToDoDto()
  {
    return new ToDoDto(Id, Description, Created, Completed);
  }
}