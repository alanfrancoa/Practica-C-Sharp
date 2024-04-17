using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_C_Sharp
{
    internal class HelloWorld
    {
        private static IEnumerable<object> myArray;

        static void Main(string[] args)
        {
            /* 
             Esto es un
             Comentario 
            */
            Console.WriteLine("Hola Mundo");

            //Tipos de datos
            string myString = "Esto es una cadena de texto";
            myString = "cambiado";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt += 4;
            Console.WriteLine(myInt - 8);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myDouble + myDouble + myInt);

            bool myBool = true;
            Console.WriteLine(!myBool);

            dynamic myDinamic = 6;
            myDinamic = "Prueba";
            Console.WriteLine(myDinamic);

            var myVar = "Variable de tipo inferido";
            //myVar = 6; Error
            Console.WriteLine(myVar);

            //Concatenacion
            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool {myBool}");

            const string MyConst = "Mi constante"; //Constantes con Mayuscula
            Console.WriteLine(MyConst);

            //Estructuras
            var MyArray = new string[] { "Alan", "Franco", "Alvarez" };

            MyArray[2] = "36";
            Console.WriteLine(MyArray[2]);

            //Diccionario
            var myDiccionary = new Dictionary<string, int>
            {
                {"Alan", 30 },
                {"Trostsky", 7 },
                { "Misato", 4 }
            };
            Console.WriteLine(myDiccionary["Alan"]); //Muestra el valor 30

            var mySet = new HashSet<string> { "Alan", "Franco", "Alvarez", "Alvarez" }; //Set estructura sin repetidos

            var myTuple = ("Alan", "Franco", "Alvarez");
            Console.WriteLine(myTuple); //Recorre los valores pero no tiene indexado

            //Bucles
            //For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //ForEach
            foreach (var item in MyArray)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myDiccionary)
            {
                Console.WriteLine(item);
            }

            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }

            //Flujos
            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El numero es 11");
            }
            else if (myInt == 12)
            {
                Console.WriteLine("El numero es 12");
            }
            else
            {
                Console.WriteLine("El numero no es 11 y 12");
            }

            myFunction();
            Console.WriteLine(myFunctionWithReturn(5));

            //Llamamos la clase
            var myClass = new MyClass("Alan");
            myClass.myName = "Otro Nombre";
            Console.WriteLine(myClass.myName);

            Console.ReadKey();
        }
        //Funciones
        static void myFunction()
        {
            Console.WriteLine("Mi funcion!");
        }
        static int myFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        //Clases
        class MyClass
        {
            public string myName { get; set; }

            public MyClass(string myCurrentName)
            {
                this.myName = myCurrentName;
            }
        }
    }
}
