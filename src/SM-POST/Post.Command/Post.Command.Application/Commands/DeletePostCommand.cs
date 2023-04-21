using CQRS.Core.Commands;

namespace Post.Command.Application.Commands;

public class DeletePostCommand : BaseCommand
{
    public string? Username { get; set; }
}