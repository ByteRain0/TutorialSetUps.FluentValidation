namespace FluentValidation.Services;

public class ReactionAnalysis
{
    public ReactionAnalysis(bool isPositive, string? message)
    {
        if (isPositive)
        {
            IsPositive = true;
            Message = string.Empty;
        }
        else
        {
            IsPositive = false;
            Message = message;
        }
    }

    public bool IsPositive { get; }

    public string Message { get;  }
}