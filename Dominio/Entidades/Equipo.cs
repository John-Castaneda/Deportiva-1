//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Equipo
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int CantidadDeportistas {get;set;}
        public string Disciplina {get;set;}

        // Propiedad para navegar entre la tabla de entrenadores
        public Entrenador Entrenador {get;set;} 

        // Llave foranea de patrocinadores
        public int PatrocinadorId {get;set;}

        // Propiedad navigacional hacia tabla intermedia TorneoEquipo
        public List<TorneoEquipo> TorneoEquipos {get;set;}

        // Propiedad para navegar en tabla de deportistas
        public List<Deportista> Deportistas {get;set;}
    }       
}