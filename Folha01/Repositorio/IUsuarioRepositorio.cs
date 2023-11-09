using Folha01.Models;
using System.Collections.Generic;

namespace Folha01.Repositorio
{
    public interface IUsuarioRepositorio
    {
        // Método para buscar um usuário pelo login
        CadastroFModel BuscarPorLogin(string login);

        // Método para buscar um usuário por email e login
        CadastroFModel BuscarPorEmailELogin(string email, string login);

        // Método para buscar todos os usuários
        List<CadastroFModel> BuscarTodos();

        // Método para buscar um usuário por ID
        CadastroFModel BuscarPorID(int id);

        // Método para adicionar um novo usuário
        CadastroFModel Adicionar(CadastroFModel usuario);

        // Método para atualizar as informações de um usuário
        CadastroFModel Atualizar(CadastroFModel usuario);

        // Método para apagar um usuário com base no ID
        bool Apagar(int id);

        // Comentário de método que foi comentado
        // CadastroFModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);
    }
}
