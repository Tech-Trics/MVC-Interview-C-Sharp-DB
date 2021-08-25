using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public class ExtensionMethodClass 
    {
        public void Test()
        {
            var testVal = "45";
            var result = int.Parse(testVal);

            //if you wanted to say testVal.ToInt() instead of int.Parse(testVal) how could you do that?
        }
    }
}
