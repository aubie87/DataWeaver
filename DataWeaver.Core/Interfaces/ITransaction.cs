namespace DataWeaver.Core.Interfaces;

/// <summary>
/// Common interface for all transaction types
/// </summary>
public interface ITransaction
{
    /// <summary>
    /// Unique transaction identifier
    /// </summary>
    string TransactionId { get; set; }

    /// <summary>
    /// Date the transaction occurred
    /// </summary>
    DateTime TransactionDate { get; set; }

    /// <summary>
    /// Transaction amount (positive for credits, negative for debits)
    /// </summary>
    decimal Amount { get; set; }

    /// <summary>
    /// Description of the transaction
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Running balance after this transaction
    /// </summary>
    decimal RunningBalance { get; set; }
}