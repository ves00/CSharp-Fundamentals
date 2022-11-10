using System;

namespace ObjectsAndClasses_Exercise
{
    internal class Program
    {
        static void Main()
        {
            MyClass instance1 = new MyClass(5);
            MyClass insrance2 = new MyClass(10);

            instance1.Add(1);
            Console.WriteLine(instance1.Count);

            insrance2.Add(2);
            Console.WriteLine(insrance2.Count);
        }
    }

    public class MyClass
    {
        //Fields -> private
        private int[] data;
        private int count;  

        //Constructors (Special methods -> Automatically involved when creating new instamce of the class)
        public MyClass(int n)
        {
            this.data = new int[5];
            this.Count = 0;
        }

        //Properties
        //Syntax sugar
        public int Count { get; private set; }

        public int GetCount()
        {
            return count;
        }

        public void SetCount(int value)
        {
            this.count = value;
        }

        //Methods (Behavior)
        public void Add(int el)
        {
            this.data[this.Count] = el;
            this.Count++;
        }
    }
}
