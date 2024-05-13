namespace LHPet.Models;

public class Client(
    int id,
    string name,
    string cpf,
    string email,
    string patient
)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Cpf { get; set; } = cpf;
    public string Email { get; set; } = email;
    public string Patient { get; set; } = patient;
}