using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    [Foo(1, 2, 3)]
    public class ClassA
    {
    }

    [Foo(4, 5)]
    public class ClassB : ClassA
    {
    }

    [Foo(6, 7, 8)]
    class ClassC : ClassB
    {
    }
}
