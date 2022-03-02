using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._22
{
    internal class Person
    {
       
        public int GetAge(DateTime birthDate)
        {
            var now = DateTime.Today;
            string err = string.Empty;
            int age;
            if (birthDate.Year < now.Year)
            {
                age = now.Year - birthDate.Year;
                //if (birthDate.Day == now.Day & birthDate.Month >= now.Month)
                //{
                //return age;
                //}
                if (birthDate.Month > now.Month & birthDate.Day < now.Day) 
                {
                    age--;

                }

            }

            else
            {
                err = "Error";
                age = 0;
                Console.WriteLine(err);
            }
            return age;
        }
    }
}
