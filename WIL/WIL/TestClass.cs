﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLogic;

namespace WIL
{
    class TestClass
    {
        public static void Main(string[] args)
        {
            DBManager dbm = new DBManager();
            foreach(var t in dbm.GetTrips())
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();
        }
    }
}
