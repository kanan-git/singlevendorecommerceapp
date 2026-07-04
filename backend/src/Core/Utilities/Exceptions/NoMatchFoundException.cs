using Core.Utilities.Constants;

namespace Core.Utilities.Exceptions;

public class NoMatchFoundException : Exception
{
    public NoMatchFoundException() : base(ResultMessages.NoMatchFound)
    {}
    public NoMatchFoundException(string message) : base(message)
    {}
}
