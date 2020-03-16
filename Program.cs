using System;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encuesta Preferencias por tipos de programaciones en Televisión");

            int encuestados; 
            int noticias = 1;
            int magazines = 2;
            int novelas = 3;
            int peliculas = 4; 
            int opcion;
            int horasNoticias = 0;
            int horasMagazines = 0;
            int horasNovelas = 0;
            int horasPeliculas = 0;
    
            Console.WriteLine("¿Cuantas personas Participan?");
            
            encuestados = Convert.ToInt32(Console.ReadLine()); 

            for(int i = 0; encuestados > i; i++){

                int numeroParticipante = i + 1;
                Console.WriteLine("Participante Numero: " + numeroParticipante);
                
                int horas = 0;

                Console.WriteLine("¿Que tipo de programación frecuenta? ");
                Console.WriteLine(noticias +": noticias"); 
                Console.WriteLine(magazines +": magazines");
                Console.WriteLine(novelas+": novelas");
                Console.WriteLine(peliculas+": peliculas"); 

                Console.WriteLine("¡Escoja una de las opciones!");
                opcion = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("¿Cuantas Horas dedica a este tipo de programación?"); 
                horas = Convert.ToInt32(Console.ReadLine()); 
                if(opcion == noticias){
                    horasNoticias += horas;
                }else if(opcion == magazines){
                    horasMagazines += horas;
                }else if(opcion == novelas){
                    horasNovelas += horas;
                }else if(opcion == peliculas){
                    horasPeliculas += horas;
                }
            } 
        Console.WriteLine("El total de horas invertidas por tipo de programación son:"); 
        Console.WriteLine("En noticias: "+horasNoticias); 
        Console.WriteLine("En magazines: "+horasMagazines);
        Console.WriteLine("En novelas: "+horasNovelas);
        Console.WriteLine("En peliculas: "+horasPeliculas); 
        }
    }
}
