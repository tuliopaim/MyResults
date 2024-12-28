namespace MyResults;

public class Result<T>(T? data = default, List<Error>? errors = null)
{
    public List<Error> Errors { get; protected set; } = errors ?? [];

    public T? Data { get; protected set; } = data;

    public bool IsValid => Errors.Count == 0;

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
    public static implicit operator Result<T>(List<Error> errors) => new(errors: errors);
    public static implicit operator Result<T>(T data) => new(data);
}
