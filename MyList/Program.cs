using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Emre Alkan");
            Console.WriteLine(names.Count); 
        }
    }

    class MyList<T>
    {
        T[] myArray;
        T[] tempArray;
        public MyList()
        {
            myArray = new T[0];
        }

        public void Add(T item)
        {
            tempArray = myArray;
            myArray = new T[myArray.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                myArray[i] = tempArray[i];
            }
            myArray[myArray.Length - 1] = item;
        }

        public int Count
        {
            get { return myArray.Length; }
        }
    }
}
