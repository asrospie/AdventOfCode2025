namespace AdventOfCode2025.Utils.Exceptions;

public class NotEnoughArgsException : Exception
{
    public NotEnoughArgsException()
    {}
    
    public NotEnoughArgsException(string msg) : base(msg)
    {}
    
    public NotEnoughArgsException(string msg, Exception inner) : base(msg, inner)
    {}
}

public class ConfigErrorException : Exception
{
    public ConfigErrorException()
    {}
    
    public ConfigErrorException(string msg) : base(msg)
    {}
    
    public ConfigErrorException(string msg, Exception inner) : base(msg, inner)
    {}
}
