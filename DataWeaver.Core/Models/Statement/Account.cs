using DataWeaver.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Represents a bank account with its transactions and summary information
/// </summary>
public class Account
{
    /// <summary>
    /// Unique account number
    /// </summary>
    [Required]
    public string AccountNumber { get; set; } = string.Empty;

    /// <summary>
    /// Type of account (Checking, Savings, etc.)
    /// </summary>
    [Required]
    public AccountType AccountType { get; set; }

    /// <summary>
    /// Human-readable account name or description
    /// </summary>
    [Required]
    public string AccountName { get; set; } = string.Empty;

    /// <summary>
    /// Current account balance
    /// </summary>
    [Required]
    public decimal CurrentBalance { get; set; }

    /// <summary>
    /// Available balance (may differ from current balance due to holds)
    /// </summary>
    [Required]
    public decimal AvailableBalance { get; set; }

    /// <summary>
    /// Beginning balance for the statement period
    /// </summary>
    [Required]
    public decimal BeginningBalance { get; set; }

    /// <summary>
    /// Ending balance for the statement period
    /// </summary>
    [Required]
    public decimal EndingBalance { get; set; }

    /// <summary>
    /// Total deposits during the statement period
    /// </summary>
    public decimal TotalDeposits { get; set; }

    /// <summary>
    /// Total withdrawals during the statement period
    /// </summary>
    public decimal TotalWithdrawals { get; set; }

    /// <summary>
    /// Interest earned during the statement period
    /// </summary>
    public decimal InterestEarned { get; set; }

    /// <summary>
    /// Total fees charged during the statement period
    /// </summary>
    public decimal TotalFees { get; set; }

    /// <summary>
    /// Minimum balance during the statement period
    /// </summary>
    public decimal MinimumBalance { get; set; }

    /// <summary>
    /// Maximum balance during the statement period
    /// </summary>
    public decimal MaximumBalance { get; set; }

    /// <summary>
    /// Average daily balance during the statement period
    /// </summary>
    public decimal AverageDailyBalance { get; set; }

    /// <summary>
    /// List of check transactions
    /// </summary>
    public List<CheckTransaction> CheckTransactions { get; set; } = new();

    /// <summary>
    /// List of general transactions (debits, credits, etc.)
    /// </summary>
    public List<GeneralTransaction> GeneralTransactions { get; set; } = new();

    /// <summary>
    /// Total number of transactions for this account
    /// </summary>
    public int TotalTransactions => CheckTransactions.Count + GeneralTransactions.Count;

    /// <summary>
    /// All transactions sorted by date
    /// </summary>
    public IEnumerable<ITransaction> AllTransactions => 
        CheckTransactions.Cast<ITransaction>()
            .Concat(GeneralTransactions.Cast<ITransaction>())
            .OrderBy(t => t.TransactionDate);
}