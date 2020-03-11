using Db.Sqlserver;
using Demo1.common;
using System;
using System.Reflection;

namespace Demo1
{
    /**
     * 反射学习
     * 
     * 程序的编译步骤
     * 
     * C#编写的代码-》编译器编译-》DLL/EXE-》CLR/JIT-》机器码（0110000）
     * 
     * IL叫中间语言，标准的面向对象语言，阅读性差
     * 
     * 反射：Reflection  就是一个帮助类库
     */
    public class Program
    {
        /// <summary>
        /// 使用反射加载函数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //没使用反射
            {
                /**
                 * 1、添加引用
                 * 2、实例化对象
                 * 3、调用方法
                 */
                //IDbHelper dbHelper = new SqlServerHelper();
                //dbHelper.Query();
            }
            //使用反射:Reflection
            {
                /**
                 * 反射加载的前提：将Dll放到项目的obj路径下
                 * 加载方式有4种
                 * load、loadFile、loadFrom 分别如下代码
                 * 
                 */
                //Assembly assembly = Assembly.Load("Db.Sqlserver");
                //Assembly assembly1 = Assembly.LoadFile(@"C:\Users\Bit\source\repos\CoreStuden\Demo1\obj\Debug\netcoreapp3.0\Db.Sqlserver.dll");
                //Assembly assembly2 = Assembly.LoadFrom("Db.Sqlserver.dll");
                //Assembly assembly3 = Assembly.LoadFrom(@"C:\Users\Bit\source\repos\CoreStuden\Demo1\obj\Debug\netcoreapp3.0\Db.Sqlserver.dll");

                ////输出就可以查看信息
                //foreach (Type type in assembly.GetTypes())
                //{
                //    Console.WriteLine("--|这是类的名称：{0}", type.FullName);

                //    foreach (MethodInfo method in type.GetMethods())
                //    {
                //        Console.WriteLine("----|这是类中方法的名称：{0}",method.Name);
                //    }
                //}

                //Console.ReadLine();
            }

            /*
             *反射的常规使用 
             * 
             */
            {
                //1、动态加载dll
                //Assembly assembly = Assembly.Load("Db.Sqlserver");

                //2、获取类型
                //Type type = assembly.GetType("Db.Sqlserver.SqlServerHelper");

                //3、实例化对象
                // obj= Activator.CreateInstance(type);

                //4.调用方法
                //obj.Query();//编译不通过，C# 是强类型语言

                //5、使用dynamic
                //dynamic dyn = Activator.CreateInstance(type);

                //6、调用方法
                //dyn.Query();
                //dyn.GetStuent();//这是不报错，因为dynamic是动态类型，可以避开编译器的检测，运行是检查

                //7、类型转换
                //IDbHelper dbHelper = obj as IDbHelper;

                //8、调用方法
                //dbHelper.Query();
            }

            //封装的方式
            {
                //IDbHelper dbHelper = DBFactory.CreateInstentce();
                //dbHelper.Query();
            }

            //调用方法
            //{
            //    //动态加载
            //    Assembly assembly = Assembly.Load("Db.Sqlserver");

            //    //获取类型
            //    Type type = assembly.GetType("Db.Sqlserver.Student");

            //    //创建对象
            //    object oTest = Activator.CreateInstance(type);

            //    //获取方法
            //    MethodInfo method = type.GetMethod("Read");

            //    //执行方法
            //    method.Invoke(oTest, new object[] { "周星星" });

            //    //获取方法
            //    MethodInfo memberInfo = type.GetMethod("Writer", new Type[] { typeof(string), typeof(int) });

            //    //多参数的方法
            //    memberInfo.Invoke(oTest, new object[] { "周星小棍", 10010 });

            //    //获取私有的方法
            //    MethodInfo method1 = type.GetMethod("Test", BindingFlags.Instance | BindingFlags.NonPublic);

            //    //输出数据
            //    method1.Invoke(oTest, new object[] { "xxx" });

            //    //---------------------泛型第一种调用
            //    //获取泛型方法
            //    MethodInfo method2 = type.GetMethod("Cat");

            //    //泛型传参数
            //    MethodInfo method3 = method2.MakeGenericMethod(new Type[] { typeof(string) });

            //    //调用方法
            //    method3.Invoke(oTest, new object[] { "THIS IS Cat" });

            //    //-----------------------------泛型第二种调用
            //    //Type type1 = type.MakeGenericType(new Type[] { typeof(string) });

            //    //object oTest2 = Activator.CreateInstance(type1);

            //    //MethodInfo method4 = type1.GetMethod("Cat");

            //    //method4.Invoke(oTest2, new object[] { "THIS IS Cat 2" });


            //    Singleton singleton = Singleton.CreateInstance();
            //    Singleton singleton2 = Singleton.CreateInstance();
            //    Singleton singleton3 = Singleton.CreateInstance();
            //    Console.WriteLine(singleton.Equals(singleton2));



            //    Type type1 = typeof(Student);
            //    object oStudent = Activator.CreateInstance(type1);
            //    type1.get();

            //}

            //特性学习
            {
                Student student = new Student();

                //获取 Remark 标记
                var remark = AttributeExtend.GetRemark<UserState>(UserState.Deleted);
                Console.WriteLine(remark);
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }

}
