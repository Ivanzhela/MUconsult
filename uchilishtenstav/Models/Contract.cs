public class Contract
{
    public int ID { get; set; }
    public int PropertyID { get; set; }
    public Property Property { get; set; } 

    public int? TenantID { get; set; }
    public Person Tenant { get; set; }

    public int? LandlordID { get; set; }
    public Person Landlord { get; set; }

    public DateTime ContractDate { get; set; }
    public decimal Deposit { get; set; }
    public int PaymentDueDay { get; set; }
    public string Notes { get; set; }
}
