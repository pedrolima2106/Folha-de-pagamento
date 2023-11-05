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

        public CadastroFModel BuscarPorLogin(string Login)
        {
            return _context.Lista.FirstOrDefault(x => x.LoginFuncionario.ToUpper() == Login.ToUpper());
        }

        /* public LoginModel BuscarPorEmailELogin(string email, string _login)
         {
             return _context.LoginF.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper() && x.Login.ToUpper() == login.ToUpper());
         }

         public LoginModel BuscarPorID(int id)
         {
             return _context.Usuarios.FirstOrDefault(x => x.Id == id);
         }*/

        public List<CadastroFModel> BuscarTodos()
        {
            return _context.Lista.ToList();
                /*.Include(x => x.Contatos)
                .ToList();*/
        }

        public CadastroFModel Adicionar(CadastroFModel usuario)
        {
           /* usuario.DataCadastro = DateTime.Now;
            usuario.SetSenhaHash();*/
            _context.Lista.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

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
            usuarioDB.DatadeNascimento = DateTime.Now;

            _context.Lista.Update(usuarioDB);
            _context.SaveChanges();

            return usuarioDB;
        }


       /* public UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel)
        {
            UsuarioModel usuarioDB = BuscarPorID(alterarSenhaModel.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização da senha, usuário não encontrado!");

            if (!usuarioDB.SenhaValida(alterarSenhaModel.SenhaAtual)) throw new Exception("Senha atual não confere!");

            if (usuarioDB.SenhaValida(alterarSenhaModel.NovaSenha)) throw new Exception("Nova senha deve ser diferente da senha atual!");

            usuarioDB.SetNovaSenha(alterarSenhaModel.NovaSenha);
            usuarioDB.DataAtualizacao = DateTime.Now;

            _context.Usuarios.Update(usuarioDB);
            _context.SaveChanges();

            return usuarioDB;
        }*/

        public bool Apagar(int id)
        {
            CadastroFModel usuarioDB = BuscarPorID(id);

            if (usuarioDB == null) throw new Exception("Houve um erro na deleção do usuário!");

            _context.Lista.Remove(usuarioDB);
            _context.SaveChanges();

            return true;
        }

        CadastroFModel IUsuarioRepositorio.BuscarPorLogin(string login)
        {
            throw new NotImplementedException();
        }

        CadastroFModel IUsuarioRepositorio.BuscarPorEmailELogin(string email, string login)
        {
            throw new NotImplementedException();
        }

        List<CadastroFModel> IUsuarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        CadastroFModel IUsuarioRepositorio.BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public CadastroFModel BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        /* CadastroFModel IUsuarioRepositorio.BuscarPorLogin(string login)
         {
             throw new NotImplementedException();
         }

         public CadastroFModel BuscarPorEmailELogin(string email, string login)
         {
             throw new NotImplementedException();
         }

         List<CadastroFModel> IUsuarioRepositorio.BuscarTodos()
         {
             throw new NotImplementedException();
         }


         public CadastroFModel Adicionar(CadastroFModel usuario)
         {
             throw new NotImplementedException();
         }

         public CadastroFModel Atualizar(CadastroFModel usuario)
         {
             throw new NotImplementedException();
         }*/

        /*
        public LoginModel Adicionar(LoginModel usuario)
        {
            throw new NotImplementedException();
        }

        public LoginModel Atualizar(LoginModel usuario)
        {
            throw new NotImplementedException();
        }

        LoginModel IUsuarioRepositorio.BuscarPorLogin(string login)
        {
            throw new NotImplementedException();
        }

        LoginModel IUsuarioRepositorio.BuscarPorEmailELogin(string email, string login)
        {
            throw new NotImplementedException();
        }

        List<LoginModel> IUsuarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        LoginModel IUsuarioRepositorio.BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public LoginModel Adicionar(LoginModel usuario)
        {
            throw new NotImplementedException();
        }

        public LoginModel Atualizar(LoginModel usuario)
        {
            throw new NotImplementedException();
        }*/
    }
}
