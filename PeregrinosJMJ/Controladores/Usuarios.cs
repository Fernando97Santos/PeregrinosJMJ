using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregrinosJMJ.Modelo
{
    class Usuarios
    {
        private peregrinosjmjEntities contexto = new peregrinosjmjEntities();
        public int agregar(usuarios nueva)
        {
            contexto.usuarios.Add(nueva);
            return contexto.SaveChanges();
        }

        public usuarios buscar(int codgigo)
        {
            return contexto.usuarios.Find(codgigo);
        }

        public List<usuarios> getUsuarios()
        {
            return contexto.usuarios.ToList();
        }

        public int eliminar(int codigo)
        {
            usuarios p = contexto.usuarios.Find(codigo);
            contexto.usuarios.Remove(p);
            return contexto.SaveChanges();
        }

        public int modificar(usuarios nuevo)
        {
            usuarios p = contexto.usuarios.Find(nuevo.id_usuario);
            p = nuevo;
            return contexto.SaveChanges();
        }
    }
}
