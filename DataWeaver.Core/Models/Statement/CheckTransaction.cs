using DataWeaver.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Represents a check transaction
/// </summary>
public class CheckTransaction : ITransaction
{
    /// <summary>
    /// Unique transaction identifier
    /// </summary>
    [Required]
    public string TransactionId { get; set; } = string.Empty;

    /// <summary>
    /// Date the transaction occurred
    /// </summary>
    [Required]
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// Transaction amount (typically negative for checks)
    /// </summary>
    [Required]
    public decimal Amount { get; set; }

    /// <summary>
    /// Description of the transaction
    /// </summary>
    [Required]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Running balance after this transaction
    /// </summary>
    [Required]
    public decimal RunningBalance { get; set; }

    /// <summary>
    /// Check number
    /// </summary>
    [Required]
    public string CheckNumber { get; set; } = string.Empty;

    /// <summary>
    /// Date the check was written (may differ from transaction date)
    /// </summary>
    public DateTime? DateWritten { get; set; }

    /// <summary>
    /// Payee name on the check
    /// </summary>
    public string? PayeeName { get; set; }

    /// <summary>
    /// Memo line from the check
    /// </summary>
    public string? MemoLine { get; set; }

    /// <summary>
    /// Status of the check
    /// </summary>
    [Required]
    public CheckStatus Status { get; set; } = CheckStatus.Cleared;

    /// <summary>
    /// Date the check was cleared
    /// </summary>
    public DateTime? ClearedDate { get; set; }

    /// <summary>
    /// Sequence number for ordering checks
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Indicates if this is a voided check
    /// </summary>
    public bool IsVoided { get; set; }

    /// <summary>
    /// Indicates if this is a stop payment
    /// </summary>
    public bool IsStopPayment { get; set; }
}