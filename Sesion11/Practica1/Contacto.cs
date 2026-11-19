using System;
using System.Collections.Generic;
using System.Text;

public class Contacto
{
    public int Id { get; set; }                 // EF la usa como clave por su nombre
    public string Nombre { get; set; } = "";
    public string Telefono { get; set; } = "";
    public string Correo { get; set; } = "";
}
