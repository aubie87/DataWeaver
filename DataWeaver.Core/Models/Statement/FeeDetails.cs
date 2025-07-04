namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Details for fee transactions
/// </summary>
public class FeeDetails
{
    /// <summary>
    /// Type of fee
    /// </summary>
    public FeeType FeeType { get; set; }

    /// <summary>
    /// Description of why the fee was charged
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// Base fee amount
    /// </summary>
    public decimal BaseFee { get; set; }

    /// <summary>
    /// Any additional charges
    /// </summary>
    public decimal AdditionalCharges { get; set; }

    /// <summary>
    /// Whether this fee can be waived
    /// </summary>
    public bool CanBeWaived { get; set; }

    /// <summary>
    /// Date the fee was waived (if applicable)
    /// </summary>
    public DateTime? WaivedDate { get; set; }
}