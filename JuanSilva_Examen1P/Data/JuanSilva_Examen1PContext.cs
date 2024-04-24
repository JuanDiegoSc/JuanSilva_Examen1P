using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanSilva_Examen1P.Models;

namespace JuanSilva_Examen1P.Data
{
    public class JuanSilva_Examen1PContext : DbContext
    {
        public JuanSilva_Examen1PContext (DbContextOptions<JuanSilva_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JuanSilva_Examen1P.Models.JS_producto> JS_producto { get; set; } = default!;
    }
}
