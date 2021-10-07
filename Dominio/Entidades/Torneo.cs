using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Torneo
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Categoria {get;set;}
        public DateTime FechaInicial {get;set;}
        public DateTime FechaFinal {get;set;}
        public string Tipo{get;set;}

        // Propiedad Navigacional a la tabla intermedia TorneoEquipo
        public List<TorneoEquipo> TorneoEquipos {get;set;}

        // Llave foranea para la relación con municipio
        public int MunicipioId {get;set;}

        // Navigacionalidad hacia la tabla arbitros
        public List<Arbitro> Arbitros {get;set;}

        // Navigacionalidad hacia la tabla escenarios
        public List<Escenario> Escenarios {get;set;} 
    }       
}