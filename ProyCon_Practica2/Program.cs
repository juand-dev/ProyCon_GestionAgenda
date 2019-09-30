using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCon_Practica2
{
    class Program
    {
        static void Main(string[] args)
        { 
            var objAgenda = new clsAgenda();
            var lstEntradas = new List<clsEntrada>();  
            var objActividad = new clsActividad();
            var objRecordatorio = new clsRecordatorio();
            var objReunion = new clsReunion();

            Console.WriteLine("Ingrese datos de Agenda \n");
            Console.Write("Ingrese Nombre del Dueño: ");
            string strDueño = Console.ReadLine();

            Console.Write("Ingrese Año de agenda: ");
            int intAño = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingrese la cantidad de entradas: ");
            int intCantidadEntradas = int.Parse(Console.ReadLine());

            for (int i = 0; i < intCantidadEntradas; i++)
            {
                Console.Write("\nSeleccione Entrada.- Activida(A), Reunion(R), Recordatorio(E): ");
                string strOpcion = Console.ReadLine();

                Console.WriteLine("\nIngrese datos de Entrada: \n");
                Console.Write("Ingrese Titulo: ");
                string titulo = Console.ReadLine();

                Console.Write("Ingrese Descripcion: ");
                string descripcion = Console.ReadLine();

                Console.Write("Ingrese Fecha: ");
                string fecha = Console.ReadLine();

                switch (strOpcion.ToUpper())
                {
                    case "A":
                        Console.Write("Ingrese Hora: ");
                        string hora = Console.ReadLine();

                        Console.Write("Ingrese Duracion: ");
                        int duracion = int.Parse(Console.ReadLine());

                        objActividad.Agregar(titulo, descripcion, DateTime.Parse(fecha), hora, duracion);

                        lstEntradas.Add(objActividad);
                        break;

                    case "R":
                        Console.Write("Ingrese Lugar: ");
                        string Lugar = Console.ReadLine();

                        Console.Write("Ingrese Hora Inicio: ");
                        string horaInicio = Console.ReadLine();

                        Console.Write("Ingrese Hora Fin: ");
                        string HoraFin = Console.ReadLine();

                        objReunion.Agregar(titulo, descripcion, DateTime.Parse(fecha), Lugar, horaInicio, HoraFin);

                        lstEntradas.Add(objReunion);
                        break;

                    case "E":
                        Console.Write("Ingrese la Frecuencia: ");
                        string frecuencia = Console.ReadLine();

                        objRecordatorio.Agregar(titulo, descripcion, DateTime.Parse(fecha), frecuencia);

                        lstEntradas.Add(objRecordatorio);
                        break;
                }
            }

            objAgenda.Agregar(strDueño, intAño, lstEntradas);

            Console.WriteLine(objAgenda.Mostrar(DateTime.Parse("12/12/2018"), DateTime.Parse("12/12/2019"))); 
            Console.ReadLine();
        }
    }
}
