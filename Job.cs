namespace Devan;

using System.ComponentModel.DataAnnotations;

public class Job
{
    [Key]
    public string JobName { get; set; } = "";


    public string Status { get; set; } = "";
    public string Priority { get; set; } = "";
}