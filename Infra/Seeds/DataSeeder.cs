using Domain.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Seeds
{
    public static class DataSeeder
    {
        public static void Seed(this ProjetoDbContext context)
        {
            if (!context.Usuarios.Any())
            {
                List<Usuario> usuarios = new List<Usuario>();

                for (int i = 0; i < 11; i++)
                {
                    usuarios.Add(new Usuario { Nome = "Usuário " + i, Email = "email" + i + "@teste.com" });
                }

                context.Usuarios.AddRange(usuarios);

                context.SaveChanges();
            }
        }
    }
}
