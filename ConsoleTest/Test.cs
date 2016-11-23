using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US.WordProcessor.Internal;

namespace ConsoleTest
{
    static class Test
    {
        public static void OptionalTest()
        {
            string x = "1";
            var optional = new Optional<string>(x);
            Console.WriteLine(optional.HasValue.ToString());
            
        }
    }
}
