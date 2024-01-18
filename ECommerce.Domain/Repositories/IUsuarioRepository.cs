
using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario GetById(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
