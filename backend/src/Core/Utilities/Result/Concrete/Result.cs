namespace Core.Utilities.Result.Concrete;

public class Result : Abstract.IResult
{
    public string Message {get;}
    public bool Success {get;}

    public Result(bool success)
    {
        Success = success;
    }
    public Result(bool success, string message) : this(success)
    {
        Message = message;
    }
}
