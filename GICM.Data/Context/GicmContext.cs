using GICM.Domain.Entityes;
using GICM.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using GICM.Data.Extensions;

public class GicmContext: DbContext
{

    public GicmContext(DbContextOptions<GicmContext> options)
            : base(options) { }

    #region DBSETS

    public DbSet<Usuario> Usuarios { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.ApplyConfiguration(new UsuarioMap());
    modelBuilder.SeedData();    
    

    base.OnModelCreating(modelBuilder);


    }
}
