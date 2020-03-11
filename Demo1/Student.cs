using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    //[Obsolete("您弄好")]
    [Serializable]
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        [AttributeDome]
        public void Read() { 
        
        }
    }
}
