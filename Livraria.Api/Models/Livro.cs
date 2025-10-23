
namespace Livraria.Api.Models;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int AutorId { get; set; }
    public Autor? Autor { get; set; }
}
