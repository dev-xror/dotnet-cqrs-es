using CQRS.Core.Commands;

namespace Post.Command.Application.Commands;

public class EditCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public string? Comment { get; set; }
    public string? Username { get; set; }
}
