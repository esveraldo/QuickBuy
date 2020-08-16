using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class UsuarioRepository : BaseReporitory<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return Context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
