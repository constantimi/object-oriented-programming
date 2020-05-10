using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class DelegateTutorial
    {
        delegate void DelegateExample(int a);
       
        void Start()
        {
            // Initializing of delegate
            // <delegate-type> <name> = <name-of-method>
            DelegateExample myDelegate = Bar;
            myDelegate.Invoke(5);

            // Use another class
            Foobar(Foo);
        }

        void Foobar(DelegateExample myDelegate)
        {
            myDelegate(50);
        }
        void Foo(int a)
        {

        }

        void Bar(int a)
        {

        }
    }
}
