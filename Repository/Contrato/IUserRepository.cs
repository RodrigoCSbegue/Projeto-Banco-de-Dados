using Segundo_App_BancoDados.Models;

namespace Segundo_App_BancoDados.Repository.Contrato
{
    public interface IUserRepository
    {
        // CRUD - Create, Read, Update, Delete

        IEnumerable<User> ObterTodosUsers();
        void Cadastrar(Usuario usuario);
        void Atualizar(Usuario usuario);
        Usuario ObterUsuario(int id);
        void Excluir(int id);
    }
}
