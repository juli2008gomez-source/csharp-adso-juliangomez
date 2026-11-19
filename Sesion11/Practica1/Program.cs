using Practica1;

using var db = new AgendaContext();
db.Database.EnsureCreated();

db.Contactos.Add(new Contacto { Nombre = "Ana", Telefono = "3001234567", Correo = "ana@gmail.com" });
db.Contactos.Add(new Contacto { Nombre = "Luis", Telefono = "3109876543", Correo = "luis@gmail.com" });
db.SaveChanges();   // ¡firma la planilla!

foreach (var c in db.Contactos.OrderBy(c => c.Nombre).ToList())
    Console.WriteLine($"{c.Id} · {c.Nombre} · {c.Telefono}");

var ana = db.Contactos.FirstOrDefault(c => c.Nombre == "Ana");
if (ana is not null)
{
    ana.Telefono = "3110000000";
    db.SaveChanges();
}

var primero = db.Contactos.Find(1);
if (primero is not null)
{
    db.Contactos.Remove(primero);
    db.SaveChanges();
}

Console.WriteLine($"La base está en: {Path.GetFullPath("agenda.db")}");