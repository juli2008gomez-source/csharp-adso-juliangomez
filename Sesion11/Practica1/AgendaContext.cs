using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Practica1;

public class AgendaContext : DbContext
{
    public DbSet<Contacto> Contactos => Set<Contacto>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=agenda.db");
}
