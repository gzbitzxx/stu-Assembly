using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Sqlserver
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public void Read(string name) {
            Console.WriteLine($"测试调用方法！{name}");
        }

        public void Writer(string name ,int id) {
            Console.WriteLine($"我的名字是：{name}，我的学号是{id}");
        }

        /// <summary>
        /// 反射调用私有的方法
        /// </summary>
        /// <param name="name"></param>
        private void Test(string name) {
            Console.WriteLine(name);
        }

        /// <summary>
        /// 泛型的方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tname"></param>
        public void Cat<T>(T tname) {
            Console.WriteLine(tname);
        }
    }
}
