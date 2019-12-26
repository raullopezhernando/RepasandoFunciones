using System;

namespace RepasandoFunciones
{
    class Program
    {
        // SUMA -------------- TIPO 1 - FUNCIONES QUE EJECUTAN CODIGO
        // RESTA -------------TIPO 2 - FUCNCIONES QUE PUEDEN DEVOLVER UN VALOR

    
        static void Main(string[] args)
        {
            // Variables necesarias

            int opcion = 0;
            string valor = "";

            // Mostrar el menu

            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicacion");
            Console.WriteLine("4- Division");

            // Pedimos la opcion

            Console.Write("Escoge una opcion");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            // Verificacion de la suma

            if (opcion == 1) 
            {
                Suma();
            }


            // Verificacion de la resta

            if (opcion == 2)
            {
                // Variable para nuestro resultado
                float resultado = 0;

                // Invocar y obtener el resultado
                resultado = Resta();

                // Mostramos el resultado

                Console.WriteLine("El resultado de la resta es :{0}", resultado);

                
            }
        


            // Verificacion de la multiplicacion

            if (opcion == 3)
            {
                Multiplicacion();
            }


            // Verificacion de la division

            if (opcion == 4)
            {
                Division();
            }

        }
        // Funciones que ejecutan codigo : Ni cogen ni devuelvern valores
        static void Suma() 
        {
            // Declaramos las variables

            float a = 0;
            float b = 0;
            float r = 0;
            string numero = "";

            // Pedimos los valores

            Console.WriteLine("Dame el primer numero");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Dame el segundo numero");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            // Calcular el resultado

            r = a + b;

            // Mostramos el resultado

            Console.WriteLine("El resultado de sumar {0} + {1} = {2}",a, b, r);
                

        }

        static  float Resta()
        {
            // Declaramos las variables

            float a = 0; // Declaracion e inicializacion de variable a
            float b = 0;
            float r = 0;
            string numero = "";

            // Pedimos los valores

            Console.WriteLine("Dame el primer numero");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Dame el segundo numero");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            // Calcular el resultado
            r = a - b;

            return r;

        }

        static void Multiplicacion()
        {
            // Declaramos las variables

            float a = 0;
            float b = 0;
            float r = 0;
            string numero = "";

            // Pedimos los valores

            Console.WriteLine("Dame el primer numero");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Dame el segundo numero");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            // Calcular el resultado

            r = a - b;

            // Mostramos el resultado

            Console.WriteLine("El resultado de sumar {0} * {1} = {2}", a, b, r);


        }

        static void Division()
        {
            // Declaramos las variables

            float a = 0;
            float b = 0;
            float r = 0;
            string numero = "";

            // Pedimos los valores

            Console.WriteLine("Dame el primer numero");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Dame el segundo numero");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            // Calcular el resultado

            r = a - b;

            // Mostramos el resultado

            Console.WriteLine("El resultado de sumar {0} / {1} = {2}", a, b, r);


        }
    }
}
