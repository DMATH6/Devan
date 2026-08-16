using System.ComponentModel.DataAnnotations;

public class Main
{
    [Key]
    public string Job { get; set; } = "";

    public string? JobDescription { get; set; }

    public string? Status { get; set; }

    public string? Owner { get; set; }

    public string? Priority { get; set; }
}