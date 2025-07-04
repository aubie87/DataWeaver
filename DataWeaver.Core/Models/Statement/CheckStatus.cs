namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Enumeration of check statuses
/// </summary>
public enum CheckStatus
{
    /// <summary>
    /// Check has been cleared
    /// </summary>
    Cleared,

    /// <summary>
    /// Check is pending clearance
    /// </summary>
    Pending,

    /// <summary>
    /// Check was returned/bounced
    /// </summary>
    Returned,

    /// <summary>
    /// Check was voided
    /// </summary>
    Voided,

    /// <summary>
    /// Stop payment placed on check
    /// </summary>
    StopPayment,

    /// <summary>
    /// Check is outstanding/not yet cleared
    /// </summary>
    Outstanding
}