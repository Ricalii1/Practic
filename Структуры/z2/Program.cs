using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace z1
    {
        class MyClass
        {
            public string change;
        }
        struct MyStruct
        {
            public string change;
            public void StruktTaker()
            {
                change = "Изменено";
            }
        }

        class Program
        {
            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "Изменено";
            }

            static void Main(string[] args)
            {
                MyClass mcl = new MyClass();
                MyStruct mstruc = new MyStruct();

                mcl.change = "Не изменено";
                mstruc.change = "Не изменено";

                ClassTaker(mcl);
                mstruc.StruktTaker();

                Console.WriteLine(mcl.change);
                Console.WriteLine(mstruc.change);

                Console.ReadKey();
            }
        }
    }

}
