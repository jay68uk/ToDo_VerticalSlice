using System.Data;
using FastEndpoints;
using FluentValidation;

namespace ToDo.Application.CreateItem.Endpoints;

public class CreateToDoRequestValidator : Validator<CreateToDoRequest>
{
  public CreateToDoRequestValidator()
  {
    RuleFor(d => d.Description)
      .NotEmpty()
      .WithMessage("Description is required!")
      .MaximumLength(100)
      .WithMessage((request, description) => $"Description has a maximum length of 100 characters but {description.Length} characters were received!");
  }
}