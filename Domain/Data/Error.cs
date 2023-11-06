namespace DefaultNamespace;

public class Error
{
    [Key]
    public int BatchNo { get; set; }
    public string Reason { get; set; }
    public int ErrorMeters { get; set; }
    public DateTime DateTime { get; set; }
    public string Type { get; set; }
    public int Machine { get; set; }
}