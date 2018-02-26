using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            int cent=int.Parse(Console.ReadLine());
            int year=cent*100;
            double days=year*365.2422;
            int dayz=(int)days;
            long hours=dayz*24;
            long min=hours*60;
            BigInteger sec=min*60;
            string millisec=sec.ToString()+"000";
            string microSec=millisec+"000";
            string nano=microSec+"000";

            Console.WriteLine($"{cent} centuries = {year} years = {dayz} days = {hours} hours = {min} minutes = {sec} seconds = {millisec} milliseconds = {microSec} microseconds = {nano} nanoseconds");
        }
    }
}
