using Demo1.common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace Demo1
{
    public class DBFactory
    {
        /*
         * 这里需要导入：using System.Configuration;
         * **/
        private static string IDBhelpConfig = ConfigurationManager.AppSettings["IDbHelper"];

        private static string DllName = IDBhelpConfig.Split(',')[0];
        private static string TypeName = IDBhelpConfig.Split(',')[1];
        public static IDbHelper CreateInstentce()
        {
            //1、动态加载dll
            Assembly assembly = Assembly.Load(DllName);

            //2、获取类型
            Type type = assembly.GetType(TypeName);

            //3、实例化对象
            object obj = Activator.CreateInstance(type);

            //类型转
            IDbHelper dbHelper = obj as IDbHelper;

            //返回对象
            return dbHelper;
        }

    }
}
