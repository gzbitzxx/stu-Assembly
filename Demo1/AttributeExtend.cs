using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Demo1
{
    public static class AttributeExtend
    {
        public static string GetRemark<T>(T value)
        {
            //获取类型
            Type type = value.GetType();

            //获取字段
            var field = type.GetField(value.ToString());

            //检查这类型是不是 RemarkAttribute 定义的
            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                RemarkAttribute remarkAttribute = (RemarkAttribute)field.GetCustomAttribute(typeof(RemarkAttribute), true);
                return remarkAttribute.Remark;
            }
            return value.ToString();
        }
    }
}
