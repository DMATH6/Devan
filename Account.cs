namespace Devan;

using System.ComponentModel.DataAnnotations;

public class Account
{
    [Key]
    public string AccountName { get; set; } = "";

    public string Role { get; set; } = "";
}