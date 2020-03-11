using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 定义一个特性的类
/// </summary>
namespace Demo1
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class RemarkAttribute : Attribute
    {
        public string Remark { get; private set; }

        public RemarkAttribute(string remark)
        {
            this.Remark = remark;
        }
    }
}
