using System.ComponentModel.DataAnnotations;

namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Represents a bank statement containing one or more accounts
/// </summary>
public class Statement
{
    /// <summary>
    /// Unique identifier for the statement
    /// </summary>
    [Required]
    public string StatementId { get; set; } = string.Empty;

    /// <summary>
    /// The bank or financial institution name
    /// </summary>
    [Required]
    public string BankName { get; set; } = string.Empty;

    /// <summary>
    /// Start date of the statement period
    /// </summary>
    [Required]
    public DateTime StatementPeriodStart { get; set; }

    /// <summary>
    /// End date of the statement period
    /// </summary>
    [Required]
    public DateTime StatementPeriodEnd { get; set; }

    /// <summary>
    /// Date the statement was generated
    /// </summary>
    [Required]
    public DateTime GeneratedDate { get; set; }

    /// <summary>
    /// Customer information associated with this statement
    /// </summary>
    [Required]
    public CustomerInfo Customer { get; set; } = new();

    /// <summary>
    /// List of accounts included in this statement
    /// </summary>
    public List<Account> Accounts { get; set; } = new();

    /// <summary>
    /// Total number of accounts in this statement
    /// </summary>
    public int TotalAccounts => Accounts.Count;

    /// <summary>
    /// Combined balance of all accounts in this statement
    /// </summary>
    public decimal TotalBalance => Accounts.Sum(a => a.CurrentBalance);
}