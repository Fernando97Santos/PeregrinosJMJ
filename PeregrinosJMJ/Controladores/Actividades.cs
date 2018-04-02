using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregrinosJMJ.Modelo
{
    class Actividades
    {
        private peregrinosjmjEntities contexto = new peregrinosjmjEntities();
        public int agregar(actividades nueva)
        {
            contexto.actividades.Add(nueva);
            return contexto.SaveChanges();
        }

        public actividades buscar(int codgigo)
        {
            return contexto.actividades.Find(codgigo);
        }

        public List<actividades> getPeregrinos()
        {
            return contexto.actividades.ToList();
        }

        public int eliminar(int codigo)
        {
            actividades p = contexto.actividades.Find(codigo);
            contexto.actividades.Remove(p);
            return contexto.SaveChanges();
        }

        public int modificar(actividades nuevo)
        {
            actividades p = contexto.actividades.Find(nuevo.id_actividad);
            p = nuevo;
            return contexto.SaveChanges();
        }
    }
}
