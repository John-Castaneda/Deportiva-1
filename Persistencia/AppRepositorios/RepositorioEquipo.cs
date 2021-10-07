using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEquipo:IRepositorioEquipo
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioEquipo(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioEquipo
        bool IRepositorioEquipo.CrearEquipo(Equipo equipo)
        {
            bool creado = false;
            try
            {
                _appContext.Equipos.Add(equipo);
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

        bool IRepositorioEquipo.ActualizarEquipo(Equipo equipo)
        {
            bool actualizado = false;
            var _equipo = _appContext.Equipos.Find(equipo.Id);
            if(equipo!=null)
            {
                try
                {
                    _equipo.Nombre = equipo.Nombre;
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

        bool IRepositorioEquipo.EliminarEquipo(int idEquipo)
        {
            bool eliminado = false;
            var equipo = _appContext.Equipos.Find(idEquipo);
            if(equipo != null)
            {
                try
                {
                    _appContext.Equipos.Remove(equipo);
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

        Equipo IRepositorioEquipo.BuscarEquipo(int idEquipo)
        {
            Equipo equipo=null;
            return equipo;
        }

        // Metodo para retornar todos los equipos
        IEnumerable<Equipo> IRepositorioEquipo.ListarEquipos()
        {
            return _appContext.Equipos;
        }
    }
}