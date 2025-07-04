namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Enumeration of transaction types
/// </summary>
public enum TransactionType
{
    /// <summary>
    /// Debit transaction (withdrawal)
    /// </summary>
    Debit,

    /// <summary>
    /// Credit transaction (deposit)
    /// </summary>
    Credit,

    /// <summary>
    /// ATM transaction
    /// </summary>
    ATM,

    /// <summary>
    /// Debit card transaction
    /// </summary>
    DebitCard,

    /// <summary>
    /// Electronic funds transfer
    /// </summary>
    ElectronicTransfer,

    /// <summary>
    /// Wire transfer
    /// </summary>
    WireTransfer,

    /// <summary>
    /// Direct deposit
    /// </summary>
    DirectDeposit,

    /// <summary>
    /// Automatic payment
    /// </summary>
    AutomaticPayment,

    /// <summary>
    /// Fee charge
    /// </summary>
    Fee,

    /// <summary>
    /// Interest payment
    /// </summary>
    Interest,

    /// <summary>
    /// Dividend payment
    /// </summary>
    Dividend,

    /// <summary>
    /// Online banking transfer
    /// </summary>
    OnlineTransfer,

    /// <summary>
    /// Mobile banking transaction
    /// </summary>
    MobileTransaction,

    /// <summary>
    /// Point of sale transaction
    /// </summary>
    PointOfSale,

    /// <summary>
    /// ACH transaction
    /// </summary>
    ACH,

    /// <summary>
    /// Returned item
    /// </summary>
    ReturnedItem,

    /// <summary>
    /// Service charge
    /// </summary>
    ServiceCharge,

    /// <summary>
    /// Adjustment
    /// </summary>
    Adjustment,

    /// <summary>
    /// Other transaction type
    /// </summary>
    Other
}