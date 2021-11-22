using System;

namespace ConsoleApp2
{
    [AttributeUsage(AttributeTargets.Class)]
    class FooAttribute : Attribute
    {
        public readonly int[] foo;

        public FooAttribute(params int[] bar)
        {
            foo = bar;
        }
    }
}
