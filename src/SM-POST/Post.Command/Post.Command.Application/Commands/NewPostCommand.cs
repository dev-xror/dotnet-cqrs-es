using CQRS.Core.Commands;

namespace Post.Command.Application.Commands;

public class NewPostCommand : BaseCommand
{
    public string? Author { get; set; }
    public string? Message { get; set; }
}