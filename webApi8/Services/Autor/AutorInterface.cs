using webApi8.Dto.Autor;
using webApi8.Models;

namespace webApi8.Services.Autor
{
    public interface IAutorInterface
    {

        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto);
        Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdcaoDto autorEdcaoDto);
        Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idAutor);

    }
}
