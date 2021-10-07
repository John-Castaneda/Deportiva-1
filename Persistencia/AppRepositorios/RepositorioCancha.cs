using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioCancha:IRepositorioCancha
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioCancha(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioCancha
        bool IRepositorioCancha.CrearCancha(Cancha cancha)
        {
            bool creado = false;
            try
            {
                _appContext.Canchas.Add(cancha);
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

        bool IRepositorioCancha.ActualizarCancha(Cancha cancha)
        {
            bool actualizado = false;
            var _cancha = _appContext.Canchas.Find(cancha.Id);
            if(cancha!=null)
            {
                try
                {
                    _cancha.Nombre = cancha.Nombre;
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

        bool IRepositorioCancha.EliminarCancha(int idCancha)
        {
            bool eliminado = false;
            var cancha = _appContext.Canchas.Find(idCancha);
            if(cancha != null)
            {
                try
                {
                    _appContext.Canchas.Remove(cancha);
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

        Cancha IRepositorioCancha.BuscarCancha(int idCancha)
        {
            Cancha cancha=null;
            return cancha;
        }

        // Metodo para retornar todos los canchas
        IEnumerable<Cancha> IRepositorioCancha.ListarCanchas()
        {
            return _appContext.Canchas;
        }
    }
}