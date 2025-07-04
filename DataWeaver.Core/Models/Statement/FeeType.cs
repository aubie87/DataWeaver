namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Enumeration of fee types
/// </summary>
public enum FeeType
{
    /// <summary>
    /// Monthly maintenance fee
    /// </summary>
    MonthlyMaintenance,

    /// <summary>
    /// ATM fee
    /// </summary>
    ATM,

    /// <summary>
    /// Overdraft fee
    /// </summary>
    Overdraft,

    /// <summary>
    /// Insufficient funds fee
    /// </summary>
    InsufficientFunds,

    /// <summary>
    /// Wire transfer fee
    /// </summary>
    WireTransfer,

    /// <summary>
    /// Stop payment fee
    /// </summary>
    StopPayment,

    /// <summary>
    /// Check ordering fee
    /// </summary>
    CheckOrdering,

    /// <summary>
    /// Account closure fee
    /// </summary>
    AccountClosure,

    /// <summary>
    /// Foreign transaction fee
    /// </summary>
    ForeignTransaction,

    /// <summary>
    /// Cashier's check fee
    /// </summary>
    CashiersCheck,

    /// <summary>
    /// Paper statement fee
    /// </summary>
    PaperStatement,

    /// <summary>
    /// Excess transaction fee
    /// </summary>
    ExcessTransaction,

    /// <summary>
    /// Early withdrawal penalty
    /// </summary>
    EarlyWithdrawal,

    /// <summary>
    /// Other fee type
    /// </summary>
    Other
}