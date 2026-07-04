using Core.Utilities.Constants;

namespace Core.Utilities.Exceptions;

public class AlreadyExistException : Exception
{
    public AlreadyExistException() : base(ResultMessages.AlreadyExist)
    {}
    public AlreadyExistException(string message) : base(message)
    {}
}
