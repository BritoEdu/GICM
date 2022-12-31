using GICM.Domain.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GICM.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasData( 
               new Usuario { Id = Guid.Parse("8c6011a9-d115-4bf9-aade-ee25024d44f7"), Nome = "UsuarioPadrão", Email = "emailpadrao@gicm.com" }
            );
            return builder;
        }
    }
}
