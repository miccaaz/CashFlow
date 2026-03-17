using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Entities;

public class Expense
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public Decimal Amount { get; set; }
    public PaymentType PaymentType { get; set; }
}
