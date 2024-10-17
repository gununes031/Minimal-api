namespace MinimalApi.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MinimalApi.Dominio.Entidades;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto(IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }
    public DbSet<Administrador> administradores { get; set; } = default!;

    public DbSet<Veiculo> Veiculos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador{
                Id = 1,
                Email = "admin@teste.com",
                Senha = "1234",
                Perfil = "Adm"
            }
           
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            var stringConexao = _configuracaoAppSettings.GetConnectionString("ConexaoPadrao")?.ToString();
        if(!string.IsNullOrEmpty(stringConexao))
        {
            optionsBuilder.UseSqlServer(stringConexao);
        }
        }
        


       
    }

}