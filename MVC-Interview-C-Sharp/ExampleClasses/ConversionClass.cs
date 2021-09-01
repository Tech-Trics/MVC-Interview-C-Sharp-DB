using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public class ConversionClass
    {        
        public int ToInt(string stringVal)
        {
            return int.Parse(stringVal);
        }
    }
}
