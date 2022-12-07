using System;

namespace NewAndOverride
{
    public class Base
    {
        public virtual void Foo()
        {
            Console.WriteLine("Base Foo");
        }

        public void Bar()
        {
            Console.WriteLine("Base Bar");
        }

        public void Func()
        {
            Console.WriteLine("Base Func");
            Foo();
            Bar();
        }
    }

    public class Child : Base
    {
        public override void Foo()
        {
            Console.WriteLine("Child Foo");
        }

        public new void Bar()
        {
            Console.WriteLine("Child Bar");
        }
    }

    public class Grandchild : Child
    {
        public override void Foo()
        {
            Console.WriteLine("Grandchild Foo");
        }

        public new void Bar()
        {
            Console.WriteLine("Grandchild Bar");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var grandChild = new Grandchild();
            grandChild         .Foo();
            ((Child)grandChild).Foo();
            ((Base)grandChild) .Foo();

            Console.WriteLine("-------------");

            grandChild         .Bar();
            ((Child)grandChild).Bar();
            ((Base)grandChild) .Bar();

            Console.WriteLine("-------------");

            grandChild.Func();

            Console.WriteLine("-------------");

            var child = new Child();
            child.Func();

            /// Output
            // Grandchild Foo
            // Grandchild Foo
            // Grandchild Foo
            // -------------
            // Grandchild Bar
            // Child Bar
            // Base Bar
            // -------------
            // Base Func
            // Grandchild Foo
            // Base Bar
            // -------------
            // Base Func
            // Child Foo
            // Base Bar
        }
    }
}
