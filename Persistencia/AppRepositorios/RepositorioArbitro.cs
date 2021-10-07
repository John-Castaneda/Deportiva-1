using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioArbitro:IRepositorioArbitro
    {
        // Atributos
        private readonly AppContext _appContext;

        // Metodos
        // Constructor
        public RepositorioArbitro(AppContext appContext)
        {
            _appContext = appContext;
        }

        // Implementacion de metodos CRUD a la interfaz IRepositorioArbitro
        bool IRepositorioArbitro.CrearArbitro(Arbitro arbitro)
        {
            bool creado = false;
            try
            {
                _appContext.Arbitros.Add(arbitro);
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

        bool IRepositorioArbitro.ActualizarArbitro(Arbitro arbitro)
        {
            bool actualizado = false;
            var _arbitro = _appContext.Arbitros.Find(arbitro.Id);
            if(arbitro!=null)
            {
                try
                {
                    _arbitro.Nombres = arbitro.Nombres;
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

        bool IRepositorioArbitro.EliminarArbitro(int idArbitro)
        {
            bool eliminado = false;
            var arbitro = _appContext.Arbitros.Find(idArbitro);
            if(arbitro != null)
            {
                try
                {
                    _appContext.Arbitros.Remove(arbitro);
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

        Arbitro IRepositorioArbitro.BuscarArbitro(int idArbitro)
        {
            Arbitro arbitro=null;
            return arbitro;
        }

        // Metodo para retornar todos los arbitros
        IEnumerable<Arbitro> IRepositorioArbitro.ListarArbitros()
        {
            return _appContext.Arbitros;
        }
    }
}