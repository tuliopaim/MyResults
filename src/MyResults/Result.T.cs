namespace MyResults;

public class Result<T>
{
    public List<Error> Errors { get; protected set; }

    public T? Data { get; protected set; }

    public bool Succeeded => Errors.Count == 0;

    public Result(T? data = default, List<Error>? errors = null)
    {
        Errors = errors ?? [];
        Data = data;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(data);
    }

    public static Result<T> WithError(Error error)
    {
        return new Result<T>(errors: [ error ]);
    }

    public static Result<T> WithErrors(List<Error> errors)
    {
        return new Result<T>(errors: errors);
    }

    public static implicit operator Result<T>(Error error) => new(errors: [ error ]);
    public static implicit operator Result<T>(T data) => new(data);
}
