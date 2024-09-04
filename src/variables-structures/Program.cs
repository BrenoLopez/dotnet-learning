using System;

namespace VariablesStructures
{

    struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

     double X;
     double Y;

    public override string ToString() => $"{X}, {Y}";
}

    class X
    {
        //attributes of class
        int x = default(int);

        char varChar = 'a';
        float varFloat = default(float);

        bool z = true;


        static void Main()
        {
            
            X x = new X();
            Console.WriteLine($"float = {(float)x.varFloat}, int = {(int)x.x}, char= {(char)x.varChar}, bool={(bool)x.z}");

            //scope variables
            string stringVariable = "variavel string";

            //multi initialization 
            int a = 0, b = 1, c = 2;

            //constant
            const string Greeting = "Hello";

            // implicit variable
            var greeting = "Hello";

            Console.WriteLine($"x= {(string)stringVariable} {greeting.GetType()}");

                        Coords coords = new Coords(0.0f, 0.0f);
                        Console.WriteLine(coords.ToString());

        }
    }
}