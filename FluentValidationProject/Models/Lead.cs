using System.ComponentModel.DataAnnotations;

namespace FluentValidation.Models;

public class Lead
{
    public string Description { get; set; }
    public Guid CheckId { get; set; }
    public int ExecutionDurationInDays { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<string> Comments { get; set; }
    public Address Address { get; set; }
}