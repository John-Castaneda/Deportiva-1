using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioPatrocinador:IRepositorioPatrocinador
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioPatrocinador(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioPatrocinador
        bool IRepositorioPatrocinador.CrearPatrocinador(Patrocinador patrocinador)
        {
            bool creado = false;
            try
            {
                _appContext.Patrocinadores.Add(patrocinador);
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

        bool IRepositorioPatrocinador.ActualizarPatrocinador(Patrocinador patrocinador)
        {
            bool actualizado = false;
            var _patrocinador = _appContext.Patrocinadores.Find(patrocinador.Id);
            if(patrocinador!=null)
            {
                try
                {
                    _patrocinador.Nombre = patrocinador.Nombre;
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

        bool IRepositorioPatrocinador.EliminarPatrocinador(int idPatrocinador)
        {
            bool eliminado = false;
            var patrocinador = _appContext.Patrocinadores.Find(idPatrocinador);
            if(patrocinador != null)
            {
                try
                {
                    _appContext.Patrocinadores.Remove(patrocinador);
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

        Patrocinador IRepositorioPatrocinador.BuscarPatrocinador(int idPatrocinador)
        {
            Patrocinador patrocinador=null;
            return patrocinador;
        }

        // Metodo para retornar todos los patrocinadores
        IEnumerable<Patrocinador> IRepositorioPatrocinador.ListarPatrocinadores()
        {
            return _appContext.Patrocinadores;
        }
    }
}