namespace MyResults;

public class Error(string message)
{
    public string Message { get; set; } = message;

    public static implicit operator Error(string message) => new(message);
    public static implicit operator string(Error error) => error.Message;
}
