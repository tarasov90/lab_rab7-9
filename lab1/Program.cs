using System;

namespace lab1
{
    class Program
    {
        class A { }

        class B : A {
            public A a;

            public B(A a) {
                this.a = a;
            }
        }

        class C : B {
            public A a2;
            public B b;

            public C(A a, A a2, B b) : base(a) {
                this.a2 = a2;
                this.b = b;
            }
        }

        static void Main()
        {
            C c = new C(new A(), new A(), new B(new A()));
        }
    }
}
