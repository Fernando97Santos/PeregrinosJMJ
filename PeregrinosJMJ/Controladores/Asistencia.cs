using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregrinosJMJ.Controladores
{
    class Asistencia
    {
        peregrinosjmjEntities contexto = new peregrinosjmjEntities();

        public int guardar(asistencia nueva)
        {
            contexto.asistencia.Add(nueva);
            return contexto.SaveChanges();
        }

        public asistencia buscar(int codgigo)
        {
            return contexto.asistencia.Find(codgigo);
        }

        public List<asistencia> getAsistencias()
        {
            return contexto.asistencia.ToList();
        }

        public int eliminar(int codigo)
        {
            asistencia p = contexto.asistencia.Find(codigo);
            contexto.asistencia.Remove(p);
            return contexto.SaveChanges();
        }

        public int modificar(asistencia nuevo)
        {
            asistencia p = contexto.asistencia.Find(nuevo.id_asistencia);
            p = nuevo;
            return contexto.SaveChanges();
        }
    }
}
