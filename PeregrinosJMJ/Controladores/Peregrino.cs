using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregrinosJMJ.Clases
{
    class Peregrino
    {
        private peregrinosjmjEntities contexto = new peregrinosjmjEntities();
        public int agregarPeregrino(peregrinos nueva)
        {
            contexto.peregrinos.Add(nueva);
            return contexto.SaveChanges();
        }

        public peregrinos buscar(int codgigo)
        {
            return contexto.peregrinos.Find(codgigo);
        }

        public List<peregrinos> getPeregrinos()
        {
            return contexto.peregrinos.ToList();
        }

        public int eliminar(int codigo)
        {
            peregrinos p = contexto.peregrinos.Find(codigo);
            contexto.peregrinos.Remove(p);
            return contexto.SaveChanges();
        }

        public int modificar(peregrinos nuevo)
        {
            peregrinos p = contexto.peregrinos.Find(nuevo.id_peregrino);
            p = nuevo;
            return contexto.SaveChanges();
        }
    }
}
