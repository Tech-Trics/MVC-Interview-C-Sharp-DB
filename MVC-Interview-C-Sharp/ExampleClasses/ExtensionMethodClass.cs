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
            
            return new IntDimesions
            {
                Height = ConversionClass.ToInt(stringDimesions.Height)
            };

            // Challenge 1: Uncomment the block below and implement ToInt() as an
            // extension method in ExtensionMethodClass so this compiles and runs.
            //return new IntDimesions
            //{
            //    Height = stringDimesions.Height.ToInt()
            //};
        }
    }

    // ---------------------------------------------------------------------------
    // Extension methods – implement the bodies of each method below.
    // Each method has a comment describing expected behaviour.
    // ---------------------------------------------------------------------------
    public static class ExtensionMethodClass
    {
        // Challenge 1: ToInt()
        // Parse a string to int.
        // Behaviour contract:
        //   • null / whitespace / non-numeric  → throw FormatException (same as int.Parse)
        // Hint: use int.Parse(value)
        public static int ToInt(this string value)
        {
            // TODO: implement
            throw new NotImplementedException("Challenge 1 – implement ToInt()");
        }

        // Challenge 2a: ToIntOrDefault()
        // Parse a string to int, returning defaultValue when parsing fails.
        // Behaviour contract:
        //   • null / whitespace / non-numeric  → return defaultValue (no exception)
        // Hint: use int.TryParse(value, out var result)
        public static int ToIntOrDefault(this string value, int defaultValue = 0)
        {
            // TODO: implement
            throw new NotImplementedException("Challenge 2a – implement ToIntOrDefault()");
        }

        // Challenge 2b: ToIntOrNull()
        // Parse a string to int?, returning null when parsing fails.
        // Behaviour contract:
        //   • null / whitespace / non-numeric  → return null (no exception)
        // Hint: use int.TryParse(value, out var result)
        public static int? ToIntOrNull(this string value)
        {
            // TODO: implement
            throw new NotImplementedException("Challenge 2b – implement ToIntOrNull()");
        }

        // Challenge 3: TryToInt()
        // Mirror the BCL TryParse pattern as an extension method.
        // Behaviour contract:
        //   • returns true and sets result when parsing succeeds
        //   • returns false and sets result = 0 when parsing fails
        // Hint: delegate directly to int.TryParse(value, out result)
        public static bool TryToInt(this string value, out int result)
        {
            // TODO: implement
            result = 0;
            throw new NotImplementedException("Challenge 3 – implement TryToInt()");
        }

        // Challenge 4a: Tap<T>()
        // Execute a side-effect action on a value and return the *same* value unchanged
        // (useful for fluent debugging / logging in method chains).
        // Behaviour contract:
        //   • action must not be null
        //   • returns obj so chaining continues
        public static T Tap<T>(this T obj, Action<T> action)
        {
            // TODO: implement
            throw new NotImplementedException("Challenge 4a – implement Tap<T>()");
        }

        // Challenge 4b: Let<T, TR>()
        // Apply a transformation function to a value and return the result
        // (the functional "let" / "pipe" operator).
        // Behaviour contract:
        //   • func must not be null
        //   • returns func(obj)
        public static TR Let<T, TR>(this T obj, Func<T, TR> func)
        {
            // TODO: implement
            throw new NotImplementedException("Challenge 4b – implement Let<T, TR>()");
        }

        // Challenge 5: WithHeight()
        // Extension targeting StringDimesions – return a *new* StringDimesions with
        // Height replaced by the supplied value (immutable-style update).
        // Behaviour contract:
        //   • src must not be null
        //   • other properties (if any are added later) should be copied unchanged
        public static StringDimesions WithHeight(this StringDimesions src, string height)
        {
            // TODO: implement
            throw new NotImplementedException("Challenge 5 – implement WithHeight()");
        }
    }

    // ---------------------------------------------------------------------------
    // Challenge usage examples – these are intentionally commented out.
    // Uncomment each block AFTER you have implemented the corresponding extension
    // method above.  Each block should compile and produce the shown output.
    // ---------------------------------------------------------------------------
    public class ExtensionMethodChallenges
    {
        private readonly StringDimesions _dims = new StringDimesions { Height = "  42  " };

        // Challenge 1 usage – uncomment once ToInt() is implemented.
        //public void Challenge1_ToInt()
        //{
        //    var mapped = new IntDimesions
        //    {
        //        Height = _dims.Height.Trim().ToInt()   // expects 42
        //    };
        //    Console.WriteLine($"Challenge 1 – Height: {mapped.Height}");
        //}

        // Challenge 2a usage – uncomment once ToIntOrDefault() is implemented.
        //public void Challenge2a_ToIntOrDefault()
        //{
        //    int h1 = "99".ToIntOrDefault();          // 99
        //    int h2 = "abc".ToIntOrDefault(-1);        // -1
        //    int h3 = ((string)null).ToIntOrDefault(); // 0
        //    Console.WriteLine($"Challenge 2a – h1={h1}, h2={h2}, h3={h3}");
        //}

        // Challenge 2b usage – uncomment once ToIntOrNull() is implemented.
        //public void Challenge2b_ToIntOrNull()
        //{
        //    int height = _dims.Height.ToIntOrNull() ?? 0;  // 0 (whitespace not trimmed)
        //    int height2 = _dims.Height.Trim().ToIntOrNull() ?? 0;  // 42
        //    Console.WriteLine($"Challenge 2b – height={height}, height2={height2}");
        //}

        // Challenge 3 usage – uncomment once TryToInt() is implemented.
        //public void Challenge3_TryToInt()
        //{
        //    if (_dims.Height.Trim().TryToInt(out var h))
        //        Console.WriteLine($"Challenge 3 – parsed: {h}");   // 42
        //    else
        //        Console.WriteLine("Challenge 3 – could not parse");
        //}

        // Challenge 4 usage – uncomment once Tap<T> and Let<T,TR> are implemented.
        //public void Challenge4_TapAndLet()
        //{
        //    var mappingClass = new MappingClass();
        //
        //    var result = _dims
        //        .Tap(x => Console.WriteLine($"Before: Height='{x.Height}'"))
        //        .Tap(x => x.Height = x.Height?.Trim())
        //        .Let(mappingClass.MapToIntDimesions);   // IntDimesions { Height = 42 }
        //
        //    Console.WriteLine($"Challenge 4 – Height: {result.Height}");
        //}

        // Challenge 5 usage – uncomment once WithHeight() is implemented.
        //public void Challenge5_WithHeight()
        //{
        //    var updated = _dims.WithHeight("180");
        //    Console.WriteLine($"Challenge 5 – original: {_dims.Height}, updated: {updated.Height}");
        //    // Bonus: chain with Let
        //    // var mapped = _dims.WithHeight(_dims.Height.Trim()).Let(new MappingClass().MapToIntDimesions);
        //    // Console.WriteLine($"Challenge 5 bonus – Height: {mapped.Height}");
        //}
    }
}
