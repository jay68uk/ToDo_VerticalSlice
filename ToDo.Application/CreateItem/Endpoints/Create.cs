using FastEndpoints;

namespace ToDo.Application.CreateItem.Endpoints;

internal class Create : Endpoint<CreateToDoRequest, ToDoDto>
{
  private readonly ICreateToDoService _createToDoService;

  public Create(ICreateToDoService createToDoService)
  {
    _createToDoService = createToDoService;
  }
  
  public override void Configure()
  {
    
    Post("/todo");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CreateToDoRequest req, CancellationToken ct)
  {
    //TODO: validation
    
    var toDoItem = new ToDoDto(Ulid.NewUlid(), req.Description, DateTimeOffset.Now, false);
    
    var newToDoItem = await _createToDoService.CreateToDoAsync(toDoItem);

    var returnToDo = newToDoItem.MapToToDoDto();
    
    await SendCreatedAtAsync(endpointName: "GetById", routeValues: returnToDo.Id, responseBody: returnToDo, cancellation: ct);
  }
}

