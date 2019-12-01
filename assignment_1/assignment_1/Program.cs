using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class employee
    {
        static void Main()
        {
            

            employee e1 = new employee();
            e1.Empno = 66;
            Console.WriteLine(e1.Empno);

            employee e2 = new employee();
            e2.Name ="sufi";
            Console.WriteLine(e2.Name);

            employee e3 = new employee();
            e3.Basic = 45000;
            Console.WriteLine(e3.Basic);

            employee e4 = new employee();
            e4.Deptno = 7;
            Console.WriteLine(e4.Deptno);

            Console.ReadLine();
        }

        private int empno;
        public int Empno
        {
            set
            {
                if (value > 0)
                {
                    empno = value;
                }
                else
                {
                    Console.WriteLine("Invalid..!!");
                }
            }
            get
            {
                return empno;
            }

        }
        private String name;
        public String Name
        {
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid..!!");

                }
                else
                {
                    //Console.WriteLine("valid..!!");
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }


        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 20000 && value < 50000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid Range!!");
                }
            }

            get
            {
                return basic;
            }


        }

        private short deptno;
        public short Deptno
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("Invalid Deptno!!");
                }
            }
            get
            {
                return deptno;
            }

        }

    }

    
}
