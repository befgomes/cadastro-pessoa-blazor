using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Pessoas.Data;
public class AppDbContext: DbContext
{
    public AppDbContext (DbContextOptions options) : base(options)
    {

    }
    DbSet<Pessoa> Pessoas { get; set; } = null!;
}
