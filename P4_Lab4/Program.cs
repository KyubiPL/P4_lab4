using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new PC() { CoolingType = "liquid", Description = "Gaming PC" });
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Computers.Add(new PC() { CoolingType = "liquid", Description = "Gaming PC" });
            tpt.SaveChanges();

            var tpc = new TPTContext();
            tpc.Computers.Add(new PC() { CoolingType = "liquid", Description = "Gaming PC" });
            tpc.SaveChanges();

            Console.WriteLine("Ready");


        }
    }
}
