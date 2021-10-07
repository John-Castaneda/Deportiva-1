//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class TorneoEquipo
    {
        // Llaves principales compuestas por los campos ID
        public int TorneoId {get;set;}
        public string EquipoId {get;set;}

        // Propiedad para navegar entre Torneos y Equipos
        public Torneo Torneo {get;set;}
        public Equipo Equipo {get;set;}
    }       
}