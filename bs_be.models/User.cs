using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bs_be.models;

public class User
{
    [Key]
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string? StreetAddress { get; set; }
    public string? StrictAddress { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public int? CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    [ValidateNever]
    public Company? Company { get; set; }
    [NotMapped]
    public string Role { get; set; }

}
