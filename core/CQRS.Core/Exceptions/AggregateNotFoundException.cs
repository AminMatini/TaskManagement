namespace CQRS.Core.Exceptions;

public class AggregateNotFoundException : Exception
{
    public AggregateNotFoundException(string errMsg) : base(errMsg)
    {
            
    }
}