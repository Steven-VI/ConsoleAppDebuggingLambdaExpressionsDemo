using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDebuggingLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LambdaExample> favThings = new List<LambdaExample>();

            LambdaExample thing1 = new LambdaExample();
            thing1.FavThings = "Ice-cream";
            favThings.Add(thing1);

            LambdaExample thing2= new LambdaExample();
            thing2.FavThings = "Summer Rain";
            favThings.Add(thing2);

            LambdaExample thing3 = new LambdaExample();
            thing3.FavThings = "Sunday Morning Snooze";
            favThings.Add(thing3);

            // Copy Lambda Expression in Debug - Windows - Watch1 "favThings.Where(feature => feature.FavThings.StartsWith("Sum"))"
            var filteredFavThings = favThings.Where(feature => feature.FavThings.StartsWith("Sum"));
        }
    }
}
