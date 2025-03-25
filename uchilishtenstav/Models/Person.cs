public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; } 
    public string SearchPreferences { get; set; }

    public List<Contract> ContractsAsTenant { get; set; } = new List<Contract>();
    public List<Contract> ContractsAsLandlord { get; set; } = new List<Contract>();
}
