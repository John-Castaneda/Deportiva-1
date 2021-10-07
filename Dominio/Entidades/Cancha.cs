//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Cancha
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Disciplina {get;set;}
        public string Estado {get;set;}
        public int CapacidadEspectadores {get;set;}
        public double Medidas {get;set;}

        // Llave foranea para la relación con escenario
        public int EscenarioId {get;set;}
    }       
}