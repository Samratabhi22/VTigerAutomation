using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTigerAutomation.Practise
{
   // [TestClass]
    public class SampleBaseClass
    {
        [AssemblyInitialize]
        public static void AssemblyIni(TestContext context)
        {
            Console.WriteLine("Assembly iniitialized");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup() 
        {
            Console.WriteLine("Assembly cleanedup");
                
        }
        
    }
}
