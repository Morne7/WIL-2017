﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Route
    {
        public int ID { get; set; }
        public Department Departure { get; set; }
        public Department Destination { get; set; }
        public int Kms { get; set; }
        //public double Cost { get; set; }

        public Route(int id, Department depart, Department dest, int kms)
        {
            ID = id;
            Departure = depart;
            Destination = dest;
            this.Kms = kms;
        }

        public override string ToString()
        {
            string result = $"{Departure} > {Destination}";
            return result;
        }

    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            ID = id;
            this.Name = name;
        }

        public override String ToString()
        {
            return Name;
        }

    }
}
