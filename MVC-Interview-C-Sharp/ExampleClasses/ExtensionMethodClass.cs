using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public class StringDimesions
    {
        public string Height { get; set;}
    }

     public class IntDimesions
     {
        public int Height { get; set;}
     }

    public class MappingClass
    {
        private ConversionClass ConversionClass { get; set;}

        public MappingClass ()
	    {
            ConversionClass = new ConversionClass();
	    }

        public IntDimesions MapToIntDimesions(StringDimesions stringDimesions)
        {
            // Instead of ConversionClass.ToInt(stringDimesions.Height)
            // switch to exampleA.ToInt()
            return new IntDimesions
            {
                Height = ConversionClass.ToInt(stringDimesions.Height)
            };
        }
    }

    public class ExtensionMethodClass 
    {
        //implement .ToInt() here
    }
}
