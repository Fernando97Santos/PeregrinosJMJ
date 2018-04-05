using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregrinosJMJ.Controladores
{
    class Inversion
    {
        peregrinosjmjEntities contexto = new peregrinosjmjEntities();

        public int guardar(inversion nueva)
        {
            contexto.inversion.Add(nueva);
            return contexto.SaveChanges();
        }

        public inversion buscar(int codgigo)
        {
            return contexto.inversion.Find(codgigo);
        }

        public List<inversion> getInversion()
        {
            return contexto.inversion.ToList();
        }

        public int eliminar(int codigo)
        {
            inversion p = contexto.inversion.Find(codigo);
            contexto.inversion.Remove(p);
            return contexto.SaveChanges();
        }

        public int modificar(inversion nuevo)
        {
            inversion p = contexto.inversion.Find(nuevo.id_inversion);
            p = nuevo;
            return contexto.SaveChanges();
        }
    }
}
