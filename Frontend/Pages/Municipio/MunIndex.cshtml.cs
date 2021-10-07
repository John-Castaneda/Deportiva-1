using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages
{
    public class MunIndexModel : PageModel
    {
        //Creacion de objeto para manejar los repositorios de Persitencia
        private readonly IRepositorioMunicipio _repomunicipio;

        //Modelo u objeto para transportar hacia MunIndex.cshtml
        public IEnumerable<Municipio> Municipios{get;set;}

        //Constructor
        public MunIndexModel(IRepositorioMunicipio repomunicipio)
        {
            this._repomunicipio = repomunicipio;
        }
        public void OnGet()
        {
            Municipios = _repomunicipio.ListarMunicipios();
        }
    }
}
