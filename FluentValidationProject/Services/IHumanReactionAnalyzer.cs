namespace FluentValidation.Services;

public interface IHumanReactionAnalyzer
{
    Task<ReactionAnalysis> AnalyzeCommentAsync(string comment, CancellationToken cancellationToken);

    ReactionAnalysis AnalyzeComment(string comment);
}