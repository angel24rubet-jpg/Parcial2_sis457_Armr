using CadParcial2Armr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Armr
{
    public class CanalCln
    {
        public static int crear(Canal canal)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                var existe = context.Canal.Where(x => x.nombre == canal.nombre || x.frecuencia == canal.frecuencia).FirstOrDefault();
                if (existe != null) throw new Exception("El canal ya existe.");

                context.Canal.Add(canal);
                context.SaveChanges();
                return canal.id;
            }
        }

        public static int actualizar(Canal canal)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                var registro = context.Canal.Where(x => x.id == canal.id).FirstOrDefault();
                if (registro == null) throw new Exception("El canal no existe.");

                registro.nombre = canal.nombre;
                registro.frecuencia = canal.frecuencia;
                registro.estado = canal.estado;

                context.SaveChanges();
                return registro.id;
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                var registro = context.Canal.Where(x => x.id == id).FirstOrDefault();
                if (registro == null) throw new Exception("El canal no existe.");

                registro.estado = 0;

                context.SaveChanges();
                return registro.id;
            }
        }

        public static List<Canal> listar()
        {
            using (var context = new Parcial2ArmrEntities())
            {
                return context.Canal
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.nombre).ToList();
            }
        }

        public static Canal obtener(int id)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                return context.Canal.Where(x => x.id == id).FirstOrDefault();
            }
        }
    }
}