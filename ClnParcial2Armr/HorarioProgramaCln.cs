using CadParcial2Armr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Armr
{
    public class HorarioProgramaCln
    {
        public static int crear(HorarioPrograma horarioPrograma)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                var existe = context.HorarioPrograma.
                    Where(x => x.idCanal == horarioPrograma.idCanal
                     && x.titulo == horarioPrograma.titulo
                     && x.diaSemana == horarioPrograma.diaSemana
                     && x.horaInicio == horarioPrograma.horaInicio
                     && x.estado == 1)
                     .FirstOrDefault();
                if (existe != null) throw new Exception("El horario del programa ya existe.");

                // agregamos 

                horarioPrograma.clasificacion = horarioPrograma.clasificacion;

                context.HorarioPrograma.Add(horarioPrograma);
                context.SaveChanges();
                return horarioPrograma.id;
            }
        }
        public static int actualizar(HorarioPrograma horarioPrograma)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                var registro = context.HorarioPrograma.Where(x => x.id == horarioPrograma.id).FirstOrDefault();
                if (registro == null) throw new Exception("El horario del programa no existe.");

                registro.idCanal = horarioPrograma.idCanal;
                registro.titulo = horarioPrograma.titulo;
                registro.horaInicio = horarioPrograma.horaInicio;
                registro.horaFin = horarioPrograma.horaFin;
                registro.diaSemana = horarioPrograma.diaSemana;
                registro.conductorPrincipal = horarioPrograma.conductorPrincipal;
                //  nueva asignacion
                registro.clasificacion = horarioPrograma.clasificacion;
                registro.estado = horarioPrograma.estado;

                context.SaveChanges();
                return registro.id;
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                var registro = context.HorarioPrograma.Where(x => x.id == id).FirstOrDefault();
                if (registro == null) throw new Exception("El horario del programa no existe.");

                registro.estado = 0;

                context.SaveChanges();
                return registro.id;
            }
        }

        public static List<paHorarioProgramaListar_Result1> listar(string parametro)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                return context.paHorarioProgramaListar(parametro.Trim()).ToList();
            }
        }

        public static HorarioPrograma obtener(int id)
        {
            using (var context = new Parcial2ArmrEntities())
            {
                return context.HorarioPrograma.Where(x => x.id == id).FirstOrDefault();
            }
        }

    }
}
