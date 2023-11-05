using Folha01.Models;
using System.Collections.Generic;

namespace Folha01.Repositorio
{
    public interface IUsuarioRepositorio
    {
        CadastroFModel BuscarPorLogin(string login);
        CadastroFModel BuscarPorEmailELogin(string email, string login);
        List<CadastroFModel> BuscarTodos();
        CadastroFModel BuscarPorID(int id);
        CadastroFModel Adicionar(CadastroFModel usuario);
        CadastroFModel Atualizar(CadastroFModel usuario);
       /* CadastroFModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);*/
        bool Apagar(int id);
    }
}
