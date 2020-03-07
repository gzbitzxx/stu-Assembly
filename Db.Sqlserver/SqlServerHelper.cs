using Demo1.common;
using System;

namespace Db.Sqlserver
{
    public class SqlServerHelper : IDbHelper
    {
        public SqlServerHelper() {
            Console.WriteLine("----执行 SqlServerHelper 构造函数----");
        }
        public void Query()
        {
            Console.WriteLine("这是SqlServer实现的方法");
        }
    }
}
