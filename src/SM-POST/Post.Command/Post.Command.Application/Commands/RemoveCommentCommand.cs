using CQRS.Core.Commands;

namespace Post.Command.Application.Commands;

public class RemoveCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public string? Username { get; set; }
}
