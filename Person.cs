using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanyaCSharp
{
   internal class Person
    {
        public int _age;
        public DateTime _birthDate;
        public int Age
        {
            get
            {
                _age = DateTime.Now.Year - _birthDate.Year;
                if (DateTime.Now.Month < _birthDate.Month
                    || (DateTime.Now.Month == _birthDate.Month && DateTime.Now.Day < _birthDate.Day))
                {
                    _age--;
                }
                return _age;
            }
        }
    }
}
                                    /* Вызов метода
                                      using DanyaCSharp;

                                    var Roman = new Person();
                                    {
                                        Roman._birthDate = new DateTime(1998, 08, 11);
                                        var _date = new DateTime(1998, 08, 11);
                                        Console.WriteLine("Rome " + Roman.Age);
                                    }
                                     */
}
