using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AttributeDome : Attribute
    {
    }
}
