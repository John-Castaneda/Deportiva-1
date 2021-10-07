//Librerías | Referencias
// <>
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class EscuelaArbitro
    {
        public int Id {get;set;}
        public string Nit {get;set;}
        public string Nombre {get;set;}
        public string Resolucion {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Correo {get;set;}

        // Llave foranea para la relación con escenario
        public int ArbitroId {get;set;}
    }       
}