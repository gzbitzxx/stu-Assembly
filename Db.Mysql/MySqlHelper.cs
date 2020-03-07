using Demo1.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Mysql
{
    public class MySqlHelper : IDbHelper
    {
        public void Query()
        {
            Console.WriteLine("这是mysql实现的查询方法");
        }
    }
}
