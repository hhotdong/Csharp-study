using System;

namespace keyword_new_and_override
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
            var baseObj = new Grandchild();

            baseObj         .Foo();
            ((Child)baseObj).Foo();
            ((Base)baseObj) .Foo();

            baseObj         .Bar();
            ((Child)baseObj).Bar();
            ((Base)baseObj) .Bar();

            /// Output
            // Grandchild Foo
            // Grandchild Foo
            // Grandchild Foo
            // Grandchild Bar
            // Child Bar
            // Base Bar
        }
    }
}
