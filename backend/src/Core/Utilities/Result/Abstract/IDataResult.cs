namespace Core.Utilities.Result.Abstract;

public interface IDataResult<T>
{
    public string Message {get;}
    public bool Success {get;}
    public T Data {get;}
}
