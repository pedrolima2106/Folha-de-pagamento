using Folha01.Data;
using Folha01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Folha01.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Context _context;

        public UsuarioRepositorio(Context context)
        {
            this._context = context;
        }

        // Método para buscar um usuário pelo login
        public CadastroFModel BuscarPorLogin(string Login)
        {
            return _context.Lista.FirstOrDefault(x => x.LoginFuncionario.ToUpper() == Login.ToUpper());
        }

        // Método para buscar todos os usuários
        public List<CadastroFModel> BuscarTodos()
        {
            return _context.Lista.ToList();
        }

        // Método para adicionar um novo usuário
        public CadastroFModel Adicionar(CadastroFModel usuario)
        {
            _context.Lista.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        // Método para atualizar as informações de um usuário
        public CadastroFModel Atualizar(CadastroFModel usuario)
        {
            CadastroFModel usuarioDB = BuscarPorID(usuario.IdFuncionario);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário!");

            usuarioDB.NomeFuncionario = usuario.NomeFuncionario;
            usuarioDB.Email = usuario.Email;
            usuarioDB.LoginFuncionario = usuario.LoginFuncionario;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.Cpf = usuario.Cpf;
            usuarioDB.Cep = usuario.Cep;
            usuarioDB.DatadeNascimento = usuario.DatadeNascimento; // Corrigido para usar a data fornecida

            _context.Lista.Update(usuarioDB);
            _context.SaveChanges();

            return usuarioDB;
        }

        // Método para apagar um usuário com base no ID
        public bool Apagar(int id)
        {
            CadastroFModel usuarioDB = BuscarPorID(id);

            if (usuarioDB == null) throw new Exception("Houve um erro na deleção do usuário!");

            _context.Lista.Remove(usuarioDB);
            _context.SaveChanges();

            return true;
        }

        // Método para buscar um usuário por ID (método da interface)
        public CadastroFModel BuscarPorID(int id)
        {
            return _context.Lista.FirstOrDefault(x => x.IdFuncionario == id);
        }

        // Método para buscar um usuário pelo login (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        CadastroFModel IUsuarioRepositorio.BuscarPorLogin(string login)
        {
            throw new NotImplementedException();
        }

        // Método para buscar um usuário por email e login (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        CadastroFModel IUsuarioRepositorio.BuscarPorEmailELogin(string email, string login)
        {
            throw new NotImplementedException();
        }

        // Método para buscar todos os usuários (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        List<CadastroFModel> IUsuarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        // Método para buscar um usuário por ID (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        CadastroFModel IUsuarioRepositorio.BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        // Método para adicionar um usuário (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        CadastroFModel IUsuarioRepositorio.Adicionar(CadastroFModel usuario)
        {
            throw new NotImplementedException();
        }

        // Método para atualizar um usuário (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        CadastroFModel IUsuarioRepositorio.Atualizar(CadastroFModel usuario)
        {
            throw new NotImplementedException();
        }

        // Método para apagar um usuário (não implementado)
        // Este método lança uma exceção de "Não Implementado" para indicar que a implementação está em falta.
        bool IUsuarioRepositorio.Apagar(int id)
        {
            throw new NotImplementedException();
        }

        // Os métodos a seguir estão comentados, e a interface não os requer atualmente. Eles podem ser implementados no futuro, se necessário.
        /*
        public CadastroFModel BuscarPorEmailELogin(string email, string login)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel)
        {
            throw new NotImplementedException();
        }
        */

        // Implementação dos métodos da interface que foram comentados
        // (descomentar e implementar, se necessário)

        /* CadastroFModel IUsuarioRepositorio.BuscarPorEmailELogin(string email, string login)
        {
            throw new NotImplementedException();
        }

        List<CadastroFModel> IUsuarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }
        */
    }
}
