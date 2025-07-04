using DataWeaver.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Represents a general transaction (debit, credit, fee, etc.)
/// </summary>
public class GeneralTransaction : ITransaction
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
    /// Transaction amount (positive for credits, negative for debits)
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
    /// Type of transaction
    /// </summary>
    [Required]
    public TransactionType TransactionType { get; set; }

    /// <summary>
    /// Category of the transaction
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Reference number for the transaction
    /// </summary>
    public string? ReferenceNumber { get; set; }

    /// <summary>
    /// Electronic transaction details
    /// </summary>
    public ElectronicTransactionDetails? ElectronicDetails { get; set; }

    /// <summary>
    /// Fee information if this is a fee transaction
    /// </summary>
    public FeeDetails? FeeDetails { get; set; }

    /// <summary>
    /// Transfer details if this is a transfer transaction
    /// </summary>
    public TransferDetails? TransferDetails { get; set; }

    /// <summary>
    /// Indicates if this transaction is pending
    /// </summary>
    public bool IsPending { get; set; }

    /// <summary>
    /// Indicates if this transaction was reversed
    /// </summary>
    public bool IsReversed { get; set; }

    /// <summary>
    /// Date the transaction was posted (may differ from transaction date)
    /// </summary>
    public DateTime? PostedDate { get; set; }

    /// <summary>
    /// Merchant or institution name
    /// </summary>
    public string? MerchantName { get; set; }

    /// <summary>
    /// Location where transaction occurred
    /// </summary>
    public string? Location { get; set; }
}