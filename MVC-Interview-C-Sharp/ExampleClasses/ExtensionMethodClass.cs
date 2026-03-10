using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public class StringDimesions
    {
        public string Height { get; set; }
    }

    public class IntDimesions
    {
        public int Height { get; set; }
    }

    public class MappingClass
    {
        private ConversionClass ConversionClass { get; set; }

        public MappingClass()
        {
            ConversionClass = new ConversionClass();
        }

        public IntDimesions MapToIntDimesions(StringDimesions stringDimesions)
        {
            return new IntDimesions
            {
                Height = ConversionClass.ToInt(stringDimesions.Height)
            };

            // Challenge #1 (original): make this compile by implementing string.ToInt()
            // return new IntDimesions
            // {
            //     Height = stringDimesions.Height.ToInt()
            // };
        }
    }

    /// <summary>
    /// Extension-method interview challenges live here.
    ///
    /// NOTE: In real projects you’d usually make this a static class like `StringExtensions`,
    /// but we keep the original class name to match the exercise.
    /// </summary>
    public static class ExtensionMethodClass
    {
        // ==========================================================
        // Challenge #1: ToInt()
        // Goal: basic extension method syntax + parsing semantics
        // Behavior choice (documented): throws on null/invalid, like int.Parse,
        // but with a clearer exception message for the exercise.
        // ==========================================================
        public static int ToInt(this string value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value), "Cannot convert null to int.");

            if (int.TryParse(value, out var result))
                return result;

            throw new FormatException($"'{value}' is not a valid integer.");
        }

        // ==========================================================
        // Challenge #2: ToIntOrDefault()
        // Goal: overloads + safe parsing without exceptions
        // ==========================================================
        public static int ToIntOrDefault(this string value, int defaultValue = 0)
        {
            return int.TryParse(value, out var result) ? result : defaultValue;
        }

        // ==========================================================
        // Challenge #3: ToIntOrNull()
        // Goal: nullable return types + safe parsing
        // ==========================================================
        public static int? ToIntOrNull(this string value)
        {
            return int.TryParse(value, out var result) ? result : (int?)null;
        }

        // ==========================================================
        // Challenge #4: TryToInt(out ...)
        // Goal: extension methods can use `out` parameters (TryParse-style)
        // ==========================================================
        public static bool TryToInt(this string value, out int result)
        {
            return int.TryParse(value, out result);
        }

        // ==========================================================
        // Challenge #5: Tap<T>()
        // Goal: generic extension method + fluent style + returning the original object
        // ==========================================================
        public static T Tap<T>(this T obj, Action<T> action)
        {
            if (action is null) throw new ArgumentNullException(nameof(action));

            action(obj);
            return obj;
        }

        // ==========================================================
        // Challenge #6: Let<T, TResult>()
        // Goal: generic extension method that transforms values (functional style)
        // ==========================================================
        public static TResult Let<T, TResult>(this T obj, Func<T, TResult> func)
        {
            if (func is null) throw new ArgumentNullException(nameof(func));
            return func(obj);
        }

        // ==========================================================
        // Challenge #7: WithHeight() targeting your own type
        // Goal: extension methods aren’t only for BCL types; return a copy (immutable-ish)
        // ==========================================================
        public static StringDimesions WithHeight(this StringDimesions src, string height)
        {
            if (src is null) throw new ArgumentNullException(nameof(src));

            return new StringDimesions
            {
                Height = height
            };
        }
    }

    /// <summary>
    /// Optional: a place to stash additional commented-out usage examples
    /// that candidates can uncomment once they implement the extensions.
    /// </summary>
    public class ExtensionMethodChallenges
    {
        public IntDimesions MapWithExtensions(StringDimesions stringDimesions)
        {
            // Challenge usage for #2 / #3:
            // int height1 = stringDimesions.Height.ToIntOrDefault(0);
            // int height2 = stringDimesions.Height.ToIntOrNull() ?? 0;

            // Challenge usage for #4:
            // if (!stringDimesions.Height.TryToInt(out var h))
            //     throw new ArgumentException("Height must be an integer");
            // return new IntDimesions { Height = h };

            // Challenge usage for #5 / #6 (fluent):
            // return stringDimesions
            //     .Tap(x => x.Height = x.Height?.Trim())
            //     .Let(x => new IntDimesions { Height = x.Height.ToIntOrDefault(0) });

            // Challenge usage for #7:
            // var cleaned = stringDimesions.WithHeight(stringDimesions.Height?.Trim());
            // return new IntDimesions { Height = cleaned.Height.ToIntOrDefault(0) };

            // Keep baseline behavior:
            return new IntDimesions { Height = 0 };
        }
    }
}
