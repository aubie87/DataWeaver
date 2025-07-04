namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Enumeration of transfer types
/// </summary>
public enum TransferType
{
    /// <summary>
    /// Transfer between accounts at the same bank
    /// </summary>
    Internal,

    /// <summary>
    /// Transfer to external bank account
    /// </summary>
    External,

    /// <summary>
    /// Wire transfer
    /// </summary>
    Wire,

    /// <summary>
    /// ACH transfer
    /// </summary>
    ACH,

    /// <summary>
    /// Online banking transfer
    /// </summary>
    Online,

    /// <summary>
    /// Mobile banking transfer
    /// </summary>
    Mobile,

    /// <summary>
    /// Phone banking transfer
    /// </summary>
    Phone,

    /// <summary>
    /// Branch transfer
    /// </summary>
    Branch,

    /// <summary>
    /// Automatic transfer
    /// </summary>
    Automatic
}