using System;

namespace RepasandoFunciones
{
    class Program
    {
        // SUMA -------------- TIPO 1 - FUNCIONES QUE EJECUTAN CODIGO
        // RESTA -------------TIPO 2 - FUNCIONES QUE PUEDEN DEVOLVER UN VALOR
        // MULTIPLICACION ------- TIPO3 - FUNCIONES QUE TRABAJAN CON VALORES PASADOS POR EL PROGRAMA
        // DIVISION ------------- TIPO 4 - FUNCIONES QUE RECIBEN PARAMETROS Y REGRESAN UN VALOR

    
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
                // Variables necesarias

                float n1 = 0;
                float n2 = 0;
                string numero = "";

                // Pedimos los numeros

                Console.WriteLine("Dame el primer numero");
                numero = Console.ReadLine();
                n1 = Convert.ToSingle(numero);


                Console.WriteLine("Dame el segundo numero");
                numero = Console.ReadLine();
                n2 = Convert.ToSingle(numero);

                // Invocamos la funcion

                Multiplicacion(n1, n2);

            }


            // Verificacion de la division

            if (opcion == 4)
            {
                // Variables necesarias

                float n1 = 0.0f; // Definicion e iniciacion de variable n1
                float n2 = 0.0f; // Definicion e iniciacion de variable n2
                float resultado = 0.0f; // Definicion e iniciacion de variable resultado
                string numero = ""; // Definicion e iniciacion de variable numero

                // Pedimos los valores

                Console.WriteLine("Dame el primer numero");
                numero = Console.ReadLine();
                n1 = Convert.ToSingle(numero);

                Console.WriteLine("Dame el segundo numero");
                numero = Console.ReadLine();
                n2 = Convert.ToSingle(numero);

                // Invocamos la funcion

                resultado = Division(n1, n2);

                // Mostramos el resultado

                Console.WriteLine("El resultado es {0}", resultado);
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

        static void Multiplicacion(float a , float b)
        {
            // Declaramos las variables

           
            float r = 0;
           

           

            // Calcular el resultado

            r = a * b;

            // Mostramos el resultado

            Console.WriteLine("El resultado de sumar {0}", r);


        }

        static float Division(float a ,float b)

        // En este tipo de funciones solo se podra devolver un valor pero habla que devolver un return
        // para cada ruta de ejecucion

        {
            // Variables necesarias

           
            float r = 0;


            // Verificacomos la division entre 0

            if (b == 0)
            {
                Console.WriteLine("No es posible dividir entre 0");
                return 0.0f;
            }
            else 
            {
                r = a / b;
                return r;

            }
        
        }
    }
}
