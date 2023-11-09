using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace biblioteca.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }

        public DbSet<Catalog> Catalogos {get; set;}
        public DbSet<Books> Livros {get; set;}
        public DbSet<GeneralBook> LivrosGenericos {get; set;}
        public DbSet<ReferenceBook> LivrosReferencia {get; set;}
        public DbSet<Member> Membros {get; set;}
        public DbSet<FacultyMember> MembrosFaculdade {get; set;}
        public DbSet<Student> Estudantes {get; set;}
        public DbSet<Librarian> Bibliotecarios {get; set;}
        public DbSet<Alert> Alertas {get; set;}
    }
}