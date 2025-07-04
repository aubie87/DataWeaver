using System.ComponentModel.DataAnnotations;

namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Represents customer information on a bank statement
/// </summary>
public class CustomerInfo
{
    /// <summary>
    /// Customer's unique identifier
    /// </summary>
    [Required]
    public string CustomerId { get; set; } = string.Empty;

    /// <summary>
    /// Customer's full name
    /// </summary>
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Customer's mailing address
    /// </summary>
    public Address? MailingAddress { get; set; }

    /// <summary>
    /// Customer's phone number
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Customer's email address
    /// </summary>
    public string? EmailAddress { get; set; }
}