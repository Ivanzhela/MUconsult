using static System.Net.Mime.MediaTypeNames;

public class Property
{
    public int ID { get; set; }
    public string Type { get; set; }
    public string Kind { get; set; }
    public string Address { get; set; }
    public string Exposure { get; set; }
    public int? ConstructionYear { get; set; }
    public string Floor { get; set; }
    public string Layout { get; set; }
    public string Heating { get; set; }
    public string Notes { get; set; }
    public decimal? Price { get; set; }
    public string RentConditions { get; set; }

    public List<Contract> Contracts { get; set; } = new List<Contract>();

    public List<Image> Images { get; set; } = new List<Image>();
}
