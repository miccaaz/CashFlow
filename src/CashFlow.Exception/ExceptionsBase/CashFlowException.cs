namespace CashFlow.Exception.ExceptionsBase;

public abstract class CashFlowException : SystemException
{
    public CashFlowException(string errorMessage) : base(errorMessage)
    { 
    }
}
