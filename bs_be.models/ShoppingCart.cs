using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bs_be.models;

public class ShoppingCart
{
    [Key]
    public int Id { get; set; }
    public int ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    [ValidateNever]
    public Product Product { get; set; }
    public string UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    [ValidateNever]
    public User User { get; set; }
    [Range(1, 1000, ErrorMessage = "Please enter a value between 1 and 1000")]
    public int Count { get; set; }
    public double Price { get; set; }

}
