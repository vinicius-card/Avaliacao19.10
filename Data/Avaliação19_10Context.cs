using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avaliação19._10.Pages.Funcionarios;
using Avaliação19._10.Pages.Alunos;
using Avaliação19._10.Pages.Treinamentos;

namespace Avaliação19._10.Data
{
    public class Avaliação19_10Context : DbContext
    {
        public Avaliação19_10Context (DbContextOptions<Avaliação19_10Context> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = VINICIUSDARKDEL\SQLEXPRESS; Initial Catalog=BDAutoEscola; Integrated Security = true");
        }

        public DbSet<Avaliação19._10.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<Avaliação19._10.Pages.Alunos.Aluno> Aluno { get; set; }

        public DbSet<Avaliação19._10.Pages.Treinamentos.Treinamento> Treinamento { get; set; }
    }
}
