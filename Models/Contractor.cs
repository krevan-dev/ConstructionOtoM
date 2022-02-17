namespace ConstructionThingy.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int? CompanyId { get; set; }
    public Company Company { get; set; }
  }
}