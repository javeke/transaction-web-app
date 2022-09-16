using System.ComponentModel.DataAnnotations;

namespace WebService.Models;

public class Transaction {
    public int id { get; set; }

    [Required]
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string? orderType { get; set; }
    public string? stock { get; set; }
}