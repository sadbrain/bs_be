﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bs_be.models;

public class Company
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string? StreetAddress { get; set; }
    public string? StrictAddress { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? PhoneNumber { get; set; }

}
