namespace DefaultNamespace;

public class Batch
{
    [Key]
    public int BatchNo { get; set; }
    public int Machine { get; set; }
    public string Type { get; set; }
    public DateTime DateTime { get; set; }
}