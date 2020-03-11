using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Sqlserver
{
    public class Singleton
    {
        public static Singleton _singletion=null;

        private Singleton() {
            Console.WriteLine("构造函数被调用");
        }

        static Singleton() {
            _singletion = new Singleton();
        }

        public static Singleton CreateInstance() {
            return _singletion;
        }
    }
}
