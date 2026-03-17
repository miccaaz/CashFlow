using System;
using System.Collections.Generic;
using System.Text;

namespace CashFlow.Exception.ExceptionsBase;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> Errors { get; set; }
    public ErrorOnValidationException(List<string> errorMessages) : base(string.Empty)
    {
        Errors = errorMessages;
    }
}
