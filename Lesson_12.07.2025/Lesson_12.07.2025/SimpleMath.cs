using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12._07._2025
{
    public class SimpleMath
    {
        int a = 0;
        int? b;

        /// <summary>
        /// Object object = null
        /// DateTime? date = object?.Property
        /// index(?[])
        /// 
        /// </summary>

        int c;
        public int DVariable { get; set; } 
        public int TodayTime { get; set; } = DateTime.Now.Year < 2000 ? DateTime.Now.Hour : DateTime.Now.Year;

        public void method()
        {
            if(b != null)
            {
                b = DateTime.DaysInMonth(2002, 10);
            }
        }


        public int CVariable
        {
            get { return c; }
            set { c = value; }
        }

        public SimpleMath(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Set(int b, int a)
        {
            this.a = a; this.b = b;
        }

        public string Get()
        {
            return $"{a} + {b}" ;
        }

        public void PrintC()
        {
            Console.WriteLine(c);
        }

    }
}
