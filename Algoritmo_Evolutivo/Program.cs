using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Evolutivo
{
    class Program
    {
        static void Main(string[] args)
        {           
            string objetivo = "MVM INGENIERIA DE SOFTWARE";           
            Cadena cadena = new Cadena(objetivo.Length);
            bool logrado = false;
            int generacion = 1;
            while (!logrado)               
            {
                int puntuacionMayor = cadena.getPuntuacion(objetivo);
                string cadenaString = cadena.getCadena();
                for (int i=1; i<50; i++)             
                {
                    Cadena cadenaMutar = new Cadena(cadenaString);
                    cadenaMutar.mutar();
                    int puntacion = cadenaMutar.getPuntuacion(objetivo);
                    if(puntacion  > puntuacionMayor)
                    {                       
                        puntuacionMayor = puntacion;
                        cadena = cadenaMutar;
                    }
                }
                Console.WriteLine($"Generación: {generacion} - Mutación: {cadena.getCadena()} - Puntaje: {puntuacionMayor}");
                logrado = puntuacionMayor==objetivo.Length;
                generacion++;
            }
            Console.WriteLine("Presione un tecla para salir...");
            Console.Read();
            
        }
    }
}
