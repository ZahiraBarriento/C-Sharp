using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml.Serialization;
using System.IO;

namespace TestHumano
{
    class Program
    {
        #region "Deserializar/Serializar Alumno"
        public static Alumno DeserializarAlumno()
        {
            Alumno retorno = new Alumno();

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\alumno.xml";
                XmlSerializer deserializar = new XmlSerializer(typeof(Alumno));
                using (StreamReader lectura = new StreamReader(path, true))
                {
                    retorno = (Alumno)deserializar.Deserialize(lectura);
                }    
            }

            catch(Exception)
            {
                retorno = null;
            }

            return retorno;
        }

        public static bool SerializarAlumno(Alumno alumno)
        {
            bool retorno = false;

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\alumno.xml";
                XmlSerializer serializar = new XmlSerializer(typeof(Alumno));
                using (StreamWriter escritura = new StreamWriter(path, true))
                {
                    serializar.Serialize(escritura, alumno);
                }

                retorno = true;
            }

            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region "Deserializar/Serializar Humano"
        public static Humano DeserializarHumano()
        {
            Humano retorno = new Humano();

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\humano.xml";
                XmlSerializer deserializar = new XmlSerializer(typeof(Humano));

                using (StreamReader lectura = new StreamReader(path, true))
                {
                    retorno = (Humano)deserializar.Deserialize(lectura);
                }
            }

            catch (Exception)
            {
                retorno = null;
            }

            return retorno;
        }

        public static bool SerializarHumano(Humano humano)
        {
            bool retorno = false;

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\humano.xml";
                XmlSerializer serializar = new XmlSerializer(typeof(Humano));
                using (StreamWriter escritura = new StreamWriter(path, true))
                {
                    serializar.Serialize(escritura, humano);
                    retorno = true;
                }
            }

            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region "Deserializar/Serealizar ListaHumanos

        public static List<Humano> DeserializarLista()
        {
            List<Humano> retorno = new List<Humano>();

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaHumanos.xml";
                XmlSerializer deserializar = new XmlSerializer(typeof(List<Humano>));

                using (StreamReader lectura = new StreamReader(path, true))
                {
                    retorno = (List<Humano>)deserializar.Deserialize(lectura);
                }
            }

            catch (Exception)
            {
                retorno = null;
            }

            return retorno;
        }

        public static bool SerializarLista(List<Humano> humano)
        {
            bool retorno = false;

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaHumanos.xml";
                XmlSerializer serializar = new XmlSerializer(typeof(List<Humano>));

                using (StreamWriter escritura = new StreamWriter(path, true))
                {
                    serializar.Serialize(escritura, humano);
                    retorno = true;
                }
            }

            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        #endregion

        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            Humano humano = new Humano();
            Profesor profesor = new Profesor();
            List<Humano> listaHumanos = new List<Humano>();

            #region "Alumno"

            Console.WriteLine("\nAlumno");
            alumno.nombre = "Lucas";
            alumno.apellido = "Vargas";
            alumno.Dni = 48591263;
            alumno.Legajo = 4869;
            Console.WriteLine(alumno);

            if (SerializarHumano(alumno))
            {
                Console.WriteLine("Se ha podido serializar");
            }

            else
            {
                Console.WriteLine("No se ha podido serializar");
            }

            alumno = (Alumno)Program.DeserializarHumano();

            if(alumno == null)
            {
                Console.WriteLine("Se ha podido deserializar");
            }

            else
            {
                Console.WriteLine("No se ha podido deserializar");
            }

            #endregion

            #region "Humano"

            Console.WriteLine("\nHumano");
            humano.Dni = 45698523;
            Console.WriteLine(humano);

            if (SerializarHumano(humano))
            {
                Console.WriteLine("Se ha podido serializar");
            }

            else
            {
                Console.WriteLine("No se ha podido serializar");
            }

            humano = Program.DeserializarHumano();

            if (humano == null)
            {
                Console.WriteLine("Se ha podido deserializar");
            }

            else
            {
                Console.WriteLine("No se ha podido deserializar");
            }

            #endregion

            #region "Profesor"

            Console.WriteLine("\nProfesor");
            profesor.nombre = "Carlos";
            profesor.apellido = "Vial";
            profesor.Dni = 65985326;
            profesor.Titulo = "Programador";
            Console.WriteLine(profesor);

            if (SerializarHumano(profesor))
            {
                Console.WriteLine("Se ha podido serializar");
            }

            else
            {
                Console.WriteLine("No se ha podido serializar");
            }

            profesor = (Profesor)Program.DeserializarHumano();

            if (profesor == null)
            {
                Console.WriteLine("Se ha podido deserializar");
            }

            else
            {
                Console.WriteLine("No se ha podido deserializar");
            }

            #endregion

            #region "Lista Humanos"

            Console.WriteLine("\nLista Humanos");

            listaHumanos.Add(humano);
            listaHumanos.Add(alumno);
            listaHumanos.Add(profesor);

            if (SerializarLista(listaHumanos))
            {
                Console.WriteLine("Se ha podido serializar");
            }

            else
            {
                Console.WriteLine("No se ha podido serializar");
            }

            listaHumanos = Program.DeserializarLista();

            if (listaHumanos == null)
            {
                Console.WriteLine("Se ha podido deserializar");
            }

            else
            {
                Console.WriteLine("No se ha podido deserializar");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
