using Business.Models;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> databaseContext):base(databaseContext)
        {

        }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Quadro> Quadros { get; set; }
        public DbSet<SubTarefa> SubTarefas { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
