namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Details for transfer transactions
/// </summary>
public class TransferDetails
{
    /// <summary>
    /// Source account number
    /// </summary>
    public string? FromAccount { get; set; }

    /// <summary>
    /// Destination account number
    /// </summary>
    public string? ToAccount { get; set; }

    /// <summary>
    /// Bank routing number for external transfers
    /// </summary>
    public string? RoutingNumber { get; set; }

    /// <summary>
    /// Bank name for external transfers
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Type of transfer
    /// </summary>
    public TransferType TransferType { get; set; }

    /// <summary>
    /// Confirmation number for the transfer
    /// </summary>
    public string? ConfirmationNumber { get; set; }

    /// <summary>
    /// Whether this is a recurring transfer
    /// </summary>
    public bool IsRecurring { get; set; }

    /// <summary>
    /// Frequency of recurring transfers
    /// </summary>
    public string? RecurringFrequency { get; set; }
}