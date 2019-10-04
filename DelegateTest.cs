using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0917
{
    class Class2
    {
        delegate int Mydelegate(int a, int b);
        static int Add(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            Mydelegate d1;
            //////////////////////////////////////////////////
            d1 = new Mydelegate(Add);  //C# 1.0 문법
            d1 = Add;                         //C# 2.0 문법
            d1 = delegate(int a, int b)    //익명 매서드
            {
                return a + b;
            };
            d1 =  (int a, int b) =>  a + b; //람다식
            /////////////////////////////////////////////////
            int result = d1(3, 5);


            var t = new { Name = "홍길동", Age = 20 };
            string s = t.Name;
            Console.WriteLine(s);

            var list = new[]
            {
                new { Name = "Lee", Age = 23, Phone = "02-111-1110" },
                new { Name = "Kin", Age = 24, Phone = "02-111-1110" },
                new { Name = "Park", Age = 25, Phone = "02-111-1110" }
            };
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + item.Age);
            }
        }
    }
}
