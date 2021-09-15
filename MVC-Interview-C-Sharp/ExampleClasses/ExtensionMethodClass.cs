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
            var conversionClass = new ConversionClass();
            var testVal = "45";
            var result = conversionClass.ToInt(testVal);

            //If you wanted to say testVal.ToInt() instead of conversionClass.ToInt(testVal)
            //how could you changes the conversion class to do that?
        }
    }
}
