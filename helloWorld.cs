/* using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        string myString = "Hola esto es un string";
        myString = "Ahora se cambia el contenido de la variable myString";

        Console.WriteLine(myString);

        int numero = 7;
        Console.WriteLine(numero);

        Boolean myBoolean = true;
        Console.WriteLine(myBoolean);

        float myFloat = 6.5f;
        Console.WriteLine(myFloat);

        double myDouble = 6.6;
        Console.WriteLine(myDouble);


        //Estructuras
        //creación de arreglos

        var myArray = new string[] {"Lucho", "Tiziano"};
        Console.WriteLine(myArray);
        Console.WriteLine(myArray[1]);


        var myDictionary = new Dictionary<string, int>
        {
            {"luciano", 28},
            {"angeles", 27},
            {"Tiziano", 9},
        };
        Console.WriteLine(myDictionary["luciano"]);


        var mySet = new HashSet<string>{"Lucho", "Tiziano"};

        var myTuple = ("Nancy", "Marcelo", "Leandro");
        Console.WriteLine(myTuple);

        //Bucles

        for(int i = 0; i <= 15; i++){
            Console.WriteLine(i);
        }

        foreach (var myItem in myArray){
            Console.WriteLine(myItem);
        }



    }
}


 */