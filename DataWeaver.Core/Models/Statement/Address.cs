using System.ComponentModel.DataAnnotations;

namespace DataWeaver.Core.Models.Statement;

/// <summary>
/// Represents a mailing address
/// </summary>
public class Address
{
    /// <summary>
    /// Street address line 1
    /// </summary>
    [Required]
    public string Street1 { get; set; } = string.Empty;

    /// <summary>
    /// Street address line 2 (optional)
    /// </summary>
    public string? Street2 { get; set; }

    /// <summary>
    /// City name
    /// </summary>
    [Required]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// State or province
    /// </summary>
    [Required]
    public string State { get; set; } = string.Empty;

    /// <summary>
    /// Postal/ZIP code
    /// </summary>
    [Required]
    public string PostalCode { get; set; } = string.Empty;

    /// <summary>
    /// Country name
    /// </summary>
    [Required]
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Returns formatted address string
    /// </summary>
    public override string ToString()
    {
        var address = Street1;
        if (!string.IsNullOrEmpty(Street2))
            address += $", {Street2}";
        address += $", {City}, {State} {PostalCode}";
        if (!string.IsNullOrEmpty(Country))
            address += $", {Country}";
        return address;
    }
}