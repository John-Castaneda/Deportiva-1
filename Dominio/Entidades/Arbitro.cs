//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Arbitro
    {
        public int Id {get;set;}
        public string Documento {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Genero {get;set;}
        public string Celular {get;set;}
        public string Correo {get;set;}
        public string Disciplina {get;set;}
        
        // Llave foranea a tabla Torneo (1-*)
        public int TorneoId {get;set;}

        // Listar arbitros de la escuela de arbitros
        public List<EscuelaArbitro> EscuelaArbitros {get;set;} 
    }       
}