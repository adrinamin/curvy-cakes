namespace CurvyCakes.Entities;

public class Account
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Amount { get; set; }
    public string Bank { get; set; }
}