using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Reto;

public class AgendaContext : DbContext
{
    public DbSet<Contacto> Contactos => Set<Contacto>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=agenda.db");
}
