using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Sqlserver
{
    public class Student
    {
        public void Read(string name) {
            Console.WriteLine($"测试调用方法！{name}");
        }

        public void Writer() { 
        }
    }
}
