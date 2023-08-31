// using System;

// namespace MyApp// Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//          static void Main(string[] args)
//         {

//             //EJERCICIOS CON ESTRUCTURA SELECTIVA IF - ELSE

//             //PROGRAMA PARA PODER CALCULAR SI ES MAYOR DE EDAD

//             Console.WriteLine("\n---PROGRAMA QUE DETERMINE SI ES MAYOR DE EDAD---\n");

//             Console.WriteLine("\nIngrese tu edad: ");
//             int edad=Convert.ToInt32(Console.ReadLine());

//             if (edad >=18)
//             {
//                 Console.WriteLine("Tu edad es " + edad +  " eres mayor de edad ");

//             }
//             else{

//                 Console.WriteLine("Tu edad es " + edad + " Eres menor de edad");
//             }

//             Console.ReadKey();


//             Console.WriteLine("\n\n---PROGRAMA QUE DETERMINE SI UN NUMERO ES PAR O IMPAR---\n");
//             Console.WriteLine("\nIngrese un numero: ");
//             int numero=Convert.ToInt32(Console.ReadLine());

//             if (numero % 2 == 0)
//             {
//                 Console.WriteLine("\nEl numero " + numero + " es par");
//             }
//             else
//             {
//                 Console.WriteLine("\nEl numero " + numero + " es impar");
//             }

//             Console.ReadKey();
//         }
//     }
// }




using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---PROGRAMA DE CALIFICACIONES---\n");

            Console.WriteLine("\nIngrese una calificacion: ");
            double calificacion = Convert.ToDouble(Console.ReadLine());

            if (calificacion >= 9.5)
            {
                Console.WriteLine("La calificacion " + calificacion + " es Excelente");
            }
            else if (calificacion >= 8.5)
            {
                Console.WriteLine("La calificacion " + calificacion + " es Muy Buena");
            }
            else if (calificacion >= 7.0)
            {
                Console.WriteLine("La calificacion " + calificacion + " es Buena");
            }
            else
            {
                Console.WriteLine("La calificacion obtenida es Deficiente");
            }

            Console.WriteLine("\n---FIN DE PROGRAMA DE CALIFICACIONES---\n");
        }
    }
}

