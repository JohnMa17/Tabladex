using System;

namespace tabla
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es un programa hecho para mostrar la tabla de multiplicar de dicho numero hasta el 12.\n");
            
            Console.WriteLine("Ingrese que numero se multiplicara:");
            int numero = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= 12)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i} ");
                i++;
            }
        }
    }
}