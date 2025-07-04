namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Details for electronic transactions
/// </summary>
public class ElectronicTransactionDetails
{
    /// <summary>
    /// Terminal ID where transaction occurred
    /// </summary>
    public string? TerminalId { get; set; }

    /// <summary>
    /// ATM ID if applicable
    /// </summary>
    public string? AtmId { get; set; }

    /// <summary>
    /// Card number used (masked)
    /// </summary>
    public string? CardNumber { get; set; }

    /// <summary>
    /// Authorization code
    /// </summary>
    public string? AuthorizationCode { get; set; }

    /// <summary>
    /// Trace number
    /// </summary>
    public string? TraceNumber { get; set; }

    /// <summary>
    /// Network used (Visa, MasterCard, etc.)
    /// </summary>
    public string? Network { get; set; }
}