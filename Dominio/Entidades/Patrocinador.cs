//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Patrocinador
    {
        public int Id {get;set;}
        public string Identificacion {get;set;}
        public string Nombre {get;set;}
        public string TipoPersona {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        
        // Propiedad para navegar hacia la tabla equipos
        public List<Equipo> Equipos {get;set;}
    }       
}