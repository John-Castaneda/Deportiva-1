using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioDeportista:IRepositorioDeportista
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioDeportista(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioDeportista
        bool IRepositorioDeportista.CrearDeportista(Deportista deportista)
        {
            bool creado = false;
            try
            {
                _appContext.Deportistas.Add(deportista);
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

        bool IRepositorioDeportista.ActualizarDeportista(Deportista deportista)
        {
            bool actualizado = false;
            var _deportista = _appContext.Deportistas.Find(deportista.Id);
            if(deportista!=null)
            {
                try
                {
                    _deportista.Nombres = deportista.Nombres;
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

        bool IRepositorioDeportista.EliminarDeportista(int idDeportista)
        {
            bool eliminado = false;
            var deportista = _appContext.Deportistas.Find(idDeportista);
            if(deportista != null)
            {
                try
                {
                    _appContext.Deportistas.Remove(deportista);
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

        Deportista IRepositorioDeportista.BuscarDeportista(int idDeportista)
        {
            Deportista deportista=null;
            return deportista;
        }

        // Metodo para retornar todos los deportistas
        IEnumerable<Deportista> IRepositorioDeportista.ListarDeportistas()
        {
            return _appContext.Deportistas;
        }
    }
}