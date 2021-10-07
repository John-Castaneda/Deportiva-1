//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Escenario
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Horario {get;set;}

        // Llave foranea para la relación con Torneo
        public int TorneoId {get;set;}

        // Navigacionalidad hacia la tabla escenarios
        public List<Cancha> Canchas {get;set;}
    }       
}