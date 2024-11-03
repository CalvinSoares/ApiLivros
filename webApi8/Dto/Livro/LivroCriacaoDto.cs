using webApi8.Models;

namespace webApi8.Dto.Autor
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}