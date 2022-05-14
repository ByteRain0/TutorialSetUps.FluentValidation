namespace FluentValidation.Services;

public class ReactionAnalyzer : IHumanReactionAnalyzer
{
    public Task<ReactionAnalysis> AnalyzeCommentAsync(string comment, CancellationToken cancellationToken)
    {
        return Task.FromResult(AnalyzeComment(comment));
    }

    public ReactionAnalysis AnalyzeComment(string comment)
    {
        return new ReactionAnalysis(!comment.ToLowerInvariant().Contains("bastard"),
            !comment.ToLowerInvariant().Contains("bastard") ? string.Empty : "Comment is not positive");
    }
}