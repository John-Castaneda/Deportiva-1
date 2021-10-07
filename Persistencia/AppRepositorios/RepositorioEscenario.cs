using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEscenario:IRepositorioEscenario
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioEscenario(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioEscenario
        bool IRepositorioEscenario.CrearEscenario(Escenario escenario)
        {
            bool creado = false;
            try
            {
                _appContext.Escenarios.Add(escenario);
                _appContext.SaveChanges();
                creado = true;
            }
            catch(System.Exception)
            {
                return creado;
                // Throw
            }
            return creado;
        }

        bool IRepositorioEscenario.ActualizarEscenario(Escenario escenario)
        {
            bool actualizado = false;
            var _escenario = _appContext.Escenarios.Find(escenario.Id);
            if(escenario!=null)
            {
                try
                {
                    _escenario.Nombre = escenario.Nombre;
                    _appContext.SaveChanges();
                    actualizado = true;                   
                }
                catch(System.Exception)
                {
                    return actualizado;
                }
            }
            return actualizado;
        }

        bool IRepositorioEscenario.EliminarEscenario(int idEscenario)
        {
            bool eliminado = false;
            var escenario = _appContext.Escenarios.Find(idEscenario);
            if(escenario != null)
            {
                try
                {
                    _appContext.Escenarios.Remove(escenario);
                    _appContext.SaveChanges();
                    eliminado = true;
                }
                catch(System.Exception)
                {
                    return eliminado;
                }
            }
            return eliminado;
        }

        Escenario IRepositorioEscenario.BuscarEscenario(int idEscenario)
        {
            Escenario escenario=null;
            return escenario;
        }

        // Metodo para retornar todos los escenarios
        IEnumerable<Escenario> IRepositorioEscenario.ListarEscenarios()
        {
            return _appContext.Escenarios;
        }
    }
}