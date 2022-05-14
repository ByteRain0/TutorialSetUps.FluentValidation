using System.ComponentModel.DataAnnotations;

namespace FluentValidation.Models;

public class Lead
{
    [Required]
    public string Description { get; set; }

    [Required]
    public Guid CheckId { get; set; }
    
    [Required]
    [Range(0,365)]
    public int ExecutionDurationInDays { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }
    
    public List<string> Comments { get; set; }

    [Required]
    public Address Address { get; set; }
}