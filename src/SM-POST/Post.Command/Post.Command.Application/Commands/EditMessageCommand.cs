using CQRS.Core.Commands;

namespace Post.Command.Application.Commands;

public class EditMessageCommand : BaseCommand
{
    public string? Message { get; set; }
}