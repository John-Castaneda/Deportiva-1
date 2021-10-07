using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioTorneo:IRepositorioTorneo
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioTorneo(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioTorneo
        bool IRepositorioTorneo.CrearTorneo(Torneo torneo)
        {
            bool creado = false;
            try
            {
                _appContext.Torneos.Add(torneo);
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

        bool IRepositorioTorneo.ActualizarTorneo(Torneo torneo)
        {
            bool actualizado = false;
            var _torneo = _appContext.Torneos.Find(torneo.Id);
            if(torneo!=null)
            {
                try
                {
                    _torneo.Nombre = torneo.Nombre;
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

        bool IRepositorioTorneo.EliminarTorneo(int idTorneo)
        {
            bool eliminado = false;
            var torneo = _appContext.Torneos.Find(idTorneo);
            if(torneo != null)
            {
                try
                {
                    _appContext.Torneos.Remove(torneo);
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

        Torneo IRepositorioTorneo.BuscarTorneo(int idTorneo)
        {
            Torneo torneo=null;
            return torneo;
        }

        // Metodo para retornar todos los torneos
        IEnumerable<Torneo> IRepositorioTorneo.ListarTorneos()
        {
            return _appContext.Torneos;
        }
    }
}