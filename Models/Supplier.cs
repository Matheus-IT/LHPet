using System.Security.Cryptography.X509Certificates;

namespace LHPet.Models;

public class Supplier(
    int id,
    string name,
    string cnpj,
    string email
)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Cnpj { get; set; } = cnpj;
    public string Email { get; set; } = email;
}