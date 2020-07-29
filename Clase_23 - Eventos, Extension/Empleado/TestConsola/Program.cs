using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace TestConsola
{
    class Program
    {
        public static void LimiteSueldoEmpleado(Empleado e, float s)
        {
            Console.WriteLine("El empleado " + e.Nombre + " con legajo " + e.Legajo.ToString() + " se le asigno el sueldo " + s.ToString());
        }

        public void GuardarLog(Empleado e, float s)
        {
            StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"incidentes.log", true);

            try
            {
                streamWriter.WriteLine(DateTime.Now);
                streamWriter.WriteLine("Nombre: {0}", e.Nombre);
                streamWriter.WriteLine("Legajo: {0}", e.Legajo);
                streamWriter.WriteLine("Sueldo: {0}", e.Sueldo);
                streamWriter.Close();
            }

            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            Program program = new Program();

            e.limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            e.limiteSueldo += new DelegadoSueldo(program.GuardarLog); //Solo se guarda si se dispara en evento

            e.Nombre = "Rogelio";
            e.Legajo = 123;
            e.Sueldo = 15000;

            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
