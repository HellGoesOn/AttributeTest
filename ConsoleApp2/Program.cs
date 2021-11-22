using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class A: ");
            var foo1 = FullOf(typeof(ClassA));
            for (int i = 0; i < foo1.Count; i++)
                Console.Write(foo1[i] + " ");

            Console.WriteLine("\nClass B: ");
            var foo2 = FullOf(typeof(ClassB));
            for (int i = 0; i < foo2.Count; i++)
                Console.Write(foo2[i] + " ");

            Console.WriteLine("\nClass C: ");
            var foo3 = FullOf(typeof(ClassC));
            for (int i = 0; i < foo3.Count; i++)
                Console.Write(foo3[i] + " ");

            Console.Write("\n\n\n");
        }

        static List<int> FullOf(Type type)
        {
            List<int> result = new List<int>();

            FooAttribute att = (FooAttribute)Attribute.GetCustomAttribute(type, typeof(FooAttribute));

            Type parent = type.BaseType;

            if(parent != null)
            {
                var additions = FullOf(parent);
                foreach (int addition in additions)
                    result.Add(addition);
            }

            if(att != null)
            foreach (int addition in att.foo)
                result.Add(addition);

            return result;
        }
    }
}
