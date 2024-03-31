using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_Boldyrev;

public sealed class OneDimensional<T> : BaseArray<T>
where T : IComparable<T> 
{
    private T[] array;
    private int size = 0;
    public const int defaultsize = 7;

    public OneDimensional()
    {
        array = new T[defaultsize]; // емкость по умолчанию
    }

    public OneDimensional(int n)
    {
        array = new T[n];
    }

    public override void Print()
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public T[] ReverseArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[array.Length - 1 - i];
        }
        return array;
    }

    //public int LengthOfArray()
    //{
      //  return array.Length + 1; //неправильно
    //}

    public T MinValue()
    {
        T min = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (min.CompareTo(array[i]) > 0)
            {
                min = array[i];
            }
        }
        return min;
    }

    public T[] adder_element(T item)
    {
        if (size>= array.Length)
        {
            int new_length = array.Length * 2 + 1;
            Array.Resize(ref array, new_length);
            array[size] = item;
            size++;
        }
        return array;
    }

    public T MaxValue()
    {
        T max = array[0];
        for(int i = 0; i< array.Length; i++)
        {
            if (max.CompareTo(array[i]) < 0)
            {
                max = array[i];
            }
        }
        return max;
    }

    public void elementInArray(T item)
    {
        bool boolen = false;
        for(int i =0; i < array.Length; i++)
        {
            if (array[i].CompareTo(item) == 0)
            {
                boolen = true;
            }
        }
        if (boolen)
        {
            Console.WriteLine("Элемент в массиве присутствует!");
        }
        else
        {
            Console.WriteLine("Элемент в массиве не присутствует!");
        }
    }

    public T[] SortArray()
    {
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = i+1; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    T item = array[i];
                    array[i] = array[j];
                    array[j] = item;
                }
            }
        }
        return array;
    }

    public TResult Min<TResult>(Func<T, TResult> projector)
    {
        Comparer<TResult> comparer = Comparer<TResult>.Default;
        TResult min = projector(array[0]);
        for(int i = 1; i < array.Length; i++)
        {
            var current = projector(array[i]);
            if(comparer.Compare(min, current) > 0)
            {
                min = current;
            }
        }
        return min;
    }

    public TResult Max<TResult>(Func<T, TResult> projector)
    {
        Comparer<TResult> comparer = Comparer<TResult>.Default;
        TResult max = projector(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            var current = projector(array[i]);
            if (comparer.Compare(max, current) < 0)
            {
                max = current;
            }
        }
        return max;
    }


    public void DoElement(Action<T> action)
    {
        for(int i = 0; i < array.Length; i++)
        {
            action(array[i]);
        }
    }

    public bool IfOnly_Cond(Func<T, bool> condition)
    {
        for(int i = 0;i<array.Length; i++)
        {
            if (condition(array[i]))
            {
                return true;
            }
        }
        return false;
    }
    


    //protected override void fill_RandomArray()
    //{
    //  Random random = new Random();
    //int length = random.Next(1, ss11);
    //array = new T[length];
    //for (int i = 0; i < array.Length; i++)
    //{
    //  array[i] = generator.Generate();
    //}
    //}

    //protected override void fillArray_by_User()
    //{
    //  Console.WriteLine("Введите длину массива: ");
    //int length = int.Parse(Console.ReadLine());

    //for (int i = 0; i < array.Length; i++)
    //{
    //  array[i] = generator.ConvertFromString(Console.ReadLine());
    //}
    //}

    //public override void Create(bool choice)
    //{
    //  Console.WriteLine("Введите длину массива: ");
    //int length = Convert.ToInt32(Console.ReadLine());
    //array = new T[length];
    //base.Create(choice);
    //}

    //private static bool Exists(int value, int[] array)
    //{
    //  for (int i = 0; i < array.Length; i++)
    //{
    //  if (array[i] == value)
    //{
    //  return true;
    //}
    //}
    //return false;
    //}

}

