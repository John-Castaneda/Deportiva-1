//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Entrenador
    {
        public int Id {get;set;}
        public string Documento {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Genero {get;set;}
        public string DisciplinaDeportiva {get;set;}
        
        // Llave foranea a tabla equipo (1-1)
        public int EquipoId {get;set;}
    }       
}