using System;

namespace Task_Boldyrev;

class MainClass
{
    public static void Main()
    {
        Random random = new Random();
        OneDimensional<int> array;
        OneDimensional<int> array1 = new OneDimensional<int>();
        Console.WriteLine("Массив будет введен автоматически? да/нет");
        string choice = Console.ReadLine();
        if(choice == "да")
        {
            array = new OneDimensional<int>();
            for(int i = 0; i < 5; i++)
            {
                int n = random.Next(1, 101);
                array.adder_element(n);
            }
            array.Print();
            array.SortArray();
            array.Print();
            array.ReverseArray();
            array.Print();
            Console.WriteLine(array.MaxValue());
            Console.WriteLine(array.MinValue());
            array.elementInArray(10);
        }
        else if(choice == "нет")
        {
            array = new OneDimensional<int>(int.Parse(Console.ReadLine()));
            array = new OneDimensional<int>();
            for (int i = 0; i < 5; i++)
            {
                int n = random.Next(1, 101);
                array.adder_element(n);
            }
            array.Print();
            array.SortArray();
            array.Print();
            array.ReverseArray();
            array.Print();
            Console.WriteLine(array.MaxValue());
            Console.WriteLine(array.MinValue());
            array.elementInArray(10);
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
        Console.ReadKey();
    }
}



