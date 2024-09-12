namespace MyResults;

public class Result
{
    public List<Error> Errors { get; protected set; }

    public bool Succeeded => Errors.Count == 0;

    public Result(List<Error>? errors = null)
    {
        Errors = errors ?? [];
    }

    public virtual void AddError(Error error)
    {
        Errors.Add(error);
    }

    public static Result Success()
    {
        return new Result();
    }

    public static Result WithError(Error error)
    {
        return new Result([ error ]);
    }

    public static Result WithErrors(List<Error> errors)
    {
        return new Result(errors);
    }

    public static implicit operator Result(Error error) => new([ error ]);
}
