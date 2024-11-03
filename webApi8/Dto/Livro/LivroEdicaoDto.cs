using webApi8.Models;

namespace webApi8.Dto.Autor
{
    public class LivroEdcaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}