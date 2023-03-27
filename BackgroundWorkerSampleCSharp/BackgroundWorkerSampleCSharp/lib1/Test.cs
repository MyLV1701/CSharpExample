using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundWorkerSampleCSharp.lib1
{
    internal class Test
    {

        public async Task<int> Calculator() {

            Console.WriteLine("begin handling C A L C U L A T E ============>>> " );
            

            await Task.Delay(20000);

            Console.WriteLine(" * * * Finshed task  * * *  ============>>> ");


            // return value 
            return 42;
        }


    }
}
