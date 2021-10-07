using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEntrenador:IRepositorioEntrenador
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioEntrenador(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioEntrenador
        bool IRepositorioEntrenador.CrearEntrenador(Entrenador entrenador)
        {
            bool creado = false;
            try
            {
                _appContext.Entrenadores.Add(entrenador);
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

        bool IRepositorioEntrenador.ActualizarEntrenador(Entrenador entrenador)
        {
            bool actualizado = false;
            var _entrenador = _appContext.Entrenadores.Find(entrenador.Id);
            if(entrenador!=null)
            {
                try
                {
                    _entrenador.Nombres = entrenador.Nombres;
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

        bool IRepositorioEntrenador.EliminarEntrenador(int idEntrenador)
        {
            bool eliminado = false;
            var entrenador = _appContext.Entrenadores.Find(idEntrenador);
            if(entrenador != null)
            {
                try
                {
                    _appContext.Entrenadores.Remove(entrenador);
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

        Entrenador IRepositorioEntrenador.BuscarEntrenador(int idEntrenador)
        {
            Entrenador entrenador=null;
            return entrenador;
        }

        // Metodo para retornar todos los entrenadores
        IEnumerable<Entrenador> IRepositorioEntrenador.ListarEntrenadores()
        {
            return _appContext.Entrenadores;
        }
    }
}