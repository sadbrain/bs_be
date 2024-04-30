using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bs_be.models;

public class OrderHeader
{
    public int Id { get; set; }
    public string UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    [ValidateNever]
    public User User { get; set; }
    public DateTime OrderDate { get; set; }
    public double OrderTotal { get; set; }
    public string? OrderStatus { get; set; }
    public DateTime ShippingDate { get; set; }
    public string? TrackingNumber { get; set; }
    public string? Carrier { get; set; }
    public string? PaymentStatus { get; set; }
    public string? SessionId { get; set; }
    public string? PaymentIntentId { get; set; }
    public DateTime PaymentDate { get; set; }
    [NotMapped] 
    public DateOnly PaymentDueDate { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string? StreetAddress { get; set; }
    [Required]
    public string? StrictAddress { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public string? PostalCode { get; set; }
    [Required]
    public string? PhoneNumber { get; set; }

}
