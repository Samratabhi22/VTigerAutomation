﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTigerAutomation.Practise
{
    [TestClass]
    public class ClassWithInheritance:ClassGeneric
    {
        [TestMethod]
        public void Example1()
        {
            Console.WriteLine(" Example1 Test Method without Inheriting");
        }
        [TestMethod]
        public void Example2()
        {
            Console.WriteLine(" Example2 Test Method without Inheriting");
        }
        [TestMethod]
        public void Example3()
        {
            Console.WriteLine(" Example3 Test Method without Inheriting");
        }
    }
}
