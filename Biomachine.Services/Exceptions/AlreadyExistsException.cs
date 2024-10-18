namespace Biomachine.Services.Exceptions;

public class AlreadyExistsException : Exception
{
    public AlreadyExistsException() { }
    public AlreadyExistsException(string message) : base(message) { }
    public AlreadyExistsException(string message, Exception exception) { }

    public int StatusCode => 409;
}
